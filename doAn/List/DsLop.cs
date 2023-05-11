using doAn.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn.List
{
    internal class DsLop
    {
        private int size = 0;
        public Lop[] dsLop = new Lop[1000];
        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        // add vào mang ta ko can vòng lặp nữa vì ta đã có nút btn Nhập
        public void add(Lop a)
        {
            dsLop[size] = a;
            size++;
        }

        public void remove(int index)
        {
            for (int i = index; i < size; i++)
            {
                dsLop[i] = dsLop[i + 1];
            }
            size--;
        }

        public void editLop(Lop lop)
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

        public void display(ListViewItem a)
        {
            Program.formMain.lvLop.Items.Clear();
            for (int i = 0; i < length(); i++)
            {
                if(dsLop[i].namHoc == Convert.ToInt32(Program.formMain.txtNamHoc.Text))
                {
                    a = new ListViewItem(dsLop[i].maLop);
                    // khởi tạo ô đầu tiên của dòng đầu tiên
                    //them cac o tiep theo
                    a.SubItems.Add(dsLop[i].tenLop); // ô2
                    a.SubItems.Add(dsLop[i].namHoc.ToString()); // ô3
                    Program.formMain.lvLop.Items.Add(a);
                }
            }
        }
    }
}
