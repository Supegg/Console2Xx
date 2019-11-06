using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console2Xx
{
    public partial class Form1 : Form
    {
        //bool inited = false; //manully init console, another choise
        readonly string consoleName = "Su";
        private TextWriter defaultConsoleOut = null;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WinHelper.AllocConsole();
            Console.Title = consoleName;
            defaultConsoleOut = Console.Out;//keep standard Out reffence

            while (true)
            {
                Thread.Sleep(1);//wait for init console
                IntPtr intptr = WinHelper.FindWindow("ConsoleWindowClass", consoleName);
                if (intptr != IntPtr.Zero)
                {
                    WinHelper.ShowWindow(intptr, 0);//隐藏这个窗口
                    break;
                }
                
            }
        }

        /// <summary>
        /// 打开Console窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsole_Click(object sender, EventArgs e)
        {
            IntPtr intptr = WinHelper.FindWindow("ConsoleWindowClass", consoleName);
            if (intptr != IntPtr.Zero)
            {
                WinHelper.ShowWindow(intptr, 1);//显示这个窗口
            }

            Console.WriteLine(DateTime.Now);
            Shell.WriteLine("Shell helper");
        }

        /// <summary>
        /// 隐藏Console
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHide_Click(object sender, EventArgs e)
        {
            Shell.WriteLine("注意：1秒后隐藏Console...");
            Thread.Sleep(1000);

            IntPtr intptr = WinHelper.FindWindow("ConsoleWindowClass", consoleName);
            if (intptr != IntPtr.Zero)
            {
                WinHelper.ShowWindow(intptr, 0);//隐藏这个窗口
            }
        }

        /// <summary>
        /// 重定向到其他流
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2ListBox_Click(object sender, EventArgs e)
        {
            Console.SetOut(new TextBoxWriter(listBox1));
        }

        /// <summary>
        /// 输出时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintTime_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now);
        }

        private void btn2Console_Click(object sender, EventArgs e)
        {
            if (defaultConsoleOut != null)
            {
                Console.SetOut(defaultConsoleOut);
            }
        }
    }
}