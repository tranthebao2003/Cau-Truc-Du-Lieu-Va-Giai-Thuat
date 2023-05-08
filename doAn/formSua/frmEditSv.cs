using doAn.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn.formSua
{
    public partial class frmEditSv : Form
    {
        public frmEditSv()
        {
            InitializeComponent();
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

        private void btnSua_Click(object sender, EventArgs e) // vẫn lỗi
        {
            string maSvChon = Program.lvItem.SubItems[0].Text;
            SinhVien sv1 = new SinhVien();
            sv1.maSV = maSvChon;
            sv1.ho = txtInPutHo.Text;
            sv1.ten = txtInPutTen.Text;
            sv1.soDT = txtInputSDT.Text;
            Program.ds1.editSv(sv1);
            Program.ds1.display(Program.lvItem);
        }

        private void frmEditSv_Load(object sender, EventArgs e)
        {
            radNu.Checked = true;
        }
    }
}
