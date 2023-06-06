using doAn.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn.List
{
    internal class DsSinhVien
    {
        #region Node dach sach lien ket
        public class Node // đây cũng xem là thuộc tính của dsSinhVien
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
        public Node head { get; set; }
        public Node tail { get; set; }
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

        // bản chất của thuật toán add thằng nào vào là sắp xếp thằng đó luôn
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
                            addLast(a); // truyền vao Node sv đã tạo
                        }
                    }
                    ptr = ptr.next; // phải để ở đầu vì nếu để ở cuối sau khi đã thêm thì nó sẽ bị lặp lại
                }
            }
            size += 1;
        }

        public void addFirst(Node e)
        {
            e.next = head;
            head = e;
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

        public void addLast(Node sv)
        {
            tail.next = sv;
            tail = sv;
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

        public void remove(int position)
        {
            if(length() == 1) // nếu chỉ có 1 sv thì gán head == null lun
            {
                head = null;
            } 
            else if(position == (length() - 1)) // neu ng ta chọn xóa cái cuối thì dùng removeLast
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
            size--;
        }

        public void editSv(SinhVien a)
        {
            // ma sv khi làm trên window form thì ko bao giờ nhap sai đc vì lúc đó ng dùng sẽ chọn thay vì nhập
            Node ptr = head;
            Node e = new Node(a);
            while (ptr != null) // tìm kiếm thằng trùng mã để edit và lien ket thang moi vs thang phia truoc dong thoi lay ma ptr
            {
                if (head.sv.maSV == e.sv.maSV)
                {
                    e.next = ptr.next;
                    head = e;
                    return; // vì nếu vào đây nghĩa là đã thay thế xong luôn rồi nên thoát
                }
                else if (ptr.sv.maSV == e.sv.maSV)
                {
                    e.next = ptr.next;
                    break;
                }
                ptr = ptr.next;
            }
            Node ptr2 = head;
            while (ptr2 != ptr) // tim thang kế thang dc thay the sau do lien ket no voi thang moi them vao
            {
                if (ptr2.next == ptr)
                {
                    ptr2.next = e;
                    break;
                }
                ptr2 = ptr2.next;
            }
        }

        // thiếu bước nhập mã lớp rồi mới cho nhập sinh viên vào lớp đó
        public void display()
        {
            Node ptr = head;
            Program.formMain.lvSinhVien.Items.Clear(); // xoa nhung dong trong listview trx đó
            while (ptr != null)
            {
                ListViewItem a = new ListViewItem(ptr.sv.maSV);
                // khởi tạo ô đầu tiên của dòng đầu tiên
                //them cac o tiep theo
                a.SubItems.Add(ptr.sv.ho); // ô2
                a.SubItems.Add(ptr.sv.ten); // ô3
                if (ptr.sv.phai == true)
                {
                    a.SubItems.Add("Nữ"); //ô4
                }
                else
                {
                    a.SubItems.Add("Nam"); //ô4
                }
                a.SubItems.Add(ptr.sv.soDT);// ô5

                Program.formMain.lvSinhVien.Items.Add(a);
                ptr = ptr.next;
            }
        }
    }
}
