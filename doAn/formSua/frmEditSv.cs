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

        private void btnSuaSinhVien_Click(object sender, EventArgs e) // vẫn lỗi
        {
            string maSvChon = Program.lvItem.SubItems[0].Text;
            SinhVien sv1 = new SinhVien();
            sv1.maSV = maSvChon;
            sv1.ho = txtInPutHo.Text;
            sv1.ten = txtInPutTen.Text;
            sv1.soDT = txtInputSDT.Text;
            if (radNu.Checked == true) // nếu ng dùng click vao nữ thì ta cho phai là true
            {
                sv1.phai = true;
            }
            else if (radNam.Checked == true)
            {
                sv1.phai = false;
            }
            Program.objectDsSinhVien.editSv(sv1);
            Program.objectDsSinhVien.display(Program.lvItem);
        }

        private void frmEditSv_Load(object sender, EventArgs e)
        {
            radNu.Checked = true;
        }

        private void btnThoatSv_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
