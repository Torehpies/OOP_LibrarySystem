using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Web;
using System.Security.Policy;

namespace FINAL_PROJECT_DRAFTZ_5_.Controls
{
    public partial class AddBookDashboard : UserControl
    {
        public event EventHandler ReturnToBookInventory;
        public AddBookDashboard()
        {
            InitializeComponent();
        }

        private void AddBooks_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Retrieve kung meron na ba itong book na ito.
            Database checkBook = new Database();
            if (checkBook.checkBook(titleText.Text))
            {
                MessageBox.Show("Book Title exists within the database!");
                return;
            }

            if (checkBook.checkBook(isbnText.Text))
            {
                MessageBox.Show("ISBN already exists within the database!");
                return;
            }

            int n;
            bool isNumeric = int.TryParse(bookNoText.Text, out n);

            if (!isNumeric)
            {
                MessageBox.Show("Invalid number!");
                return;

            }


            if (titleText.Text.Length == 0 || isbnText.Text.Length == 0 || authorText.Text.Length == 0 || dateText.Text.Length == 0 || categoryText.Text.Length == 0 || publisherText.Text.Length == 0 || bookNoText.Text.Length == 0)
            {
                MessageBox.Show("Make sure that everything is filled.");
                return;
            }

            if (pictureBox.Image == null)
            {
                MessageBox.Show("Make sure to include the book cover!");
                return;
            }




            Books bookToAdd = new Books(titleText.Text, isbnText.Text, authorText.Text, categoryText.Text, publisherText.Text, dateText.Text);
            string imagePath = SaveImageInResourceFolder(bookToAdd, pictureBox.Image);
            //bookToAdd.ImagePath = imagePath;
            //bookToAdd.ImagePath = imagePath;
            var year = DateTime.Parse(dateText.Text).Year;
            bookCRUD.AddBooks(titleText.Text, authorText.Text, isbnText.Text, categoryText.Text, publisherText.Text, year, int.Parse(bookNoText.Text), imagePath);

            LibraryEdit.Instance.populateItems();

            // Reset the textfields
            titleText.ResetText();
            isbnText.ResetText();
            authorText.ResetText();
            dateText.ResetText();
            categoryText.ResetText();
            publisherText.ResetText();
            bookNoText.ResetText();





        }

        public string SaveImageInResourceFolder(Books book, Image image)
        {
            string projectDiretory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string resourceFolderPath = Path.Combine(projectDiretory, "Resources");

            string imageName = book.Title;

            string imagePath = Path.Combine(resourceFolderPath, imageName);

            MessageBox.Show(imagePath);
            MessageBox.Show(resourceFolderPath);
            image.Save(imagePath + ".jpg");


            return imageName + ".jpg";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in uploading image.");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bookNoText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
