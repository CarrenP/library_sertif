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
            LoadBooks(); // load data buku saat form dibuka
        }

        private void LoadBooks()
        {
            // ambil dan tampilkan data buku dari database
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
            // validasi input tidak boleh kosong
            if (txtTitle_bookmag.Text == "" ||
                txtAuthor_bookmag.Text == "" ||
                txtStock_bookmag.Text == "")
            {
                MessageBox.Show("Lengkapi semua data");
                return;
            }

            // simpan data buku baru ke database
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
            ClearInput();   // reset input setelah insert
            LoadBooks();    // refresh DataGridView
        }

        private void btnRemove_bookmag_Click(object sender, EventArgs e)
        {
            // pastikan ada baris yang dipilih
            if (dgvBook_bookmag.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih buku terlebih dahulu");
                return;
            }

            // ambil data buku yang dipilih
            int bookId = Convert.ToInt32(
                dgvBook_bookmag.SelectedRows[0].Cells["id"].Value
            );

            string title =
                dgvBook_bookmag.SelectedRows[0].Cells["title"].Value.ToString();

            // konfirmasi penghapusan
            DialogResult confirm = MessageBox.Show(
                $"Remove \"{title}\"?",
                "Konfirmasi",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes) return;

            // hapus buku dari database
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM books WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", bookId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Buku berhasil dihapus");
            LoadBooks(); // refresh data setelah delete
        }

        private void ClearInput()
        {
            // bersihkan textbox input
            txtTitle_bookmag.Clear();
            txtAuthor_bookmag.Clear();
            txtStock_bookmag.Clear();
        }

        private void lblBack_bookmag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // kembali ke menu admin
            new AdminMenuForm().Show();
            this.Close();
        }
    }
}
