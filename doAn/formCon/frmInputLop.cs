using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn.formCon
{
    public partial class frmInputLop : Form
    {
        public frmInputLop()
        {
            InitializeComponent();
        }

        private void btnNhapLop_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có chắc muốn thoát?",
               "Thông báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
