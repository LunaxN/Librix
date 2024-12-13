namespace Librix
{
    partial class EditBook
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
            l_or = new Label();
            b_save = new Button();
            b_cancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            l_totalCopies = new Label();
            tb_totalCopies = new TextBox();
            tb_publishDate = new TextBox();
            tb_genres = new TextBox();
            l_genres = new Label();
            l_publishDate = new Label();
            l_edition = new Label();
            tb_edition = new TextBox();
            tb_title = new TextBox();
            tb_authors = new TextBox();
            l_authors = new Label();
            l_title = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // l_or
            // 
            l_or.AutoSize = true;
            l_or.Font = new Font("Sitka Subheading", 10F);
            l_or.Location = new Point(186, 339);
            l_or.Name = "l_or";
            l_or.Size = new Size(25, 20);
            l_or.TabIndex = 35;
            l_or.Text = "Or";
            // 
            // b_save
            // 
            b_save.BackColor = Color.FromArgb(255, 192, 192);
            b_save.FlatStyle = FlatStyle.Flat;
            b_save.Font = new Font("Sitka Subheading", 10F);
            b_save.Location = new Point(21, 276);
            b_save.Name = "b_save";
            b_save.Size = new Size(360, 52);
            b_save.TabIndex = 32;
            b_save.Text = "Save Changes";
            b_save.UseVisualStyleBackColor = false;
            b_save.Click += b_save_Click;
            // 
            // b_cancel
            // 
            b_cancel.BackColor = Color.Black;
            b_cancel.FlatStyle = FlatStyle.Flat;
            b_cancel.Font = new Font("Sitka Subheading", 10F);
            b_cancel.ForeColor = Color.White;
            b_cancel.Location = new Point(21, 372);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(360, 52);
            b_cancel.TabIndex = 27;
            b_cancel.Text = "Cancle";
            b_cancel.UseVisualStyleBackColor = false;
            b_cancel.Click += b_cancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // l_totalCopies
            // 
            l_totalCopies.Font = new Font("Sitka Subheading", 10F);
            l_totalCopies.Location = new Point(46, 232);
            l_totalCopies.Name = "l_totalCopies";
            l_totalCopies.Size = new Size(100, 23);
            l_totalCopies.TabIndex = 71;
            l_totalCopies.Text = "Total Copies:";
            // 
            // tb_totalCopies
            // 
            tb_totalCopies.Font = new Font("Segoe UI", 10F);
            tb_totalCopies.Location = new Point(172, 232);
            tb_totalCopies.Name = "tb_totalCopies";
            tb_totalCopies.Size = new Size(175, 25);
            tb_totalCopies.TabIndex = 70;
            tb_totalCopies.Validating += tb_totalCopies_Validating;
            // 
            // tb_publishDate
            // 
            tb_publishDate.Font = new Font("Segoe UI", 10F);
            tb_publishDate.Location = new Point(172, 152);
            tb_publishDate.Name = "tb_publishDate";
            tb_publishDate.Size = new Size(175, 25);
            tb_publishDate.TabIndex = 68;
            // 
            // tb_genres
            // 
            tb_genres.Font = new Font("Segoe UI", 10F);
            tb_genres.Location = new Point(172, 192);
            tb_genres.Name = "tb_genres";
            tb_genres.Size = new Size(175, 25);
            tb_genres.TabIndex = 69;
            // 
            // l_genres
            // 
            l_genres.Font = new Font("Sitka Subheading", 10F);
            l_genres.Location = new Point(46, 192);
            l_genres.Name = "l_genres";
            l_genres.Size = new Size(100, 23);
            l_genres.TabIndex = 67;
            l_genres.Text = "Genres:";
            // 
            // l_publishDate
            // 
            l_publishDate.Font = new Font("Sitka Subheading", 10F);
            l_publishDate.Location = new Point(46, 152);
            l_publishDate.Name = "l_publishDate";
            l_publishDate.Size = new Size(100, 23);
            l_publishDate.TabIndex = 66;
            l_publishDate.Text = "Publish date:";
            // 
            // l_edition
            // 
            l_edition.Font = new Font("Sitka Subheading", 10F);
            l_edition.Location = new Point(46, 112);
            l_edition.Name = "l_edition";
            l_edition.Size = new Size(110, 23);
            l_edition.TabIndex = 64;
            l_edition.Text = "Edition:";
            // 
            // tb_edition
            // 
            tb_edition.Font = new Font("Segoe UI", 10F);
            tb_edition.Location = new Point(172, 112);
            tb_edition.Name = "tb_edition";
            tb_edition.Size = new Size(175, 25);
            tb_edition.TabIndex = 65;
            // 
            // tb_title
            // 
            tb_title.Font = new Font("Segoe UI", 10F);
            tb_title.Location = new Point(173, 32);
            tb_title.Name = "tb_title";
            tb_title.Size = new Size(175, 25);
            tb_title.TabIndex = 62;
            // 
            // tb_authors
            // 
            tb_authors.Font = new Font("Segoe UI", 10F);
            tb_authors.Location = new Point(172, 72);
            tb_authors.Name = "tb_authors";
            tb_authors.Size = new Size(175, 25);
            tb_authors.TabIndex = 63;
            // 
            // l_authors
            // 
            l_authors.Font = new Font("Sitka Subheading", 10F);
            l_authors.Location = new Point(46, 72);
            l_authors.Name = "l_authors";
            l_authors.Size = new Size(100, 23);
            l_authors.TabIndex = 61;
            l_authors.Text = "Authors:";
            // 
            // l_title
            // 
            l_title.Font = new Font("Sitka Subheading", 10F);
            l_title.Location = new Point(46, 32);
            l_title.Name = "l_title";
            l_title.Size = new Size(100, 23);
            l_title.TabIndex = 60;
            l_title.Text = "Title:";
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(403, 439);
            Controls.Add(l_totalCopies);
            Controls.Add(tb_totalCopies);
            Controls.Add(tb_publishDate);
            Controls.Add(tb_genres);
            Controls.Add(l_genres);
            Controls.Add(l_publishDate);
            Controls.Add(l_edition);
            Controls.Add(tb_edition);
            Controls.Add(tb_title);
            Controls.Add(tb_authors);
            Controls.Add(l_authors);
            Controls.Add(l_title);
            Controls.Add(l_or);
            Controls.Add(b_save);
            Controls.Add(b_cancel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Book";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_or;
        private Button b_save;
        private Button b_cancel;
        private ErrorProvider errorProvider1;
        private Label l_totalCopies;
        private TextBox tb_totalCopies;
        private TextBox tb_publishDate;
        private TextBox tb_genres;
        private Label l_genres;
        private Label l_publishDate;
        private Label l_edition;
        private TextBox tb_edition;
        private TextBox tb_title;
        private TextBox tb_authors;
        private Label l_authors;
        private Label l_title;
    }
}