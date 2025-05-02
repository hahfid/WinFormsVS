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
            lblBookId.Font = new Font("Segoe UI", 10F);
            lblBookId.Location = new Point(38, 38);
            lblBookId.Margin = new Padding(4, 0, 4, 0);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(85, 28);
            lblBookId.TabIndex = 0;
            lblBookId.Text = "Book ID:";
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 10F);
            lblUserId.Location = new Point(38, 100);
            lblUserId.Margin = new Padding(4, 0, 4, 0);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(79, 28);
            lblUserId.TabIndex = 2;
            lblUserId.Text = "User ID:";
            // 
            // lblLoanPeriod
            // 
            lblLoanPeriod.AutoSize = true;
            lblLoanPeriod.Font = new Font("Segoe UI", 10F);
            lblLoanPeriod.Location = new Point(38, 162);
            lblLoanPeriod.Margin = new Padding(4, 0, 4, 0);
            lblLoanPeriod.Name = "lblLoanPeriod";
            lblLoanPeriod.Size = new Size(119, 28);
            lblLoanPeriod.TabIndex = 4;
            lblLoanPeriod.Text = "Loan Period:";
            // 
            // lblLoanDate
            // 
            lblLoanDate.AutoSize = true;
            lblLoanDate.Font = new Font("Segoe UI", 10F);
            lblLoanDate.Location = new Point(38, 225);
            lblLoanDate.Margin = new Padding(4, 0, 4, 0);
            lblLoanDate.Name = "lblLoanDate";
            lblLoanDate.Size = new Size(104, 28);
            lblLoanDate.TabIndex = 6;
            lblLoanDate.Text = "Loan Date:";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(188, 38);
            txtBookId.Margin = new Padding(4, 4, 4, 4);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(286, 31);
            txtBookId.TabIndex = 1;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(188, 100);
            txtUserId.Margin = new Padding(4, 4, 4, 4);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(286, 31);
            txtUserId.TabIndex = 3;
            // 
            // txtLoanPeriod
            // 
            txtLoanPeriod.Location = new Point(188, 162);
            txtLoanPeriod.Margin = new Padding(4, 4, 4, 4);
            txtLoanPeriod.Name = "txtLoanPeriod";
            txtLoanPeriod.Size = new Size(286, 31);
            txtLoanPeriod.TabIndex = 5;
            // 
            // dtpLoanDate
            // 
            dtpLoanDate.Location = new Point(188, 225);
            dtpLoanDate.Margin = new Padding(4, 4, 4, 4);
            dtpLoanDate.Name = "dtpLoanDate";
            dtpLoanDate.Size = new Size(286, 31);
            dtpLoanDate.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(188, 288);
            btnSubmit.Margin = new Padding(4, 4, 4, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(125, 50);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // BookLoanForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 400);
            Controls.Add(lblBookId);
            Controls.Add(txtBookId);
            Controls.Add(lblUserId);
            Controls.Add(txtUserId);
            Controls.Add(lblLoanPeriod);
            Controls.Add(txtLoanPeriod);
            Controls.Add(lblLoanDate);
            Controls.Add(dtpLoanDate);
            Controls.Add(btnSubmit);
            Margin = new Padding(4, 4, 4, 4);
            Name = "BookLoanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Loan";
            Load += BookLoanForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
