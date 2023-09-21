namespace WPFLab1
{
    partial class FrmBktLvlOps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBktLvlOps));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBucket = new System.Windows.Forms.TextBox();
            this.btnCreateBkt = new System.Windows.Forms.Button();
            this.btnDelBkt = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bucket Name";
            // 
            // txtBucket
            // 
            this.txtBucket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBucket.Location = new System.Drawing.Point(266, 40);
            this.txtBucket.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBucket.Name = "txtBucket";
            this.txtBucket.Size = new System.Drawing.Size(814, 38);
            this.txtBucket.TabIndex = 1;
            // 
            // btnCreateBkt
            // 
            this.btnCreateBkt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateBkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBkt.ForeColor = System.Drawing.Color.Yellow;
            this.btnCreateBkt.Location = new System.Drawing.Point(1090, 40);
            this.btnCreateBkt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCreateBkt.Name = "btnCreateBkt";
            this.btnCreateBkt.Size = new System.Drawing.Size(378, 116);
            this.btnCreateBkt.TabIndex = 2;
            this.btnCreateBkt.Text = "Create Bucket";
            this.btnCreateBkt.UseVisualStyleBackColor = false;
            this.btnCreateBkt.Click += new System.EventHandler(this.btnCreateBkt_Click);
            // 
            // btnDelBkt
            // 
            this.btnDelBkt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelBkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelBkt.ForeColor = System.Drawing.Color.Yellow;
            this.btnDelBkt.Location = new System.Drawing.Point(1090, 194);
            this.btnDelBkt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelBkt.Name = "btnDelBkt";
            this.btnDelBkt.Size = new System.Drawing.Size(378, 116);
            this.btnDelBkt.TabIndex = 3;
            this.btnDelBkt.Text = "Delete Bucket";
            this.btnDelBkt.UseCompatibleTextRendering = true;
            this.btnDelBkt.UseVisualStyleBackColor = false;
            this.btnDelBkt.Click += new System.EventHandler(this.btnDelBkt_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.ForeColor = System.Drawing.Color.Yellow;
            this.btnBackToMain.Location = new System.Drawing.Point(1086, 825);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(378, 116);
            this.btnBackToMain.TabIndex = 4;
            this.btnBackToMain.Text = "Back to Main Window";
            this.btnBackToMain.UseCompatibleTextRendering = true;
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 822);
            this.dataGridView1.TabIndex = 5;
            // 
            // FrmBktLvlOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 958);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.btnDelBkt);
            this.Controls.Add(this.btnCreateBkt);
            this.Controls.Add(this.txtBucket);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBktLvlOps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bucket Level Operations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBktLvlOps_FormClosing);
            this.Load += new System.EventHandler(this.FrmBktLvlOps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBucket;
        private System.Windows.Forms.Button btnCreateBkt;
        private System.Windows.Forms.Button btnDelBkt;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}