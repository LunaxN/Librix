using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Reflection.Metadata.BlobBuilder;

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
            using (SqlConnection connection = new SqlConnection(dbManager.GetUsersDbConnectionString()))
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

        private void showBooks()
        {
            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Books", connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_books.DataSource = dataTable;
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
            showBooks();
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
            AddMember addMember = new AddMember();
            if (addMember.ShowDialog() == DialogResult.OK)
            {
                showMembers();
            }
        }

        private void b_deleteMember_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgv_members.SelectedRows.Count;

            DialogResult result = MessageBox.Show(
                String.Format("You are about to delete {0} row(s).\n\n Click Yes to permanently delete those rows. You won't be able to undo those changes", selectedRowCount),
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                if (selectedRowCount > 0)
                {
                    DatabaseManager dbManager = new DatabaseManager();
                    using (SqlConnection connection = new SqlConnection(dbManager.GetUsersDbConnectionString()))
                    {
                        connection.Open();
                        foreach (DataGridViewRow row in dgv_members.SelectedRows)
                        {
                            try
                            {
                                int membershipId = Convert.ToInt32(row.Cells["MembershipID"].Value);
                                SqlCommand command = new SqlCommand("DELETE FROM Members WHERE MembershipID = @membershipID", connection);
                                command.Parameters.AddWithValue("@membershipID", membershipId);
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
                else
                {
                    MessageBox.Show("Please select at least one record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tb_searchMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                DatabaseManager dbManager = new DatabaseManager();
                using (SqlConnection connection = new SqlConnection(dbManager.GetUsersDbConnectionString()))
                {
                    SqlCommand command = new SqlCommand("SELECT MembershipID, FirstName, LastName, PhoneNumber, AccountBalance, CreatedAt FROM Members WHERE MembershipID = @membershipId OR (FirstName + ' ' + LastName) LIKE @fullName", connection);

                    int membershipId;
                    if (int.TryParse(tb_searchMember.Text, out membershipId))
                    {
                        command.Parameters.AddWithValue("@membershipId", membershipId);
                        command.Parameters.AddWithValue("@fullName", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@membershipId", DBNull.Value);
                        command.Parameters.AddWithValue("@fullName", "%" + tb_searchMember.Text + "%");
                    }

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
            tb_searchMember.Clear();
        }

        private void b_editMember_Click(object sender, EventArgs e)
        {
            if (dgv_members.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_members.SelectedRows[0];
                EditMember editMember = new EditMember();
                editMember.RecordID = selectedRow.Cells["MembershipID"].Value.ToString();
                editMember.RecordFirstName = selectedRow.Cells["FirstName"].Value.ToString();
                editMember.RecordLastName = selectedRow.Cells["LastName"].Value.ToString();
                editMember.RecordPhoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();

                if (editMember.ShowDialog() == DialogResult.OK)
                {
                    DatabaseManager dbManager = new DatabaseManager();
                    using (SqlConnection connection = new SqlConnection(dbManager.GetUsersDbConnectionString()))
                    {
                        SqlCommand command = new SqlCommand("UPDATE Members SET FirstName = @firstName, LastName = @lastName, PhoneNumber = @phoneNumber WHERE MembershipID = @membershipID", connection);
                        command.Parameters.AddWithValue("@firstName", editMember.RecordFirstName);
                        command.Parameters.AddWithValue("@lastName", editMember.RecordLastName);
                        command.Parameters.AddWithValue("@phoneNumber", editMember.RecordPhoneNumber);
                        command.Parameters.AddWithValue("@membershipID", editMember.RecordID);

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

        private void b_addMember_MouseHover(object sender, EventArgs e)
        {
            l_addMember.Visible = true;
        }

        private void b_deleteMember_MouseHover(object sender, EventArgs e)
        {
            l_deleteMember.Visible = true;
        }

        private void b_editMember_MouseHover(object sender, EventArgs e)
        {
            l_editMember.Visible = true;
        }

        private void b_editMember_MouseLeave(object sender, EventArgs e)
        {
            l_editMember.Visible = false;
        }

        private void b_deleteMember_MouseLeave(object sender, EventArgs e)
        {
            l_deleteMember.Visible = false;
        }

        private void b_addMember_MouseLeave(object sender, EventArgs e)
        {
            l_addMember.Visible = false;
        }

        private void b_addBook_MouseHover(object sender, EventArgs e)
        {
            l_addBook.Visible = true;
        }

        private void b_deleteBook_MouseHover(object sender, EventArgs e)
        {
            l_deleteBook.Visible = true;
        }

        private void b_editBook_MouseHover(object sender, EventArgs e)
        {
            l_editBook.Visible = true;
        }

        private void b_addBook_MouseLeave(object sender, EventArgs e)
        {
            l_addBook.Visible = false;
        }

        private void b_deleteBook_MouseLeave(object sender, EventArgs e)
        {
            l_deleteBook.Visible = false;
        }

        private void b_editBook_MouseLeave(object sender, EventArgs e)
        {
            l_editBook.Visible = false;
        }

        private void b_resetBooks_Click(object sender, EventArgs e)
        {
            showBooks();
            tb_searchBook.Clear();
        }

        private void b_addBook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            if (addBook.ShowDialog() == DialogResult.OK)
            {
                showBooks();
            }
        }

        private void b_editBook_Click(object sender, EventArgs e)
        {
            if (dgv_books.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_books.SelectedRows[0];
                EditBook editBook = new EditBook();
                editBook.RecordID = selectedRow.Cells["BookID"].Value.ToString();
                editBook.RecordTitle = selectedRow.Cells["Title"].Value.ToString();
                editBook.RecordAuthors = selectedRow.Cells["Authors"].Value.ToString();
                editBook.RecordEdition = selectedRow.Cells["Edition"].Value.ToString();
                editBook.RecordPublishDate = selectedRow.Cells["PublishDate"].Value.ToString();
                editBook.RecordGenres = selectedRow.Cells["Genres"].Value.ToString();
                editBook.RecordTotalCopies = selectedRow.Cells["NoOfTotalCopies"].Value.ToString();

                if (editBook.ShowDialog() == DialogResult.OK)
                {
                    DatabaseManager dbManager = new DatabaseManager();
                    using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
                    {
                        SqlCommand command = new SqlCommand("UPDATE Books SET Title = @title, Authors = @authors, Edition = @edition, PublishDate = @publishDate, Genres = @genres, NoOfTotalCopies = @noOfTotalCopies WHERE BookID = @bookID", connection);
                        command.Parameters.AddWithValue("@title", editBook.RecordTitle);
                        command.Parameters.AddWithValue("@authors", editBook.RecordAuthors);
                        command.Parameters.AddWithValue("@edition", editBook.RecordEdition);
                        command.Parameters.AddWithValue("@publishDate", editBook.RecordPublishDate);
                        command.Parameters.AddWithValue("@genres", editBook.RecordGenres);
                        command.Parameters.AddWithValue("@bookID", editBook.RecordID);
                        command.Parameters.AddWithValue("@noOfTotalCopies", editBook.RecordTotalCopies);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected == 1)
                            {
                                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                showBooks();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void tb_searchBook_Click(object sender, EventArgs e)
        {
            tb_searchBook.Clear();
            tb_searchBook.ForeColor = Color.Black;
        }

        private void tb_searchMember_Click(object sender, EventArgs e)
        {
            tb_searchMember.Clear();
            tb_searchMember.ForeColor = Color.Black;
        }

        private void tb_searchBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                DatabaseManager dbManager = new DatabaseManager();
                using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE BookID = @bookId OR Title LIKE @title", connection);

                    int bookId;
                    if (int.TryParse(tb_searchBook.Text, out bookId))
                    {
                        command.Parameters.AddWithValue("@bookId", bookId);
                        command.Parameters.AddWithValue("@title", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@bookId", DBNull.Value);
                        command.Parameters.AddWithValue("@title", "%" + tb_searchBook.Text + "%");
                    }

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable searchResult = new DataTable();
                        adapter.Fill(searchResult);
                        if (searchResult.Rows.Count > 0)
                        {
                            dgv_books.DataSource = searchResult;
                            b_resetBooks.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void b_deleteBook_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgv_books.SelectedRows.Count;

            DialogResult result = MessageBox.Show(
                String.Format("You are about to delete {0} row(s).\n\n Click Yes to permanently delete those rows. You won't be able to undo those changes", selectedRowCount),
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                if (selectedRowCount > 0)
                {
                    DatabaseManager dbManager = new DatabaseManager();
                    using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
                    {
                        connection.Open();
                        foreach (DataGridViewRow row in dgv_books.SelectedRows)
                        {
                            try
                            {
                                int bookID = Convert.ToInt32(row.Cells["BookID"].Value);
                                SqlCommand command = new SqlCommand("DELETE FROM Books WHERE BookID = @bookID", connection);
                                command.Parameters.AddWithValue("@bookID", bookID);
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Book(s) deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    showBooks();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to delete book(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Please select at least one record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}