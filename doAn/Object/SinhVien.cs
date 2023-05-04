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
        public SinhVien(string maSV, string ho, string ten, bool phai, string soDT)
        {
            this.maSV = maSV;
            this.ho = ho;
            this.ten = ten;
            this.phai = phai;
            this.soDT = soDT;
        }
    }
}
