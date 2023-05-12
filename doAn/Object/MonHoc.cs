using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn.Object
{
    internal class MonHoc
    {
        public string maMonHoc { get; set; } // 10 kí tự và 3 số cuối phải là số vd: abcdefg002
        public string tenMonHoc { get; set; }
        public int tinChiLT { get; set; } // > 0
        public int tinChiTH { get; set; } // > 0

        public MonHoc()
        {
        }
        // không cần hàm khởi tạo full tham so vì mik đã có phương thức input và gán thẳng những j ng dùng nhập vào thuộc tính lun roi
        
    }
}
