using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace A19_Ex01_Aline_000802480_Uri_201465234
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}
