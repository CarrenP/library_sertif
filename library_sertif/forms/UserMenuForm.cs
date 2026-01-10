using System;
using System.Windows.Forms;

namespace library_sertif.forms
{
    public partial class UserMenuForm : BaseMenuForm
    {
        private string _userName;

        public UserMenuForm(int userId, string userName = "Member") : base(userId)
        {
            InitializeComponent();

            _userName = userName;

            if (lblWelcome != null)
            {
                lblWelcome.Text = $"Welcome, {_userName}";
            }

            this.Text = ShowMenuInfo();
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            new booklist(UserId).Show();
            this.Hide();
        }

        private void btnMyLoans_Click(object sender, EventArgs e)
        {
            new loanlist(UserId).Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                new home().Show();
                this.Close();
            }
            new UserMenuForm(Session.UserId, Session.MemberId).Show();
            this.Hide();

        }

    }
}
