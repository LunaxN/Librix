namespace Librix
{
    public partial class Login : Form
    {
        private bool show_password_clicked = true;

        public Login()
        {
        InitializeComponent();
        }
        private void b_show_password_Click(object sender, EventArgs e)
        {
            if (show_password_clicked)
            {
                b_show_password.Image = icons.openeye;
                tb_password.PasswordChar = '\0';
            }
            else
            {
                b_show_password.Image = icons.closedeye;
                tb_password.PasswordChar = '*';
            }
            show_password_clicked = !show_password_clicked;
        }

        private void rb_admin_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_admin.Checked == true)
            {
                l_or.Visible = false;
                b_signup.Visible = false;
                this.Size = new Size(414, 415);
            }
        }

        private void rb_member_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_member.Checked == true)
            {
                l_or.Visible = true;
                b_signup.Visible = true;
                this.Size = new Size(414, 505);
            }
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedIndex = 0;
        }

        private void b_signup_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedIndex = 1;
        }

    }
}
