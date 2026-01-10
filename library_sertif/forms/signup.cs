using library_sertif.Forms;
using LibrarySystem.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace library_sertif.forms
{
    public partial class signup : Form
    {
        private int _userId;
        public signup()
        {
            InitializeComponent();

        }
        private string GenerateMemberId()
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT MAX(member_id) FROM users WHERE member_id LIKE 'MEM%'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            object result = cmd.ExecuteScalar();
            conn.Close();

            if (result == DBNull.Value || result == null)
            {
                return "MEM0001";
            }

            string lastId = result.ToString(); 
            int number = int.Parse(lastId.Substring(3));
            number++;

            return "MEM" + number.ToString("D4");
        }
        private void btnSignup_signup_Click(object sender, EventArgs e)
        {
            string memberId = GenerateMemberId();

            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            string query = @"
                INSERT INTO users
                (member_id, name, address, email, sex, age, password, role)
                VALUES
                (@mid, @name, @addr, @email, @sex, @age, @pass, 'USER')
            ";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@mid", memberId);
            cmd.Parameters.AddWithValue("@name", txtName_signup.Text);
            cmd.Parameters.AddWithValue("@addr", txtAddress_signup.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail_signup.Text);
            cmd.Parameters.AddWithValue("@sex", cmbGender_signup.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(txtAge_signup.Text));
            cmd.Parameters.AddWithValue("@pass", txtPsw_signup.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show(
                $"Signup berhasil!\nMember ID kamu adalah: {memberId}",
                "Sukses"
            );

            new LoginForm().Show();
            this.Hide();
        }

        private void lblBack_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new home().Show();
            this.Hide();
        }
        private void signup_Load(object sender, EventArgs e)
        {
        }

       
    }
}
