using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class Form1 : Form
    {
        private BookManager bookManager = new BookManager();

        public Form1()
        {
            InitializeComponent();
            UpdateLocalization(); // Применить локализацию при запуске
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            int year = (int)numYear.Value;

            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(author))
            {
                bookManager.AddBook(title, author, year);
                MessageBox.Show(Localization.Translate("AddBookSuccess"), Localization.Translate("Success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitle.Clear();
                txtAuthor.Clear();
                numYear.Value = DateTime.Now.Year;
                UpdateBookList();
            }
            else
            {
                MessageBox.Show(Localization.Translate("AddBookError"), Localization.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0)
            {
                var selectedBook = bookManager.GetAllBooks()[lstBooks.SelectedIndex];
                if (bookManager.RemoveBook(selectedBook.Id))
                {
                    MessageBox.Show(Localization.Translate("RemoveBookSuccess"), Localization.Translate("Success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateBookList();
                }
                else
                {
                    MessageBox.Show(Localization.Translate("RemoveBookError"), Localization.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Localization.Translate("RemoveBookSelectError"), Localization.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var results = bookManager.SearchBooks(keyword);
                lstBooks.Items.Clear();

                if (results.Any())
                {
                    foreach (var book in results)
                    {
                        lstBooks.Items.Add(FormatBookDisplay(book));
                    }
                }
                else
                {
                    MessageBox.Show(Localization.Translate("SearchNoResults"), Localization.Translate("Info"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(Localization.Translate("SearchKeywordError"), Localization.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAllBooks_Click(object sender, EventArgs e)
        {
            UpdateBookList();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileExtension = Path.GetExtension(openFileDialog.FileName).ToLower();
                        switch (fileExtension)
                        {
                            case ".csv":
                                bookManager.ImportBooks(openFileDialog.FileName);
                                MessageBox.Show(Localization.Translate("ImportCSVSuccess"), Localization.Translate("Success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case ".txt":
                                bookManager.AddBooksFromTextFile(openFileDialog.FileName);
                                MessageBox.Show(Localization.Translate("ImportTXTSuccess"), Localization.Translate("Success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            default:
                                MessageBox.Show(Localization.Translate("ImportFormatError"), Localization.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                        UpdateBookList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{Localization.Translate("ImportError")} {ex.Message}", Localization.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileExtension = Path.GetExtension(saveFileDialog.FileName).ToLower();
                        switch (fileExtension)
                        {
                            case ".csv":
                                bookManager.ExportBooks(saveFileDialog.FileName);
                                MessageBox.Show(Localization.Translate("ExportCSVSuccess"), Localization.Translate("Success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case ".txt":
                                bookManager.ExportBooksToTextFile(saveFileDialog.FileName);
                                MessageBox.Show(Localization.Translate("ExportTXTSuccess"), Localization.Translate("Success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case ".pdf":
                                bookManager.ExportBooksToPdf(saveFileDialog.FileName);
                                MessageBox.Show(Localization.Translate("ExportPDFSuccess"), Localization.Translate("Success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            default:
                                MessageBox.Show(Localization.Translate("ExportFormatError"), Localization.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{Localization.Translate("ExportError")} {ex.Message}", Localization.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLanguageToggle_Click(object sender, EventArgs e)
        {
            Localization.ToggleLanguage();
            UpdateLocalization();
        }

        private void UpdateLocalization()
        {
            lblTitle.Text = Localization.Translate("Title");
            lblAuthor.Text = Localization.Translate("Author");
            lblYear.Text = Localization.Translate("Year");
            lblSearch.Text = Localization.Translate("Search");
            lblBooks.Text = Localization.Translate("Books");
            btnAddBook.Text = Localization.Translate("AddBook");
            btnRemoveBook.Text = Localization.Translate("RemoveBook");
            btnSearchBook.Text = Localization.Translate("Search");
            btnShowAllBooks.Text = Localization.Translate("ShowAllBooks");
            btnImport.Text = Localization.Translate("Import");
            btnExport.Text = Localization.Translate("Export");
            this.Text = Localization.Translate("LibraryManagement");
            btnLanguageToggle.Text = Localization.CurrentLanguage == "ru" ? "EN" : "RU";
        }

        private void UpdateBookList()
        {
            lstBooks.Items.Clear();
            var allBooks = bookManager.GetAllBooks();

            foreach (var book in allBooks)
            {
                lstBooks.Items.Add(FormatBookDisplay(book));
            }
        }

        private string FormatBookDisplay(Book book)
        {
            return $"ID: {book.Id}, {Localization.Translate("Title")}: {book.Title}, {Localization.Translate("Author")}: {book.Author}, {Localization.Translate("Year")}: {book.Year}";
        }

    }
}
