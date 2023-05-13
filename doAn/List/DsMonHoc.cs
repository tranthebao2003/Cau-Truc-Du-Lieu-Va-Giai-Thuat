using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn.Object
{
    internal class DsMonHoc
    {
        #region Node cay nhi phan
        public class Node
        {
            public MonHoc monHoc;
            public Node left;
            public Node right;

            public Node(MonHoc monHoc) // khi khởi tạo thằng đầu tiên thì hiển nhiên 2 con trỏ left, right phải là null
            {
                this.monHoc = monHoc;
                this.left = null;
                this.right = null;
            }
        }
        #endregion

        public Node root { get; set; }
        public DsMonHoc()
        {
            this.root = null;
        }
        
        // ta sẽ in theo ten mon hoc de khi dung inorder thi no se duyet theo thu tu tang dan ten mon hoc
        // vi them theo ten mon hoc va ma mon hoc ko trung nen ta se rang buoc ten mon hoc va ma mon hoc deu khong duoc trung nhau
        public bool insert(Node temproot, MonHoc e)
        {
            // bản chất ở đây ta cần 2 biến tạm là temp và temproot để chứa địa chỉ của root
            //  temproot dùng để tìm vị trí thích hợp khi chen, còn temp thì để liên kết 2 node lại vs nhau
            Node temp = null;
            
            while (temproot != null)
            {
                temp = temproot; // 2 thằng này giờ đang lưu trữ địa chỉ của root
                
                if (e.maMonHoc.CompareTo(temproot.monHoc.maMonHoc) == 0)  //note
                {
                    MessageBox.Show(
                        "Mã môn học bị trùng!",
                        "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if(e.tenMonHoc.CompareTo(temproot.monHoc.tenMonHoc) == 0)
                {
                    MessageBox.Show(
                        "Tên môn học bị trùng!",
                        "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (e.tenMonHoc.CompareTo(temproot.monHoc.tenMonHoc) == -1) // phần tử x < gốc thì thêm vào trái
                {
                    temproot = temproot.left;
                }
                else if (e.tenMonHoc.CompareTo(temproot.monHoc.tenMonHoc) == 1) // phần tử x > gốc thì thêm vào trái
                {
                    temproot = temproot.right;
                }
           
            }

            Node n = new Node(e);
            if (root != null)
            {
                if (e.tenMonHoc.CompareTo(temp.monHoc.tenMonHoc) == -1)
                    temp.left = n;
                else if(e.tenMonHoc.CompareTo(temp.monHoc.tenMonHoc) == 1)
                    temp.right = n;
            }
            else
            {
                root = n;
            }
            return true;
        }

        public Node timNodeTheMang(Node rootCanXoa, Node PhaiRootCanXoa)
        {
            // tìm node trái nhất của cây con phải(cây con phải của cái node cần xóa)
            // thì khi node thể mạng này thay thế node cần xóa nó sẽ đảm bảo tính chất của cây nhị phân
            // tóm lại ta chỉ cần thay thế element của node cần xóa == element của node thế mạng rồi xong đó nó quay ve truong hợp xóa node leaf va dung ham xoa 1 lan nua
            if (PhaiRootCanXoa.left != null)
            {
                rootCanXoa = timNodeTheMang(rootCanXoa, PhaiRootCanXoa.left);
            }
            else // tim ra đc node trái nhất
            {
                rootCanXoa.monHoc = PhaiRootCanXoa.monHoc;
                /*PhaiRootCanXoa = PhaiRootCanXoa.right;*/ // nếu mà mik gán thẳng thàng rootY bằng null thì những thằng sau sẽ bị mất
            }
            return rootCanXoa;
        }

        // xóa đc node 1 con và node leaf
        // phải sử dụng nút ref để tham chiếu đến cây nhị phân thì mới xóa đc node trong cây nhị phân
        // tempRoot no chính la cai root thực sự lun vì hien tai dang dung ref(tham chieu) vì the no se co quyen thay
        // the node trong cay
        public Node removeNode(Node tempRoot, MonHoc e)
        {
            if (tempRoot == null)
            {
                return null;
            }
            else
            {
                if (e.tenMonHoc.CompareTo(tempRoot.monHoc.tenMonHoc) == -1)
                {
                    tempRoot.left = removeNode(tempRoot.left, e);
                }
                else if (e.tenMonHoc.CompareTo(tempRoot.monHoc.tenMonHoc) == 1)
                {
                    tempRoot.right = removeNode(tempRoot.right, e);
                }

                // bản chất thuật toán này là nếu là node leaf thì nó sẽ trả về null lun
                // còn nếu là node có 1 con thì nó sẽ lấy node cha của node cần xóa liên kết với node con của node cần xóa
                else // e == tempRoot.element, đã tìm ra node can xoa
                {
                    if (tempRoot.left == null && tempRoot.right == null)
                    {
                        return null; 
                    }
                    else if (tempRoot.left == null)
                    {
                        return tempRoot.right;
                    }
                    else if (tempRoot.right == null)
                    {
                        return tempRoot.left;
                    }
                    // Node can xoa node co 2 con
                    else
                    {
                        Node minNode = timNodeTheMang(tempRoot, tempRoot.right); // nó trả về node nhỏ nhất của tempRoot.right và đồng thời đã thay e của node đó vào node cần xóa
                        tempRoot.right = removeNode(tempRoot.right, minNode.monHoc); // h ta chỉ cần xóa node thế mạng kia là xong, ta cần truyen vao cái root của node thể mạng và cái element của node thế mạng
                    }
                }
            }
            return tempRoot; // cập nhật lại tempRoot sau quá trình sửa đổi ở trên
        }

        // thuat toan này mik cho sửa mã môn lun mac dù nó là duy nhất vì thuat toan sửa này kết hết giữa thêm và xóa
        // nếu ta ko cho sửa ma mon thì khi thêm vào sẽ bị lỗi vì ngay từ đầu ta đã ko cho ng dùng nhập trùng mã môn
        public Node modifyNode(Node root, MonHoc target, MonHoc newValue)
        {
            bool mark = insert(root, newValue);
            if (mark == true)
            {
               root =  removeNode(root, target);
               
            }
            return root;
        }


        public void displayInOrder(Node tmpRoot, ListViewItem a)
        {
            if (tmpRoot != null)
            {
                displayInOrder(tmpRoot.left, a);

                a = new ListViewItem(tmpRoot.monHoc.maMonHoc);
                // khởi tạo ô đầu tiên của dòng đầu tiên
                //them cac o tiep theo
                a.SubItems.Add(tmpRoot.monHoc.tenMonHoc); // ô2
                a.SubItems.Add(tmpRoot.monHoc.tinChiLT.ToString()); // ô3
                a.SubItems.Add(tmpRoot.monHoc.tinChiTH.ToString()); // ô4
                Program.formMain.lvDsMon.Items.Add(a);

                displayInOrder(tmpRoot.right, a);
            }
        }
    }
}
