using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibrarySystem.Data;

namespace library_sertif.forms
{
    public partial class booklist : Form
    {
        private int _userId; // simpan userId yang sedang login

        public booklist(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadBooks(); // load daftar buku saat form dibuka
        }

        private void LoadBooks()
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    // ambil data buku dari database
                    string query = "SELECT id, title, author, stock FROM books";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // tampilkan ke DataGridView
                    dgvBooks_booklist.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // tampilkan error jika gagal load data
                ShowInfo("Error loading books: " + ex.Message);
            }
        }

        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // pastikan baris valid
            if (e.RowIndex < 0) return;

            // ambil data buku yang dipilih
            int bookId = Convert.ToInt32(
                dgvBooks_booklist.Rows[e.RowIndex].Cells["id"].Value
            );

            string title =
                dgvBooks_booklist.Rows[e.RowIndex].Cells["title"].Value.ToString();

            int stock = Convert.ToInt32(
                dgvBooks_booklist.Rows[e.RowIndex].Cells["stock"].Value
            );

            // cek stok sebelum peminjaman
            if (stock <= 0)
            {
                ShowInfo("Sorry, the current stock is not enough");
                return;
            }

            // konfirmasi peminjaman
            DialogResult confirm = MessageBox.Show(
                $"Are you borrowing \"{title}\"?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                BorrowBook(bookId, title);
                LoadBooks(); // refresh stok setelah peminjaman
            }
        }

        private void BorrowBook(int bookId, string title)
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    // insert data peminjaman + update stok buku
                    string sql = @"
                        INSERT INTO loans (user_id, book_id, loan_date, due_date)
                        VALUES (@uid, @bid, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 7 DAY));

                        UPDATE books SET stock = stock - 1 WHERE id = @bid;
                    ";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@uid", Session.UserId);
                    cmd.Parameters.AddWithValue("@bid", bookId);
                    cmd.ExecuteNonQuery();
                }

                WriteLoanLog(title); // simpan log ke file
                ShowInfo("Book borrowed successfully");
            }
            catch (Exception ex)
            {
                ShowInfo("Borrow failed: " + ex.Message);
            }
        }

        private void WriteLoanLog(string title)
        {
            // catat aktivitas peminjaman ke file txt
            string log = $"[{DateTime.Now}] User {Session.MemberId} borrowed '{title}'";
            File.AppendAllText("loan_log.txt", log + Environment.NewLine);
        }

        private void ReadLoanLog()
        {
            string path = "loan_log.txt";

            // cek apakah file log ada
            if (!File.Exists(path))
            {
                ShowInfo("No loan log found");
                return;
            }

            // baca dan tampilkan isi log
            string content = File.ReadAllText(path);
            MessageBox.Show(content, "Loan Log");
        }

        private void ShowInfo(string message)
        {
            // helper untuk menampilkan message box
            MessageBox.Show(message, "Information");
        }

        private void lblBack_booklist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // kembali ke menu user
            new UserMenuForm(_userId).Show();
            this.Close();
        }
    }
}
