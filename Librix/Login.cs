using System.Data.SqlClient;

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
                b_show_password.Image = icons.closedeye;
                tb_password.PasswordChar = '\0';
            }
            else
            {
                b_show_password.Image = icons.openeye;
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
            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetAdminDbConnectionString()))
            {
                SqlCommand command = new SqlCommand(rb_admin.Checked ?
                                                      "SELECT * FROM Admins WHERE Username = @username AND Password = @password"
                                                    : "SELECT * FROM Members WHERE Username = @username AND Password = @password"
                                                    , connection);
                command.Parameters.AddWithValue("@username", tb_username.Text);
                command.Parameters.AddWithValue("@password", tb_password.Text);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (rb_admin.Checked)
                            {
                                AdminDashboard dashboard = new AdminDashboard();
                                dashboard.Show();
                                this.Hide();
                            }
                            else if (rb_member.Checked)
                            {
                                MemberDashboard dashboard = new MemberDashboard();
                                dashboard.Show();
                                this.Hide();
                            }

                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void b_signup_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedIndex = 1;
        }

        private void b_signup2_Click(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetAdminDbConnectionString()))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Members (FirstName, LastName, AccountBalance, CreatedAt, Username, Password, PhoneNumber) VALUES (@firstName, @lastName, @accountBalance, GETDATE(), @username, @password, @phoneNumber)", connection);
                command.Parameters.AddWithValue("@firstName", tb_name.Text);
                command.Parameters.AddWithValue("@lastName", tb_lastname.Text);
                command.Parameters.AddWithValue("@accountBalance", 0.00);
                command.Parameters.AddWithValue("@username", tb_username2.Text);
                command.Parameters.AddWithValue("@password", tb_password2.Text);
                command.Parameters.AddWithValue("@phoneNumber", tb_phonenumber.Text);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); // Use ExecuteNonQuery for INSERT
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    connection.Close();
                }
            }
        }

        private void b_lognin2_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedIndex = 0;
        }

        private void tb_name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_name.Text == string.Empty)
            {
                errorProvider1.SetError(tb_name, "Please Enter Name");
            }
        }

        private void tb_lastname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_lastname.Text == string.Empty)
            {
                errorProvider1.SetError(tb_lastname, "Please Enter Last Name");
            }
        }

        private void tb_username2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_username2.Text == string.Empty)
            {
                errorProvider1.SetError(tb_username2, "Please Enter Username");
            }
        }

        private void tb_password2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_password2.Text == string.Empty)
            {
                errorProvider1.SetError(tb_password2, "Please Enter Password");
            }
        }

        private void tb_username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_username.Text == string.Empty)
            {
                errorProvider1.SetError(tb_username, "Please Enter Username");
            }
        }

        private void tb_password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_password.Text == string.Empty)
            {
                errorProvider1.SetError(tb_password, "Please Enter Password");
            }
        }

        private void tb_phonenumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_phonenumber.Text == string.Empty)
            {
                errorProvider1.SetError(tb_phonenumber, "Please Enter Phone Number");
            }
        }
    }
}