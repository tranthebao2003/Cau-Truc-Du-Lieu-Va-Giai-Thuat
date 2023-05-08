using doAn.Object;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           
        Node head;
        Node tail;
        int Size = 0;

        public DsDiem()
        {
            head = null;
            tail = null;
            Size = 0;
        }

        public void add(Diem a)
        {
            Node key = new Node(a);
            if (Size == 0)
            {
                head = key;
                tail = key;
            }
            else
            {
                tail.next = key;
                tail = key;  
            }
            Size++;
        }

        //public void remove(Diem a)
        //{
        //    Node key = new Node(a);
        //    Node p = head, delete = null;
        //    for (int i = 0; i < Size; i++)
        //    {
        //        if(p == key)
        //        {
        //            if (i == 0)
        //            {
        //                head = head.next;
        //            }
        //            else
        //            {
        //                delete.next = p.next;
        //            }
        //            Size--;
        //            return;
        //        }
        //        else
        //        {
        //            delete = p;
        //            p = p.next;
        //        }
        //    }
        //}

        public void display()
        {
            Node key = head;
            for (int i=0; i<Size; i++)
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
