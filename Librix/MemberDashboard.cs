using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librix
{
    public partial class MemberDashboard : Form
    {

        private int user_id;
        public MemberDashboard(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            showCurrentDate();
            showTotalBorrowed();
            showReturnedToday();
            showNewBooks();
        }

        private void showCurrentDate()
        {
            DateTime today = DateTime.Now;
            l_currentDate.Text = today.ToString("dddd, yyyy MMMM dd");
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
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Borrowed WHERE MembershipID = @membershipID AND Status = @status", connection))
                    {
                        command.Parameters.AddWithValue("@membershipID", user_id);
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
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Borrowed WHERE MembershipID = @membershipID AND CAST(ReturnDate AS DATE) = @returnDate AND Status = @status", connection))
                    {
                        command.Parameters.AddWithValue("@membershipID", user_id);
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

        private void showNewBooks()
        {
            int recordCount = 0;

            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Books WHERE DateOfRegister = @dateOfRegister", connection))
                    {
                        command.Parameters.AddWithValue("@dateOfRegister", DateTime.Today);
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
            l_noNewBooks.Text = recordCount.ToString();
        }

        private void b_dashboard_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
            p_userInforamtion.Location = new System.Drawing.Point(0, 98);
            p_userInforamtion.Visible = false;
            b_profile.Visible = true;
            showCurrentDate();
            showTotalBorrowed();
            showReturnedToday();
            showNewBooks();
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

        private void b_reserved_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
            showReserved();
            tb_searchReserve.Clear();
            tb_searchReserve.Text = "Search for a reserved book...";
            tb_searchReserve.ForeColor = Color.Gray;
            b_resetReserved.Visible = false;
        }

        private void b_borrowed_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
            showBorrowed();
            tb_searchBorrow.Clear();
            tb_searchBorrow.Text = "Search for a borrowed book...";
            tb_searchBorrow.ForeColor = Color.Gray;
            b_resetBorrowed.Visible = false;
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

        private void showReserved()
        {
            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT ReservationID, BookID, Title, Authors, Edition, ReservationDate FROM Reserved WHERE MembershipID = @membershipID", connection);
                command.Parameters.AddWithValue("@membershipID", user_id);
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

        private void showBorrowed()
        {
            DatabaseManager dbManger = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManger.GetItemsDbConnectionString()))
            {
                SqlCommand command = new SqlCommand("SELECT BorrowedID, BookID, BorrowDate, ReturnDate, Status, Fine FROM Borrowed WHERE MembershipID = @membershipID", connection);
                command.Parameters.AddWithValue("@membershipID", user_id);

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

        private void b_reserve_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgv_books.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                StringBuilder titles = new StringBuilder();
                bool allAvailable = true; // to check if all books are availabe or not

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
                    String.Format("You are about to reserve the following books:\n{0}Are you sure?", titles.ToString()),
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes && allAvailable)
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

                                            using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Reserved (BookID, MembershipID, Title, Authors, Edition, ReservationDate) VALUES (@bookID, @membershipID, @title, @authors, @edition, GETDATE())", connection))
                                            {
                                                insertCommand.Parameters.AddWithValue("@bookID", bookID);
                                                insertCommand.Parameters.AddWithValue("@membershipID", user_id);
                                                insertCommand.Parameters.AddWithValue("@title", title);
                                                insertCommand.Parameters.AddWithValue("@authors", authors);
                                                insertCommand.Parameters.AddWithValue("@edition", edition);

                                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                                if (rowsAffected > 0)
                                                {
                                                    using (SqlCommand updateCommand = new SqlCommand("UPDATE Books SET NoOfAvailableCopies = NoOfAvailableCopies - 1, Availability = CASE WHEN NoOfAvailableCopies = 1 THEN 'Not Available' ELSE Availability END WHERE BookID = @BookID;", connection))
                                                    {
                                                        updateCommand.Parameters.AddWithValue("@bookID", bookID);
                                                        updateCommand.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Failed to reserve book(s), please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        showBooks();
                        MessageBox.Show("Book(s) reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (result == DialogResult.Yes && !allAvailable)
                {
                    MessageBox.Show("One or more selected books are unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_unreserve_Click(object sender, EventArgs e)
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
                                int bookID = Convert.ToInt32(row.Cells["BookID"].Value);
                                int reservationID = Convert.ToInt32(row.Cells["ReservationID"].Value);

                                using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM Reserved WHERE ReservationID = @reservationID", connection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@reservationID", reservationID);
                                    deleteCommand.ExecuteNonQuery();
                                }

                                using (SqlCommand updateCommand = new SqlCommand("UPDATE Books SET NoOfAvailableCopies = NoOfAvailableCopies + 1, Availability = CASE WHEN NoOfAvailableCopies >= 0 THEN 'Available' ELSE 'Not Available' END WHERE BookID = @BookID", connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@bookID", bookID);
                                    updateCommand.ExecuteNonQuery();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        showReserved();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select at least one record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void tb_searchReserve_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                DatabaseManager dbManager = new DatabaseManager();
                using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
                {
                    SqlCommand command = new SqlCommand("SELECT ReservationID, BookID, Title, Authors, Edition, ReservationDate FROM Reserved WHERE MembershipID = @membershipID AND (ReservationID = @reservationID OR Title LIKE @title)", connection);
                    command.Parameters.AddWithValue("@membershipID", user_id);

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

        private void b_renew_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgv_borrowed.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                DialogResult result = MessageBox.Show(
                    String.Format("You are about to renew {0} book(s). Are you sure?", selectedRowCount),
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
                                DateTime returnDate = Convert.ToDateTime(row.Cells["ReturnDate"].Value);
                                DateTime newReturnDate = returnDate.AddDays(7);

                                using (SqlCommand command = new SqlCommand("UPDATE Borrowed SET ReturnDate = @newReturnDate WHERE BorrowedID = @borrowedID AND Status = @status", connection))
                                {
                                    command.Parameters.AddWithValue("@newReturnDate", newReturnDate);
                                    command.Parameters.AddWithValue("@borrowedID", borrowedID);
                                    command.Parameters.AddWithValue("@status", "Borrowed");

                                    int rowsAffected = command.ExecuteNonQuery();
                                    if (rowsAffected <= 0)
                                    {
                                        MessageBox.Show("Failed to renew book(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
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
                        MessageBox.Show("Book(s) renewed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select at least one record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb_searchBorrow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                DatabaseManager dbManager = new DatabaseManager();
                using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Borrowed WHERE MembershipID = @membershipID AND BorrowedID = @borrowedID", connection);
                    command.Parameters.AddWithValue("@membershipID", user_id);
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
                                tb_name.Text = reader["FirstName"].ToString(); ;
                                tb_lastname.Text = reader["LastName"].ToString();
                                tb_phoneNumber.Text = reader["PhoneNumber"].ToString();
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

        private void tb_name_Validating(object sender, CancelEventArgs e)
        {
            if (tb_name.Text == string.Empty)
            {
                errorProvider1.SetError(tb_name, "This field cannot be empty");
            }
        }

        private void tb_lastname_Validating(object sender, CancelEventArgs e)
        {
            if (tb_lastname.Text == string.Empty)
            {
                errorProvider1.SetError(tb_lastname, "This field cannot be empty");
            }
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