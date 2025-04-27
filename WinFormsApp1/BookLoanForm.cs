using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 
namespace WinFormsApp1
{
    public partial class BookLoanForm : Form
    {
        private string connectionString = "server=localhost;database=db_login;uid=root;pwd=;";

        public BookLoanForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string bookId = txtBookId.Text.Trim();
                string userId = txtUserId.Text.Trim();
                int loanPeriod = int.Parse(txtLoanPeriod.Text.Trim());
                DateTime loanDate = dtpLoanDate.Value;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO book_loans (book_id, user_id, loan_period, loan_date) " +
                                   "VALUES (@bookId, @userId, @loanPeriod, @loanDate)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@loanPeriod", loanPeriod);
                        cmd.Parameters.AddWithValue("@loanDate", loanDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book loan record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert the book loan record.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtBookId.Text = "";
            txtUserId.Text = "";
            txtLoanPeriod.Text = "";
            dtpLoanDate.Value = DateTime.Now;
        }
    }
}
