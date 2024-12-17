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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Librix
{
    public partial class AdminDashboard : Form
    {
        private int user_id;
        public AdminDashboard(int user_id)
        {
            InitializeComponent();
            showCurrentDate();
            showTotalMembers();
            showTotalBorrowed();
            showReturnedToday();
            showNewReserves();
            this.user_id = user_id;
        }

        private void showCurrentDate()
        {
            DateTime today = DateTime.Now;
            l_currentDate.Text = today.ToString("dddd, yyyy MMMM dd");
        }

        private void showTotalMembers()
        {
            int recordCount = 0;

            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetUsersDbConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Members", connection))
                    {
                        recordCount = (int)command.ExecuteScalar();
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
            l_noTotalMembers.Text = recordCount.ToString();
        }

        private void showTotalBorrowed()
        {
            int recordCount = 0;

            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Borrowed WHERE Status = @status", connection))
                    {
                        command.Parameters.AddWithValue("@status", "Borrowed");
                        recordCount = (int)command.ExecuteScalar();
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
            l_noTotalBorrowed.Text = recordCount.ToString();
        }

        private void showReturnedToday()
        {
            int recordCount = 0;

            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Borrowed WHERE CAST(ReturnDate AS DATE) = @returnDate AND Status = @status", connection))
                    {
                        command.Parameters.AddWithValue("@returnDate", DateTime.Today);
                        command.Parameters.AddWithValue("@status", "Borrowed");
                        recordCount = (int)command.ExecuteScalar();
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
            l_noReturnedToday.Text = recordCount.ToString();
        }

        private void showNewReserves()
        {
            int recordCount = 0;

            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Reserved WHERE CAST(ReservationDate AS DATE) = @reservationDate", connection))
                    {
                        command.Parameters.AddWithValue("@reservationDate", DateTime.Today);
                        recordCount = (int)command.ExecuteScalar();
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
            l_noNewReserves.Text = recordCount.ToString();
        }

        private void b_dashboard_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
            showCurrentDate();
            showTotalMembers();
            showTotalBorrowed();
            showReturnedToday();
            showNewReserves();
        }

        private void b_books_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            showBooks();
            tb_searchBook.Clear();
            tb_searchBook.Text = "Search for a book...";
            tb_searchBook.ForeColor = Color.Gray;
            b_resetBooks.Visible = false;
        }

        private void b_borrowed_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
            showBorrowed();
            tb_searchBorrow.Clear();
            tb_searchBorrow.Text = "Search for a borrowed book...";
            tb_searchBorrow.ForeColor = Color.Gray;
            b_resetBorrowed.Visible = false;
        }

        private void b_members_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
            showMembers();
            tb_searchMember.Clear();
            tb_searchMember.Text = "Search for a member...";
            tb_searchMember.ForeColor = Color.Gray;
            b_resetMembers.Visible = false;
        }

        private void b_reserved_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
            showReserved();
            tb_searchReserve.Clear();
            tb_searchReserve.Text = "Search for a reserved book...";
            tb_searchReserve.ForeColor = Color.Gray;
            b_resetReserved.Visible = false;
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
                    dgv_members.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
                    dgv_books.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

        private void showBorrowed()
        {
            DatabaseManager dbManger = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManger.GetItemsDbConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Borrowed", connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_borrowed.DataSource = dataTable;
                    dgv_borrowed.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

        private void showReserved()
        {
            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Reserved", connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_reserved.DataSource = dataTable;
                    dgv_reserved.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
            if (selectedRowCount > 0)
            {
                DialogResult result = MessageBox.Show(
                String.Format("You are about to delete {0} row(s).\n\n Click Yes to permanently delete those rows. You won't be able to undo those changes", selectedRowCount),
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
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
                                if (rowsAffected <= 0)
                                {
                                    MessageBox.Show("Failed to delete member(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        showMembers();
                        MessageBox.Show("Member(s) deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select at least one record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void tb_searchMember_Click(object sender, EventArgs e)
        {
            tb_searchMember.Clear();
            tb_searchMember.ForeColor = Color.Black;
        }

        private void b_resetMembers_Click(object sender, EventArgs e)
        {
            showMembers();
            tb_searchMember.Clear();
            tb_searchMember.Text = "Search for a member...";
            tb_searchMember.ForeColor = Color.Gray;
        }

        private void b_addMember_MouseHover(object sender, EventArgs e)
        {
            l_addMember.Visible = true;
        }

        private void b_addMember_MouseLeave(object sender, EventArgs e)
        {
            l_addMember.Visible = false;
        }

        private void b_deleteMember_MouseHover(object sender, EventArgs e)
        {
            l_deleteMember.Visible = true;
        }

        private void b_deleteMember_MouseLeave(object sender, EventArgs e)
        {
            l_deleteMember.Visible = false;
        }

        private void b_editMember_MouseHover(object sender, EventArgs e)
        {
            l_editMember.Visible = true;
        }

        private void b_editMember_MouseLeave(object sender, EventArgs e)
        {
            l_editMember.Visible = false;
        }

        private void b_addBook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            if (addBook.ShowDialog() == DialogResult.OK)
            {
                showBooks();
            }
        }

        private void b_deleteBook_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgv_books.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                DialogResult result = MessageBox.Show(
                String.Format("You are about to delete {0} row(s).\n\n Click Yes to permanently delete those rows. You won't be able to undo those changes", selectedRowCount),
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
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
                                if (rowsAffected <= 0)
                                {
                                    MessageBox.Show("Failed to delete book(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        showBooks();
                        MessageBox.Show("Book(s) deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select at least one record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void tb_searchBook_Click(object sender, EventArgs e)
        {
            tb_searchBook.Clear();
            tb_searchBook.ForeColor = Color.Black;
        }

        private void b_resetBooks_Click(object sender, EventArgs e)
        {
            showBooks();
            tb_searchBook.Clear();
            tb_searchBook.Text = "Search for a book...";
            tb_searchBook.ForeColor = Color.Gray;
        }

        private void b_addBook_MouseHover(object sender, EventArgs e)
        {
            l_addBook.Visible = true;
        }

        private void b_addBook_MouseLeave(object sender, EventArgs e)
        {
            l_addBook.Visible = false;
        }

        private void b_deleteBook_MouseHover(object sender, EventArgs e)
        {
            l_deleteBook.Visible = true;
        }

        private void b_deleteBook_MouseLeave(object sender, EventArgs e)
        {
            l_deleteBook.Visible = false;
        }

        private void b_editBook_MouseHover(object sender, EventArgs e)
        {
            l_editBook.Visible = true;
        }

        private void b_editBook_MouseLeave(object sender, EventArgs e)
        {
            l_editBook.Visible = false;
        }

        private void tb_searchBorrow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                DatabaseManager dbManager = new DatabaseManager();
                using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Borrowed WHERE BorrowedID = @borrowedID", connection);
                    command.Parameters.AddWithValue("@borrowedID", tb_searchBorrow.Text);

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable searchResult = new DataTable();
                        adapter.Fill(searchResult);
                        if (searchResult.Rows.Count > 0)
                        {
                            dgv_borrowed.DataSource = searchResult;
                            b_resetBorrowed.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Borrowed book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void tb_searchBorrow_Click(object sender, EventArgs e)
        {
            tb_searchBorrow.Clear();
            tb_searchBorrow.ForeColor = Color.Black;
        }

        private void b_resetBorrowed_Click(object sender, EventArgs e)
        {
            showBorrowed();
            tb_searchBorrow.Clear();
            tb_searchBorrow.Text = "Search for a borrowed book...";
            tb_searchBorrow.ForeColor = Color.Gray;
        }

        private void tb_searchReserve_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                DatabaseManager dbManager = new DatabaseManager();
                using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Reserved WHERE ReservationID = @reservationID OR Title LIKE @title", connection);

                    int reservationId;
                    if (int.TryParse(tb_searchReserve.Text, out reservationId))
                    {
                        command.Parameters.AddWithValue("@reservationID", reservationId);
                        command.Parameters.AddWithValue("@title", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@reservationID", DBNull.Value);
                        command.Parameters.AddWithValue("@title", "%" + tb_searchReserve.Text + "%");
                    }

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable searchResult = new DataTable();
                        adapter.Fill(searchResult);
                        if (searchResult.Rows.Count > 0)
                        {
                            dgv_reserved.DataSource = searchResult;
                            b_resetReserved.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Reserve not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void tb_searchReserve_Click(object sender, EventArgs e)
        {
            tb_searchReserve.Clear();
            tb_searchReserve.ForeColor = Color.Black;
        }

        private void b_resetReserved_Click(object sender, EventArgs e)
        {
            showReserved();
            tb_searchReserve.Clear();
            tb_searchReserve.Text = "Search for a reserved book...";
            tb_searchReserve.ForeColor = Color.Gray;
        }

        private void b_borrowe_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgv_reserved.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                StringBuilder titles = new StringBuilder();
                foreach (DataGridViewRow row in dgv_reserved.SelectedRows)
                {
                    string title_val = row.Cells["Title"].Value.ToString();
                    titles.AppendLine(title_val);
                }

                DialogResult result = MessageBox.Show(
                    String.Format("You are about to unreserve the following items:\n{0}Are you sure?", titles.ToString()),
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    DatabaseManager dbManager = new DatabaseManager();
                    using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
                    {
                        connection.Open();
                        foreach (DataGridViewRow row in dgv_reserved.SelectedRows)
                        {
                            try
                            {
                                int reservationID = Convert.ToInt32(row.Cells["ReservationID"].Value);

                                using (SqlCommand command = new SqlCommand("SELECT * FROM Reserved WHERE ReservationID = @reservationID", connection))
                                {
                                    command.Parameters.AddWithValue("@reservationID", reservationID);

                                    using (SqlDataReader reader = command.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            int bookID = Convert.ToInt32(reader["BookID"]);
                                            int membershipID = Convert.ToInt32(reader["MembershipID"]);
                                            reader.Close();

                                            using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Borrowed (BookID, MembershipID, BorrowDate, ReturnDate, Status, Fine) VALUES (@bookID, @membershipID, GETDATE(), @returnDate, @status, @fine)", connection))
                                            {
                                                insertCommand.Parameters.AddWithValue("@bookID", bookID);
                                                insertCommand.Parameters.AddWithValue("@membershipID", membershipID);
                                                insertCommand.Parameters.AddWithValue("@returnDate", DateTime.Now.AddDays(14));
                                                insertCommand.Parameters.AddWithValue("@status", "Borrowed");
                                                insertCommand.Parameters.AddWithValue("@fine", 0.00);

                                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                                if (rowsAffected > 0)
                                                {
                                                    using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM Reserved WHERE ReservationID = @reservationID", connection))
                                                    {
                                                        deleteCommand.Parameters.AddWithValue("@reservationID", reservationID);
                                                        deleteCommand.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Failed to borrow book(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        showReserved();
                        MessageBox.Show("Book(s) borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select at least one record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_returned_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgv_borrowed.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                DialogResult result = MessageBox.Show(
                    String.Format("You are about to returned back {0} book(s). Are you sure?", selectedRowCount),
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    DatabaseManager dbManager = new DatabaseManager();
                    using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
                    {
                        connection.Open();
                        foreach (DataGridViewRow row in dgv_borrowed.SelectedRows)
                        {
                            try
                            {
                                int borrowedID = Convert.ToInt32(row.Cells["BorrowedID"].Value);

                                using (SqlCommand command = new SqlCommand("SELECT * FROM Borrowed WHERE BorrowedID = @borrowedID", connection))
                                {
                                    command.Parameters.AddWithValue("@borrowedID", borrowedID);

                                    using (SqlDataReader reader = command.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            int bookID = Convert.ToInt32(reader["BookID"]);
                                            reader.Close();

                                            using (SqlCommand updateBorrowedCommand = new SqlCommand("UPDATE Borrowed SET Status = @newStatus, ReturnDate = GETDATE() WHERE BorrowedID = @borrowedID AND Status = @status", connection))
                                            {
                                                updateBorrowedCommand.Parameters.AddWithValue("@newStatus", "Returned Back");
                                                updateBorrowedCommand.Parameters.AddWithValue("@borrowedID", borrowedID);
                                                updateBorrowedCommand.Parameters.AddWithValue("@status", "Borrowed");

                                                int rowsAffected = updateBorrowedCommand.ExecuteNonQuery();
                                                if (rowsAffected > 0)
                                                {
                                                    using (SqlCommand updateBooksCommand = new SqlCommand("UPDATE Books SET NoOfAvailableCopies = NoOfAvailableCopies + 1, Availability = CASE WHEN NoOfAvailableCopies >= 0 THEN 'Available' ELSE 'Not Available' END WHERE BookID = @BookID", connection))
                                                    {
                                                        updateBooksCommand.Parameters.AddWithValue("@bookID", bookID);
                                                        updateBooksCommand.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Failed to return back book(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        showBorrowed();
                        MessageBox.Show("Book(s) returned back successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select at least one record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_profile_Click(object sender, EventArgs e)
        {
            b_profile.Visible = false;
            p_userInforamtion.Visible = true;
            p_userInforamtion.Location = new System.Drawing.Point(0, 50);

            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetUsersDbConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Members WHERE MembershipID = @membershipID", connection))
                    {
                        command.Parameters.AddWithValue("@membershipID", user_id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tb_username.Text = reader["Username"].ToString();
                                reader.Close();
                            }
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

        private void b_save_Click(object sender, EventArgs e)
        {
            p_userInforamtion.Location = new System.Drawing.Point(0, 98);
            p_userInforamtion.Visible = false;
            b_profile.Visible = true;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            p_userInforamtion.Location = new System.Drawing.Point(0, 98);
            p_userInforamtion.Visible = false;
            b_profile.Visible = true;
        }

        private void tb_username_Validating(object sender, CancelEventArgs e)
        {
            if (tb_username.Text == string.Empty)
            {
                errorProvider1.SetError(tb_username, "This field cannot be empty");
            }
        }

        private void tb_password_Validating(object sender, CancelEventArgs e)
        {
            if (tb_username.Text == string.Empty)
            {
                errorProvider1.SetError(tb_password, "This field cannot be empty");
            }
        }
    }
}