namespace WinFormsApp1
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBookLoan;
        private System.Windows.Forms.Button btnBookReturn;
        private System.Windows.Forms.Button btnAllBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUsers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnLogout = new Button();
            btnBookLoan = new Button();
            btnBookReturn = new Button();
            btnAllBook = new Button();
            btnAddBook = new Button();
            btnUsers = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.MidnightBlue;
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(257, 37);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, User!";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Crimson;
            btnLogout.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(350, 320);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 40);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBookLoan
            // 
            btnBookLoan.Font = new Font("Arial", 12F);
            btnBookLoan.Location = new Point(30, 80);
            btnBookLoan.Name = "btnBookLoan";
            btnBookLoan.Size = new Size(180, 40);
            btnBookLoan.TabIndex = 1;
            btnBookLoan.Text = "Book Loan";
            btnBookLoan.UseVisualStyleBackColor = true;
            btnBookLoan.Click += button1_Click;
            // 
            // btnBookReturn
            // 
            btnBookReturn.Font = new Font("Arial", 12F);
            btnBookReturn.Location = new Point(30, 130);
            btnBookReturn.Name = "btnBookReturn";
            btnBookReturn.Size = new Size(180, 40);
            btnBookReturn.TabIndex = 2;
            btnBookReturn.Text = "Book Return";
            btnBookReturn.UseVisualStyleBackColor = true;
            // 
            // btnAllBook
            // 
            btnAllBook.Font = new Font("Arial", 12F);
            btnAllBook.Location = new Point(30, 180);
            btnAllBook.Name = "btnAllBook";
            btnAllBook.Size = new Size(180, 40);
            btnAllBook.TabIndex = 3;
            btnAllBook.Text = "All Books";
            btnAllBook.UseVisualStyleBackColor = true;
            btnAllBook.Click += btnAllBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Arial", 12F);
            btnAddBook.Location = new Point(30, 230);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(180, 40);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add Books";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Arial", 12F);
            btnUsers.Location = new Point(30, 280);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(180, 40);
            btnUsers.TabIndex = 5;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(500, 400);
            Controls.Add(lblWelcome);
            Controls.Add(btnBookLoan);
            Controls.Add(btnBookReturn);
            Controls.Add(btnAllBook);
            Controls.Add(btnAddBook);
            Controls.Add(btnUsers);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
    }
}
