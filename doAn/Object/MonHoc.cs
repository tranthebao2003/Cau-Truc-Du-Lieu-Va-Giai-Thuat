using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn.Object
{
    internal class MonHoc
    {
        public string maMonHoc { get; set; } // 10 kí tự và 3 số cuối phải là số vd: abcdefg002
        public string tenMonHoc { get; set; }
        public int tinChiLT { get; set; } // > 0
        public int tinChiTH { get; set; } // > 0

        public MonHoc()
        {
        }

        public MonHoc(string maMonHoc, string tenMonHoc, int tinChiLT, int tinChiTH)
        {
            this.maMonHoc = maMonHoc;
            this.tenMonHoc = tenMonHoc;
            this.tinChiLT = tinChiLT;
            this.tinChiTH = tinChiTH;
        }

        public void input()
        {
           
            Console.Write("Nhap ma mon hoc: ");
            this.maMonHoc = Console.ReadLine(); // gán thẳng cho thuộc tính của đối tượng

            Console.Write("Nhap ten mon hoc: ");
            this.tenMonHoc = Console.ReadLine();

            do
            {
                Console.Write("Nhap tin chi li thuyet: ");
                this.tinChiLT = Convert.ToInt32(Console.ReadLine());
            } while (tinChiLT <= 0);

            do
            {
                Console.Write("Nhap tin chi thuc hanh: ");
                this.tinChiTH = Convert.ToInt32(Console.ReadLine());
            } while (tinChiTH <= 0);
        }
    }
}
