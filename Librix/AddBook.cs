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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Librix
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager();
            using (SqlConnection connection = new SqlConnection(dbManager.GetItemsDbConnectionString()))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Books (Title, Authors, Edition, PublishDate, Genres, NoOfTotalCopies, NoOfAvailableCopies, DateOfRegister) VALUES (@title, @authors, @edition, @publishDate, @genres, @noOfTotalCopies, @noOfAvailableCopies, GETDATE())", connection);
                command.Parameters.AddWithValue("@title", tb_title.Text);
                command.Parameters.AddWithValue("@authors", tb_authors.Text);
                command.Parameters.AddWithValue("@edition", tb_edition.Text);
                command.Parameters.AddWithValue("@publishDate", tb_publishDate.Text);
                command.Parameters.AddWithValue("@genres", tb_genres.Text);
                command.Parameters.AddWithValue("@noOfTotalCopies", tb_totalCopies.Text);
                command.Parameters.AddWithValue("@noOfAvailableCopies", tb_availableCopies.Text);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Failed to add book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            this.Hide();
        }

        private void tb_title_Validating(object sender, CancelEventArgs e)
        {
            if (tb_title.Text == string.Empty)
            {
                errorProvider1.SetError(tb_title, "Please Enter Title");
            }
        }

        private void tb_totalCopies_Validating(object sender, CancelEventArgs e)
        {
            if (tb_totalCopies.Text == string.Empty)
            {
                errorProvider1.SetError(tb_totalCopies, "Please Enter No of Total Copies");
            }
        }

        private void tb_availableCopies_TextChanged(object sender, EventArgs e)
        {
            if (tb_availableCopies.Visible == true && tb_availableCopies.Text == string.Empty)
            {
                errorProvider1.SetError(tb_availableCopies, "Please Enter No of Available Copies");
            }
        }
    }
}