using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Amazon.S3;
using Amazon.S3.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void FetchS3Buckets()
        {
            var observableResponse = Observable.FromAsync(() => s3Client.ListBucketsAsync());

            observableResponse.ObserveOn(this).Subscribe(
                response =>
                {
                    dataGridView1.DataSource = response.Buckets;
                },
                ex => MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error));
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

        private void btnCreateBkt_Click(object sender, EventArgs e)
        {
            string bucketName = txtBucket.Text;
            if (!string.IsNullOrEmpty(bucketName)) 
            { 
            var observableResponse = Observable.FromAsync(() => s3Client.PutBucketAsync(new PutBucketRequest { BucketName = bucketName }));

            observableResponse
                .ObserveOn(this) //Ensure no Cross thread exception error
                .Subscribe(
                    response =>
                    {
                        MessageBox.Show($"Bucket {bucketName} created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FetchS3Buckets();
                        txtBucket.Text = "";
                    },
                    ex =>
                    {
                        if (ex is AmazonS3Exception amazonS3Exception && amazonS3Exception.ErrorCode == "BucketAlreadyExists")
                        {
                            MessageBox.Show("The bucket name is already in use. Please choose a different name.", "Bucket Name Taken", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                );
            }
            else 
            {
                MessageBox.Show("Invalid Bucket name. Please input a unique Bucket name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelBkt_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bucket to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bucketName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            var observableResponse = Observable.FromAsync(() => s3Client.DeleteBucketAsync(new DeleteBucketRequest { BucketName = bucketName }));

            observableResponse
                .ObserveOn(this) //Ensure no Cross thread exception error
                .Subscribe(
                    response =>
                    {
                        MessageBox.Show($"Bucket {bucketName} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FetchS3Buckets();
                    },
                    ex =>
                    {
                        if (ex is AmazonS3Exception amazonS3Exception)
                        {
                            MessageBox.Show(amazonS3Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                );
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
