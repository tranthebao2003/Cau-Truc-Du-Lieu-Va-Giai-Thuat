using doAn.List;
using doAn.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace doAn.formCon
{
    public partial class frmInputSV : Form
    {
        public frmInputSV()
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
            if(txtInPutMaSV.Text == "" || txtInPutHo.Text =="" ||
            txtInPutTen.Text == "" ||
            txtInputSDT.Text == "")
            {
                MessageBox.Show(
               "Không được để trống thông tin",
               "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // gán những thông tin ng dung da nhap vao sv
            SinhVien sv1 = new SinhVien();
            sv1.maSV = txtInPutMaSV.Text;
            sv1.ho = txtInPutHo.Text; 
            sv1.ten = txtInPutTen.Text;
            sv1.soDT = txtInputSDT.Text;
            if(radNu.Checked == true) // nếu ng dùng click vao nữ thì ta cho phai là true
            {
                sv1.phai = true;
            } 
            else if(radNam.Checked == true)
            {
                sv1.phai = false;
            }

            // moi sv sẽ có 1 ds diem riêng và gán dia chi dsDiem do cho con trỏ cùng kieu trong doi tuong sv
            DsDiem objectDsDiem = new DsDiem();
            sv1.ptrDsDiem = objectDsDiem;

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

            // bản chất thuật toán ko trùng mssv là:
            // nếu nó là node đầu thì gán nó vào dslk lun, còn ko thì ta sẽ so sánh mã sv của node vừa thêm vào (txtInPutMaSV.Text)
            // với all node trong dslk nếu trùng thì return lun còn ko trùng thì thêm nó vào dslk
            if (result.dssv.head == null)
            {
                result.dssv.add(sv1);
            }
            else
            {
                DsSinhVien.Node ptr = result.dssv.head;

                while(ptr != null)
                {
                    if (ptr.sv.maSV == txtInPutMaSV.Text)
                    {
                        MessageBox.Show(
                        "Mã sinh viên bị trùng!",
                        "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    ptr = ptr.next;
                }
                result.dssv.add(sv1);
            }
            // hiện thi ra dssv
            result.dssv.display();
        }

        private void frmInputSV_Load(object sender, EventArgs e)
        {
            radNu.Checked = true; // mặc định khi chạy form này thì radian button nu se đc check
        }

    }
}
