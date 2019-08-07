using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinForms
{
    static class Program
    {
        static Mutex _mutex = new Mutex(true, name: "bf6857be-54d9-4436-8ec3-0f8fcc3529ec");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (_mutex.WaitOne(TimeSpan.Zero, true))
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
                finally
                {
                    _mutex.ReleaseMutex();
                }
            }
            else
            {
                //Process process = new Process();
                //process.StartInfo.FileName = "LevitSoft";
                //process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                //process.Start();
                MessageBox.Show("O sistema já está aberto!");
            }
        }
    }
}
