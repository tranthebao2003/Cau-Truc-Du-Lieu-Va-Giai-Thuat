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
    public partial class frmEditMon : Form
    {
        public frmEditMon()
        {
            InitializeComponent();
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            // khi ng dùng chọn và an nut sua thì nó sẽ thuc hien lenh này  1 lan nhung khi ng dung an sua 1 lan nua thì no sẽ hieu la
            // ng dung chua cho gì và khi đó dòng 27 sẽ bị lỗi
            if (Program.formMain.lvDsMon.SelectedItems.Count > 0)
            {
                Program.lvItem = Program.formMain.lvDsMon.SelectedItems[0];

                // mon hoc ma nguoi dung chon can sua
                MonHoc targetMon = new MonHoc();


                targetMon.maMonHoc = Program.lvItem.SubItems[0].Text; ;
                targetMon.tenMonHoc = Program.lvItem.SubItems[1].Text;
                targetMon.tinChiLT = Convert.ToInt32(Program.lvItem.SubItems[2].Text);
                targetMon.tinChiTH = Convert.ToInt32(Program.lvItem.SubItems[3].Text);


                //môn sau khi đã sửa cho phép sua ma mon lun và ko dc trung
                MonHoc newMon = new MonHoc();

                newMon.maMonHoc = txtInputMaMon.Text;
                newMon.tenMonHoc = txtInPutTenMon.Text;
                newMon.tinChiLT = Convert.ToInt32(txtInPutSTCLT.Text);
                newMon.tinChiTH = Convert.ToInt32(txtInPutSTCTH.Text);

                Program.objectDsMonHoc.root = Program.objectDsMonHoc.modifyNode(Program.objectDsMonHoc.root, targetMon, newMon);
                Program.formMain.lvDsMon.Items.Clear();

                Program.objectDsMonHoc.displayInOrder(Program.objectDsMonHoc.root, Program.lvItem);
        }
            else
            {
                MessageBox.Show(
               "Bạn chưa chọn ô cần sửa!",
               "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

        private void btnThoatMon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
