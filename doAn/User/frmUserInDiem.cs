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

namespace doAn.User
{
    public partial class frmUserInDiem : Form
    {
        public frmUserInDiem()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNhapInforUser_Click(object sender, EventArgs e)
        {
            if (txtInPutMaLop.Text == "" || txtInPutMaMon.Text == "" || txtInPutLanThi.Text == "")
            {
                MessageBox.Show(
                   "Bạn nhập thiếu thông tin!",
                   "Thông báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else
            {
                frmBangDiemDaThi bangDiemDaThi1 = new frmBangDiemDaThi();
                bangDiemDaThi1.lvBangDiemDaThi.Items.Clear();

                string maLopNhapVao = txtInPutMaLop.Text;
                string maMonNhapVao = txtInPutMaMon.Text;

                int lanThiNhapVao;

                if (int.TryParse(txtInPutLanThi.Text, out lanThiNhapVao) == true) // nghĩa là nếu ep đc thì nó sẽ đưa số đó vào biến lanThiNhapVao
                {
                }
                else
                {
                    MessageBox.Show(
                  "Lần thi phải là số",
                  "Thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


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

                if (result2.maLop == "") // neu ng dung ko nhap dung ma lop thi result2.maLop khi khoi tao nen no se la rong
                {
                    MessageBox.Show(
                        "Không tìm thấy lớp bạn nhập!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                #region Gán những thông tin lên bảng điểm
                // gán ten lop tim đc vao lblOutputLop để hien thi len form
                bangDiemDaThi1.lblOutputLop.Text = result2.tenLop.ToString();
                bangDiemDaThi1.lblOutputLanThi.Text = txtInPutLanThi.Text;

                int countDsMon = Program.formMain.lvDsMon.Items.Count;

                // tóm lại đoạn code này dug de in ra dc ten mon hoc từ mã mon học và dựa vào ds Môn
                if (countDsMon > 0) // kiểm tra ng dùng đã nhập ds Môn chưa?
                {
                    for (int i = 0; i < countDsMon; i++)
                    {
                        // lấy từng dong trong lvDsMon sau đó gán nó cho listViewItem lvItemtemp
                        // sau đó ta sẽ dò mà môn nhập vào vs mã môn trong ds Mon nếu trùng thì ta sẽ gán tên môn
                        // tương ừng vs mã môn đó vào cho Program.bangDiemDaThi1.lblOutpuMon.Text
                        ListViewItem lvItemtemp = Program.formMain.lvDsMon.Items[i]; 
                        if (maMonNhapVao == lvItemtemp.SubItems[0].Text)
                        {
                             bangDiemDaThi1.lblOutpuMon.Text = lvItemtemp.SubItems[1].Text;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                       "Vui lòng nhập danh sách môn",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return;
                }
                #endregion


                // PHẦN CHÍNH

                // đoạn code này sẽ lọc ra những sv có dsDiem mà trong dsDiem này có ma mon va so lan thi trung vs ma mon va so lan thi ma user nhap vao
                DsSinhVien tmpDsSv = result2.dssv;
                DsSinhVien.Node tmpNodeSv2 = tmpDsSv.head;
                bool mark = false;
                while (tmpNodeSv2 != null)
                {
                    SinhVien sv2 = tmpNodeSv2.sv;
                    DsDiem.Node tmpDsDiem = sv2.ptrDsDiem.head;
                    while (tmpDsDiem != null)
                    {
                        Diem diem2 = tmpDsDiem.diem;
                        if (diem2.maMonHoc.CompareTo(maMonNhapVao) == 0 && diem2.soLanThi.CompareTo(lanThiNhapVao) == 0)
                        {
                            ListViewItem lvItemTmp = new ListViewItem(sv2.maSV);
                            lvItemTmp.SubItems.Add(sv2.ho);
                            lvItemTmp.SubItems.Add(sv2.ten);
                            lvItemTmp.SubItems.Add(diem2.diem.ToString());
                            bangDiemDaThi1.lvBangDiemDaThi.Items.Add(lvItemTmp);
                            mark = true;
                            break; // đã tìm thấy điểm phù hợp vs thằng sv nên thoát thôi ko cần dò nữa
                        }
                        tmpDsDiem = tmpDsDiem.next;
                    }
                    tmpNodeSv2 = tmpNodeSv2.next;
                }
                if (mark == false)
                {
                    MessageBox.Show(
                      "Không tìm thấy mã môn học và lần thi phù hợp!",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    return;
                }
               bangDiemDaThi1.Show();
            }
        }
    }
}
