using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibrarySystem.Data;
using LibrarySystem.Models;

namespace library_sertif.forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMemID_login.Text) ||
                string.IsNullOrWhiteSpace(txtPassword_login.Text))
            {
                MessageBox.Show("Please fill Member ID and Password");
                return;
            }

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"SELECT id, role FROM users 
                                 WHERE member_id = @mid AND password = @pass";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mid", txtMemID_login.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword_login.Text);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("Member ID or password incorrect");
                        return;
                    }

                    Session.UserId = reader.GetInt32("id");
                    Session.Role = reader.GetString("role");
                }
            }

            if (Session.Role == "ADMIN")
                new AdminMenuForm().Show();
            else
                new UserMenuForm(Session.UserId).Show();

            this.Hide();
        }

        private void lblBack_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new home().Show();
            this.Hide();
        }

        private void lbl_signup_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new signup().Show();
            this.Hide();
        }
    }
}
