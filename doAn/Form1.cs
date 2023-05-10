using doAn.formCon;
using doAn.formSua;
using doAn.List;
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

        #region Nhập sv theo lớp
        /* thuat toan nay ktra xem ng dung có chọn 1 lớp nào đó để nhập sv, hay chưa. Nếu có rồi thì ta phải
         lấy ra đc mã lớp đó và tìm xem mã lớp đó là lớp nào trong dsLop. Tương tự vs sự kiện double click thì
        ta cũng sẽ lưu địa chỉ cả dssv vào con trỏ dssv của doi tuong lop (điều này để đảm bảo ng dùng đang nhập sv
        cho đúng 1 lớp), sau đó gọi form lên để nhập liệu thôi
        */

        private void btnNhapSv_Click(object sender, EventArgs e)
        {
            if(lvLop.SelectedItems.Count > 0)
            {
                // tìm mã lớp mà ng dùng đã chọn trong lvLop
                Program.lvItem = lvLop.SelectedItems[0];
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

                // result.dssv: là đối tượng lớp có phuong thuc là dssv ( đây là 1 con trỏ, con trỏ kiểu DsSinhVien)
                // nghĩa là con trỏ này có thể lưu địa chỉ của 1 dssv (dssv co kieu du lieu la lk Don)
                result.dssv = Program.objectDsSinhVien; // như đã nói trên thì lúc này cái lớp có con trỏ kiểu dssv có thể lưu đc địa chỉ của 1 dssv
                frmInputSV frmSV = new frmInputSV(); // tạo 1 đối tượng từ class frmInputLop
                frmSV.Show();
            }
            else
            {
               MessageBox.Show(
              "Bạn chưa chọn lớp để nhập sinh viên!",
              "Thông báo",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

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

        #region Sửa và xóa sv
        private void btnXoaSv_Click(object sender, EventArgs e) // làm tới đây chưa xong
        {
            if(lvSinhVien.SelectedItems.Count > 0)// kiem tra xe co dong nao dc chon ko
            {
                while (lvSinhVien.SelectedItems.Count > 0) //trong khi còn lựa chọn thì cứ xóa thằng đầu tiên
                {

                    Program.objectDsSinhVien.remove(lvSinhVien.SelectedItems[0].Index); // trong ngoặc nó trả về index dòng đâu tien dc chon
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
            // mã sv là duy nhat nen ko đc sửa chỉ sửa nhug thog tin khác
            if(lvSinhVien.SelectedItems.Count > 0)
            {
                // nếu ng dùng chọn vào 1 dòng và ấn sửa thì nó se hien lại cái form sửa cho ng dung nhap
                Program.lvItem = lvSinhVien.SelectedItems[0];
                frmEditSv a = new frmEditSv();
               
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

        #endregion

        #region Xóa, sửa và xuất lớp theo năm
        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            
            if (lvLop.SelectedItems.Count > 0)// kiem tra xem co dong nao dc chon ko
            {
                while (lvLop.SelectedItems.Count > 0) //trong khi còn lựa chọn thì cứ xóa thằng đầu tiên
                {
                    Program.objectDslop.remove(lvLop.SelectedItems[0].Index); // trong ngoặc nó trả về index dòng đâu tien dc chon
                    lvLop.Items.Remove(lvLop.SelectedItems[0]); // nó sẽ trực tiếp xóa luôn đối tượng đó không cần thông qua index
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

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            // tương tự ma sv thi ma lop la duy nhat nen chi sua thong tin lop do thoi
            if (lvLop.SelectedItems.Count > 0)
            {
                // nếu ng dùng chọn vào 1 dòng và ấn sửa thì nó se hien lại cái form sửa cho ng dung nhap
                Program.lvItem = lvLop.SelectedItems[0];
                frmEditLop a = new frmEditLop();

                a.txtInPuTenLop.Text = Program.lvItem.SubItems[1].Text;
                a.txtInPuNam.Text = Program.lvItem.SubItems[2].Text;
                a.Show(); // show form eidt sv ra
            }
            else
            {
                MessageBox.Show(
               "Bạn chưa chọn ô cần sửa!",
               "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInLop_Click(object sender, EventArgs e)
        {
            if(txtNamHoc.Text == "")
            {
                MessageBox.Show(
               "Bạn chưa nhập niên khóa!",
               "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Program.objectDslop.display(Program.lvItem);
            }
        }
        #endregion

        #region Phục vụ cho cho việc xuất sv
        /* khi ta doubleClick vào 1 lớp thì nó sẽ xuất ra dssv duy nhất của lớp đó */
        private void lvLop_DoubleClick(object sender, EventArgs e) // đây là sử kiện nhấn đúp chuột vào lvLop
        {
            Program.lvItem = lvLop.SelectedItems[0]; // gán dòng đầu tiên mà người dùng chọn của lvLop cho lvItem
            string maLop = Program.lvItem.SubItems[0].Text; // lấy ô dau tien trong dong mà người dùng chọn cho maLop

            // kiểm tra mã lớp ng dùng chọn xem nó trùng với thằng nào trong ds Lop rồi lưu thằng đó vào result
            
            Lop result = new Lop();
            for (int i = 0; i < Program.objectDslop.length(); i++)
            {
                Lop lop1 = Program.objectDslop.dsLop[i]; // tạo 1 object tạm để lưu cho bớt dài thôi
                if (maLop == lop1.maLop)
                {
                    result = lop1;
                    break;
                }
            }
            // sau đó gán địa chỉ cả dssv (có kiểu dữ liệu là 1 dslk) vào con trỏ có cùng kiểu ở trong class Lop (con trỏ, trỏ đến dssv đã tạo khi tạo dsLop)
            result.dssv = Program.objectDsSinhVien ;

            Program.objectDsSinhVien.display(Program.lvItem); // hiển thị dssv thôi
        }
        #endregion
    }
}

