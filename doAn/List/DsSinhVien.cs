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
                    if ((ptr.sv.ten + ptr.sv.ho).CompareTo(e.ten + e.ho) == 1)
                    {
                        if (position == 0)
                        {
                            addFirst(e);
                            break;
                        }
                        else
                        {
                            addAny(e, position);
                            break;
                        }
                    }
                    else
                    {
                        position++;
                        if (position == length())
                        {
                            adddLast(e);
                        }
                    }
                    ptr = ptr.next;
                }
            }
            size += 1;
        }

        public void addFirst(SinhVien e)
        {
            Node a = new Node(e);
            if (isEmpty())
            {
                head = a;
                tail = a;
            }
            else
            {
                a.next = head;
                head = a;
            }
            size += 1;
        }

        public void addAny(SinhVien e, int position)
        {
            Node a = new Node(e);

            Node ptr = head;
            int i = 1;
            while (i < position - 1)
            {
                ptr = ptr.next;
                i += 1;
            }
            a.next = ptr.next;
            ptr.next = a;
            size += 1;
        }

        public void adddLast(SinhVien e)
        {
            Node b = new Node(e);
            Node ptr = tail;
            tail.next = b;
            tail = b;
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
