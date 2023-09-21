namespace WPFLab1
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.btn_bktlvlops = new System.Windows.Forms.Button();
            this.btn_objlvlops = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_bktlvlops
            // 
            this.btn_bktlvlops.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_bktlvlops.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bktlvlops.ForeColor = System.Drawing.Color.Yellow;
            this.btn_bktlvlops.Location = new System.Drawing.Point(115, 24);
            this.btn_bktlvlops.Name = "btn_bktlvlops";
            this.btn_bktlvlops.Size = new System.Drawing.Size(355, 55);
            this.btn_bktlvlops.TabIndex = 0;
            this.btn_bktlvlops.Text = "Bucket Level Operations";
            this.btn_bktlvlops.UseVisualStyleBackColor = false;
            this.btn_bktlvlops.Click += new System.EventHandler(this.btn_bktlvlops_Click);
            // 
            // btn_objlvlops
            // 
            this.btn_objlvlops.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_objlvlops.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_objlvlops.ForeColor = System.Drawing.Color.Yellow;
            this.btn_objlvlops.Location = new System.Drawing.Point(115, 107);
            this.btn_objlvlops.Name = "btn_objlvlops";
            this.btn_objlvlops.Size = new System.Drawing.Size(355, 51);
            this.btn_objlvlops.TabIndex = 1;
            this.btn_objlvlops.Text = "Object Level Operations";
            this.btn_objlvlops.UseVisualStyleBackColor = false;
            this.btn_objlvlops.Click += new System.EventHandler(this.btn_objlvlops_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Yellow;
            this.btn_exit.Location = new System.Drawing.Point(519, 64);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(144, 55);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "ROWEL ALMUETE - 301137911";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_objlvlops);
            this.Controls.Add(this.btn_bktlvlops);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab#1 – AWS S3 & AWS IAM Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bktlvlops;
        private System.Windows.Forms.Button btn_objlvlops;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
    }
}

