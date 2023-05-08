using doAn.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn
{
    internal static class Program
    {
        public static DsSinhVien ds1 = new DsSinhVien(); // tạo 1 phương thức tĩnh của class program, phương thức này khởi tạo 1 dsSinhVien
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
