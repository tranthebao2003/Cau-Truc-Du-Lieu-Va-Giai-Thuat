using doAn.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn.List
{
    internal class DsLop
    {
        private int size = 0;
        Lop[] dsLop = new Lop[1000];
        public int length()
        {
            return size;
        }

        public void add()
        {
            Lop lop1 = new Lop();
            lop1.input();
            int mark = 0;
            while (true)
            {
                mark = 0;
                for (int i = 0; i < length(); i++)
                {
                    if (dsLop[i].maLop == lop1.maLop)
                    {
                        mark = 1;
                        Console.WriteLine("Ma lop da ton tai! Vui long nhap lai ma lop");
                        lop1.maLop = Console.ReadLine();
                    }
                }
                if (mark == 0)
                {
                    break;
                }
            }
            
            dsLop[size] = lop1;
            size++;
        }
    }
}
