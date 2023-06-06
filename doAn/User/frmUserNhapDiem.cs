using doAn.formCon;
using doAn.formDiem;
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

namespace doAn
{
    public partial class frmUserNhapDiem : Form
    {
        public frmUserNhapDiem()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        ListViewItem lvTmp3ThongTin = new ListViewItem();

        public void btnNhapInforUser_Click(object sender, EventArgs e)
        {
            if(txtInPutMaLop.Text  == "" || txtInPutMaMon.Text == "" || txtInPutLanThi.Text == "")
            {
                MessageBox.Show(
                   "Bạn nhập thiếu thông tin!",
                   "Thông báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else
            {
                frmBangDiem bangDiem1 = new frmBangDiem();
                bangDiem1.lvBangDiem.Items.Clear();

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

                // dùng bien chính cua chuong trinh de luu nhung gia tri nay de su dung cho frmBangDiem
                Program.maLop = maLopNhapVao;
                Program.maMon = maMonNhapVao;
                Program.lanThi = lanThiNhapVao.ToString();



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

                if (result2.maLop == "")
                {
                    MessageBox.Show(
                        "Không tìm thấy lớp bạn nhập!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                #region Gán dsDiem nhưng chưa có điểm từ file txt
                DsSinhVien dsTmp = result2.dssv;
                DsSinhVien.Node nodeTmp1 = dsTmp.head;

                // sau khi chạy xong đoạn code này thi mỗi thằng sv sẽ có 1 ds điểm riêng và ds đó lấy từ file txt
                string path = "../../DuLieu/DsDiem1.txt";
                int markDsDiem = 1;
                while (nodeTmp1 != null) // duyet tu dau den cuoi ds sinh vien
                {
                    SinhVien sv1 = nodeTmp1.sv; // luu moi sv vào sv1
                    DsDiem dsDiem1 = sv1.ptrDsDiem; // luu moi ds diem cua sv1 vào dsDiem1

                    //tao moi doi tuong diem1 sau do gan thong tin tu file txt vao no roi add no vao dsDiem1
                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (sr.EndOfStream == false) // thuộc tính EndOfStream = true nghĩa là đã đọc hết dữ liệu rồi
                        {
                            string line = sr.ReadLine(); // sr nó sẽ đọc từng dòng và lưu vào line
                            string[] values = line.Split(','); // nó sẽ cắt line thành tưởng chuỗi nhỏ hơn dữa vào dấu ","

                            Diem diem1 = new Diem();
                            diem1.maMonHoc = values[0];
                            diem1.soLanThi = Convert.ToInt32(values[1]);
                            diem1.diem = Convert.ToSingle(values[2]);
                            dsDiem1.add(diem1);
                        }
                    }
                    //if va else if ở dưới là để đổi những dsDiem va gán no cho các sv
                    if (markDsDiem == 1)
                    {
                        path = "../../DuLieu/DsDiem2.txt";
                        markDsDiem = 0;
                        nodeTmp1 = nodeTmp1.next;
                        continue;
                    }
                    else if (markDsDiem == 0)
                    {
                        path = "../../DuLieu/DsDiem1.txt";
                        markDsDiem = 1;
                        nodeTmp1 = nodeTmp1.next;
                    }
                }
                #endregion

                #region Hiển thị những sv dựa vào thông tin user đã nhập
                // đoạn code này sẽ lọc ra những sv có dsDiem mà trong dsDiem này có ma mon va so lan thi trung vs ma mon va so lan thi ma user nhap vao
                DsSinhVien.Node nodeTmp2 = dsTmp.head;
                bool mark = false;
                while (nodeTmp2 != null)
                {
                    SinhVien sv2 = nodeTmp2.sv;
                    DsDiem.Node tmpDsDiem = sv2.ptrDsDiem.head;
                    while (tmpDsDiem != null)
                    {
                        Diem diem2 = tmpDsDiem.diem;
                        if (diem2.maMonHoc.CompareTo(maMonNhapVao) == 0 && diem2.soLanThi.CompareTo(lanThiNhapVao) == 0)
                        {
                            ListViewItem lvItemTmp = new ListViewItem(sv2.maSV);
                            lvItemTmp.SubItems.Add(sv2.ho);
                            lvItemTmp.SubItems.Add(sv2.ten);
                            lvItemTmp.SubItems.Add(diem2.diem.ToString()); // add them diem của sv vào
                            bangDiem1.lvBangDiem.Items.Add(lvItemTmp);
                            mark = true;
                            break; // đã tìm thấy diêm phù hợp vs thằng sv nên thoát thôi ko cần dò nữa
                        }
                        tmpDsDiem = tmpDsDiem.next;
                    }
                    nodeTmp2 = nodeTmp2.next;
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
                #endregion

                bangDiem1.Show();
                // sau khi người dùng nhập điểm thì mik mới hiển thị những phương thức để in điểm
                Program.formMain.btnInDiem.Visible = true;
                Program.formMain.btnInDiemTB.Visible = true;
                Program.formMain.btnInDiemTK.Visible = true;
            }
        }
    }
}
