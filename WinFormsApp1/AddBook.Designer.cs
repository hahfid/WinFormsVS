namespace WinFormsApp1
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            author = new TextBox();
            availability = new TextBox();
            nameBook = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            submitbtn = new Button();
            SuspendLayout();
            // 
            // author
            // 
            author.Location = new Point(259, 90);
            author.Name = "author";
            author.Size = new Size(150, 31);
            author.TabIndex = 0;
            // 
            // availability
            // 
            availability.Location = new Point(464, 90);
            availability.Name = "availability";
            availability.Size = new Size(150, 31);
            availability.TabIndex = 1;
            // 
            // nameBook
            // 
            nameBook.Location = new Point(46, 90);
            nameBook.Name = "nameBook";
            nameBook.Size = new Size(150, 31);
            nameBook.TabIndex = 2;
            nameBook.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 26);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 26);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 4;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(517, 26);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 5;
            label3.Text = "Availability";
            // 
            // submitbtn
            // 
            submitbtn.Location = new Point(242, 200);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(112, 34);
            submitbtn.TabIndex = 6;
            submitbtn.Text = "Add Book";
            submitbtn.UseVisualStyleBackColor = true;
            submitbtn.Click += submitbtn_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameBook);
            Controls.Add(availability);
            Controls.Add(author);
            Name = "AddBook";
            Text = "AddBook";
            Load += AddBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox author;
        private TextBox availability;
        private TextBox nameBook;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button submitbtn;
    }
}