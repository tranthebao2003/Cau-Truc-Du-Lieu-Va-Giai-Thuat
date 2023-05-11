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
            if (txtInPutMaLop.Text == "" || txtInPutNamHoc.Text == "" ||
            txtInPutTenLop.Text == "")
            {
                MessageBox.Show(
               "Không được để trống thông tin",
               "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Lop lop1 = new Lop();
            lop1.maLop = txtInPutMaLop.Text;
            lop1.tenLop = txtInPutTenLop.Text;

            // bước này kiểm tra xem ng dung có nhập số int hay ko
            int nam;
            if(int.TryParse(txtInPutNamHoc.Text, out nam) == true)
            {
                lop1.namHoc = nam;
            }
            else
            {
                MessageBox.Show(
              "Bạn đã nhập sai định dạng",
              "Thông báo",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < Program.objectDslop.length(); i++)
            {
                if (Program.objectDslop.dsLop[i].maLop == txtInPutMaLop.Text)
                {
                    MessageBox.Show(
                    "Mã lớp bị trùng!",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            Program.objectDslop.add(lop1);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
             Close();
        }
    }
}
