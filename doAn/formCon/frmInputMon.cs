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
    public partial class frmInputMon : Form
    {
        public frmInputMon()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            // kiểm tra xem ng dung có nhập đủ thong tin hay ko
            if (txtInPutMaMon.Text == "" || txtInPutSTCLT.Text == "" ||
            txtInputSTCTH.Text == "" ||
            txtInPutTenMon.Text == "")
            {
                MessageBox.Show(
               "Không được để trống thông tin",
               "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // gán những thông tin ng dung da nhap vao mon
            MonHoc monHoc1 = new MonHoc();
            monHoc1.maMonHoc = txtInPutMaMon.Text;
            monHoc1.tenMonHoc = txtInPutTenMon.Text;
            monHoc1.tinChiLT = Convert.ToInt32(txtInPutSTCLT.Text);
            monHoc1.tinChiTH = Convert.ToInt32(txtInputSTCTH.Text);


            // biến mark để đánh dấu nếu mark == flase thì  có nghĩa đá có mã môn rồi nên sẽ ko đc hiển thị
            bool mark = Program.objectDsMonHoc.insert(Program.objectDsMonHoc.root, monHoc1);

            // hiển thị nhưng chưa sắp xếp đc theo tên môn phuog pha là thay đổi cách add dựa vào ten mon chứ ko phai ma mon nua
           if(mark == true)
            {
                Program.formMain.lvDsMon.Items.Clear(); // này là chỉ xóa hiển thị cho ng dùng, chứ bản chất cái node vẫn tồn tại trong cây
                Program.objectDsMonHoc.displayInOrder(Program.objectDsMonHoc.root, Program.lvItem);
            }
               
        }
    }
}
