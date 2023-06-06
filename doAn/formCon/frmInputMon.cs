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
            int tinChiLT, tinChiTH;

            if (int.TryParse(txtInPutSTCLT.Text, out tinChiLT) == true && int.TryParse(txtInputSTCTH.Text, out tinChiTH) == true) // nghĩa là nếu ep đc thì nó sẽ đưa số đó vào biến nienKhoa va tra ve true
            {
                monHoc1.tinChiLT = tinChiLT;
                monHoc1.tinChiTH = tinChiTH;
            }
            else
            {
                MessageBox.Show(
              "Không đúng định dạng",
              "Thông báo",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            //vì thêm môn vào theo tên môn học nên khi dò mã môn thêm vào có thể sẽ bị trùng nên ta phải chuyển cây thành mảng rồi dò từ đầu đến cuối mảng
            // nếu trùng mã môn thì không thêm

            List<MonHoc> mangDsMon = new List<MonHoc>();

            DsMonHoc dsMonTmp = Program.objectDsMonHoc;
            DsMonHoc.Node nodeRootTmp = dsMonTmp.root;

            dsMonTmp.treeSangArray(nodeRootTmp, mangDsMon); // gọi hàm này vào truyền vào root và list để chuyển cây thành mảng

            foreach (MonHoc monA in mangDsMon)
            {
                if(txtInPutMaMon.Text == monA.maMonHoc)
                {
                    MessageBox.Show(
                       "Mã môn học bị trùng!",
                       "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // biến mark để đánh dấu nếu mark == flase thì  có nghĩa đá có mã môn rồi nên sẽ ko đc hiển thị
            bool mark = Program.objectDsMonHoc.insert(Program.objectDsMonHoc.root, monHoc1);

            // hiển thị nhưng chưa sắp xếp đc theo tên môn phuog pha là thay đổi cách add dựa vào ten mon chứ ko phai ma mon nua
           if(mark == true)
            {
                Program.formMain.lvDsMon.Items.Clear(); // này là chỉ xóa hiển thị cho ng dùng, chứ bản chất cái node vẫn tồn tại trong cây
                Program.objectDsMonHoc.displayInOrder(Program.objectDsMonHoc.root);
            }
               
        }
    }
}
