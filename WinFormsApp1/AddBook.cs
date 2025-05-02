using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string name = nameBook.Text.Trim();
            string authorName = author.Text.Trim();
            string available = availability.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(authorName) || string.IsNullOrWhiteSpace(available))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            Book newBook = new Book
            {
                Name = name,
                Author = authorName,
                Availability = available
            };

            try
            {
                var db = Connection.GetDatabase();
                var collection = db.GetCollection<Book>("books");
                collection.InsertOne(newBook);

                MessageBox.Show("Book added successfully!");

                // Clear the fields
                nameBook.Text = "";
                author.Text = "";
                availability.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving book: " + ex.Message);
            }
        }

    }
}
