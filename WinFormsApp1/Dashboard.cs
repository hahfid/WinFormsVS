﻿using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookLoanForm loanForm = new BookLoanForm();
            loanForm.Show();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook addBookForm = new AddBook();
            addBookForm.ShowDialog(); // modal form
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnAllBook_Click(object sender, EventArgs e)
        {
            AllBook addBookForm = new AllBook();
            addBookForm.ShowDialog();
        }
    }
}
