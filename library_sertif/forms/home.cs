using library_sertif.forms;
using library_sertif.Forms;
using System;
using System.Windows.Forms;

// NOTE:
// Potongan class home di atas namespace ini tidak diperlukan.
// Class home yang dipakai ada di bawah (dalam namespace library_sertif.forms).

namespace library_sertif.forms
{
    // Form awal aplikasi (Home)
    public partial class home : Form
    {
        private int _userId; // default userId (belum login)

        public home()
        {
            InitializeComponent();
            this.Text = "Home";
            _userId = 0; // 0 menandakan user belum login
        }

        private void btn_signin_home_Click(object sender, EventArgs e)
        {
            // buka form login
            new LoginForm().Show();
            this.Hide();
        }

        private void btn_Signup_home_Click(object sender, EventArgs e)
        {
            // buka form signup / registrasi
            new signup().Show();
            this.Hide();
        }
    }
}
