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
    public partial class frmEditLop : Form
    {
        public frmEditLop()
        {
            InitializeComponent();
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if(Program.formMain.lvLop.SelectedItems.Count > 0)
            {
                string maLopChon = Program.lvItem.SubItems[0].Text; // lấy ra text ở ô đầu tiên trong lvItem
                Lop lop1 = new Lop();
                lop1.maLop = maLopChon;
                lop1.tenLop = txtInPuTenLop.Text;
                int namHoc;
               
                if (int.TryParse(txtInPuNam.Text, out namHoc) == true) // nghĩa là nếu ep đc thì nó sẽ đưa số đó vào biến nienKhoa va tra ve true
                {
                    lop1.namHoc = namHoc;
                    Program.objectDslop.editLop(lop1);
                    Program.objectDslop.display();
                }
                else
                {
                    MessageBox.Show(
                  "Không đúng định dạng",
                  "Thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show(
              "Bạn chưa chọn ô cần sửa!",
              "Thông báo",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoatLop_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
