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

namespace doAn.formDiem
{
    public partial class frmBangDiem : Form
    {
        public frmBangDiem()
        {
            InitializeComponent();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            if(lvBangDiem.SelectedItems.Count > 0)
            {
                ListViewItem lvItemBangDiem = lvBangDiem.SelectedItems[0];
                string maSvInput = lvItemBangDiem.SubItems[0].Text;

                int indexUserChon = lvBangDiem.SelectedItems[0].Index; // trả về index của dòng đầu tiên mà ng dung chọn
                frmUserNhapDiem user1 = new frmUserNhapDiem();
               
                string maLopNhapVao = Program.maLop;
                string maMonNhapVao = Program.maMon;
                int lanThiNhapVao = Convert.ToInt32(Program.lanThi);

               

                Lop result2 = new Lop();
                // dò mã lớp đó vs all mã lớp trong ds lop
                // nếu mã lớp nào trong dsLop trùng với mã lớp mà ng dùng đã chọn thì lưu vào result và thoát 
                for (int i = 0; i < Program.objectDslop.length(); i++)
                {
                    Lop lop2 = Program.objectDslop.dsLop[i];
                    if (maLopNhapVao == lop2.maLop)
                    {
                        result2 = lop2;
                        break;
                    }
                }

                DsSinhVien b = result2.dssv;
                DsSinhVien.Node tmp2 = b.head;

                // ràng buộc ng ta nhập vào phải là kiểu float nếu nó đúng là kieu float thì nó tra ve true và gán vào biến diemNhapVao
                float diemNhapVao;
                if (Single.TryParse(txtInputDiem.Text, out diemNhapVao) == true && diemNhapVao >= 0 && diemNhapVao <= 10)
                {
                }
                else
                {
                    MessageBox.Show(
                  "Sai định dạng",
                  "Thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                while (tmp2 != null)
                {
                    SinhVien sv2 = tmp2.sv;
                    if(sv2.maSV.CompareTo(maSvInput) == 0)
                    {
                        DsDiem dsDiem1 = sv2.ptrDsDiem;
                        DsDiem.Node tmpDsDiem1 = dsDiem1.head;
                        while (tmpDsDiem1 != null)
                        {
                            Diem diem2 = tmpDsDiem1.diem;
                            if (diem2.maMonHoc.CompareTo(maMonNhapVao) == 0 && diem2.soLanThi == lanThiNhapVao)
                            {
                                // sau khi tìm đc điểm phù hợp rồi thì ta chỉ cần thay điểm của object điểm đó bằng điểm mà user nhập
                                diem2.diem = diemNhapVao;
                                dsDiem1.add(diem2);

                                // tiếp theo hiển thị lên cho user thì ta chỉ cần thay thế ô điểm tương ứng mà user chọn bằng điểm đã đc thay thế
                                lvBangDiem.Items[indexUserChon].SubItems[3].Text = diem2.diem.ToString();
                                return;
                            }
                            tmpDsDiem1 = tmpDsDiem1.next;
                        }
                    }
                    tmp2 = tmp2.next;
                }
            }
            else
            {
                MessageBox.Show(
             "Bạn chưa chọn sinh viên",
             "Thông báo",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
