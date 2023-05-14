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
            if(Program.formMain.lvSinhVien.SelectedItems.Count > 0)
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

                // tìm mã lớp mà ng dùng đã chọn trong lvLop

                Program.lvItem = Program.formMain.lvLop.SelectedItems[0];
                string maLop = Program.lvItem.SubItems[0].Text;

                Lop result = new Lop();
                // dò mã lớp đó vs all mã lớp trong ds lop
                // nếu mã lớp nào trong dsLop trùng với mã lớp mà ng dùng đã chọn thì lưu vào result và thoát 
                for (int i = 0; i < Program.objectDslop.length(); i++)
                {
                    Lop lop1 = Program.objectDslop.dsLop[i];
                    if (maLop == lop1.maLop)
                    {
                        result = lop1;
                        break;
                    }
                }
                result.dssv.editSv(sv1);
                result.dssv.display(Program.lvItem);
            }
            else
            {
                MessageBox.Show(
              "Bạn chưa chọn ô cần sửa!",
              "Thông báo",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
