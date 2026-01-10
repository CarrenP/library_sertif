using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibrarySystem.Data;

namespace library_sertif.forms
{
    public partial class booklist : Form
    {
        private int _userId;

        public booklist(int userId)
        {
            InitializeComponent();
            _userId = userId;
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
                dgvBooks_booklist.DataSource = dt;
            }
        }

        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int bookId = Convert.ToInt32(
                dgvBooks_booklist.Rows[e.RowIndex].Cells["id"].Value
            );

            string title =
                dgvBooks_booklist.Rows[e.RowIndex].Cells["title"].Value.ToString();

            int stock = Convert.ToInt32(
                dgvBooks_booklist   .Rows[e.RowIndex].Cells["stock"].Value
            );

            if (stock <= 0)
            {
                MessageBox.Show(
                    "Sorry, the current stock is not enough",
                    "Info"
                );
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you borrowing \"{title}\"?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                BorrowBook(bookId);
                LoadBooks();
            }
        }

        private void BorrowBook(int bookId)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

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

            MessageBox.Show("Book Borrowed");
        }

        private void lblBack_booklist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UserMenuForm(_userId).Show();
            this.Close();
        }
    }
}
