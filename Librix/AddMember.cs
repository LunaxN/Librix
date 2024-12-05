using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librix
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetAdminDbConnectionString()))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Members (FirstName, LastName, AccountBalance, CreatedAt, Username, Password, PhoneNumber) VALUES (@firstName, @lastName, @accountBalance, GETDATE(), @username, @password, @phoneNumber)", connection);
                command.Parameters.AddWithValue("@firstName", tb_name.Text);
                command.Parameters.AddWithValue("@lastName", tb_lastname.Text);
                command.Parameters.AddWithValue("@accountBalance", 0.00);
                command.Parameters.AddWithValue("@username", tb_name.Text + tb_lastname.Text);
                command.Parameters.AddWithValue("@password", tb_phonenumber.Text);
                command.Parameters.AddWithValue("@phoneNumber", tb_phonenumber.Text);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); // Use ExecuteNonQuery for INSERT
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
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
            }
        }

        private void tb_name_Validating(object sender, CancelEventArgs e)
        {
            if (tb_name.Text == string.Empty)
            {
                errorProvider1.SetError(tb_name, "Please Enter Name");
            }
        }

        private void tb_lastname_Validating(object sender, CancelEventArgs e)
        {
            if (tb_lastname.Text == string.Empty)
            {
                errorProvider1.SetError(tb_lastname, "Please Enter Last Name");
            }
        }

        private void tb_phonenumber_Validating(object sender, CancelEventArgs e)
        {
            if (tb_phonenumber.Text == string.Empty)
            {
                errorProvider1.SetError(tb_phonenumber, "Please Enter Phone Number");
            }
        }
    }
}
