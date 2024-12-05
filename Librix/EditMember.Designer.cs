namespace Librix
{
    partial class EditMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            l_phonenumber = new Label();
            tb_phonenumber = new TextBox();
            b_save = new Button();
            tb_name = new TextBox();
            tb_lastname = new TextBox();
            l_lastname = new Label();
            l_name = new Label();
            b_cancel = new Button();
            l_or = new Label();
            SuspendLayout();
            // 
            // l_phonenumber
            // 
            l_phonenumber.Font = new Font("Sitka Subheading", 10F);
            l_phonenumber.Location = new Point(47, 120);
            l_phonenumber.Name = "l_phonenumber";
            l_phonenumber.Size = new Size(110, 23);
            l_phonenumber.TabIndex = 18;
            l_phonenumber.Text = "Phone Number:";
            // 
            // tb_phonenumber
            // 
            tb_phonenumber.Font = new Font("Segoe UI", 10F);
            tb_phonenumber.Location = new Point(160, 120);
            tb_phonenumber.Name = "tb_phonenumber";
            tb_phonenumber.Size = new Size(175, 25);
            tb_phonenumber.TabIndex = 19;
            // 
            // b_save
            // 
            b_save.BackColor = Color.FromArgb(255, 192, 192);
            b_save.FlatStyle = FlatStyle.Flat;
            b_save.Font = new Font("Sitka Subheading", 10F);
            b_save.Location = new Point(20, 185);
            b_save.Name = "b_save";
            b_save.Size = new Size(360, 52);
            b_save.TabIndex = 17;
            b_save.Text = "Save Changes";
            b_save.UseVisualStyleBackColor = false;
            b_save.Click += b_save_Click;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 10F);
            tb_name.Location = new Point(160, 40);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(175, 25);
            tb_name.TabIndex = 15;
            // 
            // tb_lastname
            // 
            tb_lastname.Font = new Font("Segoe UI", 10F);
            tb_lastname.Location = new Point(160, 80);
            tb_lastname.Name = "tb_lastname";
            tb_lastname.Size = new Size(175, 25);
            tb_lastname.TabIndex = 16;
            // 
            // l_lastname
            // 
            l_lastname.Font = new Font("Sitka Subheading", 10F);
            l_lastname.Location = new Point(47, 80);
            l_lastname.Name = "l_lastname";
            l_lastname.Size = new Size(100, 23);
            l_lastname.TabIndex = 14;
            l_lastname.Text = "Last Name:";
            // 
            // l_name
            // 
            l_name.Font = new Font("Sitka Subheading", 10F);
            l_name.Location = new Point(47, 40);
            l_name.Name = "l_name";
            l_name.Size = new Size(100, 23);
            l_name.TabIndex = 13;
            l_name.Text = "Name:";
            // 
            // b_cancel
            // 
            b_cancel.BackColor = Color.Black;
            b_cancel.FlatStyle = FlatStyle.Flat;
            b_cancel.Font = new Font("Sitka Subheading", 10F);
            b_cancel.ForeColor = Color.White;
            b_cancel.Location = new Point(20, 281);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(360, 52);
            b_cancel.TabIndex = 9;
            b_cancel.Text = "Cancle";
            b_cancel.UseVisualStyleBackColor = false;
            b_cancel.Click += b_cancel_Click;
            // 
            // l_or
            // 
            l_or.AutoSize = true;
            l_or.Font = new Font("Sitka Subheading", 10F);
            l_or.Location = new Point(186, 248);
            l_or.Name = "l_or";
            l_or.Size = new Size(25, 20);
            l_or.TabIndex = 26;
            l_or.Text = "Or";
            // 
            // EditMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(403, 356);
            Controls.Add(l_or);
            Controls.Add(l_phonenumber);
            Controls.Add(tb_phonenumber);
            Controls.Add(b_save);
            Controls.Add(tb_name);
            Controls.Add(tb_lastname);
            Controls.Add(l_lastname);
            Controls.Add(l_name);
            Controls.Add(b_cancel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditMember";
            Text = "Edit Member";
            Load += EditMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label l_phonenumber;
        private TextBox tb_phonenumber;
        private Button b_save;
        private TextBox tb_name;
        private TextBox tb_lastname;
        private Label l_lastname;
        private Label l_name;
        private Button b_cancel;
        private Label l_or;
    }
}