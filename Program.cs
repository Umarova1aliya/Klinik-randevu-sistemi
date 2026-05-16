using System;
using System.Windows.Forms;

namespace WinFormsApp2 // Bax, buranı layihənin adına uyğunlaşdırdıq
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
