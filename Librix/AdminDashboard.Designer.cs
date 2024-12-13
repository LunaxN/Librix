namespace Librix
{
    partial class AdminDashboard
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
            tabControl = new TabControl();
            t_dashboard = new TabPage();
            t_books = new TabPage();
            l_editBook = new Label();
            b_editBook = new Button();
            b_resetBooks = new Button();
            l_addBook = new Label();
            l_deleteBook = new Label();
            b_deleteBook = new Button();
            b_addBook = new Button();
            pb_searchBook = new PictureBox();
            tb_searchBook = new TextBox();
            dgv_books = new DataGridView();
            t_bookLoan = new TabPage();
            t_members = new TabPage();
            l_editMember = new Label();
            b_editMember = new Button();
            b_resetMembers = new Button();
            l_addMember = new Label();
            l_deleteMember = new Label();
            b_deleteMember = new Button();
            b_addMember = new Button();
            pb_searchMember = new PictureBox();
            tb_searchMember = new TextBox();
            dgv_members = new DataGridView();
            b_books = new Button();
            panel = new Panel();
            b_logout = new Button();
            l_members = new Label();
            b_dashboard = new Button();
            l_bookLoan = new Label();
            b_bookLoan = new Button();
            l_books = new Label();
            b_members = new Button();
            l_dashboard = new Label();
            tabControl.SuspendLayout();
            t_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_books).BeginInit();
            t_members.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_members).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(t_dashboard);
            tabControl.Controls.Add(t_books);
            tabControl.Controls.Add(t_bookLoan);
            tabControl.Controls.Add(t_members);
            tabControl.Location = new Point(0, 87);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1284, 620);
            tabControl.TabIndex = 0;
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
            t_books.Controls.Add(l_editBook);
            t_books.Controls.Add(b_editBook);
            t_books.Controls.Add(b_resetBooks);
            t_books.Controls.Add(l_addBook);
            t_books.Controls.Add(l_deleteBook);
            t_books.Controls.Add(b_deleteBook);
            t_books.Controls.Add(b_addBook);
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
            // l_editBook
            // 
            l_editBook.AutoSize = true;
            l_editBook.BackColor = SystemColors.ControlDarkDark;
            l_editBook.Font = new Font("Sitka Subheading", 10F);
            l_editBook.ForeColor = Color.White;
            l_editBook.Location = new Point(143, 43);
            l_editBook.Name = "l_editBook";
            l_editBook.Size = new Size(34, 20);
            l_editBook.TabIndex = 21;
            l_editBook.Text = "Edit";
            l_editBook.Visible = false;
            // 
            // b_editBook
            // 
            b_editBook.BackColor = Color.Transparent;
            b_editBook.FlatAppearance.BorderColor = Color.White;
            b_editBook.FlatStyle = FlatStyle.Flat;
            b_editBook.Font = new Font("Sitka Subheading", 10F);
            b_editBook.Image = icons.edit;
            b_editBook.Location = new Point(145, 11);
            b_editBook.Name = "b_editBook";
            b_editBook.Size = new Size(30, 30);
            b_editBook.TabIndex = 20;
            b_editBook.UseVisualStyleBackColor = false;
            b_editBook.Click += b_editBook_Click;
            b_editBook.MouseLeave += b_editBook_MouseLeave;
            b_editBook.MouseHover += b_editBook_MouseHover;
            // 
            // b_resetBooks
            // 
            b_resetBooks.BackColor = Color.FromArgb(255, 192, 192);
            b_resetBooks.FlatStyle = FlatStyle.Flat;
            b_resetBooks.Font = new Font("Sitka Subheading", 10F);
            b_resetBooks.Location = new Point(595, 8);
            b_resetBooks.Name = "b_resetBooks";
            b_resetBooks.Size = new Size(116, 35);
            b_resetBooks.TabIndex = 19;
            b_resetBooks.Text = "Show Books";
            b_resetBooks.UseVisualStyleBackColor = false;
            b_resetBooks.Visible = false;
            b_resetBooks.Click += b_resetBooks_Click;
            // 
            // l_addBook
            // 
            l_addBook.AutoSize = true;
            l_addBook.BackColor = SystemColors.ControlDarkDark;
            l_addBook.Font = new Font("Sitka Subheading", 10F);
            l_addBook.ForeColor = Color.White;
            l_addBook.Location = new Point(21, 43);
            l_addBook.Name = "l_addBook";
            l_addBook.Size = new Size(34, 20);
            l_addBook.TabIndex = 18;
            l_addBook.Text = "Add";
            l_addBook.Visible = false;
            // 
            // l_deleteBook
            // 
            l_deleteBook.AutoSize = true;
            l_deleteBook.BackColor = SystemColors.ControlDarkDark;
            l_deleteBook.Font = new Font("Sitka Subheading", 10F);
            l_deleteBook.ForeColor = Color.White;
            l_deleteBook.Location = new Point(75, 43);
            l_deleteBook.Name = "l_deleteBook";
            l_deleteBook.Size = new Size(48, 20);
            l_deleteBook.TabIndex = 17;
            l_deleteBook.Text = "Delete";
            l_deleteBook.Visible = false;
            // 
            // b_deleteBook
            // 
            b_deleteBook.BackColor = Color.Transparent;
            b_deleteBook.FlatAppearance.BorderColor = Color.White;
            b_deleteBook.FlatStyle = FlatStyle.Flat;
            b_deleteBook.Font = new Font("Sitka Subheading", 10F);
            b_deleteBook.Image = icons.delete;
            b_deleteBook.Location = new Point(84, 11);
            b_deleteBook.Name = "b_deleteBook";
            b_deleteBook.Size = new Size(30, 30);
            b_deleteBook.TabIndex = 16;
            b_deleteBook.UseVisualStyleBackColor = false;
            b_deleteBook.Click += b_deleteBook_Click;
            b_deleteBook.MouseLeave += b_deleteBook_MouseLeave;
            b_deleteBook.MouseHover += b_deleteBook_MouseHover;
            // 
            // b_addBook
            // 
            b_addBook.BackColor = Color.Transparent;
            b_addBook.FlatAppearance.BorderColor = Color.White;
            b_addBook.FlatStyle = FlatStyle.Flat;
            b_addBook.Font = new Font("Sitka Subheading", 10F);
            b_addBook.Image = icons.add;
            b_addBook.Location = new Point(23, 11);
            b_addBook.Name = "b_addBook";
            b_addBook.Size = new Size(30, 30);
            b_addBook.TabIndex = 15;
            b_addBook.UseVisualStyleBackColor = false;
            b_addBook.Click += b_addBook_Click;
            b_addBook.MouseLeave += b_addBook_MouseLeave;
            b_addBook.MouseHover += b_addBook_MouseHover;
            // 
            // pb_searchBook
            // 
            pb_searchBook.Image = icons.search;
            pb_searchBook.Location = new Point(546, 15);
            pb_searchBook.Name = "pb_searchBook";
            pb_searchBook.Size = new Size(23, 23);
            pb_searchBook.TabIndex = 14;
            pb_searchBook.TabStop = false;
            // 
            // tb_searchBook
            // 
            tb_searchBook.Font = new Font("Segoe UI", 10F);
            tb_searchBook.ForeColor = Color.Gray;
            tb_searchBook.Location = new Point(205, 14);
            tb_searchBook.Name = "tb_searchBook";
            tb_searchBook.Size = new Size(365, 25);
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
            t_bookLoan.Location = new Point(4, 24);
            t_bookLoan.Name = "t_bookLoan";
            t_bookLoan.Padding = new Padding(3);
            t_bookLoan.Size = new Size(1276, 592);
            t_bookLoan.TabIndex = 3;
            t_bookLoan.Text = "Book Loan";
            t_bookLoan.UseVisualStyleBackColor = true;
            // 
            // t_members
            // 
            t_members.Controls.Add(l_editMember);
            t_members.Controls.Add(b_editMember);
            t_members.Controls.Add(b_resetMembers);
            t_members.Controls.Add(l_addMember);
            t_members.Controls.Add(l_deleteMember);
            t_members.Controls.Add(b_deleteMember);
            t_members.Controls.Add(b_addMember);
            t_members.Controls.Add(pb_searchMember);
            t_members.Controls.Add(tb_searchMember);
            t_members.Controls.Add(dgv_members);
            t_members.Location = new Point(4, 24);
            t_members.Name = "t_members";
            t_members.Padding = new Padding(3);
            t_members.Size = new Size(1276, 592);
            t_members.TabIndex = 4;
            t_members.Text = "Members";
            t_members.UseVisualStyleBackColor = true;
            // 
            // l_editMember
            // 
            l_editMember.AutoSize = true;
            l_editMember.BackColor = SystemColors.ControlDarkDark;
            l_editMember.Font = new Font("Sitka Subheading", 10F);
            l_editMember.ForeColor = Color.White;
            l_editMember.Location = new Point(143, 43);
            l_editMember.Name = "l_editMember";
            l_editMember.Size = new Size(34, 20);
            l_editMember.TabIndex = 11;
            l_editMember.Text = "Edit";
            l_editMember.Visible = false;
            // 
            // b_editMember
            // 
            b_editMember.BackColor = Color.Transparent;
            b_editMember.FlatAppearance.BorderColor = Color.White;
            b_editMember.FlatStyle = FlatStyle.Flat;
            b_editMember.Font = new Font("Sitka Subheading", 10F);
            b_editMember.Image = icons.edit;
            b_editMember.Location = new Point(145, 11);
            b_editMember.Name = "b_editMember";
            b_editMember.Size = new Size(30, 30);
            b_editMember.TabIndex = 10;
            b_editMember.UseVisualStyleBackColor = false;
            b_editMember.Click += b_editMember_Click;
            b_editMember.MouseLeave += b_editMember_MouseLeave;
            b_editMember.MouseHover += b_editMember_MouseHover;
            // 
            // b_resetMembers
            // 
            b_resetMembers.BackColor = Color.FromArgb(255, 192, 192);
            b_resetMembers.FlatStyle = FlatStyle.Flat;
            b_resetMembers.Font = new Font("Sitka Subheading", 10F);
            b_resetMembers.Location = new Point(595, 8);
            b_resetMembers.Name = "b_resetMembers";
            b_resetMembers.Size = new Size(116, 35);
            b_resetMembers.TabIndex = 9;
            b_resetMembers.Text = "Show Members";
            b_resetMembers.UseVisualStyleBackColor = false;
            b_resetMembers.Visible = false;
            b_resetMembers.Click += b_resetMembers_Click;
            // 
            // l_addMember
            // 
            l_addMember.AutoSize = true;
            l_addMember.BackColor = SystemColors.ControlDarkDark;
            l_addMember.Font = new Font("Sitka Subheading", 10F);
            l_addMember.ForeColor = Color.White;
            l_addMember.Location = new Point(21, 43);
            l_addMember.Name = "l_addMember";
            l_addMember.Size = new Size(34, 20);
            l_addMember.TabIndex = 8;
            l_addMember.Text = "Add";
            l_addMember.Visible = false;
            // 
            // l_deleteMember
            // 
            l_deleteMember.AutoSize = true;
            l_deleteMember.BackColor = SystemColors.ControlDarkDark;
            l_deleteMember.Font = new Font("Sitka Subheading", 10F);
            l_deleteMember.ForeColor = Color.White;
            l_deleteMember.Location = new Point(75, 43);
            l_deleteMember.Name = "l_deleteMember";
            l_deleteMember.Size = new Size(48, 20);
            l_deleteMember.TabIndex = 7;
            l_deleteMember.Text = "Delete";
            l_deleteMember.Visible = false;
            // 
            // b_deleteMember
            // 
            b_deleteMember.BackColor = Color.Transparent;
            b_deleteMember.FlatAppearance.BorderColor = Color.White;
            b_deleteMember.FlatStyle = FlatStyle.Flat;
            b_deleteMember.Font = new Font("Sitka Subheading", 10F);
            b_deleteMember.Image = icons.delete;
            b_deleteMember.Location = new Point(84, 11);
            b_deleteMember.Name = "b_deleteMember";
            b_deleteMember.Size = new Size(30, 30);
            b_deleteMember.TabIndex = 5;
            b_deleteMember.UseVisualStyleBackColor = false;
            b_deleteMember.Click += b_deleteMember_Click;
            b_deleteMember.MouseLeave += b_deleteMember_MouseLeave;
            b_deleteMember.MouseHover += b_deleteMember_MouseHover;
            // 
            // b_addMember
            // 
            b_addMember.BackColor = Color.Transparent;
            b_addMember.FlatAppearance.BorderColor = Color.White;
            b_addMember.FlatStyle = FlatStyle.Flat;
            b_addMember.Font = new Font("Sitka Subheading", 10F);
            b_addMember.Image = icons.add;
            b_addMember.Location = new Point(23, 11);
            b_addMember.Name = "b_addMember";
            b_addMember.Size = new Size(30, 30);
            b_addMember.TabIndex = 4;
            b_addMember.UseVisualStyleBackColor = false;
            b_addMember.Click += b_addMember_Click;
            b_addMember.MouseLeave += b_addMember_MouseLeave;
            b_addMember.MouseHover += b_addMember_MouseHover;
            // 
            // pb_searchMember
            // 
            pb_searchMember.Image = icons.search;
            pb_searchMember.Location = new Point(546, 15);
            pb_searchMember.Name = "pb_searchMember";
            pb_searchMember.Size = new Size(23, 23);
            pb_searchMember.TabIndex = 2;
            pb_searchMember.TabStop = false;
            // 
            // tb_searchMember
            // 
            tb_searchMember.Font = new Font("Segoe UI", 10F);
            tb_searchMember.ForeColor = Color.Gray;
            tb_searchMember.Location = new Point(205, 14);
            tb_searchMember.Name = "tb_searchMember";
            tb_searchMember.Size = new Size(365, 25);
            tb_searchMember.TabIndex = 1;
            tb_searchMember.Text = "Search for a member...";
            tb_searchMember.Click += tb_searchMember_Click;
            tb_searchMember.KeyDown += tb_searchMember_KeyDown;
            // 
            // dgv_members
            // 
            dgv_members.BackgroundColor = Color.White;
            dgv_members.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_members.Location = new Point(0, 51);
            dgv_members.Name = "dgv_members";
            dgv_members.Size = new Size(1276, 544);
            dgv_members.TabIndex = 0;
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
            // panel
            // 
            panel.BackColor = Color.White;
            panel.Controls.Add(b_logout);
            panel.Controls.Add(l_members);
            panel.Controls.Add(b_dashboard);
            panel.Controls.Add(l_bookLoan);
            panel.Controls.Add(b_bookLoan);
            panel.Controls.Add(l_books);
            panel.Controls.Add(b_members);
            panel.Controls.Add(l_dashboard);
            panel.Controls.Add(b_books);
            panel.Location = new Point(1, 1);
            panel.Name = "panel";
            panel.Size = new Size(1279, 101);
            panel.TabIndex = 1;
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
            // l_members
            // 
            l_members.AutoSize = true;
            l_members.Font = new Font("Sitka Subheading", 10F);
            l_members.Location = new Point(312, 70);
            l_members.Name = "l_members";
            l_members.Size = new Size(67, 20);
            l_members.TabIndex = 6;
            l_members.Text = "Members";
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
            // l_bookLoan
            // 
            l_bookLoan.AutoSize = true;
            l_bookLoan.Font = new Font("Sitka Subheading", 10F);
            l_bookLoan.Location = new Point(215, 70);
            l_bookLoan.Name = "l_bookLoan";
            l_bookLoan.Size = new Size(72, 20);
            l_bookLoan.TabIndex = 5;
            l_bookLoan.Text = "Book Loan";
            // 
            // b_bookLoan
            // 
            b_bookLoan.FlatAppearance.BorderColor = Color.White;
            b_bookLoan.FlatStyle = FlatStyle.Flat;
            b_bookLoan.Image = icons.book_loan;
            b_bookLoan.Location = new Point(223, 14);
            b_bookLoan.Name = "b_bookLoan";
            b_bookLoan.Size = new Size(55, 55);
            b_bookLoan.TabIndex = 9;
            b_bookLoan.UseVisualStyleBackColor = false;
            b_bookLoan.Click += b_bookLoan_Click;
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
            // b_members
            // 
            b_members.FlatAppearance.BorderColor = Color.White;
            b_members.FlatStyle = FlatStyle.Flat;
            b_members.Image = icons.members;
            b_members.Location = new Point(315, 14);
            b_members.Name = "b_members";
            b_members.Size = new Size(55, 55);
            b_members.TabIndex = 7;
            b_members.UseVisualStyleBackColor = false;
            b_members.Click += b_members_Click;
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
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1282, 706);
            Controls.Add(panel);
            Controls.Add(tabControl);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            tabControl.ResumeLayout(false);
            t_books.ResumeLayout(false);
            t_books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_books).EndInit();
            t_members.ResumeLayout(false);
            t_members.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_members).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage t_dashboard;
        private TabPage t_books;
        private TabPage t_bookLoan;
        private Panel panel;
        private Button b_books;
        private Label l_members;
        private Label l_bookLoan;
        private Label l_books;
        private Label l_dashboard;
        private Button b_dashboard;
        private Button b_bookLoan;
        private Button b_members;
        private TabPage t_members;
        private Button b_logout;
        private DataGridView dgv_members;
        private TextBox tb_searchMember;
        private PictureBox pb_searchMember;
        private Button b_addMember;
        private Button b_deleteMember;
        private Label l_addMember;
        private Label l_deleteMember;
        private Button b_resetMembers;
        private Button b_editMember;
        private Label l_editMember;
        private Label l_editBook;
        private Button b_editBook;
        private Button b_resetBooks;
        private Label l_addBook;
        private Label l_deleteBook;
        private Button b_deleteBook;
        private Button b_addBook;
        private PictureBox pb_searchBook;
        private TextBox tb_searchBook;
        private DataGridView dgv_books;
    }
}