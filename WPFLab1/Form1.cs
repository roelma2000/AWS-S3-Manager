using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFLab1
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_bktlvlops_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBktLvlOps frmBucket = new FrmBktLvlOps();
            frmBucket.Show();
        }

        private void btn_objlvlops_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmObjLvlOps frmObject = new FrmObjLvlOps();
            frmObject.Show();
        }
    }
}
