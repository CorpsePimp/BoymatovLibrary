namespace biblioteka
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstBooks; // Оставляем стандартный ListBox
        private Guna.UI2.WinForms.Guna2Button btnAddBook;
        private Guna.UI2.WinForms.Guna2Button btnRemoveBook;
        private Guna.UI2.WinForms.Guna2Button btnSearchBook;
        private Guna.UI2.WinForms.Guna2Button btnShowAllBooks;
        private Guna.UI2.WinForms.Guna2Button btnImport;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2Button btnLanguageToggle;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthor;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2NumericUpDown numYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAuthor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBooks;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.numYear = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowAllBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.btnLanguageToggle = new Guna.UI2.WinForms.Guna2Button();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAuthor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSearch = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBooks = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.BorderRadius = 10;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(230)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(205)))), ((int)(((byte)(161)))));
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.Location = new System.Drawing.Point(20, 40);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(200, 36);
            this.txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderRadius = 10;
            this.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthor.DefaultText = "";
            this.txtAuthor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(230)))));
            this.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(205)))), ((int)(((byte)(161)))));
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAuthor.Location = new System.Drawing.Point(20, 100);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PasswordChar = '\0';
            this.txtAuthor.PlaceholderText = "";
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.Size = new System.Drawing.Size(200, 36);
            this.txtAuthor.TabIndex = 1;
            // 
            // numYear
            // 
            this.numYear.BackColor = System.Drawing.Color.Transparent;
            this.numYear.BorderRadius = 10;
            this.numYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numYear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(230)))));
            this.numYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numYear.Location = new System.Drawing.Point(20, 159);
            this.numYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(200, 36);
            this.numYear.TabIndex = 2;
            this.numYear.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.numYear.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(230)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(205)))), ((int)(((byte)(161)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(20, 300);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(200, 36);
            this.txtSearch.TabIndex = 3;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BorderRadius = 10;
            this.btnAddBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(20, 220);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(200, 36);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Добавить книгу";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.BorderRadius = 10;
            this.btnRemoveBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.btnRemoveBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveBook.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBook.Location = new System.Drawing.Point(20, 400);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(200, 36);
            this.btnRemoveBook.TabIndex = 5;
            this.btnRemoveBook.Text = "Удалить книгу";
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BorderRadius = 10;
            this.btnSearchBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.btnSearchBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchBook.ForeColor = System.Drawing.Color.White;
            this.btnSearchBook.Location = new System.Drawing.Point(20, 350);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(200, 36);
            this.btnSearchBook.TabIndex = 6;
            this.btnSearchBook.Text = "Поиск книги";
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnShowAllBooks
            // 
            this.btnShowAllBooks.BorderRadius = 10;
            this.btnShowAllBooks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.btnShowAllBooks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowAllBooks.ForeColor = System.Drawing.Color.White;
            this.btnShowAllBooks.Location = new System.Drawing.Point(250, 400);
            this.btnShowAllBooks.Name = "btnShowAllBooks";
            this.btnShowAllBooks.Size = new System.Drawing.Size(200, 36);
            this.btnShowAllBooks.TabIndex = 7;
            this.btnShowAllBooks.Text = "Показать все книги";
            this.btnShowAllBooks.Click += new System.EventHandler(this.btnShowAllBooks_Click);
            // 
            // btnImport
            // 
            this.btnImport.BorderRadius = 10;
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(480, 400);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(90, 36);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "Импорт";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BorderRadius = 10;
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(580, 400);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 36);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Экспорт";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLanguageToggle
            // 
            this.btnLanguageToggle.BorderRadius = 10;
            this.btnLanguageToggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.btnLanguageToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLanguageToggle.ForeColor = System.Drawing.Color.White;
            this.btnLanguageToggle.Location = new System.Drawing.Point(676, 411);
            this.btnLanguageToggle.Name = "btnLanguageToggle";
            this.btnLanguageToggle.Size = new System.Drawing.Size(61, 25);
            this.btnLanguageToggle.TabIndex = 10;
            this.btnLanguageToggle.Text = "EN";
            this.btnLanguageToggle.Click += new System.EventHandler(this.btnLanguageToggle_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.ItemHeight = 16;
            this.lstBooks.Location = new System.Drawing.Point(250, 40);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(487, 340);
            this.lstBooks.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(69, 18);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Название";
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Location = new System.Drawing.Point(20, 80);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(43, 18);
            this.lblAuthor.TabIndex = 13;
            this.lblAuthor.Text = "Автор";
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Location = new System.Drawing.Point(20, 140);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(84, 18);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "Год издания";
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(20, 280);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(43, 18);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Поиск";
            // 
            // lblBooks
            // 
            this.lblBooks.BackColor = System.Drawing.Color.Transparent;
            this.lblBooks.Location = new System.Drawing.Point(250, 20);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(41, 18);
            this.lblBooks.TabIndex = 16;
            this.lblBooks.Text = "Книги";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 10;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(205)))), ((int)(((byte)(161)))));
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(707, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 17;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BorderRadius = 10;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(205)))), ((int)(((byte)(161)))));
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(671, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 18;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.btnShowAllBooks);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnLanguageToggle);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Управление библиотекой";
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}