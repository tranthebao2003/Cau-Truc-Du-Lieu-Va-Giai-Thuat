using doAn.List;
using doAn.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn
{
    internal static class Program
    {
        public static DsSinhVien objectDsSinhVien = new DsSinhVien(); // tạo 1 phương thức tĩnh của class program, phương thức này khởi tạo 1 dsSinhVien
        public static DsLop objectDslop = new DsLop();
        public static DsMonHoc objectDsMonHoc = new DsMonHoc();

        public static Form1 formMain;
        public static ListViewItem lvItem;
         

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new Form1(); 
            lvItem = new ListViewItem();
            Application.Run(formMain);
        }
    }
}
