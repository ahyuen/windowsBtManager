using System;
using System.Windows.Forms;
using 宝塔管理工具;

namespace 宝塔管理工具
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindows());
        }
    }
}