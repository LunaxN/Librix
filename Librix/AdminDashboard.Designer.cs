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
            t_bookLoan = new TabPage();
            t_members = new TabPage();
            l_editMember = new Label();
            b_editMember = new Button();
            b_resetMembers = new Button();
            l_addMember = new Label();
            l_deleteMember = new Label();
            b_deleteMember = new Button();
            b_addMember = new Button();
            pb_search = new PictureBox();
            tb_search = new TextBox();
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
            t_members.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_search).BeginInit();
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
            tabControl.Location = new Point(0, 84);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1284, 623);
            tabControl.TabIndex = 0;
            // 
            // t_dashboard
            // 
            t_dashboard.Location = new Point(4, 24);
            t_dashboard.Name = "t_dashboard";
            t_dashboard.Padding = new Padding(3);
            t_dashboard.Size = new Size(1276, 595);
            t_dashboard.TabIndex = 0;
            t_dashboard.Text = "Dashborad";
            t_dashboard.UseVisualStyleBackColor = true;
            // 
            // t_books
            // 
            t_books.Location = new Point(4, 24);
            t_books.Name = "t_books";
            t_books.Padding = new Padding(3);
            t_books.Size = new Size(1276, 595);
            t_books.TabIndex = 1;
            t_books.Text = "Books";
            t_books.UseVisualStyleBackColor = true;
            // 
            // t_bookLoan
            // 
            t_bookLoan.Location = new Point(4, 24);
            t_bookLoan.Name = "t_bookLoan";
            t_bookLoan.Padding = new Padding(3);
            t_bookLoan.Size = new Size(1276, 595);
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
            t_members.Controls.Add(pb_search);
            t_members.Controls.Add(tb_search);
            t_members.Controls.Add(dgv_members);
            t_members.Location = new Point(4, 24);
            t_members.Name = "t_members";
            t_members.Padding = new Padding(3);
            t_members.Size = new Size(1276, 595);
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
            b_addMember.MouseHover += b_addMember_MouseHover;
            // 
            // pb_search
            // 
            pb_search.Image = icons.search;
            pb_search.Location = new Point(546, 15);
            pb_search.Name = "pb_search";
            pb_search.Size = new Size(23, 23);
            pb_search.TabIndex = 2;
            pb_search.TabStop = false;
            // 
            // tb_search
            // 
            tb_search.Font = new Font("Segoe UI", 10F);
            tb_search.ForeColor = Color.Gray;
            tb_search.Location = new Point(205, 14);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(365, 25);
            tb_search.TabIndex = 1;
            tb_search.Text = "Search for a member...";
            tb_search.KeyDown += tb_search_KeyDown;
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
            Text = "Admin Dashboard";
            tabControl.ResumeLayout(false);
            t_members.ResumeLayout(false);
            t_members.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_search).EndInit();
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
        private TextBox tb_search;
        private PictureBox pb_search;
        private Button b_addMember;
        private Button b_deleteMember;
        private Label l_addMember;
        private Label l_deleteMember;
        private Button b_resetMembers;
        private Button b_editMember;
        private Label l_editMember;
    }
}