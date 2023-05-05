using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn.Object
{
    internal class SinhVien
    {
        public string maSV { get; set; } // n21dcpt008 (9 kí tự và 3 kí tự cuối là số)
        public string ho { get; set; }
        public string ten { get; set; }
        public bool phai { get; set; }
        public string soDT { get; set; } // 10 so, số đầu tiên phải là 0

        public SinhVien()
        {

        }

        public void input()
        {
            Console.Write("Nhap ma sinh vien: ");
            this.maSV = Console.ReadLine();

            Console.Write("Nhap ho: ");
            this.ho = Console.ReadLine();

            Console.Write("Nhap ten: ");
            this.ten = Console.ReadLine();

            Console.Write("Nhap gio tinh flase(nam) true(nu): ");
            this.phai = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Nhap so dien thoai: ");
            this.soDT = Console.ReadLine();
        }
    }
}
