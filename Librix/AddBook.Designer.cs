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
            b_add = new Button();
            tb_title = new TextBox();
            tb_authors = new TextBox();
            l_authors = new Label();
            l_title = new Label();
            errorProvider1 = new ErrorProvider(components);
            tb_availableCopies = new TextBox();
            l_availableCopies = new Label();
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
            // b_add
            // 
            b_add.BackColor = Color.FromArgb(255, 192, 192);
            b_add.FlatStyle = FlatStyle.Flat;
            b_add.Font = new Font("Sitka Subheading", 10F);
            b_add.Location = new Point(21, 334);
            b_add.Name = "b_add";
            b_add.Size = new Size(360, 52);
            b_add.TabIndex = 45;
            b_add.Text = "Add";
            b_add.UseVisualStyleBackColor = false;
            b_add.Click += b_add_Click;
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
            tb_availableCopies.Location = new Point(173, 272);
            tb_availableCopies.Name = "tb_availableCopies";
            tb_availableCopies.Size = new Size(175, 25);
            tb_availableCopies.TabIndex = 54;
            tb_availableCopies.TextChanged += tb_availableCopies_TextChanged;
            // 
            // l_availableCopies
            // 
            l_availableCopies.Font = new Font("Sitka Subheading", 10F);
            l_availableCopies.Location = new Point(46, 272);
            l_availableCopies.Name = "l_availableCopies";
            l_availableCopies.Size = new Size(121, 23);
            l_availableCopies.TabIndex = 55;
            l_availableCopies.Text = "Available Copies:";
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
            ClientSize = new Size(403, 415);
            Controls.Add(l_totalCopies);
            Controls.Add(tb_totalCopies);
            Controls.Add(l_availableCopies);
            Controls.Add(tb_availableCopies);
            Controls.Add(tb_publishDate);
            Controls.Add(tb_genres);
            Controls.Add(l_genres);
            Controls.Add(l_publishDate);
            Controls.Add(l_edition);
            Controls.Add(tb_edition);
            Controls.Add(b_add);
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
        private Button b_add;
        private TextBox tb_title;
        private TextBox tb_authors;
        private Label l_authors;
        private Label l_title;
        private ErrorProvider errorProvider1;
        private Label l_availableCopies;
        private TextBox tb_availableCopies;
        private Label l_totalCopies;
        private TextBox tb_totalCopies;
    }
}