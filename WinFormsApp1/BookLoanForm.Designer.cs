namespace WinFormsApp1
{
    partial class BookLoanForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblBookId;
        private Label lblUserId;
        private Label lblLoanPeriod;
        private Label lblLoanDate;
        private TextBox txtBookId;
        private TextBox txtUserId;
        private TextBox txtLoanPeriod;
        private DateTimePicker dtpLoanDate;
        private Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblBookId = new Label();
            lblUserId = new Label();
            lblLoanPeriod = new Label();
            lblLoanDate = new Label();
            txtBookId = new TextBox();
            txtUserId = new TextBox();
            txtLoanPeriod = new TextBox();
            dtpLoanDate = new DateTimePicker();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblBookId.Location = new Point(30, 30);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(70, 23);
            lblBookId.Text = "Book ID:";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(150, 30);
            txtBookId.Size = new Size(230, 27);
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserId.Location = new Point(30, 80);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(64, 23);
            lblUserId.Text = "User ID:";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(150, 80);
            txtUserId.Size = new Size(230, 27);
            // 
            // lblLoanPeriod
            // 
            lblLoanPeriod.AutoSize = true;
            lblLoanPeriod.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoanPeriod.Location = new Point(30, 130);
            lblLoanPeriod.Name = "lblLoanPeriod";
            lblLoanPeriod.Size = new Size(99, 23);
            lblLoanPeriod.Text = "Loan Period:";
            // 
            // txtLoanPeriod
            // 
            txtLoanPeriod.Location = new Point(150, 130);
            txtLoanPeriod.Size = new Size(230, 27);
            // 
            // lblLoanDate
            // 
            lblLoanDate.AutoSize = true;
            lblLoanDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoanDate.Location = new Point(30, 180);
            lblLoanDate.Name = "lblLoanDate";
            lblLoanDate.Size = new Size(89, 23);
            lblLoanDate.Text = "Loan Date:";
            // 
            // dtpLoanDate
            // 
            dtpLoanDate.Location = new Point(150, 180);
            dtpLoanDate.Size = new Size(230, 27);
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(150, 230);
            btnSubmit.Size = new Size(100, 40);
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += new EventHandler(btnSubmit_Click);
            // 
            // BookLoanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 320);
            Controls.Add(lblBookId);
            Controls.Add(txtBookId);
            Controls.Add(lblUserId);
            Controls.Add(txtUserId);
            Controls.Add(lblLoanPeriod);
            Controls.Add(txtLoanPeriod);
            Controls.Add(lblLoanDate);
            Controls.Add(dtpLoanDate);
            Controls.Add(btnSubmit);
            Name = "BookLoanForm";
            Text = "Book Loan";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
