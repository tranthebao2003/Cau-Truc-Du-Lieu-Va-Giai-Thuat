using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            public Node(MonHoc monHoc)
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
        
        public void insert(Node temproot, MonHoc e)
        {

            // bản chất ở đây ta cần 2 biến tạm là temp và temproot để chứa địa chỉ của root
            //  temproot dùng để tìm vị trí thích hợp khi chen, còn temp thì để liên kết 2 node lại vs nhau
            Node temp = null;
            
            while (temproot != null)
            {
                temp = temproot; // 2 thằng này giờ đang lưu trữ địa chỉ của root
                
                if (e.maMonHoc.CompareTo(temproot.monHoc.maMonHoc) == 0)
                {
                    return;
                }
                else if (e.maMonHoc.CompareTo(temproot.monHoc.maMonHoc) == -1) // phần tử x < gốc thì thêm vào trái
                {
                    temproot = temproot.left;
                }
                else if (e.maMonHoc.CompareTo(temproot.monHoc.maMonHoc) == 1) // phần tử x > gốc thì thêm vào trái
                {
                    temproot = temproot.right;
                }
            }

            Node n = new Node(e);
            if (root != null)
            {
                if (e.maMonHoc.CompareTo(temp.monHoc.maMonHoc) == -1)
                    temp.left = n;
                else if(e.maMonHoc.CompareTo(temp.monHoc.maMonHoc) == 1)
                    temp.right = n;
            }
            else
            {
                root = n;
            }
        }

        public void displayPreOrder(Node tmpRoot)
        {
            if (tmpRoot != null)
            {
                Console.WriteLine(tmpRoot.monHoc.maMonHoc + " ");
                Console.WriteLine(tmpRoot.monHoc.tenMonHoc + " ");
                Console.WriteLine(tmpRoot.monHoc.tinChiLT + " ");
                Console.WriteLine(tmpRoot.monHoc.tinChiTH + " ");
                displayPreOrder(tmpRoot.left);
                displayPreOrder(tmpRoot.right);
            }
        }
    }
}
