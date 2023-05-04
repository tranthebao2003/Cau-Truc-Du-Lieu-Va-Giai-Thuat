using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn.Object
{
    internal class Diem
    {
        public string maMonHoc { get; set; } // 10 kí tự và 3 số cuối phải là số vd: abcdefg002
        public int soLanThi { get; set; } // 1-> ( get, set ?)
        public float diem { get; set; } //0->10

        public Diem()
        {

        }
        public Diem(string maMonHoc, int soLanThi, float diem)
        {
            this.maMonHoc = maMonHoc;//note
            this.soLanThi = soLanThi;//note
            this.diem = diem;//note
        }
    }
}
