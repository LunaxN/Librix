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
            components = new System.ComponentModel.Container();
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
            t_borrowed = new TabPage();
            b_renew = new Button();
            b_resetBorrowed = new Button();
            pb_searchBorrow = new PictureBox();
            tb_searchBorrow = new TextBox();
            dgv_borrowed = new DataGridView();
            t_reserved = new TabPage();
            b_resetReserved = new Button();
            pb_searchReserve = new PictureBox();
            tb_searchReserve = new TextBox();
            b_unreserve = new Button();
            dgv_reserved = new DataGridView();
            t_books = new TabPage();
            b_reserve = new Button();
            b_resetBooks = new Button();
            pb_searchBook = new PictureBox();
            tb_searchBook = new TextBox();
            dgv_books = new DataGridView();
            t_dashboard = new TabPage();
            panel1 = new Panel();
            l_NewBooks2 = new Label();
            l_numberNewBooks = new Label();
            dgv_newbooks = new DataGridView();
            label1 = new Label();
            l_NewBooks = new Label();
            b_profile = new Button();
            p_newBooks = new Panel();
            l_noNewBooks = new Label();
            l_reservedBooks = new Label();
            p_totalBorrowed = new Panel();
            l_noTotalBorrowed = new Label();
            l_totalBorrowed = new Label();
            p_returnedToday = new Panel();
            l_noReturnedToday = new Label();
            l_returnedToday = new Label();
            l_currentDate = new Label();
            p_userInforamtion = new Panel();
            l_password = new Label();
            l_username = new Label();
            tb_password = new TextBox();
            tb_username = new TextBox();
            b_cancel = new Button();
            l_name = new Label();
            l_phoneNumber = new Label();
            l_lastname = new Label();
            tb_phoneNumber = new TextBox();
            tb_lastname = new TextBox();
            b_save = new Button();
            tb_name = new TextBox();
            tabControl = new TabControl();
            errorProvider1 = new ErrorProvider(components);
            panel.SuspendLayout();
            t_borrowed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBorrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_borrowed).BeginInit();
            t_reserved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchReserve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_reserved).BeginInit();
            t_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_books).BeginInit();
            t_dashboard.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_newbooks).BeginInit();
            p_newBooks.SuspendLayout();
            p_totalBorrowed.SuspendLayout();
            p_returnedToday.SuspendLayout();
            p_userInforamtion.SuspendLayout();
            tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            // t_dashboard
            // 
            t_dashboard.Controls.Add(panel1);
            t_dashboard.Controls.Add(b_profile);
            t_dashboard.Controls.Add(p_newBooks);
            t_dashboard.Controls.Add(p_totalBorrowed);
            t_dashboard.Controls.Add(p_returnedToday);
            t_dashboard.Controls.Add(l_currentDate);
            t_dashboard.Controls.Add(p_userInforamtion);
            t_dashboard.Location = new Point(4, 24);
            t_dashboard.Name = "t_dashboard";
            t_dashboard.Padding = new Padding(3);
            t_dashboard.Size = new Size(1276, 592);
            t_dashboard.TabIndex = 0;
            t_dashboard.Text = "Dashborad";
            t_dashboard.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(l_NewBooks2);
            panel1.Controls.Add(l_numberNewBooks);
            panel1.Controls.Add(dgv_newbooks);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(l_NewBooks);
            panel1.Location = new Point(544, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 403);
            panel1.TabIndex = 33;
            // 
            // l_NewBooks2
            // 
            l_NewBooks2.AutoSize = true;
            l_NewBooks2.Font = new Font("Sitka Subheading", 11F);
            l_NewBooks2.Location = new Point(605, 16);
            l_NewBooks2.Name = "l_NewBooks2";
            l_NewBooks2.Size = new Size(97, 21);
            l_NewBooks2.TabIndex = 34;
            l_NewBooks2.Text = "new book(s)!";
            l_NewBooks2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_numberNewBooks
            // 
            l_numberNewBooks.Font = new Font("Sitka Subheading", 11F);
            l_numberNewBooks.Location = new Point(565, 16);
            l_numberNewBooks.Name = "l_numberNewBooks";
            l_numberNewBooks.RightToLeft = RightToLeft.Yes;
            l_numberNewBooks.Size = new Size(44, 21);
            l_numberNewBooks.TabIndex = 35;
            l_numberNewBooks.Text = "#";
            l_numberNewBooks.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgv_newbooks
            // 
            dgv_newbooks.AllowUserToAddRows = false;
            dgv_newbooks.AllowUserToDeleteRows = false;
            dgv_newbooks.BackgroundColor = Color.White;
            dgv_newbooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_newbooks.Location = new Point(13, 51);
            dgv_newbooks.Name = "dgv_newbooks";
            dgv_newbooks.ReadOnly = true;
            dgv_newbooks.Size = new Size(685, 338);
            dgv_newbooks.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(13, 76);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 32;
            // 
            // l_NewBooks
            // 
            l_NewBooks.AutoSize = true;
            l_NewBooks.Font = new Font("Sitka Subheading", 11F);
            l_NewBooks.Location = new Point(13, 16);
            l_NewBooks.Name = "l_NewBooks";
            l_NewBooks.Size = new Size(95, 21);
            l_NewBooks.TabIndex = 1;
            l_NewBooks.Text = "New Arrivals";
            // 
            // b_profile
            // 
            b_profile.BackColor = Color.FromArgb(255, 192, 192);
            b_profile.FlatStyle = FlatStyle.Flat;
            b_profile.Font = new Font("Sitka Subheading", 10F);
            b_profile.Location = new Point(17, 57);
            b_profile.Name = "b_profile";
            b_profile.Size = new Size(162, 35);
            b_profile.TabIndex = 32;
            b_profile.Text = "Your Profile";
            b_profile.UseVisualStyleBackColor = false;
            b_profile.Click += b_profile_Click;
            // 
            // p_newBooks
            // 
            p_newBooks.BackColor = SystemColors.Control;
            p_newBooks.Controls.Add(l_noNewBooks);
            p_newBooks.Controls.Add(l_reservedBooks);
            p_newBooks.Location = new Point(787, 18);
            p_newBooks.Name = "p_newBooks";
            p_newBooks.Size = new Size(228, 127);
            p_newBooks.TabIndex = 30;
            // 
            // l_noNewBooks
            // 
            l_noNewBooks.AutoSize = true;
            l_noNewBooks.Font = new Font("Segoe UI", 15F);
            l_noNewBooks.Location = new Point(13, 76);
            l_noNewBooks.Name = "l_noNewBooks";
            l_noNewBooks.Size = new Size(0, 28);
            l_noNewBooks.TabIndex = 32;
            // 
            // l_reservedBooks
            // 
            l_reservedBooks.AutoSize = true;
            l_reservedBooks.Font = new Font("Sitka Subheading", 11F);
            l_reservedBooks.Location = new Point(13, 16);
            l_reservedBooks.Name = "l_reservedBooks";
            l_reservedBooks.Size = new Size(110, 21);
            l_reservedBooks.TabIndex = 1;
            l_reservedBooks.Text = "Reserved books";
            // 
            // p_totalBorrowed
            // 
            p_totalBorrowed.BackColor = SystemColors.Control;
            p_totalBorrowed.Controls.Add(l_noTotalBorrowed);
            p_totalBorrowed.Controls.Add(l_totalBorrowed);
            p_totalBorrowed.Location = new Point(1029, 18);
            p_totalBorrowed.Name = "p_totalBorrowed";
            p_totalBorrowed.Size = new Size(228, 127);
            p_totalBorrowed.TabIndex = 31;
            // 
            // l_noTotalBorrowed
            // 
            l_noTotalBorrowed.AutoSize = true;
            l_noTotalBorrowed.Font = new Font("Segoe UI", 15F);
            l_noTotalBorrowed.Location = new Point(14, 76);
            l_noTotalBorrowed.Name = "l_noTotalBorrowed";
            l_noTotalBorrowed.Size = new Size(0, 28);
            l_noTotalBorrowed.TabIndex = 31;
            // 
            // l_totalBorrowed
            // 
            l_totalBorrowed.AutoSize = true;
            l_totalBorrowed.Font = new Font("Sitka Subheading", 11F);
            l_totalBorrowed.Location = new Point(14, 16);
            l_totalBorrowed.Name = "l_totalBorrowed";
            l_totalBorrowed.Size = new Size(154, 21);
            l_totalBorrowed.TabIndex = 2;
            l_totalBorrowed.Text = "Total Borrowed Books";
            // 
            // p_returnedToday
            // 
            p_returnedToday.BackColor = Color.LightSkyBlue;
            p_returnedToday.Controls.Add(l_noReturnedToday);
            p_returnedToday.Controls.Add(l_returnedToday);
            p_returnedToday.Location = new Point(544, 18);
            p_returnedToday.Name = "p_returnedToday";
            p_returnedToday.Size = new Size(228, 127);
            p_returnedToday.TabIndex = 29;
            // 
            // l_noReturnedToday
            // 
            l_noReturnedToday.AutoSize = true;
            l_noReturnedToday.Font = new Font("Segoe UI", 15F);
            l_noReturnedToday.Location = new Point(15, 76);
            l_noReturnedToday.Name = "l_noReturnedToday";
            l_noReturnedToday.Size = new Size(0, 28);
            l_noReturnedToday.TabIndex = 33;
            // 
            // l_returnedToday
            // 
            l_returnedToday.AutoSize = true;
            l_returnedToday.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_returnedToday.Location = new Point(15, 16);
            l_returnedToday.Name = "l_returnedToday";
            l_returnedToday.Size = new Size(160, 21);
            l_returnedToday.TabIndex = 0;
            l_returnedToday.Text = "Books Awaiting Return";
            // 
            // l_currentDate
            // 
            l_currentDate.AutoSize = true;
            l_currentDate.Font = new Font("Segoe UI", 9F);
            l_currentDate.Location = new Point(23, 24);
            l_currentDate.Name = "l_currentDate";
            l_currentDate.Size = new Size(0, 15);
            l_currentDate.TabIndex = 5;
            // 
            // p_userInforamtion
            // 
            p_userInforamtion.Controls.Add(l_password);
            p_userInforamtion.Controls.Add(l_username);
            p_userInforamtion.Controls.Add(tb_password);
            p_userInforamtion.Controls.Add(tb_username);
            p_userInforamtion.Controls.Add(b_cancel);
            p_userInforamtion.Controls.Add(l_name);
            p_userInforamtion.Controls.Add(l_phoneNumber);
            p_userInforamtion.Controls.Add(l_lastname);
            p_userInforamtion.Controls.Add(tb_phoneNumber);
            p_userInforamtion.Controls.Add(tb_lastname);
            p_userInforamtion.Controls.Add(b_save);
            p_userInforamtion.Controls.Add(tb_name);
            p_userInforamtion.Location = new Point(0, 98);
            p_userInforamtion.Name = "p_userInforamtion";
            p_userInforamtion.Size = new Size(347, 291);
            p_userInforamtion.TabIndex = 41;
            p_userInforamtion.Visible = false;
            // 
            // l_password
            // 
            l_password.Font = new Font("Sitka Subheading", 10F);
            l_password.Location = new Point(23, 190);
            l_password.Name = "l_password";
            l_password.Size = new Size(110, 23);
            l_password.TabIndex = 43;
            l_password.Text = "New Password:";
            // 
            // l_username
            // 
            l_username.Font = new Font("Sitka Subheading", 10F);
            l_username.Location = new Point(23, 150);
            l_username.Name = "l_username";
            l_username.Size = new Size(100, 23);
            l_username.TabIndex = 41;
            l_username.Text = "Username:";
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Segoe UI", 10F);
            tb_password.Location = new Point(136, 190);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(175, 25);
            tb_password.TabIndex = 44;
            tb_password.Validating += tb_password_Validating;
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Segoe UI", 10F);
            tb_username.Location = new Point(136, 150);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(175, 25);
            tb_username.TabIndex = 42;
            tb_username.Validating += tb_username_Validating;
            // 
            // b_cancel
            // 
            b_cancel.BackColor = Color.FromArgb(224, 224, 224);
            b_cancel.FlatStyle = FlatStyle.Flat;
            b_cancel.Font = new Font("Sitka Subheading", 10F);
            b_cancel.Location = new Point(252, 232);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(59, 31);
            b_cancel.TabIndex = 40;
            b_cancel.Text = "Cancel";
            b_cancel.UseVisualStyleBackColor = false;
            b_cancel.Click += b_cancel_Click;
            // 
            // l_name
            // 
            l_name.Font = new Font("Sitka Subheading", 10F);
            l_name.Location = new Point(23, 30);
            l_name.Name = "l_name";
            l_name.Size = new Size(100, 23);
            l_name.TabIndex = 33;
            l_name.Text = "Name:";
            // 
            // l_phoneNumber
            // 
            l_phoneNumber.Font = new Font("Sitka Subheading", 10F);
            l_phoneNumber.Location = new Point(23, 110);
            l_phoneNumber.Name = "l_phoneNumber";
            l_phoneNumber.Size = new Size(110, 23);
            l_phoneNumber.TabIndex = 38;
            l_phoneNumber.Text = "Phone Number:";
            // 
            // l_lastname
            // 
            l_lastname.Font = new Font("Sitka Subheading", 10F);
            l_lastname.Location = new Point(23, 70);
            l_lastname.Name = "l_lastname";
            l_lastname.Size = new Size(100, 23);
            l_lastname.TabIndex = 34;
            l_lastname.Text = "Last Name:";
            // 
            // tb_phoneNumber
            // 
            tb_phoneNumber.Font = new Font("Segoe UI", 10F);
            tb_phoneNumber.Location = new Point(136, 110);
            tb_phoneNumber.Name = "tb_phoneNumber";
            tb_phoneNumber.Size = new Size(175, 25);
            tb_phoneNumber.TabIndex = 39;
            // 
            // tb_lastname
            // 
            tb_lastname.Font = new Font("Segoe UI", 10F);
            tb_lastname.Location = new Point(136, 70);
            tb_lastname.Name = "tb_lastname";
            tb_lastname.Size = new Size(175, 25);
            tb_lastname.TabIndex = 36;
            tb_lastname.Validating += tb_lastname_Validating;
            // 
            // b_save
            // 
            b_save.BackColor = Color.FromArgb(255, 192, 192);
            b_save.FlatStyle = FlatStyle.Flat;
            b_save.Font = new Font("Sitka Subheading", 10F);
            b_save.Location = new Point(192, 232);
            b_save.Name = "b_save";
            b_save.Size = new Size(50, 31);
            b_save.TabIndex = 37;
            b_save.Text = "Save";
            b_save.UseVisualStyleBackColor = false;
            b_save.Click += b_save_Click;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 10F);
            tb_name.Location = new Point(136, 30);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(175, 25);
            tb_name.TabIndex = 35;
            tb_name.Validating += tb_name_Validating;
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
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
            t_borrowed.ResumeLayout(false);
            t_borrowed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBorrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_borrowed).EndInit();
            t_reserved.ResumeLayout(false);
            t_reserved.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchReserve).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_reserved).EndInit();
            t_books.ResumeLayout(false);
            t_books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_books).EndInit();
            t_dashboard.ResumeLayout(false);
            t_dashboard.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_newbooks).EndInit();
            p_newBooks.ResumeLayout(false);
            p_newBooks.PerformLayout();
            p_totalBorrowed.ResumeLayout(false);
            p_totalBorrowed.PerformLayout();
            p_returnedToday.ResumeLayout(false);
            p_returnedToday.PerformLayout();
            p_userInforamtion.ResumeLayout(false);
            p_userInforamtion.PerformLayout();
            tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private Label l_borrowed;
        private Button b_borrowed;
        private TabPage t_borrowed;
        private Button b_renew;
        private Button b_resetBorrowed;
        private PictureBox pb_searchBorrow;
        private TextBox tb_searchBorrow;
        private DataGridView dgv_borrowed;
        private TabPage t_reserved;
        private Button b_resetReserved;
        private PictureBox pb_searchReserve;
        private TextBox tb_searchReserve;
        private Button b_unreserve;
        private DataGridView dgv_reserved;
        private TabPage t_books;
        private Button b_reserve;
        private Button b_resetBooks;
        private PictureBox pb_searchBook;
        private TextBox tb_searchBook;
        private DataGridView dgv_books;
        private TabPage t_dashboard;
        private Button b_profile;
        private Panel p_newBooks;
        private Label l_noNewBooks;
        private Label l_reservedBooks;
        private Panel p_totalBorrowed;
        private Label l_noTotalBorrowed;
        private Label l_totalBorrowed;
        private Panel p_returnedToday;
        private Label l_noReturnedToday;
        private Label l_returnedToday;
        private Label l_currentDate;
        private TabControl tabControl;
        private Panel p_userInforamtion;
        private Label l_password;
        private Label l_username;
        private TextBox tb_password;
        private TextBox tb_username;
        private Button b_cancel;
        private Label l_name;
        private Label l_phoneNumber;
        private Label l_lastname;
        private TextBox tb_phoneNumber;
        private TextBox tb_lastname;
        private Button b_save;
        private TextBox tb_name;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private DataGridView dgv_newbooks;
        private Label label1;
        private Label l_NewBooks;
        private Label l_NewBooks2;
        private Label l_numberNewBooks;
    }
}