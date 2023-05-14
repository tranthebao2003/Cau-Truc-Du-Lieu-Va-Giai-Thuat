using doAn.Object;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn.List
{
    internal class DsDiem
    {

        #region Node dach sach lien ket
        public class Node // đây cũng xem là thuộc tính của dsSinhVien
        {
            public Diem diem;
            public Node next;

            public Node(Diem diem)
            {
                this.diem = diem;
                this.next = null;
            }
        }

        #endregion
           
        public Node head { get; set; }
        public Node tail { get; set; }
        int size = 0;

        public DsDiem()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public void add(Diem a)
        {
            Node key = new Node(a);
            if (size == 0)
            {
                head = key;
                tail = key;
            }
            else
            {
                tail.next = key;
                tail = key;  
            }
            size++;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void remove(int position)
        {
            if (isEmpty())
            {
                MessageBox.Show(
                 "Chưa có phần tử nào để xóa",
                 "Thông báo",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            else
            {
                if (length() == 1) // nếu chỉ có 1 sv thì gán head == null lun
                {
                    head = null;
                }
                else if (position == (length() - 1)) // neu ng ta chọn xóa cái cuối thì dùng removeLast
                {
                    removeLast();
                }
                else // neu ng ta chọn bất kì thì dùng removeAny
                {
                    Node ptr = head;
                    int i = 1;
                    while (i < position - 1)
                    { // tìm cái node gần phần tử muốn xóa
                        ptr = ptr.next;
                        i += 1;
                    }
                    ptr.next = ptr.next.next;
                }
            }
            size--;
        }

        public void removeLast()
        {
            Node p = head;
            while (p.next.next != null) // tìm node của phần tử trước phần tử cuối
            { // p.next.next: trỏ đến cái next của ô kế tiếp so với địa chỉ hiện tại mà p đang lưu
                p = p.next;
            }
            p.next = null;
        }


        // chưa xong đâu cứ v đã
        public void display()
        {
            Node key = head;
            for (int i=0; i<size; i++)
            {
                string a = key.diem.maMonHoc;
                int b = key.diem.soLanThi;
                float c = key.diem.diem;
                Console.WriteLine("Ma mon hoc: " + a);
                Console.WriteLine("So lan thi: " + b);
                Console.WriteLine("Diem: " + c);
            }
        }
    }
}
