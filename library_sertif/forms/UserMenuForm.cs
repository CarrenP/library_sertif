using System;
using System.Windows.Forms;

namespace library_sertif.forms
{
    public partial class UserMenuForm : Form
    {
        private int _userId;
        private string _userName;

        public UserMenuForm(int userId, string userName)
        {
            InitializeComponent(); 
            _userId = userId;
            _userName = userName;

            if (lblWelcome != null)
            {
                lblWelcome.Text = $"Welcome, {_userName}";
            }
        }

        public UserMenuForm(int userId)
        {
            InitializeComponent();   
            _userId = userId;

            if (lblWelcome != null)
            {
                lblWelcome.Text = "Welcome, Member";
            }
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            new booklist(_userId).Show();
            this.Hide();
        }

        private void btnMyLoans_Click(object sender, EventArgs e)
        {
            new loanlist(_userId).Show();
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
        }
    }
}
