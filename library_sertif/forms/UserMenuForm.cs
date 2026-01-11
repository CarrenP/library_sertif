using System;
using System.Windows.Forms;

namespace library_sertif.forms
{
    // Menu utama untuk user (member)
    // Inherit dari BaseMenuForm
    public partial class UserMenuForm : BaseMenuForm
    {
        private string _userName; // nama user untuk ditampilkan di UI

        public UserMenuForm(int userId, string userName = "Member") : base(userId)
        {
            InitializeComponent();

            _userName = userName;

            // tampilkan nama user jika label tersedia
            if (lblWelcome != null)
            {
                lblWelcome.Text = $"Welcome, {_userName}";
            }

            // set judul form dari method base / override
            this.Text = ShowMenuInfo();
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            // buka daftar buku
            new booklist(UserId).Show();
            this.Hide();
        }

        private void btnMyLoans_Click(object sender, EventArgs e)
        {
            // buka daftar peminjaman user
            new loanlist(UserId).Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // konfirmasi logout
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                // kembali ke halaman awal
                new home().Show();
                this.Close();
            }

            // (note: kode ini akan tetap jalan walau user pilih No)
            // buka ulang menu user
            new UserMenuForm(Session.UserId, Session.MemberId).Show();
            this.Hide();
        }
    }
}
