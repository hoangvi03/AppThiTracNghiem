using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungThiTN
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DangNhap());
            //Application.Run(new DangKy());
            //Application.Run(new DoiMatKhau());
            //Application.Run(new FormThiSinh());
            //Application.Run(new FormGiaoVien());
            //Application.Run(new MonThi());
        }
    }
}
