namespace Librix
{
    partial class AddBook
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
            tb_publishDate = new TextBox();
            tb_genres = new TextBox();
            l_genres = new Label();
            l_publishDate = new Label();
            l_edition = new Label();
            tb_edition = new TextBox();
            b_save = new Button();
            tb_title = new TextBox();
            tb_authors = new TextBox();
            l_authors = new Label();
            l_title = new Label();
            errorProvider1 = new ErrorProvider(components);
            tb_availableCopies = new TextBox();
            l_availableCopies = new Label();
            l_availability = new Label();
            cb_availability = new ComboBox();
            l_totalCopies = new Label();
            tb_totalCopies = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tb_publishDate
            // 
            tb_publishDate.Font = new Font("Segoe UI", 10F);
            tb_publishDate.Location = new Point(173, 152);
            tb_publishDate.Name = "tb_publishDate";
            tb_publishDate.Size = new Size(175, 25);
            tb_publishDate.TabIndex = 51;
            // 
            // tb_genres
            // 
            tb_genres.Font = new Font("Segoe UI", 10F);
            tb_genres.Location = new Point(173, 192);
            tb_genres.Name = "tb_genres";
            tb_genres.Size = new Size(175, 25);
            tb_genres.TabIndex = 52;
            // 
            // l_genres
            // 
            l_genres.Font = new Font("Sitka Subheading", 10F);
            l_genres.Location = new Point(46, 192);
            l_genres.Name = "l_genres";
            l_genres.Size = new Size(100, 23);
            l_genres.TabIndex = 50;
            l_genres.Text = "Genres:";
            // 
            // l_publishDate
            // 
            l_publishDate.Font = new Font("Sitka Subheading", 10F);
            l_publishDate.Location = new Point(46, 152);
            l_publishDate.Name = "l_publishDate";
            l_publishDate.Size = new Size(100, 23);
            l_publishDate.TabIndex = 49;
            l_publishDate.Text = "Publish date:";
            // 
            // l_edition
            // 
            l_edition.Font = new Font("Sitka Subheading", 10F);
            l_edition.Location = new Point(46, 112);
            l_edition.Name = "l_edition";
            l_edition.Size = new Size(110, 23);
            l_edition.TabIndex = 46;
            l_edition.Text = "Edition:";
            // 
            // tb_edition
            // 
            tb_edition.Font = new Font("Segoe UI", 10F);
            tb_edition.Location = new Point(173, 112);
            tb_edition.Name = "tb_edition";
            tb_edition.Size = new Size(175, 25);
            tb_edition.TabIndex = 47;
            // 
            // b_save
            // 
            b_save.BackColor = Color.FromArgb(255, 192, 192);
            b_save.FlatStyle = FlatStyle.Flat;
            b_save.Font = new Font("Sitka Subheading", 10F);
            b_save.Location = new Point(21, 365);
            b_save.Name = "b_save";
            b_save.Size = new Size(360, 52);
            b_save.TabIndex = 45;
            b_save.Text = "Add";
            b_save.UseVisualStyleBackColor = false;
            b_save.Click += b_save_Click;
            // 
            // tb_title
            // 
            tb_title.Font = new Font("Segoe UI", 10F);
            tb_title.Location = new Point(173, 32);
            tb_title.Name = "tb_title";
            tb_title.Size = new Size(175, 25);
            tb_title.TabIndex = 43;
            tb_title.Validating += tb_title_Validating;
            // 
            // tb_authors
            // 
            tb_authors.Font = new Font("Segoe UI", 10F);
            tb_authors.Location = new Point(173, 72);
            tb_authors.Name = "tb_authors";
            tb_authors.Size = new Size(175, 25);
            tb_authors.TabIndex = 44;
            // 
            // l_authors
            // 
            l_authors.Font = new Font("Sitka Subheading", 10F);
            l_authors.Location = new Point(46, 72);
            l_authors.Name = "l_authors";
            l_authors.Size = new Size(100, 23);
            l_authors.TabIndex = 42;
            l_authors.Text = "Authors:";
            // 
            // l_title
            // 
            l_title.Font = new Font("Sitka Subheading", 10F);
            l_title.Location = new Point(46, 32);
            l_title.Name = "l_title";
            l_title.Size = new Size(100, 23);
            l_title.TabIndex = 41;
            l_title.Text = "Title:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tb_availableCopies
            // 
            tb_availableCopies.Font = new Font("Segoe UI", 10F);
            tb_availableCopies.Location = new Point(173, 312);
            tb_availableCopies.Name = "tb_availableCopies";
            tb_availableCopies.Size = new Size(175, 25);
            tb_availableCopies.TabIndex = 54;
            tb_availableCopies.Visible = false;
            tb_availableCopies.TextChanged += tb_availableCopies_TextChanged;
            // 
            // l_availableCopies
            // 
            l_availableCopies.Font = new Font("Sitka Subheading", 10F);
            l_availableCopies.Location = new Point(46, 312);
            l_availableCopies.Name = "l_availableCopies";
            l_availableCopies.Size = new Size(121, 23);
            l_availableCopies.TabIndex = 55;
            l_availableCopies.Text = "Available Copies:";
            l_availableCopies.Visible = false;
            // 
            // l_availability
            // 
            l_availability.Font = new Font("Sitka Subheading", 10F);
            l_availability.Location = new Point(46, 272);
            l_availability.Name = "l_availability";
            l_availability.Size = new Size(100, 23);
            l_availability.TabIndex = 56;
            l_availability.Text = "Availability:";
            // 
            // cb_availability
            // 
            cb_availability.Font = new Font("Segoe UI", 10F);
            cb_availability.FormattingEnabled = true;
            cb_availability.Items.AddRange(new object[] { "Available", "Not Available" });
            cb_availability.Location = new Point(173, 272);
            cb_availability.Name = "cb_availability";
            cb_availability.Size = new Size(175, 25);
            cb_availability.TabIndex = 57;
            cb_availability.SelectedIndexChanged += cb_availability_SelectedIndexChanged;
            cb_availability.Validating += cb_availability_Validating;
            // 
            // l_totalCopies
            // 
            l_totalCopies.Font = new Font("Sitka Subheading", 10F);
            l_totalCopies.Location = new Point(46, 232);
            l_totalCopies.Name = "l_totalCopies";
            l_totalCopies.Size = new Size(100, 23);
            l_totalCopies.TabIndex = 59;
            l_totalCopies.Text = "Total Copies:";
            // 
            // tb_totalCopies
            // 
            tb_totalCopies.Font = new Font("Segoe UI", 10F);
            tb_totalCopies.Location = new Point(173, 232);
            tb_totalCopies.Name = "tb_totalCopies";
            tb_totalCopies.Size = new Size(175, 25);
            tb_totalCopies.TabIndex = 58;
            tb_totalCopies.Validating += tb_totalCopies_Validating;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(403, 443);
            Controls.Add(l_totalCopies);
            Controls.Add(tb_totalCopies);
            Controls.Add(cb_availability);
            Controls.Add(l_availability);
            Controls.Add(l_availableCopies);
            Controls.Add(tb_availableCopies);
            Controls.Add(tb_publishDate);
            Controls.Add(tb_genres);
            Controls.Add(l_genres);
            Controls.Add(l_publishDate);
            Controls.Add(l_edition);
            Controls.Add(tb_edition);
            Controls.Add(b_save);
            Controls.Add(tb_title);
            Controls.Add(tb_authors);
            Controls.Add(l_authors);
            Controls.Add(l_title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Book";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_publishDate;
        private TextBox tb_genres;
        private Label l_genres;
        private Label l_publishDate;
        private Label l_edition;
        private TextBox tb_edition;
        private Button b_save;
        private TextBox tb_title;
        private TextBox tb_authors;
        private Label l_authors;
        private Label l_title;
        private ErrorProvider errorProvider1;
        private Label l_availability;
        private Label l_availableCopies;
        private TextBox tb_availableCopies;
        private ComboBox cb_availability;
        private Label l_totalCopies;
        private TextBox tb_totalCopies;
    }
}