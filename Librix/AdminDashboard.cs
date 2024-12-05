using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librix
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void showMembers()
        {
            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetAdminDbConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT MembershipID, FirstName, LastName, PhoneNumber, AccountBalance, CreatedAt From Members", connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_members.DataSource = dataTable;
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

        private void b_dashboard_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void b_books_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void b_bookLoan_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void b_members_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
            showMembers();
        }

        private void b_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confrim Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void b_addMember_Click(object sender, EventArgs e)
        {
            AddMember add = new AddMember();
            add.Show();
            if (add.ShowDialog() == DialogResult.OK)
            {
                showMembers();
            }
        }

        private void b_deleteMember_Click(object sender, EventArgs e)
        {
            if (dgv_members.SelectedRows.Count > 0) 
            {
                foreach (DataGridViewRow row in dgv_members.SelectedRows) 
                {
                    int membershipID = Convert.ToInt32(row.Cells["MembershipID"].Value);
                    DatabaseManager dbManger = new DatabaseManager();
                    using (SqlConnection connection = new SqlConnection(dbManger.GetAdminDbConnectionString()))
                    {
                        SqlCommand command = new SqlCommand("DELETE * FROM Members WHERE MembershipID = @membershipID", connection);
                        command.Parameters.AddWithValue("@membershipID", membershipID);
                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0) 
                            {
                                MessageBox.Show("Member(s) deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                showMembers();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete member(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            }
        }

        private void b_addMember_MouseHover(object sender, EventArgs e)
        {
            l_addMember.Visible = true;
        }

        private void b_deleteMember_MouseHover(object sender, EventArgs e)
        {
            l_deleteMember.Visible = true;
        }

        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                DatabaseManager dbManager = new DatabaseManager();
                using (SqlConnection connection = new SqlConnection(dbManager.GetAdminDbConnectionString()))
                {
                    SqlCommand command = new SqlCommand("SELECT MembershipID, FirstName, LastName, PhoneNumber, AccountBalance, CreatedAt FROM Members WHERE MembershipID = @searchTerm OR (FirstName + ' ' + LastName) LIKE '%' + @searchTerm + '%'", connection);
                    command.Parameters.AddWithValue("@searchTerm", tb_search.Text);
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable searchResult = new DataTable();
                        adapter.Fill(searchResult);
                        if (searchResult.Rows.Count > 0)
                        {
                            dgv_members.DataSource = searchResult;
                            b_resetMembers.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Member not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void b_resetMembers_Click(object sender, EventArgs e)
        {
            showMembers();
            tb_search.Clear();
        }

        private void b_editMember_MouseHover(object sender, EventArgs e)
        {
            l_editMember.Visible = true;
        }

        private void b_editMember_Click(object sender, EventArgs e)
        {
            if (dgv_members.SelectedRows.Count == 1) 
            {
                DataGridViewRow selectedRow = dgv_members.SelectedRows[0];
                EditMember edit = new EditMember();
                edit.Show();
                edit.RecordID = selectedRow.Cells["MembershipID"].Value.ToString();
                edit.RecordFirstName = selectedRow.Cells["FirstName"].Value.ToString();
                edit.RecordLastName = selectedRow.Cells["LastName"].Value.ToString();
                edit.RecordPhoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();
                if (edit.ShowDialog() == DialogResult.OK) 
                {
                    DatabaseManager dbManager = new DatabaseManager();
                    using (SqlConnection connection = new SqlConnection(dbManager.GetAdminDbConnectionString()))
                    {
                        SqlCommand command = new SqlCommand("UPDATE Members SET FirstName = @firstName, LastName = @lastName, PhonenNumber = @phoneNumber WHERE MembershipID = @membershipID", connection);
                        command.Parameters.AddWithValue("@firstName", edit.RecordFirstName);
                        command.Parameters.AddWithValue("@lastName", edit.RecordLastName);
                        command.Parameters.AddWithValue("@phoneNumber", edit.RecordPhoneNumber);
                        command.Parameters.AddWithValue("@membershipID", edit.RecordID);
                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected == 1) 
                            {
                                MessageBox.Show("Member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                showMembers();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            }
            else
            {
                MessageBox.Show("Please select one record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}