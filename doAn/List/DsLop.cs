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

        public void remove(string maLop) 
        {
            int index = 0;
            for (int i = 0; i < length(); i++)
            {
                if (dsLop[i].maLop == maLop)
                {
                    index = i;
                    break;
                }
            }
            for (int i = index; i < size; i++)
            {
                dsLop[i] = dsLop[i + 1];
            }
            size --;
        }

        public void edit(Lop lop)
        {
            for (int i = 0;i < length();i++)
            {
                if (dsLop[i].maLop == lop.maLop) 
                {
                    dsLop[i] = lop;
                    break;
                }
            }
        }

        public void display(int fromYear, int toYear) 
        {
            for (int i = 0; i < length();i++) 
            {
                if (dsLop[i].namHoc >= fromYear && dsLop[i].namHoc <= toYear)
                {
                    Console.WriteLine("Ma lop: " + dsLop[i].maLop);
                    Console.WriteLine("Ten lop: " + dsLop[i].tenLop);
                    Console.WriteLine("Nam hoc: " + dsLop[i].namHoc);
                    Console.WriteLine();
                }
            }
        }
    }
}
