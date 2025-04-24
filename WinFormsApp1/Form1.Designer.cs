namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shopping; // pastikan gambar sudah disediakan
            pictureBox1.Location = new Point(105, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 50); // Sesuaikan ukuran gambar
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            // 
            // label4 (Judul - Admin Login)
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16F, FontStyle.Bold); // Mengubah ukuran font
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(100, 90); // Sesuaikan posisi
            label4.Name = "label4";
            label4.Size = new Size(138, 32);
            label4.TabIndex = 7;
            label4.Text = "Admin Login";

            // 
            // label2 (Username Label)
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(80, 170);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Username";

            // 
            // txtUsername (Textbox Username)
            // 
            txtUsername.Font = new Font("Arial", 12F);
            txtUsername.Location = new Point(85, 200);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 30);
            txtUsername.TabIndex = 5;

            // 
            // label3 (Password Label)
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(80, 240);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";

            // 
            // txtPassword (Textbox Password)
            // 
            txtPassword.Font = new Font("Arial", 12F);
            txtPassword.Location = new Point(85, 270);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(150, 30);
            txtPassword.TabIndex = 6;

            // 
            // btnLogin (Tombol Login)
            // 
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.BackColor = Color.MidnightBlue;
            btnLogin.Location = new Point(85, 320);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 450);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            BackColor = Color.LightGray;  // Set background color to light gray
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label4;
    }
}
