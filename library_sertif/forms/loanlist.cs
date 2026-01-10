using LibrarySystem.Data;
using LibrarySystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace library_sertif.forms
{
    public partial class loanlist : Form
    {
        private int _userId;

        public loanlist(int userId)
        {
            InitializeComponent();
            _userId = userId;

            dgvloan_loanlist.CellContentClick += dgvloan_loanlist_CellContentClick;
            LoadLoans();
        }

        private void LoadLoans()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        b.id AS book_id,
                        b.title,
                        l.loan_date,
                        l.due_date,
                        l.is_returned
                    FROM loans l
                    JOIN books b ON l.book_id = b.id
                    WHERE l.user_id = @uid
                ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", _userId);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Columns.Add("BookId");
                table.Columns.Add("Title");
                table.Columns.Add("Loan Date");
                table.Columns.Add("Status");

                while (reader.Read())
                {
                    int bookId = reader.GetInt32("book_id");
                    string title = reader.GetString("title");
                    DateTime loanDate = reader.GetDateTime("loan_date");
                    DateTime dueDate = reader.GetDateTime("due_date");
                    bool isReturned = reader.GetInt32("is_returned") == 1;

                    string status;
                    if (isReturned)
                    {
                        status = "Returned";
                    }
                    else
                    {
                        int daysLeft = (dueDate.Date - DateTime.Now.Date).Days;
                        if (daysLeft >= 0)
                            status = $"Remaining {daysLeft} days";
                        else
                            status = $"Overdue by {Math.Abs(daysLeft)} days";
                    }

                    table.Rows.Add(bookId, title, loanDate.ToShortDateString(), status);
                }

                dgvloan_loanlist.DataSource = table;
                dgvloan_loanlist.Columns["BookId"].Visible = false;
            }

            AddReturnButton();
            HighlightOverdue();
        }

        private void AddReturnButton()
        {
            if (!dgvloan_loanlist.Columns.Contains("btnReturn"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnReturn";
                btn.HeaderText = "Action";
                btn.Text = "Return";
                btn.UseColumnTextForButtonValue = true;
                dgvloan_loanlist.Columns.Add(btn);
            }

            foreach (DataGridViewRow row in dgvloan_loanlist.Rows)
            {
                if (row.Cells["Status"].Value?.ToString() == "Returned")
                {
                    row.Cells["btnReturn"].Value = "Returned";
                    row.Cells["btnReturn"].Style.ForeColor = Color.Gray;
                    row.Cells["btnReturn"].ReadOnly = true;
                }
            }
        }

        private void HighlightOverdue()
        {
            foreach (DataGridViewRow row in dgvloan_loanlist.Rows)
            {
                if (row.Cells["Status"].Value == null) continue;

                string status = row.Cells["Status"].Value.ToString();
                if (status.Contains("Overdue"))
                {
                    row.Cells["Status"].Style.ForeColor = Color.Red;
                    row.Cells["Status"].Style.Font =
                        new Font(dgvloan_loanlist.Font, FontStyle.Bold);
                }
            }
        }

        private void dgvloan_loanlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvloan_loanlist.Columns[e.ColumnIndex].Name == "btnReturn")
            {
                string status = dgvloan_loanlist.Rows[e.RowIndex]
                                .Cells["Status"].Value.ToString();

                if (status == "Returned") return;

                int bookId = Convert.ToInt32(
                    dgvloan_loanlist.Rows[e.RowIndex].Cells["BookId"].Value
                );

                DialogResult confirm = MessageBox.Show(
                    "Return this book?",
                    "Confirm",
                    MessageBoxButtons.YesNo
                );

                if (confirm == DialogResult.Yes)
                {
                    ReturnBook(bookId);
                    LoadLoans();
                }
            }
        }

        private void ReturnBook(int bookId)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string sql = @"
                    UPDATE loans
                    SET is_returned = 1,
                        returned_date = CURDATE()
                    WHERE user_id = @uid
                      AND book_id = @bid
                      AND is_returned = 0;

                    UPDATE books
                    SET stock = stock + 1
                    WHERE id = @bid;
                ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", _userId);
                cmd.Parameters.AddWithValue("@bid", bookId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Book returned successfully");
        }

        private void lblBack_loanlist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UserMenuForm(_userId).Show();
            this.Close();
        }
    }
}
