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
    public partial class MemberDashboard : Form
    {

        private int user_id;
        public MemberDashboard(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
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

        private void b_reservedBooks_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
            showReserved();
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
        }

        private void b_reserve_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgv_books.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                DataGridViewRow selectedRow = dgv_books.SelectedRows[0];

                string title_val = selectedRow.Cells["Title"].Value.ToString();
                string availability_val = selectedRow.Cells["Availability"].Value.ToString();
                DialogResult result = MessageBox.Show(
                    String.Format("You are about to reserve {0}, are you sure?", title_val),
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes && availability_val == "Available")
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
                                                    MessageBox.Show("Book reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    using (SqlCommand updateCommand = new SqlCommand("UPDATE Books SET NoOfAvailableCopies = NoOfAvailableCopies - 1, Availability = CASE WHEN NoOfAvailableCopies = 1 THEN 'Not Available' ELSE Availability END WHERE BookID = @BookID;", connection))
                                                    {
                                                        updateCommand.Parameters.AddWithValue("@bookID", bookID);
                                                        updateCommand.ExecuteNonQuery();
                                                    }
                                                    showBooks();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Failed to reserve book, please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

                else if (availability_val != "Available") MessageBox.Show("This book is unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Please select at least one record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void b_unreserve_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgv_reserved.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                DataGridViewRow selectedRow = dgv_reserved.SelectedRows[0];

                string title_val = selectedRow.Cells["Title"].Value.ToString();
                DialogResult result = MessageBox.Show(
                    String.Format("You are about to unreserve {0}, are you sure?", title_val),
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

                                showReserved();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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