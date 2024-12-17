using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librix
{
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }

        public string RecordID { get; set; }

        public string RecordTitle
        {
            get { return tb_title.Text; }
            set { tb_title.Text = value; }
        }

        public string RecordAuthors
        {
            get { return tb_authors.Text; }
            set { tb_authors.Text = value; }
        }

        public string RecordEdition
        {
            get { return tb_edition.Text; }
            set { tb_edition.Text = value; }
        }

        public string RecordPublishDate
        {
            get { return tb_publishDate.Text; }
            set { tb_publishDate.Text = value; }
        }

        public string RecordGenres
        {
            get { return tb_genres.Text; }
            set { tb_genres.Text = value; }
        }

        public string RecordTotalCopies
        {
            get { return tb_totalCopies.Text; }
            set { tb_totalCopies.Text = value; }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void tb_title_Validating(object sender, CancelEventArgs e)
        {
            if (tb_title.Text == string.Empty)
            {
                errorProvider1.SetError(tb_title, "This field cannot be empty");
            }
        }

        private void tb_totalCopies_Validating(object sender, CancelEventArgs e)
        {
            if (tb_totalCopies.Text == string.Empty)
            {
                errorProvider1.SetError(tb_totalCopies, "This field cannot be empty");
            }
        }

        private void EditBook_Load(object sender, EventArgs e)
        {

        }
    }
}