using System;
using System.Windows.Forms;
using MongoDB.Driver;

namespace WinFormsApp1
{
    public partial class AllBook : Form
    {
        public AllBook()
        {
            InitializeComponent();
        }

        private void AllBook_Load(object sender, EventArgs e)
        {
            try
            {
                var db = Connection.GetDatabase();
                var collection = db.GetCollection<Book>("books");
                var bookList = collection.Find(_ => true).ToList();

                dataGridView1.DataSource = bookList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
