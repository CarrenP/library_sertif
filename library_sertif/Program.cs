using System;
using System.Windows.Forms;

namespace library_sertif
{
    internal static class Program
    {
        [STAThread] // required untuk aplikasi Windows Forms

        static void Main()
        {
            // aktifkan visual styles Windows
            Application.EnableVisualStyles();

            // set rendering text default
            Application.SetCompatibleTextRenderingDefault(false);

            // jalankan aplikasi dan buka form awal (home)
            Application.Run(new forms.home());
        }
    }
}
