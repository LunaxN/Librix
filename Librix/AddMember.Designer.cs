namespace Librix
{
    partial class AddMember
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
            components = new System.ComponentModel.Container();
            l_phonenumber = new Label();
            tb_phonenumber = new TextBox();
            b_add = new Button();
            tb_lastname = new TextBox();
            tb_name = new TextBox();
            l_lastname = new Label();
            l_name = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // l_phonenumber
            // 
            l_phonenumber.Font = new Font("Sitka Subheading", 10F);
            l_phonenumber.Location = new Point(47, 120);
            l_phonenumber.Name = "l_phonenumber";
            l_phonenumber.Size = new Size(110, 23);
            l_phonenumber.TabIndex = 11;
            l_phonenumber.Text = "Phone Number:";
            // 
            // tb_phonenumber
            // 
            tb_phonenumber.Font = new Font("Segoe UI", 10F);
            tb_phonenumber.Location = new Point(160, 120);
            tb_phonenumber.Name = "tb_phonenumber";
            tb_phonenumber.Size = new Size(175, 25);
            tb_phonenumber.TabIndex = 12;
            tb_phonenumber.Validating += tb_phonenumber_Validating;
            // 
            // b_add
            // 
            b_add.BackColor = Color.FromArgb(255, 192, 192);
            b_add.FlatStyle = FlatStyle.Flat;
            b_add.Font = new Font("Sitka Subheading", 10F);
            b_add.Location = new Point(20, 185);
            b_add.Name = "b_add";
            b_add.Size = new Size(360, 52);
            b_add.TabIndex = 8;
            b_add.Text = "Add";
            b_add.UseVisualStyleBackColor = false;
            b_add.Click += b_add_Click;
            // 
            // tb_lastname
            // 
            tb_lastname.Font = new Font("Segoe UI", 10F);
            tb_lastname.Location = new Point(160, 80);
            tb_lastname.Name = "tb_lastname";
            tb_lastname.Size = new Size(175, 25);
            tb_lastname.TabIndex = 5;
            tb_lastname.Validating += tb_lastname_Validating;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 10F);
            tb_name.Location = new Point(160, 40);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(175, 25);
            tb_name.TabIndex = 4;
            tb_name.Validating += tb_name_Validating;
            // 
            // l_lastname
            // 
            l_lastname.Font = new Font("Sitka Subheading", 10F);
            l_lastname.Location = new Point(47, 80);
            l_lastname.Name = "l_lastname";
            l_lastname.Size = new Size(100, 23);
            l_lastname.TabIndex = 1;
            l_lastname.Text = "Last Name:";
            // 
            // l_name
            // 
            l_name.Font = new Font("Sitka Subheading", 10F);
            l_name.Location = new Point(47, 40);
            l_name.Name = "l_name";
            l_name.Size = new Size(100, 23);
            l_name.TabIndex = 0;
            l_name.Text = "Name:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 258);
            Controls.Add(l_phonenumber);
            Controls.Add(tb_phonenumber);
            Controls.Add(b_add);
            Controls.Add(tb_name);
            Controls.Add(tb_lastname);
            Controls.Add(l_lastname);
            Controls.Add(l_name);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddMember";
            Text = "Add Member";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_phonenumber;
        private TextBox tb_phonenumber;
        private Button b_add;
        private TextBox tb_lastname;
        private TextBox tb_name;
        private Label l_lastname;
        private Label l_name;
        private ErrorProvider errorProvider1;
    }
}