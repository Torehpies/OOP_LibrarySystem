using FINAL_PROJECT_DRAFTZ_5_.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT_DRAFTZ_5_
{


    public partial class BookDetails : Form
    {
        string title;
        string isbn;
        string author;
        string category;
        string publisher;
        string published;
        Image icon;

        public BookDetails(string title, string isbn, string author, string category, string publisher, string published, Image icon)
        {
            InitializeComponent();
            loadDetails(title, isbn, author, category, publisher, published, icon);
        }

        // Edit constructor
        private Books editBook;
        public BookDetails(Books book)
        {
            InitializeComponent();
            this.editBook = book;
            loadDetails(book.Title, book.ISBN, book.Author, book.Category, book.Publisher, book.Published, book.Icon);
            BorrowButton.Text = "Save Changes";
        }

        // Original information for insertion into database
        private string originalISBN;
        private void loadDetails(string title, string isbn, string author, string category, string publisher, string published, Image icon)
        {
            this.title = title;
            this.isbn = isbn;
            originalISBN = isbn;
            this.author = author;
            this.category = category;
            this.publisher = publisher;
            this.published = published;
            this.icon = icon;

            titleLabel.Text = title;
            isbn10Label.Text = isbn;
            authorLabel.Text = author;
            categoryLabel.Text = category;
            publisherLabel.Text = publisher;
            publishedLabel.Text = published;


            
            picture.Image = icon;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Image newIcon;
        private void picture_Click(object sender, EventArgs e)
        {
            if (editBook != null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picture.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in uploading image.");
                        return;
                    }
                }

                newIcon = picture.Image;
            }
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            if (editBook != null)
            {

                grabLabelTexts(modified);

                if (newIcon != null)
                {
                    Books bookToAdd = new Books(title, isbn, author, category, publisher, published);
                    string path = SaveImageInResourceFolder(bookToAdd, newIcon);
                    string[] columnsToUpdate = { "title", "author", "isbn", "category", "publisher", "published", "picturePath" };
                    string[] newValues = { titleLabel.Text, authorLabel.Text, isbn10Label.Text, categoryLabel.Text, publisherLabel.Text, publishedLabel.Text, path };
                    bookCRUD.UpdateInfos(columnsToUpdate, newValues, "isbn", originalISBN);
                } 
                else
                {
                    string[] columnsToUpdate = { "title", "author", "isbn", "category", "publisher", "published" };
                    string[] newValues = { titleLabel.Text, authorLabel.Text, isbn10Label.Text, categoryLabel.Text, publisherLabel.Text, publishedLabel.Text };
                    bookCRUD.UpdateInfos(columnsToUpdate, newValues, "isbn", originalISBN);

                }

                
            }
            else
            {
                BookContainer addBooks = new BookContainer();
                addBooks.addBook(title, isbn, author, category, publisher, published, icon);

            }

        }

        public string SaveImageInResourceFolder(Books book, Image image)
        {
            string projectDiretory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string resourceFolderPath = Path.Combine(projectDiretory, "Resources");

            if (!Directory.Exists(resourceFolderPath))
            {
                Directory.CreateDirectory(resourceFolderPath);

            }
                

            string imagePath = Path.Combine(resourceFolderPath, book.Title + ".jpg");
            MessageBox.Show(imagePath);
            image.Save(imagePath + System.Drawing.Imaging.ImageFormat.Jpeg);


            return book.Title + ".jpg";
        }



        List<TextBox> modified = new List<TextBox>();
        private void grabLabelTexts(List<TextBox> textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                Label label = new Label();
                label.Text = textBox.Text;
                label.Location = textBox.Location;
                label.Size = label.Size;

                label.Parent = textBox.Parent;

                label.BringToFront();
                textBox.Visible = false;
                label.Focus();
            }

        }
        private void labelToTextbox(Label label)
        {
            TextBox textBox = new TextBox();

            // Properties when converting
            textBox.Text = "";
            textBox.Location = label.Location;
            textBox.Size = label.Size;

            //Set the same parent as the label
            textBox.Parent = label.Parent;

            // Adds the textbox
            textBox.BringToFront();
            label.Visible = false;
            textBox.Focus();

            // Set the focus
            textBox.Focus();

            // Add modified
            modified.Add(textBox);

            // Event handler
            textBox.TextChanged += (s, args) =>
            {
                label.Text = textBox.Text;

            };

            textBox.Leave += (s, args) =>
            {
                Controls.Remove(textBox);
                Controls.Add(label);
            };

        }

        private void isbn10Label_Click(object sender, EventArgs e)
        {
            if (editBook != null)
            {
                labelToTextbox(isbn10Label);

            }
        }

        private void authorLabel_Click(object sender, EventArgs e)
        {
            if (editBook != null)
            {
                labelToTextbox(authorLabel);
            }
        }

        private void categoryLabel_Click(object sender, EventArgs e)
        {
            if (editBook != null)
            {
                labelToTextbox(categoryLabel);
            }
        }

        private void publisherLabel_Click(object sender, EventArgs e)
        {
            if (editBook != null)
            {
                labelToTextbox(publisherLabel);
            }
        }

        private void publishedLabel_Click(object sender, EventArgs e)
        {
            if (editBook != null)
            {
                labelToTextbox(publishedLabel);
            }
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            if (editBook != null)
            {
                labelToTextbox(titleLabel);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
