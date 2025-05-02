using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WinFormsApp1
{
    public partial class BookLoanForm : Form
    {
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

                var db = Connection.GetDatabase();
                var collection = db.GetCollection<BsonDocument>("book_loans");

                var doc = new BsonDocument
        {
            { "book_id", bookId },
            { "user_id", userId },
            { "loan_period", loanPeriod },
            { "loan_date", loanDate }
        };

                collection.InsertOne(doc);

                MessageBox.Show("Book loan record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Menutup form BookLoanForm
                this.Close();

                // Membuka form Dashboard
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();
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

        private void BookLoanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
