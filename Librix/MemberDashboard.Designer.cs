namespace Librix
{
    partial class MemberDashboard
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
            panel = new Panel();
            b_logout = new Button();
            b_dashboard = new Button();
            l_reservedBooks = new Label();
            b_reservedBooks = new Button();
            l_books = new Label();
            l_dashboard = new Label();
            b_books = new Button();
            tabControl = new TabControl();
            t_dashboard = new TabPage();
            t_books = new TabPage();
            b_reserve = new Button();
            b_resetBooks = new Button();
            pb_searchBook = new PictureBox();
            tb_searchBook = new TextBox();
            dgv_books = new DataGridView();
            t_bookLoan = new TabPage();
            dgv_reserved = new DataGridView();
            b_unreserve = new Button();
            panel.SuspendLayout();
            tabControl.SuspendLayout();
            t_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_books).BeginInit();
            t_bookLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_reserved).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.Controls.Add(b_logout);
            panel.Controls.Add(b_dashboard);
            panel.Controls.Add(l_reservedBooks);
            panel.Controls.Add(b_reservedBooks);
            panel.Controls.Add(l_books);
            panel.Controls.Add(l_dashboard);
            panel.Controls.Add(b_books);
            panel.Location = new Point(1, 1);
            panel.Name = "panel";
            panel.Size = new Size(1279, 101);
            panel.TabIndex = 3;
            // 
            // b_logout
            // 
            b_logout.BackColor = Color.Transparent;
            b_logout.FlatAppearance.BorderColor = Color.White;
            b_logout.FlatStyle = FlatStyle.Flat;
            b_logout.Font = new Font("Sitka Subheading", 10F);
            b_logout.Image = icons.logout;
            b_logout.ImageAlign = ContentAlignment.MiddleRight;
            b_logout.Location = new Point(1189, 6);
            b_logout.Name = "b_logout";
            b_logout.Size = new Size(84, 32);
            b_logout.TabIndex = 2;
            b_logout.Text = "Logout";
            b_logout.TextAlign = ContentAlignment.MiddleLeft;
            b_logout.UseVisualStyleBackColor = false;
            b_logout.Click += b_logout_Click;
            // 
            // b_dashboard
            // 
            b_dashboard.FlatAppearance.BorderColor = Color.White;
            b_dashboard.FlatStyle = FlatStyle.Flat;
            b_dashboard.Image = icons.dashboard;
            b_dashboard.Location = new Point(34, 14);
            b_dashboard.Name = "b_dashboard";
            b_dashboard.Size = new Size(55, 55);
            b_dashboard.TabIndex = 8;
            b_dashboard.UseVisualStyleBackColor = false;
            b_dashboard.Click += b_dashboard_Click;
            // 
            // l_reservedBooks
            // 
            l_reservedBooks.AutoSize = true;
            l_reservedBooks.Font = new Font("Sitka Subheading", 10F);
            l_reservedBooks.Location = new Point(206, 70);
            l_reservedBooks.Name = "l_reservedBooks";
            l_reservedBooks.Size = new Size(105, 20);
            l_reservedBooks.TabIndex = 5;
            l_reservedBooks.Text = "Reserved Books";
            // 
            // b_reservedBooks
            // 
            b_reservedBooks.FlatAppearance.BorderColor = Color.White;
            b_reservedBooks.FlatStyle = FlatStyle.Flat;
            b_reservedBooks.Image = icons.book_loan;
            b_reservedBooks.Location = new Point(223, 14);
            b_reservedBooks.Name = "b_reservedBooks";
            b_reservedBooks.Size = new Size(55, 55);
            b_reservedBooks.TabIndex = 9;
            b_reservedBooks.UseVisualStyleBackColor = false;
            b_reservedBooks.Click += b_reservedBooks_Click;
            // 
            // l_books
            // 
            l_books.AutoSize = true;
            l_books.Font = new Font("Sitka Subheading", 10F);
            l_books.Location = new Point(138, 70);
            l_books.Name = "l_books";
            l_books.Size = new Size(44, 20);
            l_books.TabIndex = 4;
            l_books.Text = "Books";
            // 
            // l_dashboard
            // 
            l_dashboard.AutoSize = true;
            l_dashboard.Font = new Font("Sitka Subheading", 10F);
            l_dashboard.Location = new Point(26, 70);
            l_dashboard.Name = "l_dashboard";
            l_dashboard.Size = new Size(75, 20);
            l_dashboard.TabIndex = 2;
            l_dashboard.Text = "Dashboard";
            // 
            // b_books
            // 
            b_books.FlatAppearance.BorderColor = Color.White;
            b_books.FlatStyle = FlatStyle.Flat;
            b_books.Image = icons.books;
            b_books.Location = new Point(131, 14);
            b_books.Name = "b_books";
            b_books.Size = new Size(55, 55);
            b_books.TabIndex = 0;
            b_books.UseVisualStyleBackColor = false;
            b_books.Click += b_books_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(t_dashboard);
            tabControl.Controls.Add(t_books);
            tabControl.Controls.Add(t_bookLoan);
            tabControl.Location = new Point(0, 87);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1284, 620);
            tabControl.TabIndex = 2;
            // 
            // t_dashboard
            // 
            t_dashboard.Location = new Point(4, 24);
            t_dashboard.Name = "t_dashboard";
            t_dashboard.Padding = new Padding(3);
            t_dashboard.Size = new Size(1276, 592);
            t_dashboard.TabIndex = 0;
            t_dashboard.Text = "Dashborad";
            t_dashboard.UseVisualStyleBackColor = true;
            // 
            // t_books
            // 
            t_books.Controls.Add(b_reserve);
            t_books.Controls.Add(b_resetBooks);
            t_books.Controls.Add(pb_searchBook);
            t_books.Controls.Add(tb_searchBook);
            t_books.Controls.Add(dgv_books);
            t_books.Location = new Point(4, 24);
            t_books.Name = "t_books";
            t_books.Padding = new Padding(3);
            t_books.Size = new Size(1276, 592);
            t_books.TabIndex = 1;
            t_books.Text = "Books";
            t_books.UseVisualStyleBackColor = true;
            // 
            // b_reserve
            // 
            b_reserve.Location = new Point(668, 8);
            b_reserve.Name = "b_reserve";
            b_reserve.Size = new Size(75, 37);
            b_reserve.TabIndex = 20;
            b_reserve.Text = "Reserve";
            b_reserve.UseVisualStyleBackColor = true;
            b_reserve.Click += b_reserve_Click;
            // 
            // b_resetBooks
            // 
            b_resetBooks.BackColor = Color.FromArgb(255, 192, 192);
            b_resetBooks.FlatStyle = FlatStyle.Flat;
            b_resetBooks.Font = new Font("Sitka Subheading", 10F);
            b_resetBooks.Location = new Point(529, 8);
            b_resetBooks.Name = "b_resetBooks";
            b_resetBooks.Size = new Size(116, 35);
            b_resetBooks.TabIndex = 19;
            b_resetBooks.Text = "Show Books";
            b_resetBooks.UseVisualStyleBackColor = false;
            b_resetBooks.Visible = false;
            b_resetBooks.Click += b_resetBooks_Click;
            // 
            // pb_searchBook
            // 
            pb_searchBook.Image = icons.search;
            pb_searchBook.Location = new Point(472, 15);
            pb_searchBook.Name = "pb_searchBook";
            pb_searchBook.Size = new Size(23, 23);
            pb_searchBook.TabIndex = 14;
            pb_searchBook.TabStop = false;
            // 
            // tb_searchBook
            // 
            tb_searchBook.Font = new Font("Segoe UI", 10F);
            tb_searchBook.ForeColor = Color.Gray;
            tb_searchBook.Location = new Point(23, 14);
            tb_searchBook.Name = "tb_searchBook";
            tb_searchBook.Size = new Size(473, 25);
            tb_searchBook.TabIndex = 13;
            tb_searchBook.Text = "Search for a book...";
            tb_searchBook.Click += tb_searchBook_Click;
            tb_searchBook.KeyDown += tb_searchBook_KeyDown;
            // 
            // dgv_books
            // 
            dgv_books.AllowUserToAddRows = false;
            dgv_books.AllowUserToDeleteRows = false;
            dgv_books.BackgroundColor = Color.White;
            dgv_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_books.Location = new Point(0, 51);
            dgv_books.Name = "dgv_books";
            dgv_books.ReadOnly = true;
            dgv_books.Size = new Size(1276, 544);
            dgv_books.TabIndex = 12;
            // 
            // t_bookLoan
            // 
            t_bookLoan.Controls.Add(b_unreserve);
            t_bookLoan.Controls.Add(dgv_reserved);
            t_bookLoan.Location = new Point(4, 24);
            t_bookLoan.Name = "t_bookLoan";
            t_bookLoan.Padding = new Padding(3);
            t_bookLoan.Size = new Size(1276, 592);
            t_bookLoan.TabIndex = 3;
            t_bookLoan.Text = "Reserve Book";
            t_bookLoan.UseVisualStyleBackColor = true;
            t_bookLoan.Click += b_reservedBooks_Click;
            // 
            // dgv_reserved
            // 
            dgv_reserved.AllowUserToAddRows = false;
            dgv_reserved.AllowUserToDeleteRows = false;
            dgv_reserved.BackgroundColor = Color.White;
            dgv_reserved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_reserved.Location = new Point(0, 48);
            dgv_reserved.Name = "dgv_reserved";
            dgv_reserved.ReadOnly = true;
            dgv_reserved.Size = new Size(1276, 544);
            dgv_reserved.TabIndex = 13;
            // 
            // b_unreserve
            // 
            b_unreserve.Location = new Point(438, 15);
            b_unreserve.Name = "b_unreserve";
            b_unreserve.Size = new Size(75, 23);
            b_unreserve.TabIndex = 14;
            b_unreserve.Text = "Remove";
            b_unreserve.UseVisualStyleBackColor = true;
            b_unreserve.Click += b_unreserve_Click;
            // 
            // MemberDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 706);
            Controls.Add(panel);
            Controls.Add(tabControl);
            Name = "MemberDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Dashboard";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            tabControl.ResumeLayout(false);
            t_books.ResumeLayout(false);
            t_books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_books).EndInit();
            t_bookLoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_reserved).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Button b_logout;
        private Button b_dashboard;
        private Label l_reservedBooks;
        private Button b_reservedBooks;
        private Label l_books;
        private Label l_dashboard;
        private Button b_books;
        private TabControl tabControl;
        private TabPage t_dashboard;
        private TabPage t_books;
        private PictureBox pb_searchBook;
        private TextBox tb_searchBook;
        private DataGridView dgv_books;
        private TabPage t_bookLoan;
        private Button b_resetBooks;
        private Button b_reserve;
        private DataGridView dgv_reserved;
        private Button b_unreserve;
    }
}