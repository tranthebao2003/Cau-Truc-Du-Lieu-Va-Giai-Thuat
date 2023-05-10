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
            string maLopChon = Program.lvItem.SubItems[0].Text; // lấy ra text ở ô đầu tiên trong lvItem
            Lop lop1 = new Lop();
            lop1.maLop = maLopChon;
            lop1.tenLop = txtInPuTenLop.Text;
            lop1.namHoc = Convert.ToInt32(txtInPuNam.Text);
            Program.objectDslop.editLop(lop1);
            Program.objectDslop.display(Program.lvItem);
        }

        private void btnThoatLop_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
