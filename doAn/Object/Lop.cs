// project doAn.list để thu muc Object co thể tìm thấy thư mục list
using doAn.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn.Object
{
    internal class Lop
    {
        public string maLop { get; set; } // d21cqpt01-n (11 kí tự và kí tự 2 và 3 thể hiện năm nhập học)
        public string tenLop { get; set; }
        public int namHoc { get; set; } //1000 -> 9999

        public DsSinhVien dssv; // con trỏ này trỏ đến class dssv 


        public Lop()
        {
            this.maLop = "";
            this.dssv = new DsSinhVien(); // phải khởi tạo con trỏ này vì khi ta khởi tạo đội tướng result ở sự kiện double click nó sẽ gọi đến hàm này
        }
    }
}
