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

        public void add(Lop a)
        {
            int mark = 0;
            while (true)
            {
                mark = 0;
                for (int i = 0; i < length(); i++)
                {
                    if (dsLop[i].maLop == a.maLop)
                    {
                        mark = 1;
                        Console.WriteLine("Ma lop da ton tai! Vui long nhap lai ma lop");
                        a.maLop = Console.ReadLine();
                    }
                }
                if (mark == 0)
                {
                    break;
                }
            }

            dsLop[size] = a;
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
            size--;
        }

        public void edit(Lop lop)
        {
            for (int i = 0; i < length(); i++)
            {
                if (dsLop[i].maLop == lop.maLop)// tim vi tri lop can sua dua vao ma lop
                {
                    dsLop[i] = lop; // thay doi du lieu cua lop cu thanh lop moi
                    break;
                }
            }
        }

        public void display(int year)
        {
            for (int i = 0; i < length(); i++)
            {
                if (dsLop[i].namHoc == year)
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
