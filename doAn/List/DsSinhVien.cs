using doAn.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn.List
{
    internal class DsSinhVien
    {
        #region Node cay nhi phan
        public class Node
        {
            public SinhVien sv;
            public Node next;

            public Node(SinhVien sv)
            {
                this.sv = sv;
                this.next = null;
            }
        }
        #endregion
        private Node head;
        private Node tail;
        int size;

        public DsSinhVien()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void add(SinhVien e)
        {
            Node a = new Node(e);
            if (isEmpty())
            {
                head = a; // con trỏ head lưu địa chỉ node a
                tail = a;
            }
            else
            {
                int position = 0;
                Node ptr = head;
                while (ptr != null)
                {
                    // so sanh chuỗi ten+ho của sv mới truyền vào với all những sv trước đó


                    if ((ptr.sv.ten + ptr.sv.ho).CompareTo(e.ten + e.ho) == 1)
                    {
                        if (position == 0)
                        {
                            addFirst(a); // truyền vao Node sv được tạo ra bởi 1 sinh vien
                            break;
                        }
                        else
                        {
                            addAny(a, position);
                            break;
                        }
                    }
                    else
                    {
                        position++;
                        if (position == length()) // so sánh vị trí cần chèn vs kích thước list nếu vị trí == kích thước nghĩa là chèn ở cuối
                        {
                            adddLast(a); // truyền vao Node sv đã tạo
                        }
                    }
                    ptr = ptr.next; // phải để ở đầu vì nếu để ở cuối sau khi đã thêm thì nó sẽ bị lặp lại
                }
            }
            size += 1;
        }

        public void addFirst(Node e)
        {
            if (isEmpty())
            {
                head = e;
                tail = e;
            }
            else
            {
                e.next = head;
                head = e;
            }
        }

        public void addAny(Node e, int position) // đang có vấn đề
        {
            Node ptr = head;
            int i = 1;
            while (i < position) // tìm vị trí cần chèn
            {
                ptr = ptr.next;
                i += 1;
            }
            e.next = ptr.next;
            ptr.next = e;
        }

        public void adddLast(Node sv)
        {
            tail.next = sv;
            tail = sv;
        }

        public void display()
        {
            Node ptr = head;
            while (ptr != null)
            {
                Console.Write(ptr.sv.ho + "-->");
                Console.Write(ptr.sv.ten + "-->");
                Console.Write(ptr.sv.soDT + "-->");
                Console.Write(ptr.sv.maSV + "-->");
                Console.Write(ptr.sv.phai + "-->");
                Console.WriteLine();
                ptr = ptr.next;
            }
            Console.WriteLine();
        }

      
    }
}
