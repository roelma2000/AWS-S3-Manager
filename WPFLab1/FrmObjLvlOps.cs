using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.S3;
using Amazon.S3.Model;

namespace WPFLab1
{
    public partial class FrmObjLvlOps : Form
    {
        private AmazonS3Client s3Client;
        public FrmObjLvlOps()
        {
            InitializeComponent();
            s3Client = new AmazonS3Client(Amazon.RegionEndpoint.CACentral1);

            // Configure the DataGridView columns
            dataGridViewObj.Columns.Add("ObjectName", "Object Name");
            dataGridViewObj.Columns.Add("Size", "Size");

            // Hook up the event handler for ComboBox selection change
            cmbBoxBucket.SelectedIndexChanged += cmbBoxBucket_SelectedIndexChanged_1;
        }

        private void btnBacktoMainWindowfrmObj_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main frmMenu = new frm_main();
            frmMenu.Show();
        }

        private void PopulateBucketComboBox()
        {
            var listBucketsRequest = new ListBucketsRequest();
            var response = s3Client.ListBuckets(listBucketsRequest);
            
            cmbBoxBucket.Items.Clear();

            foreach (var bucket in response.Buckets)
            {
                cmbBoxBucket.Items.Add(bucket.BucketName);
            }
        }

        private void FrmObjLvlOps_Load(object sender, EventArgs e)
        {
            PopulateBucketComboBox();
        }

        private void ReloadDataGridView(string selectedBucket)
        {
            var listObjectsRequest = new ListObjectsRequest
            {
                BucketName = selectedBucket,
            };

            var response = s3Client.ListObjects(listObjectsRequest);

            // Clear existing rows in the DataGridView
            dataGridViewObj.Rows.Clear();

            foreach (var obj in response.S3Objects)
            {
                // Add a new row to the DataGridView with ObjectName and Size columns
                dataGridViewObj.Rows.Add(obj.Key, obj.Size);
            }
        }

        private void cmbBoxBucket_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedBucket = cmbBoxBucket.SelectedItem.ToString();
            ReloadDataGridView(selectedBucket);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string selectedFile = openFileDialog1.FileName;
            textBox1.Text = selectedFile;

            if (!string.IsNullOrEmpty(selectedFile))
            {
                string selectedBucket = cmbBoxBucket.SelectedItem.ToString(); // Get the selected S3 bucket from ComboBox
                string objectKey = System.IO.Path.GetFileName(selectedFile); // Use the filename as the object key

                // Upload the file to S3
                using (var fileStream = new FileStream(selectedFile, FileMode.Open, FileAccess.Read))
                {
                    var request = new PutObjectRequest
                    {
                        BucketName = selectedBucket,
                        Key = objectKey,
                        InputStream = fileStream,
                        ContentType = "application/octet-stream" // Set the appropriate content type
                    };

                    var response = s3Client.PutObject(request);

                    if (response.HttpStatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("File uploaded successfully to S3!");
                    }
                    else
                    {
                        MessageBox.Show("File upload to S3 failed.");
                    }
                }
                ReloadDataGridView(selectedBucket);
            }
            
        }

        private void FrmObjLvlOps_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // This prevents the form from closing
                MessageBox.Show("You cannot close this Form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
