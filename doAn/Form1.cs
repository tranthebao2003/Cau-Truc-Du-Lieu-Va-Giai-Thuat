using doAn.formCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhapLop_Click(object sender, EventArgs e)
        {
            frmInputLop frmLop = new frmInputLop(); // tạo 1 đối tượng từ class frmInputLop
            frmLop.MdiParent = this;
            frmLop.Show();
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có chắc muốn thoát?",
               "Thông báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnNhapSv_Click(object sender, EventArgs e)
        {
            frmInputSV frmSV = new frmInputSV(); // tạo 1 đối tượng từ class frmInputLop
            frmSV.MdiParent = this;
            frmSV.Show();
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
