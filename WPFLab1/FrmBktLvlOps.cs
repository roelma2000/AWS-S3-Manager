using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.S3;
using Amazon.S3.Model;

namespace WPFLab1
{
    public partial class FrmBktLvlOps : Form
    {
        private AmazonS3Client s3Client;

        public FrmBktLvlOps()
        {
            InitializeComponent();
            s3Client = new AmazonS3Client(Amazon.RegionEndpoint.CACentral1);
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main frmMenu = new frm_main();
            frmMenu.Show();
        }

        private async void FetchS3Buckets()
        {
            try
            {
                var response = await s3Client.ListBucketsAsync();
                dataGridView1.DataSource = response.Buckets;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializedBucketGrid()
        {
            // Disable automatic column generation
            dataGridView1.AutoGenerateColumns = false;

            // Create and add a column for the bucket name
            DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Bucket Name";
            column1.DataPropertyName = "BucketName";
            dataGridView1.Columns.Add(column1);

            // Create and add a column for the creation date
            DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Creation Date";
            column2.DataPropertyName = "CreationDate";
            dataGridView1.Columns.Add(column2);
        }
        private void FrmBktLvlOps_Load(object sender, EventArgs e)
        {
            InitializedBucketGrid();
            FetchS3Buckets();
        }

     
        private async void btnCreateBkt_Click(object sender, EventArgs e)
        {
            string bucketName = txtBucket.Text;
            try
            {
                PutBucketRequest request = new PutBucketRequest
                {
                    BucketName = bucketName
                };

                var response = await s3Client.PutBucketAsync(request);

                MessageBox.Show($"Bucket {bucketName} created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                if (amazonS3Exception.ErrorCode == "BucketAlreadyExists")
                {
                    MessageBox.Show("The bucket name is already in use. Please choose a different name.", "Bucket Name Taken", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(amazonS3Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            FetchS3Buckets();
            txtBucket.Text = "";
        }

        private async void btnDelBkt_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bucket to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bucketName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            try
            {
                DeleteBucketRequest request = new DeleteBucketRequest
                {
                    BucketName = bucketName
                };

                var response = await s3Client.DeleteBucketAsync(request);
                MessageBox.Show($"Bucket {bucketName} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload the DataGridView to reflect changes
                FetchS3Buckets(); 
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                MessageBox.Show(amazonS3Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBktLvlOps_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // This prevents the form from closing
                MessageBox.Show("You cannot close this Form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
