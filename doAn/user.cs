using doAn.formCon;
using doAn.formDiem;
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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNhapLop_Click(object sender, EventArgs e)
        {
            // tìm mã lớp mà ng dùng đã chọn trong lvLop
           
            string maLop = txtInPutMaLop.Text;
            string maMon = txtInPutMaMon.Text;
            int lanThi = Convert.ToInt32(txtInPutLanThi.Text);

            Lop result2 = new Lop();
            // dò mã lớp đó vs all mã lớp trong ds lop
            // nếu mã lớp nào trong dsLop trùng với mã lớp mà ng dùng đã chọn thì lưu vào result và thoát 
            for (int i = 0; i < Program.objectDslop.length(); i++)
            {
                Lop lop2 = Program.objectDslop.dsLop[i];
                if (maLop == lop2.maLop)
                {
                    result2 = lop2;
                    break;
                }
            }


            SinhVien sv2 = new SinhVien();
            DsSinhVien ptr = new DsSinhVien();
            ptr.head = result2.dssv.head; 
            sv2 = ptr.head.sv;
            

            while (ptr.head != null)
            {
                while (sv2.ptrDsDiem.head != null)
                {
                    if(sv2.ptrDsDiem.head.diem.maMonHoc == maMon && sv2.ptrDsDiem.head.diem.soLanThi == lanThi)
                    {
                        MessageBox.Show(sv2.maSV + sv2.ho + sv2.ten);
                    }
                    sv2.ptrDsDiem.head = sv2.ptrDsDiem.head.next;
                }
                ptr.head = ptr.head.next;
            }

            //// result.dssv: là đối tượng lớp có phuong thuc là dssv ( đây là 1 con trỏ, con trỏ kiểu DsSinhVien)
            //// nghĩa là con trỏ này có thể lưu địa chỉ của 1 dssv (dssv co kieu du lieu la lk Don)
            //result.dssv = Program.objectDsSinhVien; // như đã nói trên thì lúc này cái lớp có con trỏ kiểu dssv có thể lưu đc địa chỉ của 1 dssv
          

            frmBangDiem bangDiem1 = new frmBangDiem();
            bangDiem1.Show();
        }
    }
}
