using doAn.formCon;
using doAn.formDiem;
using doAn.formSua;
using doAn.List;
using doAn.Object;
using doAn.User;
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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có chắc muốn thoát?",
               "Thông báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #region Nhập lớp
        private void btnNhapLop_Click(object sender, EventArgs e)
        {
            frmInputLop frmLop = new frmInputLop(); // tạo 1 đối tượng từ class frmInputLop
            frmLop.Show();
            // file.radAllLine
            // đọc dữ liệu từ file txt
            string path = "../../DuLieu/Lop.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream == false) // thuộc tính EndOfStream = true nghĩa là đã đọc hết dữ liệu rồi
                {
                    string line = sr.ReadLine(); // sr nó sẽ đọc từng dòng và lưu vào line
                    string[] values = line.Split(','); // nó sẽ cắt line thành tưởng chuỗi nhỏ hơn dữa vào dấu ","

                    // dựa vào chỉ số của mảng để truy xuất nội dung từng cột ở đây
                    Lop lop1 = new Lop();
                    lop1.maLop = values[0];
                    lop1.tenLop = values[1];
                    lop1.namHoc = Convert.ToInt32(values[2]);

                    DsSinhVien objectDsSinhVien = new DsSinhVien();
                    lop1.dssv = objectDsSinhVien;
                    for (int i = 0; i < Program.objectDslop.length(); i++)
                    {
                        if (Program.objectDslop.dsLop[i].maLop == values[0])
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
            }
        }
        #endregion

        #region Nhập sv theo lớp
        /* thuat toan nay ktra xem ng dung có chọn 1 lớp nào đó để nhập sv, hay chưa. Nếu có rồi thì ta phải
         lấy ra đc mã lớp đó và tìm xem mã lớp đó là lớp nào trong dsLop. Tương tự vs sự kiện double click thì
        ta cũng sẽ lưu địa chỉ cả dssv vào con trỏ dssv của doi tuong lop (điều này để đảm bảo ng dùng đang nhập sv
        cho đúng 1 lớp), sau đó gọi form lên để nhập liệu thôi
        */

        private void btnNhapSv_Click(object sender, EventArgs e)
        {
            if(lvLop.SelectedItems.Count > 0)
            {
                
                //result.dssv = Program.objectDsSinhVien; // như đã nói trên thì lúc này cái lớp có con trỏ kiểu dssv có thể lưu đc địa chỉ của 1 dssv
                frmInputSV frmSV = new frmInputSV(); // tạo 1 đối tượng từ class frmInputLop
                frmSV.Show();

                // file.radAllLine
                // đọc dữ liệu từ file txt
                // đường dẫn tương đối thì cái file hiện tại phải cùng cấp với file mình cần đọc
                string path = "../../DuLieu/sinhVienDpt.txt"; // ../ là đi ra khỏi thư mục debug ../ 1 lần nữa là ra khỏi thư mục bin (./ là thư mục hiện tại)
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.EndOfStream == false) // thuộc tính EndOfStream = true nghĩa là đã đọc hết dữ liệu rồi
                    {
                        string line = sr.ReadLine(); // sr nó sẽ đọc từng dòng và lưu vào line
                        string[] values = line.Split(','); // nó sẽ cắt line thành tưởng chuỗi nhỏ hơn dữa vào dấu ","

                        // gán những thông tin ng dung da nhap vao sv
                        SinhVien sv1 = new SinhVien();
                        sv1.maSV = values[0];
                        sv1.ho = values[1];
                        sv1.ten = values[2];
                        sv1.phai = Convert.ToBoolean(values[3]);
                        sv1.soDT = values[4];

                        // moi sv sẽ có 1 ds diem riêng và gán dia chi dsDiem do cho con trỏ cùng kieu trong doi tuong sv
                        DsDiem objectDsDiem = new DsDiem();
                        sv1.ptrDsDiem = objectDsDiem; // mỗi sv lúc này sẽ có 1 dsDiem

                        // tìm mã lớp mà ng dùng đã chọn trong lvLop
                        Program.lvItem = lvLop.SelectedItems[0];
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

                            while (ptr != null)
                            {
                                if (ptr.sv.maSV == values[0])
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
                        result.dssv.display(Program.lvItem);
                    }
                }
            }
            else
            {
               MessageBox.Show(
              "Bạn chưa chọn lớp để nhập sinh viên!",
              "Thông báo",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Nhập môn và có đọc từ file.txt
        private void btnNhapMon_Click(object sender, EventArgs e)
        {
            frmInputMon frmMon1 = new frmInputMon(); // tạo 1 đối tượng từ class frmInputLop
            frmMon1.Show();

           
            // file.radAllLine
            // đọc dữ liệu từ file txt
            string path = "../../DuLieu/monHoc.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream == false) // thuộc tính EndOfStream = true nghĩa là đã đọc hết dữ liệu rồi
                {
                    string line = sr.ReadLine(); // sr nó sẽ đọc từng dòng và lưu vào line
                    string[] values = line.Split(','); // nó sẽ cắt line thành tưởng chuỗi nhỏ hơn dữa vào dấu ","

                    // dựa vào chỉ số của mảng để truy xuất nội dung từng cột ở đây
                    MonHoc monHoc1 = new MonHoc();
                    monHoc1.maMonHoc = values[0];
                    monHoc1.tenMonHoc = values[1];
                    monHoc1.tinChiLT = Convert.ToInt32(values[2]);
                    monHoc1.tinChiTH = Convert.ToInt32(values[3]);
                    bool mark = Program.objectDsMonHoc.insert(Program.objectDsMonHoc.root, monHoc1);

                    if(mark == true)
                    {
                        Program.formMain.lvDsMon.Items.Clear(); 
                        Program.objectDsMonHoc.displayInOrder(Program.objectDsMonHoc.root, Program.lvItem);
                    }
                    else
                    { 
                        // có return ở đây là vì tránh ng dung ấn vào nút nhập môn nó sẽ hiển thị ra hàng loạt mã môn trùng thay vào đó ta chỉ cần hiển thị ra 1 lan 
                        return;
                    }
                }
            }
        }
        #endregion

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            frmUserNhapDiem frmUser = new frmUserNhapDiem(); // tạo 1 đối tượng từ class frmInputLop
            frmUser.Show();
        }

        #region Sửa và xóa sv
        private void btnXoaSv_Click(object sender, EventArgs e) // làm tới đây chưa xong
        {
            if(lvSinhVien.SelectedItems.Count > 0)// kiem tra xe co dong nao dc chon ko
            {
                while (lvSinhVien.SelectedItems.Count > 0) //trong khi còn lựa chọn thì cứ xóa thằng đầu tiên
                {
                    // tìm mã lớp mà ng dùng đã chọn trong lvLop
                    Program.lvItem = lvLop.SelectedItems[0];
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
                    result.dssv.remove(lvSinhVien.SelectedItems[0].Index); // trong ngoặc nó trả về index dòng đâu tien dc chon
                    lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]); // nó sẽ trực tiếp xóa luôn đối tượng đó không cần thông qua index
                                                                        //SelectedItems[0]: trả về dòng đầu tiên dược chọn
                }
            }
            else
            {
               MessageBox.Show(
               "Bạn chưa chọn ô cần xóa!",
               "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaSv_Click(object sender, EventArgs e)
        {
            // mã sv là duy nhat nen ko đc sửa chỉ sửa nhug thog tin khác
            if(lvSinhVien.SelectedItems.Count > 0)
            {
                // nếu ng dùng chọn vào 1 dòng và ấn sửa thì nó se hien lại cái form sửa cho ng dung nhap
                Program.lvItem = lvSinhVien.SelectedItems[0];
                frmEditSv a = new frmEditSv();
               
                a.txtInPutHo.Text = Program.lvItem.SubItems[1].Text;
                a.txtInPutTen.Text = Program.lvItem.SubItems[2].Text;
                a.txtInputSDT.Text = Program.lvItem.SubItems[4].Text;
                a.Show();
            }
            else
            {
               MessageBox.Show(
              "Bạn chưa chọn ô cần sửa!",
              "Thông báo",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Xóa, sửa và xuất lớp theo năm
        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            
            if (lvLop.SelectedItems.Count > 0)// kiem tra xem co dong nao dc chon ko
            {
                while (lvLop.SelectedItems.Count > 0) //trong khi còn lựa chọn thì cứ xóa thằng đầu tiên
                {
                    Program.objectDslop.remove(lvLop.SelectedItems[0].Index); // trong ngoặc nó trả về index dòng đâu tien dc chon
                    lvLop.Items.Remove(lvLop.SelectedItems[0]); // nó sẽ trực tiếp xóa luôn đối tượng đó không cần thông qua index
                                                                          //SelectedItems[0]: trả về dòng đầu tiên dược chọn
                }
            }
            else
            {
                MessageBox.Show(
                "Bạn chưa chọn ô cần xóa!",
                "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            // tương tự ma sv thi ma lop la duy nhat nen chi sua thong tin lop do thoi
            if (lvLop.SelectedItems.Count > 0)
            {
                // nếu ng dùng chọn vào 1 dòng và ấn sửa thì nó se hien lại cái form sửa cho ng dung nhap
                Program.lvItem = lvLop.SelectedItems[0];
                frmEditLop a = new frmEditLop();

                a.txtInPuTenLop.Text = Program.lvItem.SubItems[1].Text;
                a.txtInPuNam.Text = Program.lvItem.SubItems[2].Text;
                a.Show(); // show form eidt sv ra
            }
            else
            {
                MessageBox.Show(
               "Bạn chưa chọn ô cần sửa!",
               "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInLop_Click(object sender, EventArgs e)
        {
            if(txtNamHoc.Text == "")
            {
                MessageBox.Show(
               "Bạn chưa nhập niên khóa!",
               "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int nienKhoa;

                if (int.TryParse(txtNamHoc.Text, out nienKhoa) == true) // nghĩa là nếu ep đc thì nó sẽ đưa số đó vào biến nienKhoa va tra ve true
                {
                }
                else
                {
                    MessageBox.Show(
                  "Năm phải là số",
                  "Thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Program.objectDslop.display(Program.lvItem);
            }
        }
        #endregion

        #region Phục vụ cho cho việc xuất sv
        /* khi ta doubleClick vào 1 lớp thì nó sẽ xuất ra dssv duy nhất của lớp đó */
        private void lvLop_DoubleClick(object sender, EventArgs e) // đây là sử kiện nhấn đúp chuột vào lvLop
        {
            ListViewItem tmp = lvLop.SelectedItems[0]; // gán dòng đầu tiên mà người dùng chọn của lvLop cho lvItem
            string maLop = tmp.SubItems[0].Text; // lấy ô dau tien trong dong mà người dùng chọn cho maLop

            // kiểm tra mã lớp ng dùng chọn xem nó trùng với thằng nào trong ds Lop rồi lưu thằng đó vào result
            
            Lop result = new Lop();
            for (int i = 0; i < Program.objectDslop.length(); i++)
            {
                Lop lop1 = Program.objectDslop.dsLop[i]; // tạo 1 object tạm để lưu cho bớt dài thôi
                if (maLop == lop1.maLop)
                {
                    result = lop1;
                    break;
                }
            }
            // sau đó gán địa chỉ cả dssv (có kiểu dữ liệu là 1 dslk) vào con trỏ có cùng kiểu ở trong class Lop (con trỏ, trỏ đến dssv đã tạo khi tạo dsLop)

            result.dssv.display(Program.lvItem); // hiển thị dssv thôi
        }
        #endregion

        #region xóa và sửa môn
        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (lvDsMon.SelectedItems.Count > 0)// kiem tra xe co dong nao dc chon ko
            {
                while (lvDsMon.SelectedItems.Count > 0) //trong khi còn lựa chọn thì cứ xóa thằng đầu tiên
                {
                    Program.lvItem = lvDsMon.SelectedItems[0];
                    MonHoc monHoc1 = new MonHoc();
                    monHoc1.maMonHoc = Program.lvItem.SubItems[0].Text;
                    monHoc1.tenMonHoc = Program.lvItem.SubItems[1].Text;
                    monHoc1.tinChiLT = Convert.ToInt32(Program.lvItem.SubItems[2].Text);
                    monHoc1.tinChiTH = Convert.ToInt32(Program.lvItem.SubItems[3].Text);

                    //MessageBox.Show(monHoc1.maMonHoc + monHoc1.tenMonHoc + monHoc1.tinChiLT + monHoc1.tinChiTH);

                    Program.objectDsMonHoc.root = Program.objectDsMonHoc.removeNode(Program.objectDsMonHoc.root, monHoc1); // trong ngoặc nó trả về index dòng đâu tien dc chon
                    lvDsMon.Items.Remove(lvDsMon.SelectedItems[0]); // nó sẽ trực tiếp xóa luôn đối tượng đó không cần thông qua index
                                                                    //SelectedItems[0]: trả về dòng đầu tiên dược chọn
                }
            }
            else
            {
                MessageBox.Show(
                "Bạn chưa chọn ô cần xóa!",
                "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            // tuong tu ko cho su ma mon vi ma mon la duy nhat
            if (lvDsMon.SelectedItems.Count > 0)
            {
                // nếu ng dùng chọn vào 1 dòng và ấn sửa thì nó se hien lại cái form sửa cho ng dung nhap
                Program.lvItem = lvDsMon.SelectedItems[0];
                frmEditMon a = new frmEditMon();

                a.txtInputMaMon.Text = Program.lvItem.SubItems[0].Text;
                a.txtInPutTenMon.Text = Program.lvItem.SubItems[1].Text;
                a.txtInPutSTCLT.Text = Program.lvItem.SubItems[2].Text;
                a.txtInPutSTCTH.Text = Program.lvItem.SubItems[3].Text;
                a.Show(); // show form eidt sv ra
            }
            else
            {
                MessageBox.Show(
               "Bạn chưa chọn ô cần sửa!",
               "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void btnInDiem_Click(object sender, EventArgs e)
        {
            frmUserInDiem frmUser2 = new frmUserInDiem(); // tạo 1 đối tượng từ class frmInputLop
            frmUser2.Show();
        }

        #region In điểm trung bình của all Sv trong 1 lớp
        private void btnInDiemTB_Click(object sender, EventArgs e)
        {
            if (lvLop.SelectedItems.Count > 0)
            {
                frmBangDiemTB bangDiemTB1 = new frmBangDiemTB();

                ListViewItem tmp = lvLop.SelectedItems[0];
                string maLopUserChon = tmp.SubItems[0].Text;
                string tenLopUserChon = tmp.SubItems[1].Text;
                
                bangDiemTB1.lblOutputLop.Text = tenLopUserChon;
                
                Lop result2 = new Lop();
                for (int i = 0; i < Program.objectDslop.length(); i++)
                {
                    Lop lop1 = Program.objectDslop.dsLop[i];
                    if (maLopUserChon == lop1.maLop)
                    {
                        result2 = lop1;
                        break;
                    }
                }

                //ý tưởng: điểm tb của 1 sv thì ta lấy số tín mỗi môn(STCLT + STCTH) * số điểm cứ như thế cho đến hết
                // ds điểm của 1 sv rồi chia cho tổng số tín chỉ của dsDiem.
                DsSinhVien dsSv1 = result2.dssv; // lấy dssv từ con trỏ dssv của lớp result2
                DsSinhVien.Node nodeTmpDsSv = dsSv1.head; // gán node head của dsSv1 cho nodeTmpDsSv


                float diemTBsinhVien = 0;
                float tongDiemSinhVien = 0;
                int tongTinChiSinhVien = 0;

                // dò từng sv

                while (nodeTmpDsSv != null)
                {
                    SinhVien svTmp = nodeTmpDsSv.sv;

                    // tạo 1 listview tạm để lưu thông tin của sv bao gồm: họ và tên
                    ListViewItem tmpCholvBangDiemTB = new ListViewItem(svTmp.maSV);
                    tmpCholvBangDiemTB.SubItems.Add(svTmp.ho);
                    tmpCholvBangDiemTB.SubItems.Add(svTmp.ten);

                    // lấy DsDiem của từng sv thông qua con trỏ ptrDsDiem
                    DsDiem dsDiemTmp = svTmp.ptrDsDiem;
                    DsDiem.Node nodeTmpDsDiem = dsDiemTmp.head;  // gán node head của dsDiemTmp cho nodeTmpDsDiem 

                    while (nodeTmpDsDiem != null)
                    {
                        // tạo đối tượng Điểm diemTmp để lưu từng điểm trong dsDiem
                        Diem diemTmp = nodeTmpDsDiem.diem;

                        //dựa vào mã môn học của mỗi môn trong dsDiem ta sẽ truy suất đc tổng số tín chỉ của môn đó
                        // bằng cách là lấy mã môn trong từng đối tượng điểm so sánh với từng mã môn trong ListView Ds Môn
                        for (int i = 0; i < lvDsMon.Items.Count; i++)
                        {
                            ListViewItem tmpDsMon = lvDsMon.Items[i];

                            if (diemTmp.maMonHoc == tmpDsMon.SubItems[0].Text)
                            {
                                int STCLT = Convert.ToInt32(tmpDsMon.SubItems[2].Text);
                                int STCTH = Convert.ToInt32(tmpDsMon.SubItems[3].Text);

                                float diem1Mon = diemTmp.diem * (STCLT + STCTH); // ta lấy điểm nhân vs tổng số tín chỉ của môn đó
                                tongDiemSinhVien += diem1Mon; // cộng dồn điểm lại
                                tongTinChiSinhVien = tongTinChiSinhVien + STCLT + STCTH; // cộng dồn số tín chỉ lại
                                break; // sau khi tìm đc môn đó thì thoát ko cần chạy vòng lặp nữa
                            }
                        }
                        nodeTmpDsDiem = nodeTmpDsDiem.next;
                    }
                    diemTBsinhVien = tongDiemSinhVien / tongTinChiSinhVien; // sau khi kết thúc vòng while nghĩa là đã tìm hết đc dsDiem nên sau đó chỉ cần lấy tổng điểm/ tong tín chỉ là xong

                    tmpCholvBangDiemTB.SubItems.Add(diemTBsinhVien.ToString()); // sau đó add diemTB vào subItems để hiển thị ra
                    bangDiemTB1.lvBangDiemTB.Items.Add(tmpCholvBangDiemTB); // add cả 1 dòng vào listView

                    nodeTmpDsSv = nodeTmpDsSv.next; // đến sv kết tiếp
                }
                bangDiemTB1.Show();
            }
            else
            {
                MessageBox.Show(
                "Bạn chưa chọn lớp để in điểm trung bình!",
                "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region In điểm tổng kết của all Sv trong 1 lớp (j)
        private void btnInDiemTK_Click(object sender, EventArgs e)
        {
            if (lvLop.SelectedItems.Count > 0)
            {
                frmBangDiemTK bangDiemTK1 = new frmBangDiemTK(); // tạo 1 đối tượng từ class frmInputLop
                

                ListViewItem tmpChon = lvLop.SelectedItems[0];
                string maLopUserChon = tmpChon.SubItems[0].Text;
                string tenLopUserChon = tmpChon.SubItems[1].Text;
                string namUserChon = tmpChon.SubItems[2].Text;

                bangDiemTK1.lblOutputLop.Text = tenLopUserChon;
                bangDiemTK1.lblOutputNam.Text = namUserChon;

                Lop result2 = new Lop();
                for (int i = 0; i < Program.objectDslop.length(); i++)
                {
                    Lop lop1 = Program.objectDslop.dsLop[i];
                    if (maLopUserChon == lop1.maLop)
                    {
                        result2 = lop1;
                        break;
                    }
                }

                DsSinhVien dsSv1 = result2.dssv; // lấy dssv từ con trỏ dssv của lớp result2
                DsSinhVien.Node nodeTmpDsSv = dsSv1.head;
                // có thể phải tạo thêm cột dựa vào số môn có trong dsMon của mỗi sv

                // ý tưởng: ta sẽ xuất ra toàn bộ môn mà mà sv có điểm (dsDiem), nếu môn nào thi lại nhìu lần
                // thì ta chỉ xuất ra điểm cao nhất của lần thi tương ứng
                // vi dụ: môn a thi lần 2 5đ lần 3 6đ thì ta chỉ xuất ra 6đ của môn đó


                // gán maSv va ho ten vào bảng
                ListViewItem tmpCholvBangDiemTK = new ListViewItem();
                while (nodeTmpDsSv != null)
                {
                    
                    SinhVien svTmp = nodeTmpDsSv.sv;
                    ListViewItem tmpCholvBangDiemTKTG = new ListViewItem(svTmp.maSV);
                    //tmpCholvBangDiemTK.SubItems[0].Text = svTmp.maSV.ToString();
                    // tạo 1 listview tạm để lưu thông tin của sv bao gồm: họ và tên

                    tmpCholvBangDiemTKTG.SubItems.Add(svTmp.ho + " " + svTmp.ten);


                    // lấy DsDiem của từng sv thông qua con trỏ ptrDsDiem
                    DsDiem dsDiemTmp = svTmp.ptrDsDiem;
                    DsDiem.Node nodeTmpDsDiem = dsDiemTmp.head;  // gán node head của dsDiemTmp cho nodeTmpDsDiem 

                    
                    while(nodeTmpDsDiem != null)
                    {
                        bool mark = true;
                        Diem tmpDiem = nodeTmpDsDiem.diem;
                        

                        // dò từ đầu đến cuối lvBangDiemTk all các cột
                        //  bangDiemTK1.lvBangDiemTK.Columns.Count: trả về số lượng columns có trong listView
                        for (int i = 0; i < bangDiemTK1.lvBangDiemTK.Columns.Count; i++)
                        {
                            // nếu bất kì header của columns nào == ma mon học thì đánh dấu nó lại 
                            // bangDiemTK1.lvBangDiemTK.Columns[i].Text: trả về header của columns tại vị trí i
                            if (bangDiemTK1.lvBangDiemTK.Columns[i].Text == tmpDiem.maMonHoc)
                            {
                                mark = false;
                                break;
                            }
                        }

                        // nếu mark == true nghĩa là mon mon này chưa có trong lvBangDiemTK
                        // thì ta sẽ tạo ra 1 columns để add vào
                        if (mark)
                        {
                            ColumnHeader tmpMaMonHoc = new ColumnHeader(); // tạo object columns
                            tmpMaMonHoc.Text = tmpDiem.maMonHoc; // lấy mã môn học add vào header của columns đó 
                            tmpMaMonHoc.Width = 100; // độ rộng của colunms đó

                            bangDiemTK1.lvBangDiemTK.Columns.Add(tmpMaMonHoc); // add columns đó vào lvBangDiemTK
                        }
                        nodeTmpDsDiem = nodeTmpDsDiem.next;
                    }
                    bangDiemTK1.lvBangDiemTK.Items.Add(tmpCholvBangDiemTKTG);
                    nodeTmpDsSv = nodeTmpDsSv.next;
                }


                DsSinhVien dsSv2 = result2.dssv; // lấy dssv từ con trỏ dssv của lớp result2
                DsSinhVien.Node nodeTmpDsSv2 = dsSv2.head;

                while (nodeTmpDsSv2 != null)
                {
                    SinhVien svTmp2 = nodeTmpDsSv2.sv;

                    ListViewItem listViewItemTmp = new ListViewItem(svTmp2.maSV);
                    listViewItemTmp.SubItems.Add(svTmp2.ho + " " + svTmp2.ten);

                    DsDiem dsDiemTmp2 = svTmp2.ptrDsDiem;
                    DsDiem.Node nodeTmpDsDiem2 = Program.dsDiemMax(dsDiemTmp2);

                    int i = 2; // VÌ BỎ QUA 2 CỘT MÃ SV VÀ HỌ TÊN SV
                    while (nodeTmpDsDiem2 != null)
                    {
                        Diem tmpDiem2 = nodeTmpDsDiem2.diem;

                       // CÓ TIỂN TRIỂN RỒI, H CHỈ CẦN CHO PHÉP TRÙNG MÃ MÔN VÂN ĐC NHƯNG CÁI NÀO ĐIỂM CAO HƠN THÌ MIK LẤY
                        while(i < bangDiemTK1.lvBangDiemTK.Columns.Count)
                        {

                            if (bangDiemTK1.lvBangDiemTK.Columns[i].Text == tmpDiem2.maMonHoc)
                            {
                                listViewItemTmp.SubItems.Add(tmpDiem2.diem.ToString());
                                
                                i++;
                                break;
                            }
                            else
                            {
                                listViewItemTmp.SubItems.Add("");
                            }

                            i++;
                        }

                        nodeTmpDsDiem2 = nodeTmpDsDiem2.next;
                    }

                    bangDiemTK1.lvBangDiemTK.Items[0].Remove();
                   
                    bangDiemTK1.lvBangDiemTK.Items.Add(listViewItemTmp);
                    nodeTmpDsSv2 = nodeTmpDsSv2.next;
                }

                bangDiemTK1.Show();
            }
            else
            {
                MessageBox.Show(
                "Bạn chưa chọn lớp để in điểm tổng kết!",
                "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }
        #endregion
    }
}

