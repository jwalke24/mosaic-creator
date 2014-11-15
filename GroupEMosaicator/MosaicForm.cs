using System;
using System.Drawing;
using System.Windows.Forms;

namespace GroupEMosaicator
{
    public partial class MosaicForm : Form
    {
        public MosaicForm()
        {
            InitializeComponent();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();

            this.filterFileExtensions(openDialog);

            this.openImage(openDialog);
        }

        private void openImage(OpenFileDialog openDialog)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var imageStream = openDialog.OpenFile();
                    var image = new Bitmap(imageStream);
                    this.originalImageBox.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Oops! It seems there was a problem loading the image. Please try again!");
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        private void filterFileExtensions(OpenFileDialog openDialog)
        {
            const string imageFilters = "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|PNG (*.png)|*.png|" +
                                        "Image Files (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png";
            openDialog.Filter = imageFilters;
        }
    }
}
