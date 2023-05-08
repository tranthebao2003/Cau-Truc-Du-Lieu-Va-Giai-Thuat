using doAn.formCon;
using doAn.List;
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

        private void btnNhapLop_Click(object sender, EventArgs e)
        {
            frmInputLop frmLop = new frmInputLop(); // tạo 1 đối tượng từ class frmInputLop
            frmLop.Show();
        }

        private void btnNhapSv_Click(object sender, EventArgs e)
        {
            frmInputSV frmSV = new frmInputSV(); // tạo 1 đối tượng từ class frmInputLop
            frmSV.Show();
        }

        private void btnNhapMon_Click(object sender, EventArgs e)
        {
            frmInputMon frmMon = new frmInputMon(); // tạo 1 đối tượng từ class frmInputLop
            frmMon.Show();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            frmInputDiem frmDiem = new frmInputDiem(); // tạo 1 đối tượng từ class frmInputLop
            frmDiem.Show();
        }

        private void btnInSv_Click(object sender, EventArgs e)
        {
            //frmInputSV sv1 = new frmInputSV();
            ////ban đầu khi ng dung chưa ấn j thì nó sẽ ẩn bảng đi sau khi ng dùng click in thì nó sẽ hiện
            //grbDssv.Visible = true;
        }

        private void btnXoaSv_Click(object sender, EventArgs e) // làm tới đây chưa xong
        {
            if(lvSinhVien.SelectedItems.Count > 0)// kiem tra xe co dong nao dc chon ko
            {
                while (lvSinhVien.SelectedItems.Count > 0) //trong khi còn lựa chọn thì cứ xóa thằng đầu tiên
                {

                    Program.ds1.removeTree(lvSinhVien.SelectedItems[0].Index); // trong ngoặc nó trả về index dòng đâu tien dc chon
                    lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]); // nó sẽ trực tiếp xóa luôn đối tượng đó không cần thông qua index
                                                                        //SelectedItems[0]: trả về dòng đầu tiên dược chọn
                }
            }
            else
            {
               MessageBox.Show(
               "Bạn chưa chọn ô cần xóa!",
               "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaSv_Click(object sender, EventArgs e)
        {
            if(lvSinhVien.SelectedItems.Count > 0)
            {
                // nếu ng dùng chọn vào 1 dòng và ấn sửa thì nó se hien lại cái form nhập cho ng dung nhap
                Program.lvItem = lvSinhVien.SelectedItems[0];
                frmInputSV a = new frmInputSV();
                a.txtInPutMaSV.Text = Program.lvItem.SubItems[0].Text;
                a.txtInPutHo.Text = Program.lvItem.SubItems[1].Text;
                a.txtInPutTen.Text = Program.lvItem.SubItems[2].Text;
                a.txtInputSDT.Text = Program.lvItem.SubItems[4].Text;
                a.Show();
            }
            else
            {
               MessageBox.Show(
              "Bạn chưa chọn ô cần sửa!",
              "Thông báo",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {

        }
    }
}

