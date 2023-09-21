using System;
using System.Reactive.Linq;
using System.ComponentModel;
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
            var observableResponse = Observable.FromAsync(() => s3Client.ListBucketsAsync())
                                               .ObserveOn(this); //Use OnserverOn to avoid cross-thread exception

            observableResponse.Subscribe(response =>
            {
                cmbBoxBucket.Items.Clear();

                foreach (var bucket in response.Buckets)
                {
                    cmbBoxBucket.Items.Add(bucket.BucketName);
                }
            });
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

            var observableResponse = Observable.FromAsync(() => s3Client.ListObjectsAsync(listObjectsRequest))
                                               .ObserveOn(this);

            observableResponse.Subscribe(response =>
            {
                dataGridViewObj.Rows.Clear();

                foreach (var obj in response.S3Objects)
                {
                    dataGridViewObj.Rows.Add(obj.Key, obj.Size);
                }
            });
        }

        private void cmbBoxBucket_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedBucket = cmbBoxBucket.SelectedItem.ToString();
            ReloadDataGridView(selectedBucket);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            if (cmbBoxBucket.SelectedItem == null || string.IsNullOrEmpty(cmbBoxBucket.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select a bucket...");
            }
            else
            {
                        if (!string.IsNullOrEmpty(textBox1.Text))
                        {
                            string selectedBucket = cmbBoxBucket.SelectedItem.ToString();
                            string objectKey = System.IO.Path.GetFileName(textBox1.Text);

                            var fileStream = new System.IO.FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                            var request = new PutObjectRequest
                            {
                                BucketName = selectedBucket,
                                Key = objectKey,
                                InputStream = fileStream,
                                ContentType = "application/octet-stream"
                            };

                            var observableResponse = Observable.FromAsync(() => s3Client.PutObjectAsync(request))
                                                               .ObserveOn(this);

                            observableResponse.Subscribe(response =>
                            {
                                if (response.HttpStatusCode == System.Net.HttpStatusCode.OK)
                                {
                                    MessageBox.Show("File uploaded successfully to S3!");
                                    ReloadDataGridView(selectedBucket);
                                }
                                else
                                {
                                    MessageBox.Show("File upload to S3 failed.");
                                }

                                fileStream.Close(); // Close the stream after the operation is done.
                            },
                            ex =>
                            {
                                // Handle any error here
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                fileStream.Close(); // Ensure the stream is closed even if an error occurs.
                            });

                        }
                        else
                        {
                            MessageBox.Show("Please choose a File to be uploaded in S3.");
                        }
            }
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string selectedFile = openFileDialog1.FileName;
            textBox1.Text = selectedFile;   
         }

        private void FrmObjLvlOps_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                MessageBox.Show("You cannot close this Form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
