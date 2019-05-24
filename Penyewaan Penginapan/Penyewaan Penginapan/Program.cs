using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Penyewaan_Penginapan
{
    static class Program
    {
        internal static object akuns;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
