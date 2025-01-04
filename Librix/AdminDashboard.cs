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
        private bool track = true;

        public AdminDashboard(int user_id)
        {
            InitializeComponent();
            showCurrentDate();
            showTotalMembers();
            showTotalBorrowed();
            showReturnedToday();
            showNewReserves();
            showNewReservesFromDate();
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
            l_numberTotalMembers.Text = recordCount.ToString();
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
            l_numberTotalBorrowed.Text = recordCount.ToString();
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
            l_numberNewReserves.Text = recordCount.ToString();
        }

        private void showNewReservesFromDate()
        {
            DateTime today = DateTime.Now;
            l_fromDate.Text = $"From {today.ToString("dddd, yyyy MMMM dd")}";
        }

        private void b_dashboard_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
            p_userInforamtion.Location = new System.Drawing.Point(0, 98);
            p_userInforamtion.Visible = false;
            b_profile.Visible = true;
            showCurrentDate();
            showTotalMembers();
            showTotalBorrowed();
            showReturnedToday();
            showNewReserves();
            showNewReservesFromDate();
        }

        private void b_books_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            showBooks();
            tb_searchBook.Clear();
            tb_searchBook.Text = "Search for a book...";
            tb_searchBook.ForeColor = Color.Gray;
            b_resetBooks.Visible = false;
            tb_membershipID.Visible = false;
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
            b_resetMembers.Visible = false;
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
            b_resetBooks.Visible = false;
        }

        private void showBorrowed()
        {
            DatabaseManager dbManger = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManger.GetItemsDbConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT BorrowedID, BookID, MembershipID, Title, Authors, Edition, BorrowDate, ReturnDate, Status, Fine FROM Borrowed", connection);
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
            b_resetBorrowed.Visible = false;
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
            b_resetReserved.Visible = false;
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
                    SqlCommand command = new SqlCommand("SELECT BorrowedID, BookID, MembershipID, Title, Authors, Edition, BorrowDate, ReturnDate, Status, Fine FROM Borrowed WHERE BorrowedID = @borrowedID OR Title LIKE @title", connection);

                    int borrowedId;
                    if (int.TryParse(tb_searchBorrow.Text, out borrowedId))
                    {
                        command.Parameters.AddWithValue("@borrowedId", borrowedId);
                        command.Parameters.AddWithValue("@title", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@borrowedId", DBNull.Value);
                        command.Parameters.AddWithValue("@title", "%" + tb_searchBorrow.Text + "%");
                    }

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

        private void b_returned_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgv_borrowed.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                DialogResult result = MessageBox.Show(
                    String.Format("You are about to return {0} book(s). Are you sure?", selectedRowCount),
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    DatabaseManager dbManager = new DatabaseManager();
                    using (SqlConnection itemsConnection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
                    {
                        itemsConnection.Open();
                        using (SqlConnection usersConnection = new SqlConnection(dbManager.GetUsersDbConnectionString()))
                        {
                            usersConnection.Open();

                            foreach (DataGridViewRow row in dgv_borrowed.SelectedRows)
                            {
                                try
                                {
                                    int borrowedID = Convert.ToInt32(row.Cells["BorrowedID"].Value);

                                    using (SqlCommand fineCommand = new SqlCommand("SELECT Fine, MembershipID FROM Borrowed WHERE BorrowedID = @borrowedID", itemsConnection))
                                    {
                                        fineCommand.Parameters.AddWithValue("@borrowedID", borrowedID);
                                        using (SqlDataReader reader = fineCommand.ExecuteReader())
                                        {
                                            if (reader.Read())
                                            {
                                                int Fine_val = Convert.ToInt32(reader["Fine"]);
                                                int MembershipID_val = Convert.ToInt32(reader["MembershipID"]);
                                                reader.Close();

                                                using (SqlCommand updateBorrowedCommand = new SqlCommand("UPDATE Borrowed SET IsReturned = @isreturned, ReturnDate = GETDATE() WHERE BorrowedID = @borrowedID", itemsConnection))
                                                {
                                                    updateBorrowedCommand.Parameters.AddWithValue("@isreturned", 1);
                                                    updateBorrowedCommand.Parameters.AddWithValue("@borrowedID", borrowedID);
                                                    int rowsAffected = updateBorrowedCommand.ExecuteNonQuery();
                                                    if (rowsAffected > 0)
                                                    {
                                                        using (SqlCommand updateBooksCommand = new SqlCommand("UPDATE Books SET NoOfAvailableCopies = NoOfAvailableCopies + 1 WHERE BookID = (SELECT BookID FROM Borrowed WHERE BorrowedID = @borrowedID)", itemsConnection))
                                                        {
                                                            updateBooksCommand.Parameters.AddWithValue("@borrowedID", borrowedID);
                                                            updateBooksCommand.ExecuteNonQuery();
                                                        }

                                                        using (SqlCommand updateMembersCommand = new SqlCommand("UPDATE Members SET AccountBalance = AccountBalance - @fine WHERE MembershipID = @membershipID", usersConnection))
                                                        {
                                                            updateMembersCommand.Parameters.AddWithValue("@fine", Fine_val);
                                                            updateMembersCommand.Parameters.AddWithValue("@membershipID", MembershipID_val);
                                                            updateMembersCommand.ExecuteNonQuery();
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

            if (tb_password.Text != string.Empty)
            {
                tb_password.Clear();
            }

            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetUsersDbConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Admins WHERE ID = @adminID", connection))
                    {
                        command.Parameters.AddWithValue("@adminID", user_id);

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
            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetUsersDbConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"UPDATE Admins SET Username = CASE WHEN @newUsername IS NOT NULL AND @newUsername <> '' THEN @newUsername ELSE Username END, Password = CASE WHEN @newPassword IS NOT NULL AND @newPassword <> '' THEN @newPassword ELSE Password END WHERE ID = @adminID;", connection))
                    {
                        command.Parameters.AddWithValue("@newUsername", tb_username.Text);
                        command.Parameters.AddWithValue("@newPassword", tb_password.Text);
                        command.Parameters.AddWithValue("@adminID", user_id);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update profile, please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private bool isValidMembershipID(int membershipID)
        {
            DatabaseManager dbManger = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManger.GetUsersDbConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Members WHERE MembershipID = @membershipID", connection);
                command.Parameters.AddWithValue("@membershipID", membershipID);
                return (int)command.ExecuteScalar() > 0;
            }
        }

        private void b_addBorrow_Click(object sender, EventArgs e)
        {
            if (track) {
                tb_membershipID.Visible = true;
                track = false;
            }
            else if (track == false && String.IsNullOrEmpty(tb_membershipID.Text) != true)
            {
                int selectedRowCount = dgv_books.SelectedRows.Count;
                if (selectedRowCount > 0)
                {
                    StringBuilder titles = new StringBuilder();
                    bool allAvailable = true;

                    foreach (DataGridViewRow row in dgv_books.SelectedRows)
                    {
                        string title_val = row.Cells["Title"].Value.ToString();
                        string availability_val = row.Cells["Availability"].Value.ToString();
                        titles.AppendLine(title_val);
                        if (availability_val != "Available")
                        {
                            allAvailable = false;
                        }
                    }

                    DialogResult result = MessageBox.Show(
                        String.Format("You are about to borrow the following items:\n{0}Are you sure?", titles.ToString()),
                        "Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information
                    );

                    if (result == DialogResult.Yes && allAvailable)
                    {
                        int membershipID = Convert.ToInt32(tb_membershipID.Text);

                        if (isValidMembershipID(membershipID))
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

                                        using (SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE BookID = @bookID", connection))
                                        {
                                            command.Parameters.AddWithValue("@bookID", bookID);

                                            using (SqlDataReader reader = command.ExecuteReader())
                                            {
                                                if (reader.Read())
                                                {
                                                    string title = reader["Title"].ToString();
                                                    string authors = reader["Authors"].ToString();
                                                    string edition = reader["Edition"].ToString();
                                                    reader.Close();

                                                    using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Borrowed (BookID, MembershipID, Title, Authors, Edition, BorrowDate, ReturnDate) VALUES (@bookID, @membershipID, @title, @authors, @edition, GETDATE(), @returnDate)", connection))
                                                    {
                                                        insertCommand.Parameters.AddWithValue("@bookID", bookID);
                                                        insertCommand.Parameters.AddWithValue("@membershipID", membershipID);
                                                        insertCommand.Parameters.AddWithValue("@title", title);
                                                        insertCommand.Parameters.AddWithValue("@authors", authors);
                                                        insertCommand.Parameters.AddWithValue("@edition", edition);
                                                        insertCommand.Parameters.AddWithValue("@returnDate", DateTime.Now.AddDays(14));

                                                        int rowsAffected = insertCommand.ExecuteNonQuery();
                                                        if (rowsAffected > 0)
                                                        {
                                                            using (SqlCommand updateCommand = new SqlCommand("UPDATE Books SET NoOfAvailableCopies = NoOfAvailableCopies - 1 WHERE BookID = @BookID;", connection))
                                                            {
                                                                updateCommand.Parameters.AddWithValue("@bookID", bookID);
                                                                updateCommand.ExecuteNonQuery();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Failed to borrow book(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            tb_membershipID.Visible = false;
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
                                        tb_membershipID.Visible = false;
                                        return;
                                    }
                                }
                                showBooks();
                                MessageBox.Show("Book(s) borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid membershipID OR Book Unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select at least one record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                tb_membershipID.Visible = false;
                track = true;
            }
        }

        private void b_issued_Click(object sender, EventArgs e)
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
                    String.Format("You are about to issue the following items:\n{0}Are you sure?", titles.ToString()),
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
                                            string title = reader["Title"].ToString();
                                            string authors = reader["Authors"].ToString();
                                            string edition = reader["Edition"].ToString();
                                            reader.Close();

                                            using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Borrowed (BookID, MembershipID, Title, Authors, Edition, BorrowDate, ReturnDate) VALUES (@bookID, @membershipID, @title, @authors, @edition, GETDATE(), @returnDate)", connection))
                                            {
                                                insertCommand.Parameters.AddWithValue("@bookID", bookID);
                                                insertCommand.Parameters.AddWithValue("@membershipID", membershipID);
                                                insertCommand.Parameters.AddWithValue("@title", title);
                                                insertCommand.Parameters.AddWithValue("@authors", authors);
                                                insertCommand.Parameters.AddWithValue("@edition", edition);
                                                insertCommand.Parameters.AddWithValue("@returnDate", DateTime.Now.AddDays(14));

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

        private void tb_membershipID_Validating(object sender, CancelEventArgs e)
        {
            if (tb_membershipID.Text == string.Empty)
            {
                errorProvider1.SetError(tb_membershipID, "Please Enter MembershipID");
            }
        }
    }
}