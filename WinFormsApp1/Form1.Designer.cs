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
            pictureBox1.Image = Properties.Resources.shopping;
            pictureBox1.Location = new Point(110, 30); // sedikit menggeser untuk desktop
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75); // ukuran diperbesar
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F); // ukuran font diperbesar
            label2.Location = new Point(90, 180); // posisi diubah untuk penataan lebih baik
            label2.Name = "label2";
            label2.Size = new Size(145, 32); // ukuran diperbesar
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F); // ukuran font diperbesar
            label3.Location = new Point(90, 260); // posisi diubah untuk penataan lebih baik
            label3.Name = "label3";
            label3.Size = new Size(137, 32); // ukuran diperbesar
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MidnightBlue;
            btnLogin.Font = new Font("Arial", 14F, FontStyle.Bold); // ukuran font diperbesar
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(90, 340); // posisi diubah agar tidak terlalu mepet
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 45); // ukuran tombol lebih besar
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 14F); // ukuran font diperbesar
            txtUsername.Location = new Point(90, 220); // posisi disesuaikan
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(160, 35); // ukuran diperbesar
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 14F); // ukuran font diperbesar
            txtPassword.Location = new Point(90, 290); // posisi disesuaikan
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(160, 35); // ukuran diperbesar
            txtPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold); // ukuran font diperbesar
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(95, 110); // posisi disesuaikan
            label4.Name = "label4";
            label4.Size = new Size(230, 40); // ukuran diperbesar
            label4.TabIndex = 7;
            label4.Text = "Admin Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F); // disesuaikan dengan ukuran font baru
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(400, 500); // ukuran form diperbesar
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";

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
