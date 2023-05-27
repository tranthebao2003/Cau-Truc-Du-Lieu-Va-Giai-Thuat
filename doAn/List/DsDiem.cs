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

        public Node head { get; set; }
        public Node tail { get; set; }
        int size = 0;

        public DsDiem()
        {
            head = null;
            tail = null;
            size = 0;
        }

        // thêm thì khog đc cùng lúc trùng so lan thi va ma mon hoc
        public void add(Diem a)
        {
            Node key = new Node(a);
            if (size == 0)
            {
                head = key;
                tail = key;
                size++;

            }
            else
            {
                Node ptr = head;
                while (ptr != null)
                {
                    if (ptr.diem.soLanThi == a.soLanThi && ptr.diem.maMonHoc == a.maMonHoc && a.diem.ToString() == "") // ràng buộc thêm a.diem.ToString() == "", để khi ta thêm điểm user nhập thì nó sẽ thêm vào đc mặc dù trùng cả mã môn và lần thi
                    {
                        return;
                    }
                    ptr = ptr.next;
                }
                tail.next = key;
                tail = key;
                size++;
            }
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

        public Node removeNode(Node tmp) // hàm này phục vụ cho câu j
        {
            Node ptr = head;
            while (ptr != null)
            {
                if (ptr == tmp) // nếu node cần xóa là node đầu thì phải dùng head
                {
                    head = head.next;
                }

                else if (ptr.next == tmp)
                {
                    ptr.next = ptr.next.next;
                }
                ptr = ptr.next;
            }

            size--;
            return head; // cập nhật lại cái head
        }

        // bản chất của thuật toán này là ta chuyển 1 dslk đơn về 1 mảng sau đó sắp xếp trong mảng
        // rồi lại chuyển mảng đó về dslk đơn 
        public DsDiem sortDsDiem(Node tmp)
        {
            Diem[] mangTmpDiem = new Diem[size]; // tạo 1 mảng điểm vs kich thuoc la dsDiem
            int i = 0;
            while (tmp != null) // đưa từng phan tu trong dslk đơn vào mảng
            {
                mangTmpDiem[i] = tmp.diem;
                tmp = tmp.next;
                i++;
            }

            for (int j = 0; j < mangTmpDiem.Length; j++)
            {
                for (int k = j + 1; k < mangTmpDiem.Length; k++)
                {
                    if (mangTmpDiem[j].maMonHoc.CompareTo(mangTmpDiem[k].maMonHoc) == 1) // sắp xếp mảng dựa vào mã môn học
                    {
                        Diem diemTmp = mangTmpDiem[j];
                        mangTmpDiem[j] = mangTmpDiem[k];
                        mangTmpDiem[k] = diemTmp;
                    }
                }
            }

            DsDiem tmpDsDiem = new DsDiem();


            for (int a = 0; a < mangTmpDiem.Length; a++) // đưa tần ptu của mảng vào dslk đơn mới
            {
                //if(a == 0)
                //{
                //    tmpDsDiem.head = mangTmpDiem[0];
                //}
                tmpDsDiem.add(mangTmpDiem[a]);
            }
            return tmpDsDiem; // trả về dslk mới đã đc sắp xếp
        }

        public void display()
        {
            Node key = head;
            for (int i = 0; i < size; i++)
            {
                string a = key.diem.maMonHoc;
                int b = key.diem.soLanThi;
                float c = key.diem.diem;
                Console.WriteLine("Ma mon hoc: " + a);
                Console.WriteLine("So lan thi: " + b);
                Console.WriteLine("Diem: " + c);
                key = key.next;
            }
        }
    }
}
