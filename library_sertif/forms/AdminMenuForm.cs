using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibrarySystem.Data;

namespace library_sertif.forms
{
    public partial class AdminMenuForm : Form
    {
        private int _userId;
        public AdminMenuForm()
        {
            InitializeComponent();
            this.Text = "Admin Menu";
            LoadBooks();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void btn_rmv_book_Click_1(object sender, EventArgs e) 
        {
            new bookmanagement().Show();
            this.Close();
        }
        private void btnBookBorrow_admin_Click_1(object sender, EventArgs e)
        {
            new bookborrowed().Show();
            this.Close();
        }

        private void LoadBooks()
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT id, title, author, stock FROM books";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dgvBooks.DataSource = table;

            conn.Close();
        }

        private void lblBack_admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new home().Show();
            this.Close();
        }

        
    }
}
