using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console2Xx
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


//#if DEBUG
//            AllocConsole();
//            Shell.WriteLine("注意：启动程序...");

//            Shell.WriteLine("/tWritten by Oyi319");
//            Shell.WriteLine("/tBlog: http://blog.csdn.com/oyi319");
//            Shell.WriteLine("{0}：{1}", "警告", "这是一条警告信息。");
//            Shell.WriteLine("{0}：{1}", "错误", "这是一条错误信息！");
//            Shell.WriteLine("{0}：{1}", "注意", "这是一条需要的注意信息。");
//            Shell.WriteLine("");
//#endif
//            Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new Form1());
//#if DEBUG
//            Shell.WriteLine("注意：2秒后关闭...");
//            Thread.Sleep(2000);
//            FreeConsole();
//#endif
        }
    }
}
