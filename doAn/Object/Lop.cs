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

        public DsSinhVien dssv;

        public Lop()
        {

        }
        public Lop(string maLop, string tenLop, int namHoc)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.namHoc = namHoc;
        }
    }
}
