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
                    if (ptr.diem.soLanThi == a.soLanThi && ptr.diem.maMonHoc == a.maMonHoc)
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
        public DsDiem sortDsDiem(Node tmp) // phục vụ cho câu j
        {

            List<Diem> tmpDsDiem = new List<Diem>();

            while (tmp != null) // đưa từng phan tu trong dslk đơn vào LIST
            {
                tmpDsDiem.Add(tmp.diem);
                tmp = tmp.next;
            }

            //tmpDsDiem.Count: trả về số phần tử trong list tmpDsDiem
            for (int j = 0; j < tmpDsDiem.Count; j++)
            {
                for (int k = j + 1; k < tmpDsDiem.Count; k++)
                {
                    if (tmpDsDiem[j].maMonHoc.CompareTo(tmpDsDiem[k].maMonHoc) == 1) // sắp xếp list dựa vào mã môn học
                    {
                        Diem diemTmp = tmpDsDiem[j];
                        tmpDsDiem[j] = tmpDsDiem[k];
                        tmpDsDiem[k] = diemTmp;
                    }
                }
            }

            DsDiem tmpDsDiem2 = new DsDiem();

            for (int a = 0; a < tmpDsDiem.Count; a++) // đưa tần ptu của list vào dslk đơn mới
            {
                tmpDsDiem2.add(tmpDsDiem[a]);
            }
            return tmpDsDiem2; // trả về dslk mới đã đc sắp xếp
        }
    }
}
