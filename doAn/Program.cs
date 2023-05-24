using doAn.formDiem;
using doAn.List;
using doAn.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn
{
    internal static class Program
    {
        // ta sử dụng từ khóa static là vì nếu có từ khóa này thì khi muốn truy cập đến thuộc tính hay phuong thước của 1 class thì ko cần phải tạo đối tượng class đó
        //public static DsSinhVien objectDsSinhVien = new DsSinhVien(); // tạo 1 phương thức tĩnh của class program, phương thức này khởi tạo 1 dsSinhVien
        public static DsLop objectDslop = new DsLop();
        public static DsMonHoc objectDsMonHoc = new DsMonHoc();
        public static DsDiem objectDsDiem = new DsDiem();

        public static Form1 formMain;
        public static ListViewItem lvItem;

        public static string maLop;
        public static string maMon;
        public static string lanThi;

        #region phục vụ cho câu j
        public static DsDiem.Node dsDiemMax(DsDiem dsDiemtmp)
        {
            DsDiem.Node NodetmpDsDiem = dsDiemtmp.head; // gán node head dsDiemtmp cho NodetmpDsDiem
            DsDiem.Node tmp = NodetmpDsDiem; // đây là node đc tạm để lưu kết quá sau cùng sau khi đã tìm ra đc node có điểm cao nhất

            // bản chất của thuật toán này là dò từ đầu đến cuối, lọc ra những thằng trùng mã môn,
            // xong đó so sánh diêm của 2 thằng đó rồi xóa thằng nhỏ hơn, con nếu 2 thằng bằng điểm nhau (khác số lần thi)
            // thì xóa 1 trong 2 thằng
            while (NodetmpDsDiem != null)
            {
                DsDiem.Node NodetmpDsDiem2 = NodetmpDsDiem.next;

                while (NodetmpDsDiem2 != null)
                {
                    if (NodetmpDsDiem.diem.maMonHoc == NodetmpDsDiem2.diem.maMonHoc)
                    {
                        if (NodetmpDsDiem.diem.diem > NodetmpDsDiem2.diem.diem)
                        {
                            tmp = dsDiemtmp.removeNode(NodetmpDsDiem2); // truyền vào cái node cần xóa
                            break;
                        }

                        else if (NodetmpDsDiem.diem.diem < NodetmpDsDiem2.diem.diem)
                        {
                            tmp = dsDiemtmp.removeNode(NodetmpDsDiem); // truyền vào cái node cần xóa
                            break;
                        }

                        else // xoa cai nao  cug dc
                        {
                            tmp = dsDiemtmp.removeNode(NodetmpDsDiem2); // truyền vào cái node cần xóa
                            break;
                        }
                    }
                    NodetmpDsDiem2 = NodetmpDsDiem2.next;
                }
                NodetmpDsDiem = NodetmpDsDiem.next;
            }
            return tmp; // cập nhật lại ds sau khi đã xóa những node có điểm thấp hơn (cùng mã môn nhưng khác lần thi)
        }
        #endregion

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new Form1();
            lvItem = new ListViewItem();
            Application.Run(formMain);
        }
    }
}
