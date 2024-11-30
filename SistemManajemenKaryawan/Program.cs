using SistemManajemenKaryawan.View;
using System;
using System.Windows.Forms;

namespace SistemManajemenKaryawan
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMulai());
        }
    }
}
