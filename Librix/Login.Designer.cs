namespace Librix
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            t_signup = new TabPage();
            l_phonenumber = new Label();
            tb_phonenumber = new TextBox();
            l_or2 = new Label();
            l_getstarted = new Label();
            b_lognin2 = new Button();
            b_signup2 = new Button();
            tb_password2 = new TextBox();
            tb_username2 = new TextBox();
            tb_lastname = new TextBox();
            tb_name = new TextBox();
            l_password2 = new Label();
            l_username2 = new Label();
            l_lastname = new Label();
            l_name = new Label();
            t_login = new TabPage();
            b_show_password = new Button();
            tb_username = new TextBox();
            tb_password = new TextBox();
            b_signup = new Button();
            b_login = new Button();
            l_or = new Label();
            l_password = new Label();
            l_welcomeback = new Label();
            l_username = new Label();
            rb_member = new RadioButton();
            rb_admin = new RadioButton();
            tabcontrol = new TabControl();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            t_signup.SuspendLayout();
            t_login.SuspendLayout();
            tabcontrol.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // t_signup
            // 
            t_signup.Controls.Add(l_phonenumber);
            t_signup.Controls.Add(tb_phonenumber);
            t_signup.Controls.Add(l_or2);
            t_signup.Controls.Add(l_getstarted);
            t_signup.Controls.Add(b_lognin2);
            t_signup.Controls.Add(b_signup2);
            t_signup.Controls.Add(tb_password2);
            t_signup.Controls.Add(tb_username2);
            t_signup.Controls.Add(tb_lastname);
            t_signup.Controls.Add(tb_name);
            t_signup.Controls.Add(l_password2);
            t_signup.Controls.Add(l_username2);
            t_signup.Controls.Add(l_lastname);
            t_signup.Controls.Add(l_name);
            t_signup.Location = new Point(4, 24);
            t_signup.Name = "t_signup";
            t_signup.Padding = new Padding(3);
            t_signup.Size = new Size(394, 474);
            t_signup.TabIndex = 1;
            t_signup.Text = "Signup";
            t_signup.UseVisualStyleBackColor = true;
            // 
            // l_phonenumber
            // 
            l_phonenumber.Font = new Font("Sitka Subheading", 10F);
            l_phonenumber.Location = new Point(45, 240);
            l_phonenumber.Name = "l_phonenumber";
            l_phonenumber.Size = new Size(110, 23);
            l_phonenumber.TabIndex = 11;
            l_phonenumber.Text = "Phone Number:";
            // 
            // tb_phonenumber
            // 
            tb_phonenumber.Font = new Font("Segoe UI", 10F);
            tb_phonenumber.Location = new Point(158, 240);
            tb_phonenumber.Name = "tb_phonenumber";
            tb_phonenumber.Size = new Size(175, 25);
            tb_phonenumber.TabIndex = 12;
            // 
            // l_or2
            // 
            l_or2.AutoSize = true;
            l_or2.Font = new Font("Sitka Subheading", 10F);
            l_or2.Location = new Point(186, 368);
            l_or2.Name = "l_or2";
            l_or2.Size = new Size(25, 20);
            l_or2.TabIndex = 11;
            l_or2.Text = "Or";
            // 
            // l_getstarted
            // 
            l_getstarted.AutoSize = true;
            l_getstarted.Font = new Font("Aldhabi", 36F, FontStyle.Italic);
            l_getstarted.Location = new Point(107, 18);
            l_getstarted.Name = "l_getstarted";
            l_getstarted.Size = new Size(175, 75);
            l_getstarted.TabIndex = 10;
            l_getstarted.Text = "Get Started";
            // 
            // b_lognin2
            // 
            b_lognin2.BackColor = Color.Black;
            b_lognin2.FlatStyle = FlatStyle.Flat;
            b_lognin2.Font = new Font("Sitka Subheading", 10F);
            b_lognin2.ForeColor = Color.White;
            b_lognin2.Location = new Point(16, 404);
            b_lognin2.Name = "b_lognin2";
            b_lognin2.Size = new Size(360, 52);
            b_lognin2.TabIndex = 9;
            b_lognin2.Text = "Login";
            b_lognin2.UseVisualStyleBackColor = false;
            b_lognin2.Click += b_lognin2_Click;
            // 
            // b_signup2
            // 
            b_signup2.BackColor = Color.FromArgb(255, 192, 192);
            b_signup2.FlatStyle = FlatStyle.Flat;
            b_signup2.Font = new Font("Sitka Subheading", 10F);
            b_signup2.Location = new Point(16, 301);
            b_signup2.Name = "b_signup2";
            b_signup2.Size = new Size(360, 52);
            b_signup2.TabIndex = 8;
            b_signup2.Text = "Signup";
            b_signup2.UseVisualStyleBackColor = false;
            b_signup2.Click += b_signup2_Click;
            // 
            // tb_password2
            // 
            tb_password2.Font = new Font("Segoe UI", 10F);
            tb_password2.Location = new Point(158, 205);
            tb_password2.Name = "tb_password2";
            tb_password2.Size = new Size(175, 25);
            tb_password2.TabIndex = 7;
            tb_password2.Validating += tb_password2_Validating;
            // 
            // tb_username2
            // 
            tb_username2.Font = new Font("Segoe UI", 10F);
            tb_username2.Location = new Point(158, 170);
            tb_username2.Name = "tb_username2";
            tb_username2.Size = new Size(175, 25);
            tb_username2.TabIndex = 6;
            tb_username2.Validating += tb_username2_Validating;
            // 
            // tb_lastname
            // 
            tb_lastname.Font = new Font("Segoe UI", 10F);
            tb_lastname.Location = new Point(158, 135);
            tb_lastname.Name = "tb_lastname";
            tb_lastname.Size = new Size(175, 25);
            tb_lastname.TabIndex = 5;
            tb_lastname.Validating += tb_lastname_Validating;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 10F);
            tb_name.Location = new Point(158, 100);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(175, 25);
            tb_name.TabIndex = 4;
            tb_name.Validating += tb_name_Validating;
            // 
            // l_password2
            // 
            l_password2.Font = new Font("Sitka Subheading", 10F);
            l_password2.Location = new Point(45, 205);
            l_password2.Name = "l_password2";
            l_password2.Size = new Size(100, 23);
            l_password2.TabIndex = 3;
            l_password2.Text = "Password:";
            // 
            // l_username2
            // 
            l_username2.Font = new Font("Sitka Subheading", 10F);
            l_username2.Location = new Point(45, 170);
            l_username2.Name = "l_username2";
            l_username2.Size = new Size(100, 23);
            l_username2.TabIndex = 2;
            l_username2.Text = "Username:";
            // 
            // l_lastname
            // 
            l_lastname.Font = new Font("Sitka Subheading", 10F);
            l_lastname.Location = new Point(45, 135);
            l_lastname.Name = "l_lastname";
            l_lastname.Size = new Size(100, 23);
            l_lastname.TabIndex = 1;
            l_lastname.Text = "Last Name:";
            // 
            // l_name
            // 
            l_name.Font = new Font("Sitka Subheading", 10F);
            l_name.Location = new Point(45, 100);
            l_name.Name = "l_name";
            l_name.Size = new Size(100, 23);
            l_name.TabIndex = 0;
            l_name.Text = "Name:";
            // 
            // t_login
            // 
            t_login.Controls.Add(b_show_password);
            t_login.Controls.Add(tb_username);
            t_login.Controls.Add(tb_password);
            t_login.Controls.Add(b_signup);
            t_login.Controls.Add(b_login);
            t_login.Controls.Add(l_or);
            t_login.Controls.Add(l_password);
            t_login.Controls.Add(l_welcomeback);
            t_login.Controls.Add(l_username);
            t_login.Controls.Add(rb_member);
            t_login.Controls.Add(rb_admin);
            t_login.Location = new Point(4, 24);
            t_login.Name = "t_login";
            t_login.Padding = new Padding(3);
            t_login.Size = new Size(394, 474);
            t_login.TabIndex = 0;
            t_login.Text = "Login";
            t_login.UseVisualStyleBackColor = true;
            // 
            // b_show_password
            // 
            b_show_password.BackColor = Color.White;
            b_show_password.FlatAppearance.BorderColor = Color.White;
            b_show_password.FlatStyle = FlatStyle.Flat;
            b_show_password.Image = icons.openeye;
            b_show_password.Location = new Point(305, 215);
            b_show_password.Name = "b_show_password";
            b_show_password.Size = new Size(26, 23);
            b_show_password.TabIndex = 26;
            b_show_password.UseVisualStyleBackColor = false;
            b_show_password.Click += b_show_password_Click;
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Segoe UI", 10F);
            tb_username.Location = new Point(159, 174);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(175, 25);
            tb_username.TabIndex = 17;
            tb_username.Validating += tb_username_Validating;
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Segoe UI", 10F);
            tb_password.Location = new Point(159, 214);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(175, 25);
            tb_password.TabIndex = 16;
            tb_password.Validating += tb_password_Validating;
            // 
            // b_signup
            // 
            b_signup.BackColor = Color.Black;
            b_signup.FlatStyle = FlatStyle.Flat;
            b_signup.Font = new Font("Sitka Subheading", 10F);
            b_signup.ForeColor = Color.White;
            b_signup.Location = new Point(16, 404);
            b_signup.Name = "b_signup";
            b_signup.Size = new Size(360, 52);
            b_signup.TabIndex = 15;
            b_signup.Text = "Get Started";
            b_signup.UseVisualStyleBackColor = false;
            b_signup.Click += b_signup_Click;
            // 
            // b_login
            // 
            b_login.BackColor = Color.FromArgb(255, 192, 192);
            b_login.FlatStyle = FlatStyle.Flat;
            b_login.Font = new Font("Sitka Subheading", 10F);
            b_login.Location = new Point(16, 301);
            b_login.Name = "b_login";
            b_login.Size = new Size(360, 52);
            b_login.TabIndex = 14;
            b_login.Text = "Login";
            b_login.UseVisualStyleBackColor = false;
            b_login.Click += b_login_Click;
            // 
            // l_or
            // 
            l_or.AutoSize = true;
            l_or.Font = new Font("Sitka Subheading", 10F);
            l_or.Location = new Point(186, 368);
            l_or.Name = "l_or";
            l_or.Size = new Size(25, 20);
            l_or.TabIndex = 25;
            l_or.Text = "Or";
            // 
            // l_password
            // 
            l_password.AutoSize = true;
            l_password.Font = new Font("Sitka Subheading", 10F);
            l_password.Location = new Point(46, 215);
            l_password.Name = "l_password";
            l_password.Size = new Size(73, 20);
            l_password.TabIndex = 24;
            l_password.Text = "Password:";
            // 
            // l_welcomeback
            // 
            l_welcomeback.Font = new Font("Aldhabi", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            l_welcomeback.Location = new Point(84, 18);
            l_welcomeback.Name = "l_welcomeback";
            l_welcomeback.Size = new Size(227, 70);
            l_welcomeback.TabIndex = 23;
            l_welcomeback.Text = "Welcome Back!";
            // 
            // l_username
            // 
            l_username.AutoSize = true;
            l_username.Font = new Font("Sitka Subheading", 10F);
            l_username.Location = new Point(46, 174);
            l_username.Name = "l_username";
            l_username.Size = new Size(77, 20);
            l_username.TabIndex = 22;
            l_username.Text = "Username:";
            // 
            // rb_member
            // 
            rb_member.AutoSize = true;
            rb_member.Checked = true;
            rb_member.Font = new Font("Sitka Subheading", 10F);
            rb_member.Location = new Point(84, 110);
            rb_member.Name = "rb_member";
            rb_member.Size = new Size(79, 24);
            rb_member.TabIndex = 21;
            rb_member.TabStop = true;
            rb_member.Text = "Member";
            rb_member.UseVisualStyleBackColor = true;
            rb_member.CheckedChanged += rb_member_CheckedChanged;
            // 
            // rb_admin
            // 
            rb_admin.AutoSize = true;
            rb_admin.Font = new Font("Sitka Subheading", 10F);
            rb_admin.Location = new Point(243, 110);
            rb_admin.Name = "rb_admin";
            rb_admin.Size = new Size(68, 24);
            rb_admin.TabIndex = 20;
            rb_admin.Text = "Admin";
            rb_admin.UseVisualStyleBackColor = true;
            rb_admin.CheckedChanged += rb_admin_CheckedChanged;
            // 
            // tabcontrol
            // 
            tabcontrol.Controls.Add(t_login);
            tabcontrol.Controls.Add(t_signup);
            tabcontrol.Location = new Point(0, -21);
            tabcontrol.Name = "tabcontrol";
            tabcontrol.SelectedIndex = 0;
            tabcontrol.Size = new Size(402, 502);
            tabcontrol.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 478);
            Controls.Add(tabcontrol);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            t_signup.ResumeLayout(false);
            t_signup.PerformLayout();
            t_login.ResumeLayout(false);
            t_login.PerformLayout();
            tabcontrol.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider1;
        private TabControl tabcontrol;
        private TabPage t_login;
        private Button b_show_password;
        private TextBox tb_username;
        private TextBox tb_password;
        private Button b_signup;
        private Button b_login;
        private Label l_or;
        private Label l_password;
        private Label l_welcomeback;
        private Label l_username;
        private RadioButton rb_member;
        private RadioButton rb_admin;
        private TabPage t_signup;
        private Label l_or2;
        private Label l_getstarted;
        private Button b_lognin2;
        private Button b_signup2;
        private TextBox tb_password2;
        private TextBox tb_username2;
        private TextBox tb_lastname;
        private TextBox tb_name;
        private Label l_password2;
        private Label l_username2;
        private Label l_lastname;
        private Label l_name;
        private TextBox tb_phonenumber;
        private Label l_phonenumber;
    }
}
