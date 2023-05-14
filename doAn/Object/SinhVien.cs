using doAn.List;
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

        public DsDiem ptrDsDiem; // con trỏ này trỏ đến dsDiem của sv nào đó

        public SinhVien()
        {
            this.ptrDsDiem = new DsDiem();
        }
    }
}
