using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibrarySystem.Data;

namespace library_sertif.forms
{
    public partial class bookborrowed : Form
    {
        public bookborrowed()
        {
            InitializeComponent();
            this.Text = "Admin - Borrowed Books";
            LoadBorrowedBooks();
        }

        private void LoadBorrowedBooks()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                         u.member_id,
                        u.name,
                        b.title,
                        l.loan_date,
                        l.due_date,
                        l.is_returned,
                        l.returned_date
                    FROM loans l
                    JOIN users u ON l.user_id = u.id
                    JOIN books b ON l.book_id = b.id
                ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Columns.Add("Member ID");
                table.Columns.Add("Name");
                table.Columns.Add("Book Title");
                table.Columns.Add("Loan Date");
                table.Columns.Add("Status");

                while (reader.Read())
                {
                    bool isReturned = Convert.ToInt32(reader["is_returned"]) == 1;

                    string status;

                    if (isReturned)
                    {
                        status = "Returned";
                    }
                    else
                    {
                        DateTime dueDate = reader.GetDateTime("due_date");
                        int daysLeft = (dueDate.Date - DateTime.Now.Date).Days;

                        status = daysLeft >= 0
                            ? $"Remaining {daysLeft} days"
                            : $"Overdue by {Math.Abs(daysLeft)} days";
                    }

                    table.Rows.Add(
                        reader["member_id"],
                        reader["name"],
                        reader["title"],
                        reader.GetDateTime("loan_date").ToShortDateString(),
                        status
                    );
                }


                dgvBorrowed.DataSource = table;
            }

            HighlightOverdue();
        }

        private void HighlightOverdue()
        {
            foreach (DataGridViewRow row in dgvBorrowed.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["Status"].Value == null) continue;

                string status = row.Cells["Status"].Value.ToString();

                if (status.Contains("Overdue"))
                {
                    row.Cells["Status"].Style.ForeColor = Color.Red;
                    row.Cells["Status"].Style.Font =
                        new Font(dgvBorrowed.Font, FontStyle.Bold);
                }
                else if (status == "Returned")
                {
                    row.Cells["Status"].Style.ForeColor = Color.Green;
                    row.Cells["Status"].Style.Font =
                        new Font(dgvBorrowed.Font, FontStyle.Italic);
                }
            }

        }

        private void lblBack_bookborrow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminMenuForm().Show();
            this.Close();
        }
    }
}
