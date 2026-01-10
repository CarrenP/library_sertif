using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibrarySystem.Data;

namespace library_sertif.forms
{
    public partial class bookmanagement : Form
    {
        public bookmanagement()
        {
            InitializeComponent();
            this.Text = "Admin - Manage Books";
            LoadBooks();
        }

        private void LoadBooks()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, title, author, stock FROM books";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBook_bookmag.DataSource = dt;
            }
        }

        private void btnAdd_bookmag_Click(object sender, EventArgs e)
        {
            if (txtTitle_bookmag.Text == "" || txtAuthor_bookmag.Text == "" || txtStock_bookmag.Text == "")
            {
                MessageBox.Show("Lengkapi semua data");
                return;
            }

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"
                    INSERT INTO books (title, author, stock)
                    VALUES (@title, @author, @stock)
                ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", txtTitle_bookmag.Text);
                cmd.Parameters.AddWithValue("@author", txtAuthor_bookmag.Text);
                cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock_bookmag.Text));
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Buku berhasil ditambahkan");
            ClearInput();
            LoadBooks();
        }

        private void btnRemove_bookmag_Click(object sender, EventArgs e)
        {
            if (dgvBook_bookmag.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih buku terlebih dahulu");
                return;
            }

            int bookId = Convert.ToInt32(
                dgvBook_bookmag.SelectedRows[0].Cells["id"].Value
            );

            string title =
                dgvBook_bookmag.SelectedRows[0].Cells["title"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Remove \"{title}\"?",
                "Konfirmasi",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes) return;

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM books WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", bookId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Buku berhasil dihapus");
            LoadBooks();
        }

        private void ClearInput()
        {
            txtTitle_bookmag.Clear();
            txtAuthor_bookmag.Clear();
            txtStock_bookmag.Clear();
        }

        private void lblBack_bookmag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminMenuForm().Show();
            this.Close();
        }
    }
}
