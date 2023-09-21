namespace WPFLab1
{
    partial class FrmObjLvlOps
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObjLvlOps));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBacktoMainWindowfrmObj = new System.Windows.Forms.Button();
            this.labelBktfrObj = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbBoxBucket = new System.Windows.Forms.ComboBox();
            this.dataGridViewObj = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObj)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Yellow;
            this.btnBrowse.Location = new System.Drawing.Point(1238, 14);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(635, 116);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.Yellow;
            this.btnUpload.Location = new System.Drawing.Point(1238, 140);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(635, 116);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBacktoMainWindowfrmObj
            // 
            this.btnBacktoMainWindowfrmObj.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBacktoMainWindowfrmObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoMainWindowfrmObj.ForeColor = System.Drawing.Color.Yellow;
            this.btnBacktoMainWindowfrmObj.Location = new System.Drawing.Point(1238, 919);
            this.btnBacktoMainWindowfrmObj.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBacktoMainWindowfrmObj.Name = "btnBacktoMainWindowfrmObj";
            this.btnBacktoMainWindowfrmObj.Size = new System.Drawing.Size(635, 106);
            this.btnBacktoMainWindowfrmObj.TabIndex = 5;
            this.btnBacktoMainWindowfrmObj.Text = "Back to Main Window";
            this.btnBacktoMainWindowfrmObj.UseVisualStyleBackColor = false;
            this.btnBacktoMainWindowfrmObj.Click += new System.EventHandler(this.btnBacktoMainWindowfrmObj_Click);
            // 
            // labelBktfrObj
            // 
            this.labelBktfrObj.AutoSize = true;
            this.labelBktfrObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBktfrObj.Location = new System.Drawing.Point(14, 31);
            this.labelBktfrObj.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelBktfrObj.Name = "labelBktfrObj";
            this.labelBktfrObj.Size = new System.Drawing.Size(117, 35);
            this.labelBktfrObj.TabIndex = 6;
            this.labelBktfrObj.Text = "Bucket";
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObject.Location = new System.Drawing.Point(20, 144);
            this.lblObject.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(111, 35);
            this.lblObject.TabIndex = 7;
            this.lblObject.Text = "Object";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(141, 144);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1087, 35);
            this.textBox1.TabIndex = 8;
            // 
            // cmbBoxBucket
            // 
            this.cmbBoxBucket.FormattingEnabled = true;
            this.cmbBoxBucket.Location = new System.Drawing.Point(141, 29);
            this.cmbBoxBucket.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbBoxBucket.Name = "cmbBoxBucket";
            this.cmbBoxBucket.Size = new System.Drawing.Size(1087, 37);
            this.cmbBoxBucket.TabIndex = 9;
            this.cmbBoxBucket.SelectedIndexChanged += new System.EventHandler(this.cmbBoxBucket_SelectedIndexChanged_1);
            // 
            // dataGridViewObj
            // 
            this.dataGridViewObj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObj.Location = new System.Drawing.Point(15, 256);
            this.dataGridViewObj.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridViewObj.Name = "dataGridViewObj";
            this.dataGridViewObj.RowHeadersWidth = 82;
            this.dataGridViewObj.RowTemplate.Height = 28;
            this.dataGridViewObj.Size = new System.Drawing.Size(1213, 769);
            this.dataGridViewObj.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FrmObjLvlOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1901, 1072);
            this.Controls.Add(this.dataGridViewObj);
            this.Controls.Add(this.cmbBoxBucket);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblObject);
            this.Controls.Add(this.labelBktfrObj);
            this.Controls.Add(this.btnBacktoMainWindowfrmObj);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmObjLvlOps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Object to S3 Bucket Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmObjLvlOps_FormClosing);
            this.Load += new System.EventHandler(this.FrmObjLvlOps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnBacktoMainWindowfrmObj;
        private System.Windows.Forms.Label labelBktfrObj;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbBoxBucket;
        private System.Windows.Forms.DataGridView dataGridViewObj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}