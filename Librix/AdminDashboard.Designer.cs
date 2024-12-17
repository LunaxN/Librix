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
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            t_dashboard = new TabPage();
            p_totalMembers = new Panel();
            l_noTotalMembers = new Label();
            l_totalMembers = new Label();
            b_profile = new Button();
            l_currentDate = new Label();
            p_newReserves = new Panel();
            l_noNewReserves = new Label();
            l_newReserves = new Label();
            p_totalBorrowed = new Panel();
            l_noTotalBorrowed = new Label();
            l_totalBorrowed = new Label();
            p_returnedToday = new Panel();
            l_noReturnedToday = new Label();
            l_returnedToday = new Label();
            p_userInforamtion = new Panel();
            l_password = new Label();
            l_username = new Label();
            tb_password = new TextBox();
            tb_username = new TextBox();
            b_cancel = new Button();
            b_save = new Button();
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
            t_borrowed = new TabPage();
            label1 = new Label();
            b_addBorrowed = new Button();
            b_returned = new Button();
            b_resetBorrowed = new Button();
            pb_searchBorrow = new PictureBox();
            tb_searchBorrow = new TextBox();
            dgv_borrowed = new DataGridView();
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
            t_reserved = new TabPage();
            b_resetReserved = new Button();
            pb_searchReserve = new PictureBox();
            tb_searchReserve = new TextBox();
            b_issued = new Button();
            dgv_reserved = new DataGridView();
            b_books = new Button();
            panel = new Panel();
            b_reserved = new Button();
            l_reserved = new Label();
            b_logout = new Button();
            l_members = new Label();
            b_dashboard = new Button();
            l_borrowed = new Label();
            b_borrowed = new Button();
            l_books = new Label();
            b_members = new Button();
            l_dashboard = new Label();
            errorProvider1 = new ErrorProvider(components);
            tabControl.SuspendLayout();
            t_dashboard.SuspendLayout();
            p_totalMembers.SuspendLayout();
            p_newReserves.SuspendLayout();
            p_totalBorrowed.SuspendLayout();
            p_returnedToday.SuspendLayout();
            p_userInforamtion.SuspendLayout();
            t_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_books).BeginInit();
            t_borrowed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBorrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_borrowed).BeginInit();
            t_members.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_members).BeginInit();
            t_reserved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchReserve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_reserved).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(t_dashboard);
            tabControl.Controls.Add(t_books);
            tabControl.Controls.Add(t_borrowed);
            tabControl.Controls.Add(t_members);
            tabControl.Controls.Add(t_reserved);
            tabControl.Location = new Point(0, 89);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1284, 620);
            tabControl.TabIndex = 0;
            // 
            // t_dashboard
            // 
            t_dashboard.Controls.Add(p_totalMembers);
            t_dashboard.Controls.Add(b_profile);
            t_dashboard.Controls.Add(l_currentDate);
            t_dashboard.Controls.Add(p_newReserves);
            t_dashboard.Controls.Add(p_totalBorrowed);
            t_dashboard.Controls.Add(p_returnedToday);
            t_dashboard.Controls.Add(p_userInforamtion);
            t_dashboard.Location = new Point(4, 24);
            t_dashboard.Name = "t_dashboard";
            t_dashboard.Padding = new Padding(3);
            t_dashboard.Size = new Size(1276, 592);
            t_dashboard.TabIndex = 0;
            t_dashboard.Text = "Dashborad";
            t_dashboard.UseVisualStyleBackColor = true;
            // 
            // p_totalMembers
            // 
            p_totalMembers.BackColor = SystemColors.Control;
            p_totalMembers.Controls.Add(l_noTotalMembers);
            p_totalMembers.Controls.Add(l_totalMembers);
            p_totalMembers.Location = new Point(1040, 16);
            p_totalMembers.Name = "p_totalMembers";
            p_totalMembers.Size = new Size(220, 127);
            p_totalMembers.TabIndex = 29;
            // 
            // l_noTotalMembers
            // 
            l_noTotalMembers.AutoSize = true;
            l_noTotalMembers.Font = new Font("Segoe UI", 15F);
            l_noTotalMembers.Location = new Point(16, 76);
            l_noTotalMembers.Name = "l_noTotalMembers";
            l_noTotalMembers.Size = new Size(0, 28);
            l_noTotalMembers.TabIndex = 30;
            // 
            // l_totalMembers
            // 
            l_totalMembers.AutoSize = true;
            l_totalMembers.Font = new Font("Sitka Subheading", 11F);
            l_totalMembers.Location = new Point(16, 16);
            l_totalMembers.Name = "l_totalMembers";
            l_totalMembers.Size = new Size(107, 21);
            l_totalMembers.TabIndex = 1;
            l_totalMembers.Text = "Total Members";
            // 
            // b_profile
            // 
            b_profile.BackColor = Color.FromArgb(255, 192, 192);
            b_profile.FlatStyle = FlatStyle.Flat;
            b_profile.Font = new Font("Sitka Subheading", 10F);
            b_profile.Location = new Point(17, 57);
            b_profile.Name = "b_profile";
            b_profile.Size = new Size(162, 35);
            b_profile.TabIndex = 28;
            b_profile.Text = "Your Profile";
            b_profile.UseVisualStyleBackColor = false;
            b_profile.Click += b_profile_Click;
            // 
            // l_currentDate
            // 
            l_currentDate.AutoSize = true;
            l_currentDate.Font = new Font("Segoe UI", 9F);
            l_currentDate.Location = new Point(23, 24);
            l_currentDate.Name = "l_currentDate";
            l_currentDate.Size = new Size(0, 15);
            l_currentDate.TabIndex = 4;
            // 
            // p_newReserves
            // 
            p_newReserves.BackColor = SystemColors.Control;
            p_newReserves.Controls.Add(l_noNewReserves);
            p_newReserves.Controls.Add(l_newReserves);
            p_newReserves.Location = new Point(572, 16);
            p_newReserves.Name = "p_newReserves";
            p_newReserves.Size = new Size(220, 127);
            p_newReserves.TabIndex = 3;
            // 
            // l_noNewReserves
            // 
            l_noNewReserves.AutoSize = true;
            l_noNewReserves.Font = new Font("Segoe UI", 15F);
            l_noNewReserves.Location = new Point(13, 76);
            l_noNewReserves.Name = "l_noNewReserves";
            l_noNewReserves.Size = new Size(0, 28);
            l_noNewReserves.TabIndex = 32;
            // 
            // l_newReserves
            // 
            l_newReserves.AutoSize = true;
            l_newReserves.Font = new Font("Sitka Subheading", 11F);
            l_newReserves.Location = new Point(13, 16);
            l_newReserves.Name = "l_newReserves";
            l_newReserves.Size = new Size(100, 21);
            l_newReserves.TabIndex = 1;
            l_newReserves.Text = "New Reserves";
            // 
            // p_totalBorrowed
            // 
            p_totalBorrowed.BackColor = SystemColors.Control;
            p_totalBorrowed.Controls.Add(l_noTotalBorrowed);
            p_totalBorrowed.Controls.Add(l_totalBorrowed);
            p_totalBorrowed.Location = new Point(806, 16);
            p_totalBorrowed.Name = "p_totalBorrowed";
            p_totalBorrowed.Size = new Size(220, 127);
            p_totalBorrowed.TabIndex = 3;
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
            p_returnedToday.Location = new Point(337, 16);
            p_returnedToday.Name = "p_returnedToday";
            p_returnedToday.Size = new Size(220, 127);
            p_returnedToday.TabIndex = 2;
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
            l_returnedToday.Size = new Size(186, 21);
            l_returnedToday.TabIndex = 0;
            l_returnedToday.Text = "Books to be returned today";
            // 
            // p_userInforamtion
            // 
            p_userInforamtion.Controls.Add(l_password);
            p_userInforamtion.Controls.Add(l_username);
            p_userInforamtion.Controls.Add(tb_password);
            p_userInforamtion.Controls.Add(tb_username);
            p_userInforamtion.Controls.Add(b_cancel);
            p_userInforamtion.Controls.Add(b_save);
            p_userInforamtion.Location = new Point(0, 98);
            p_userInforamtion.Name = "p_userInforamtion";
            p_userInforamtion.Size = new Size(335, 159);
            p_userInforamtion.TabIndex = 42;
            p_userInforamtion.Visible = false;
            // 
            // l_password
            // 
            l_password.Font = new Font("Sitka Subheading", 10F);
            l_password.Location = new Point(17, 64);
            l_password.Name = "l_password";
            l_password.Size = new Size(110, 23);
            l_password.TabIndex = 43;
            l_password.Text = "New Password:";
            // 
            // l_username
            // 
            l_username.Font = new Font("Sitka Subheading", 10F);
            l_username.Location = new Point(17, 24);
            l_username.Name = "l_username";
            l_username.Size = new Size(78, 23);
            l_username.TabIndex = 41;
            l_username.Text = "Username:";
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Segoe UI", 10F);
            tb_password.Location = new Point(130, 64);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(175, 25);
            tb_password.TabIndex = 44;
            tb_password.Validating += tb_password_Validating;
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Segoe UI", 10F);
            tb_username.Location = new Point(130, 24);
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
            b_cancel.Location = new Point(246, 106);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(59, 31);
            b_cancel.TabIndex = 40;
            b_cancel.Text = "Cancel";
            b_cancel.UseVisualStyleBackColor = false;
            b_cancel.Click += b_cancel_Click;
            // 
            // b_save
            // 
            b_save.BackColor = Color.FromArgb(255, 192, 192);
            b_save.FlatStyle = FlatStyle.Flat;
            b_save.Font = new Font("Sitka Subheading", 10F);
            b_save.Location = new Point(186, 106);
            b_save.Name = "b_save";
            b_save.Size = new Size(50, 31);
            b_save.TabIndex = 37;
            b_save.Text = "Save";
            b_save.UseVisualStyleBackColor = false;
            b_save.Click += b_save_Click;
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
            // t_borrowed
            // 
            t_borrowed.Controls.Add(label1);
            t_borrowed.Controls.Add(b_addBorrowed);
            t_borrowed.Controls.Add(b_returned);
            t_borrowed.Controls.Add(b_resetBorrowed);
            t_borrowed.Controls.Add(pb_searchBorrow);
            t_borrowed.Controls.Add(tb_searchBorrow);
            t_borrowed.Controls.Add(dgv_borrowed);
            t_borrowed.Location = new Point(4, 24);
            t_borrowed.Name = "t_borrowed";
            t_borrowed.Padding = new Padding(3);
            t_borrowed.Size = new Size(1276, 592);
            t_borrowed.TabIndex = 3;
            t_borrowed.Text = "Borrowed";
            t_borrowed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Sitka Subheading", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 43);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 33;
            label1.Text = "Add";
            label1.Visible = false;
            // 
            // b_addBorrowed
            // 
            b_addBorrowed.BackColor = Color.Transparent;
            b_addBorrowed.FlatAppearance.BorderColor = Color.White;
            b_addBorrowed.FlatStyle = FlatStyle.Flat;
            b_addBorrowed.Font = new Font("Sitka Subheading", 10F);
            b_addBorrowed.Image = icons.add;
            b_addBorrowed.Location = new Point(11, 11);
            b_addBorrowed.Name = "b_addBorrowed";
            b_addBorrowed.Size = new Size(30, 30);
            b_addBorrowed.TabIndex = 32;
            b_addBorrowed.UseVisualStyleBackColor = false;
            b_addBorrowed.Click += b_addBorrowed_Click;
            // 
            // b_returned
            // 
            b_returned.BackColor = Color.LightSkyBlue;
            b_returned.FlatStyle = FlatStyle.Flat;
            b_returned.Font = new Font("Sitka Subheading", 10F);
            b_returned.Location = new Point(554, 9);
            b_returned.Name = "b_returned";
            b_returned.Size = new Size(87, 35);
            b_returned.TabIndex = 31;
            b_returned.Text = "Returned";
            b_returned.UseVisualStyleBackColor = false;
            b_returned.Click += b_returned_Click;
            // 
            // b_resetBorrowed
            // 
            b_resetBorrowed.BackColor = Color.FromArgb(255, 192, 192);
            b_resetBorrowed.FlatStyle = FlatStyle.Flat;
            b_resetBorrowed.Font = new Font("Sitka Subheading", 10F);
            b_resetBorrowed.Location = new Point(647, 9);
            b_resetBorrowed.Name = "b_resetBorrowed";
            b_resetBorrowed.Size = new Size(157, 35);
            b_resetBorrowed.TabIndex = 22;
            b_resetBorrowed.Text = "Show Borrowed Books ";
            b_resetBorrowed.UseVisualStyleBackColor = false;
            b_resetBorrowed.Visible = false;
            b_resetBorrowed.Click += b_resetBorrowed_Click;
            // 
            // pb_searchBorrow
            // 
            pb_searchBorrow.Image = icons.search;
            pb_searchBorrow.Location = new Point(497, 16);
            pb_searchBorrow.Name = "pb_searchBorrow";
            pb_searchBorrow.Size = new Size(23, 23);
            pb_searchBorrow.TabIndex = 21;
            pb_searchBorrow.TabStop = false;
            // 
            // tb_searchBorrow
            // 
            tb_searchBorrow.Font = new Font("Segoe UI", 10F);
            tb_searchBorrow.ForeColor = Color.Gray;
            tb_searchBorrow.Location = new Point(48, 15);
            tb_searchBorrow.Name = "tb_searchBorrow";
            tb_searchBorrow.Size = new Size(473, 25);
            tb_searchBorrow.TabIndex = 20;
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
            dgv_borrowed.TabIndex = 13;
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
            dgv_members.AllowUserToAddRows = false;
            dgv_members.AllowUserToDeleteRows = false;
            dgv_members.BackgroundColor = Color.White;
            dgv_members.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_members.Location = new Point(0, 51);
            dgv_members.Name = "dgv_members";
            dgv_members.ReadOnly = true;
            dgv_members.Size = new Size(1276, 544);
            dgv_members.TabIndex = 0;
            // 
            // t_reserved
            // 
            t_reserved.Controls.Add(b_resetReserved);
            t_reserved.Controls.Add(pb_searchReserve);
            t_reserved.Controls.Add(tb_searchReserve);
            t_reserved.Controls.Add(b_issued);
            t_reserved.Controls.Add(dgv_reserved);
            t_reserved.Location = new Point(4, 24);
            t_reserved.Name = "t_reserved";
            t_reserved.Padding = new Padding(3);
            t_reserved.Size = new Size(1276, 592);
            t_reserved.TabIndex = 5;
            t_reserved.Text = "Reserved";
            t_reserved.UseVisualStyleBackColor = true;
            // 
            // b_resetReserved
            // 
            b_resetReserved.BackColor = Color.FromArgb(255, 192, 192);
            b_resetReserved.FlatStyle = FlatStyle.Flat;
            b_resetReserved.Font = new Font("Sitka Subheading", 10F);
            b_resetReserved.Location = new Point(665, 8);
            b_resetReserved.Name = "b_resetReserved";
            b_resetReserved.Size = new Size(116, 35);
            b_resetReserved.TabIndex = 35;
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
            pb_searchReserve.TabIndex = 34;
            pb_searchReserve.TabStop = false;
            // 
            // tb_searchReserve
            // 
            tb_searchReserve.Font = new Font("Segoe UI", 10F);
            tb_searchReserve.ForeColor = Color.Gray;
            tb_searchReserve.Location = new Point(23, 14);
            tb_searchReserve.Name = "tb_searchReserve";
            tb_searchReserve.Size = new Size(473, 25);
            tb_searchReserve.TabIndex = 33;
            tb_searchReserve.Text = "Search for a reserved book...";
            tb_searchReserve.Click += tb_searchReserve_Click;
            tb_searchReserve.KeyDown += tb_searchReserve_KeyDown;
            // 
            // b_issued
            // 
            b_issued.BackColor = Color.LightSkyBlue;
            b_issued.FlatStyle = FlatStyle.Flat;
            b_issued.Font = new Font("Sitka Subheading", 10F);
            b_issued.Location = new Point(529, 8);
            b_issued.Name = "b_issued";
            b_issued.Size = new Size(116, 35);
            b_issued.TabIndex = 30;
            b_issued.Text = "Issued";
            b_issued.UseVisualStyleBackColor = false;
            b_issued.Click += b_issued_Click;
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
            dgv_reserved.TabIndex = 26;
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
            panel.Controls.Add(b_reserved);
            panel.Controls.Add(l_reserved);
            panel.Controls.Add(b_logout);
            panel.Controls.Add(l_members);
            panel.Controls.Add(b_dashboard);
            panel.Controls.Add(l_borrowed);
            panel.Controls.Add(b_borrowed);
            panel.Controls.Add(l_books);
            panel.Controls.Add(b_members);
            panel.Controls.Add(l_dashboard);
            panel.Controls.Add(b_books);
            panel.Location = new Point(1, 1);
            panel.Name = "panel";
            panel.Size = new Size(1279, 101);
            panel.TabIndex = 1;
            // 
            // b_reserved
            // 
            b_reserved.FlatAppearance.BorderColor = Color.White;
            b_reserved.FlatStyle = FlatStyle.Flat;
            b_reserved.Image = icons.reserve;
            b_reserved.Location = new Point(229, 15);
            b_reserved.Name = "b_reserved";
            b_reserved.Size = new Size(51, 53);
            b_reserved.TabIndex = 11;
            b_reserved.UseVisualStyleBackColor = false;
            b_reserved.Click += b_reserved_Click;
            // 
            // l_reserved
            // 
            l_reserved.AutoSize = true;
            l_reserved.Font = new Font("Sitka Subheading", 10F);
            l_reserved.Location = new Point(206, 70);
            l_reserved.Name = "l_reserved";
            l_reserved.Size = new Size(105, 20);
            l_reserved.TabIndex = 10;
            l_reserved.Text = "Reserved Books";
            // 
            // b_logout
            // 
            b_logout.BackColor = Color.White;
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
            l_members.Location = new Point(434, 70);
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
            // l_borrowed
            // 
            l_borrowed.AutoSize = true;
            l_borrowed.Font = new Font("Sitka Subheading", 10F);
            l_borrowed.Location = new Point(318, 70);
            l_borrowed.Name = "l_borrowed";
            l_borrowed.Size = new Size(108, 20);
            l_borrowed.TabIndex = 5;
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
            b_borrowed.TabIndex = 9;
            b_borrowed.UseVisualStyleBackColor = false;
            b_borrowed.Click += b_borrowed_Click;
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
            b_members.Location = new Point(437, 14);
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
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
            t_dashboard.ResumeLayout(false);
            t_dashboard.PerformLayout();
            p_totalMembers.ResumeLayout(false);
            p_totalMembers.PerformLayout();
            p_newReserves.ResumeLayout(false);
            p_newReserves.PerformLayout();
            p_totalBorrowed.ResumeLayout(false);
            p_totalBorrowed.PerformLayout();
            p_returnedToday.ResumeLayout(false);
            p_returnedToday.PerformLayout();
            p_userInforamtion.ResumeLayout(false);
            p_userInforamtion.PerformLayout();
            t_books.ResumeLayout(false);
            t_books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_books).EndInit();
            t_borrowed.ResumeLayout(false);
            t_borrowed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchBorrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_borrowed).EndInit();
            t_members.ResumeLayout(false);
            t_members.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_members).EndInit();
            t_reserved.ResumeLayout(false);
            t_reserved.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_searchReserve).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_reserved).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage t_dashboard;
        private TabPage t_books;
        private TabPage t_borrowed;
        private Panel panel;
        private Button b_books;
        private Label l_members;
        private Label l_borrowed;
        private Label l_books;
        private Label l_dashboard;
        private Button b_dashboard;
        private Button b_borrowed;
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
        private DataGridView dgv_borrowed;
        private Button b_resetBorrowed;
        private PictureBox pb_searchBorrow;
        private TextBox tb_searchBorrow;
        private Label l_reserved;
        private Button b_reserved;
        private TabPage t_reserved;
        private DataGridView dgv_reserved;
        private Button b_issued;
        private Button b_resetReserved;
        private PictureBox pb_searchReserve;
        private TextBox tb_searchReserve;
        private Button b_returned;
        private Panel p_newReserves;
        private Panel p_totalBorrowed;
        private Panel p_returnedToday;
        private Label l_currentDate;
        private Button b_profile;
        private Label l_returnedToday;
        private Label l_newReserves;
        private Label l_totalBorrowed;
        private Panel p_totalMembers;
        private Label l_totalMembers;
        private Label l_noTotalMembers;
        private Label l_noNewReserves;
        private Label l_noTotalBorrowed;
        private Label l_noReturnedToday;
        private Panel p_userInforamtion;
        private Label l_password;
        private Label l_username;
        private TextBox tb_password;
        private TextBox tb_username;
        private Button b_cancel;
        private Button b_save;
        private ErrorProvider errorProvider1;
        private Label label1;
        private Button b_addBorrowed;
    }
}