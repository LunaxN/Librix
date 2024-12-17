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
    public partial class EditMember : Form
    {
        public string RecordID { get; set; }

        public string RecordFirstName
        {
            get { return tb_name.Text; }
            set { tb_name.Text = value; }
        }

        public string RecordLastName
        {
            get { return tb_lastname.Text; }
            set { tb_lastname.Text = value; }
        }

        public string RecordPhoneNumber
        {
            get { return tb_phoneNumber.Text; }
            set { tb_phoneNumber.Text = value; }
        }

        public EditMember()
        {
            InitializeComponent();
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
    }
}