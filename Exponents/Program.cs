using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Exponents
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Brandon Collins
        /// 5/1/2022
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
