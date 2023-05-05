// project doAn.list để thu muc Object co thể tìm thấy thư mục list
using doAn.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn.Object
{
    internal class Lop
    {
        public string maLop { get; set; } // d21cqpt01-n (11 kí tự và kí tự 2 và 3 thể hiện năm nhập học)
        public string tenLop { get; set; }
        public int namHoc { get; set; } //1000 -> 9999

        public DsSinhVien dssv; // con trỏ này trỏ đến class dssv 

        public Lop()
        {

        }
        public Lop(string maLop, string tenLop, int namHoc)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.namHoc = namHoc;
        }

        public void input()
        {

            do
            {
                Console.Write("Nhap ma lop: ");
                this.maLop = Console.ReadLine(); // gán thẳng cho thuộc tính của đối tượng
            } while (this.maLop.Trim().Length > 15 || this.maLop.Trim().Length == 0); // trim loại bỏ khoảng trắng

            do
            {
                Console.Write("Nhap ten lop: ");
                this.tenLop = Console.ReadLine();
            } while (this.tenLop.Trim().Length == 0); // trim loại bỏ khoảng trắng

            do
            {
                Console.Write("Nhap nam hoc: ");
                this.namHoc = Convert.ToInt32(Console.ReadLine());
            } while (this.namHoc <= 0);

            this.dssv = new DsSinhVien();
        }

    }
}
