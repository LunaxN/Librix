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
            l_borrowed = new Label();
            b_borrowed = new Button();
            b_logout = new Button();
            b_dashboard = new Button();
            l_reserved = new Label();
            b_reserved = new Button();
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
            t_reserved = new TabPage();
            b_resetReserved = new Button();
            pb_searchReserve = new PictureBox();
            tb_searchReserve = new TextBox();
            b_unreserve = new Button();
            dgv_reserved = new DataGridView();
            t_borrowed = new TabPage();
            b_renew = new Button();
            b_resetBorrowed = new Button();
            pb_searchBorrow = new PictureBox();
            tb_searchBorrow = new TextBox();
            dgv_borrowed = new DataGridView();
            panel.SuspendLayout();
            tabControl.SuspendLayout();
            t_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_books).BeginInit();
            t_reserved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchReserve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_reserved).BeginInit();
            t_borrowed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBorrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_borrowed).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.Controls.Add(l_borrowed);
            panel.Controls.Add(b_borrowed);
            panel.Controls.Add(b_logout);
            panel.Controls.Add(b_dashboard);
            panel.Controls.Add(l_reserved);
            panel.Controls.Add(b_reserved);
            panel.Controls.Add(l_books);
            panel.Controls.Add(l_dashboard);
            panel.Controls.Add(b_books);
            panel.Location = new Point(1, 1);
            panel.Name = "panel";
            panel.Size = new Size(1279, 101);
            panel.TabIndex = 3;
            // 
            // l_borrowed
            // 
            l_borrowed.AutoSize = true;
            l_borrowed.Font = new Font("Sitka Subheading", 10F);
            l_borrowed.Location = new Point(318, 70);
            l_borrowed.Name = "l_borrowed";
            l_borrowed.Size = new Size(108, 20);
            l_borrowed.TabIndex = 10;
            l_borrowed.Text = "Borrowed Books";
            // 
            // b_borrowed
            // 
            b_borrowed.FlatAppearance.BorderColor = Color.White;
            b_borrowed.FlatStyle = FlatStyle.Flat;
            b_borrowed.Image = icons.borrow;
            b_borrowed.Location = new Point(344, 16);
            b_borrowed.Name = "b_borrowed";
            b_borrowed.Size = new Size(55, 55);
            b_borrowed.TabIndex = 11;
            b_borrowed.UseVisualStyleBackColor = false;
            b_borrowed.Click += b_borrowed_Click;
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
            // l_reserved
            // 
            l_reserved.AutoSize = true;
            l_reserved.Font = new Font("Sitka Subheading", 10F);
            l_reserved.Location = new Point(206, 70);
            l_reserved.Name = "l_reserved";
            l_reserved.Size = new Size(105, 20);
            l_reserved.TabIndex = 5;
            l_reserved.Text = "Reserved Books";
            // 
            // b_reserved
            // 
            b_reserved.FlatAppearance.BorderColor = Color.White;
            b_reserved.FlatStyle = FlatStyle.Flat;
            b_reserved.Image = icons.reserve;
            b_reserved.Location = new Point(229, 15);
            b_reserved.Name = "b_reserved";
            b_reserved.Size = new Size(51, 53);
            b_reserved.TabIndex = 9;
            b_reserved.UseVisualStyleBackColor = false;
            b_reserved.Click += b_reserved_Click;
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
            tabControl.Controls.Add(t_reserved);
            tabControl.Controls.Add(t_borrowed);
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
            b_reserve.BackColor = Color.LightSkyBlue;
            b_reserve.FlatStyle = FlatStyle.Flat;
            b_reserve.Font = new Font("Sitka Subheading", 10F);
            b_reserve.Location = new Point(529, 8);
            b_reserve.Name = "b_reserve";
            b_reserve.Size = new Size(75, 35);
            b_reserve.TabIndex = 20;
            b_reserve.Text = "Reserve";
            b_reserve.UseVisualStyleBackColor = false;
            b_reserve.Click += b_reserve_Click;
            // 
            // b_resetBooks
            // 
            b_resetBooks.BackColor = Color.FromArgb(255, 192, 192);
            b_resetBooks.FlatStyle = FlatStyle.Flat;
            b_resetBooks.Font = new Font("Sitka Subheading", 10F);
            b_resetBooks.Location = new Point(628, 8);
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
            // t_reserved
            // 
            t_reserved.Controls.Add(b_resetReserved);
            t_reserved.Controls.Add(pb_searchReserve);
            t_reserved.Controls.Add(tb_searchReserve);
            t_reserved.Controls.Add(b_unreserve);
            t_reserved.Controls.Add(dgv_reserved);
            t_reserved.Location = new Point(4, 24);
            t_reserved.Name = "t_reserved";
            t_reserved.Padding = new Padding(3);
            t_reserved.Size = new Size(1276, 592);
            t_reserved.TabIndex = 3;
            t_reserved.Text = "Reserved";
            t_reserved.UseVisualStyleBackColor = true;
            t_reserved.Click += b_reserved_Click;
            // 
            // b_resetReserved
            // 
            b_resetReserved.BackColor = Color.FromArgb(255, 192, 192);
            b_resetReserved.FlatStyle = FlatStyle.Flat;
            b_resetReserved.Font = new Font("Sitka Subheading", 10F);
            b_resetReserved.Location = new Point(628, 8);
            b_resetReserved.Name = "b_resetReserved";
            b_resetReserved.Size = new Size(116, 35);
            b_resetReserved.TabIndex = 25;
            b_resetReserved.Text = "Show Reserves";
            b_resetReserved.UseVisualStyleBackColor = false;
            b_resetReserved.Visible = false;
            b_resetReserved.Click += b_resetReserved_Click;
            // 
            // pb_searchReserve
            // 
            pb_searchReserve.Image = icons.search;
            pb_searchReserve.Location = new Point(472, 15);
            pb_searchReserve.Name = "pb_searchReserve";
            pb_searchReserve.Size = new Size(23, 23);
            pb_searchReserve.TabIndex = 24;
            pb_searchReserve.TabStop = false;
            // 
            // tb_searchReserve
            // 
            tb_searchReserve.Font = new Font("Segoe UI", 10F);
            tb_searchReserve.ForeColor = Color.Gray;
            tb_searchReserve.Location = new Point(23, 14);
            tb_searchReserve.Name = "tb_searchReserve";
            tb_searchReserve.Size = new Size(473, 25);
            tb_searchReserve.TabIndex = 23;
            tb_searchReserve.Text = "Search for a reserved book...";
            tb_searchReserve.Click += tb_searchReserve_Click;
            tb_searchReserve.KeyDown += tb_searchReserve_KeyDown;
            // 
            // b_unreserve
            // 
            b_unreserve.BackColor = Color.LightSkyBlue;
            b_unreserve.FlatStyle = FlatStyle.Flat;
            b_unreserve.Font = new Font("Sitka Subheading", 10F);
            b_unreserve.Location = new Point(529, 8);
            b_unreserve.Name = "b_unreserve";
            b_unreserve.Size = new Size(75, 35);
            b_unreserve.TabIndex = 14;
            b_unreserve.Text = "Remove";
            b_unreserve.UseVisualStyleBackColor = false;
            b_unreserve.Click += b_unreserve_Click;
            // 
            // dgv_reserved
            // 
            dgv_reserved.AllowUserToAddRows = false;
            dgv_reserved.AllowUserToDeleteRows = false;
            dgv_reserved.BackgroundColor = Color.White;
            dgv_reserved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_reserved.Location = new Point(0, 51);
            dgv_reserved.Name = "dgv_reserved";
            dgv_reserved.ReadOnly = true;
            dgv_reserved.Size = new Size(1276, 544);
            dgv_reserved.TabIndex = 13;
            // 
            // t_borrowed
            // 
            t_borrowed.Controls.Add(b_renew);
            t_borrowed.Controls.Add(b_resetBorrowed);
            t_borrowed.Controls.Add(pb_searchBorrow);
            t_borrowed.Controls.Add(tb_searchBorrow);
            t_borrowed.Controls.Add(dgv_borrowed);
            t_borrowed.Location = new Point(4, 24);
            t_borrowed.Name = "t_borrowed";
            t_borrowed.Padding = new Padding(3);
            t_borrowed.Size = new Size(1276, 592);
            t_borrowed.TabIndex = 4;
            t_borrowed.Text = "tabPage1";
            t_borrowed.UseVisualStyleBackColor = true;
            // 
            // b_renew
            // 
            b_renew.BackColor = Color.LightSkyBlue;
            b_renew.FlatStyle = FlatStyle.Flat;
            b_renew.Font = new Font("Sitka Subheading", 10F);
            b_renew.Location = new Point(529, 8);
            b_renew.Name = "b_renew";
            b_renew.Size = new Size(75, 35);
            b_renew.TabIndex = 27;
            b_renew.Text = "Renew";
            b_renew.UseVisualStyleBackColor = false;
            b_renew.Click += b_renew_Click;
            // 
            // b_resetBorrowed
            // 
            b_resetBorrowed.BackColor = Color.FromArgb(255, 192, 192);
            b_resetBorrowed.FlatStyle = FlatStyle.Flat;
            b_resetBorrowed.Font = new Font("Sitka Subheading", 10F);
            b_resetBorrowed.Location = new Point(628, 8);
            b_resetBorrowed.Name = "b_resetBorrowed";
            b_resetBorrowed.Size = new Size(116, 35);
            b_resetBorrowed.TabIndex = 26;
            b_resetBorrowed.Text = "Show Borrows";
            b_resetBorrowed.UseVisualStyleBackColor = false;
            b_resetBorrowed.Visible = false;
            b_resetBorrowed.Click += b_resetBorrowed_Click;
            // 
            // pb_searchBorrow
            // 
            pb_searchBorrow.Image = icons.search;
            pb_searchBorrow.Location = new Point(472, 15);
            pb_searchBorrow.Name = "pb_searchBorrow";
            pb_searchBorrow.Size = new Size(23, 23);
            pb_searchBorrow.TabIndex = 25;
            pb_searchBorrow.TabStop = false;
            // 
            // tb_searchBorrow
            // 
            tb_searchBorrow.Font = new Font("Segoe UI", 10F);
            tb_searchBorrow.ForeColor = Color.Gray;
            tb_searchBorrow.Location = new Point(23, 14);
            tb_searchBorrow.Name = "tb_searchBorrow";
            tb_searchBorrow.Size = new Size(473, 25);
            tb_searchBorrow.TabIndex = 24;
            tb_searchBorrow.Text = "Search for a borrowed book...";
            tb_searchBorrow.Click += tb_searchBorrow_Click;
            tb_searchBorrow.KeyDown += tb_searchBorrow_KeyDown;
            // 
            // dgv_borrowed
            // 
            dgv_borrowed.AllowUserToAddRows = false;
            dgv_borrowed.AllowUserToDeleteRows = false;
            dgv_borrowed.BackgroundColor = Color.White;
            dgv_borrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_borrowed.Location = new Point(0, 51);
            dgv_borrowed.Name = "dgv_borrowed";
            dgv_borrowed.ReadOnly = true;
            dgv_borrowed.Size = new Size(1276, 544);
            dgv_borrowed.TabIndex = 23;
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
            t_reserved.ResumeLayout(false);
            t_reserved.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchReserve).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_reserved).EndInit();
            t_borrowed.ResumeLayout(false);
            t_borrowed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBorrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_borrowed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Button b_logout;
        private Button b_dashboard;
        private Label l_reserved;
        private Button b_reserved;
        private Label l_books;
        private Label l_dashboard;
        private Button b_books;
        private TabControl tabControl;
        private TabPage t_dashboard;
        private TabPage t_books;
        private PictureBox pb_searchBook;
        private TextBox tb_searchBook;
        private DataGridView dgv_books;
        private TabPage t_reserved;
        private Button b_resetBooks;
        private Button b_reserve;
        private DataGridView dgv_reserved;
        private Button b_unreserve;
        private Button b_resetReserved;
        private PictureBox pb_searchReserve;
        private TextBox tb_searchReserve;
        private Label l_borrowed;
        private Button b_borrowed;
        private TabPage t_borrowed;
        private Button b_resetBorrowed;
        private PictureBox pb_searchBorrow;
        private TextBox tb_searchBorrow;
        private DataGridView dgv_borrowed;
        private Button b_renew;
    }
}