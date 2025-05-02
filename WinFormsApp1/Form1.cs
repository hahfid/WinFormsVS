using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            try
            {
                var db = Connection.GetDatabase();
                var collection = db.GetCollection<BsonDocument>("users");

                var filter = Builders<BsonDocument>.Filter.Eq("username", username) &
                             Builders<BsonDocument>.Filter.Eq("password", password); // Gunakan hash untuk keamanan nyata

                var user = collection.Find(filter).FirstOrDefault();

                return user != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
