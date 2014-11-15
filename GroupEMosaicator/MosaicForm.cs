using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace GroupEMosaicator
{
    public partial class MosaicForm : Form
    {
        public MosaicForm()
        {
            this.InitializeComponent();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();

            this.filterFileExtensions(openDialog);

            this.openImage(openDialog);
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            saveDialog.Title = "Save the File";
            this.saveAsImage(saveDialog);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openImage(OpenFileDialog openDialog)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream imageStream = openDialog.OpenFile();
                    String fileLocation = openDialog.FileName;
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

        private void saveAsImage(SaveFileDialog saveDialog)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream imageStream = saveDialog.OpenFile();

                    switch (saveDialog.FilterIndex)
                    {
                        case 1:
                            this.originalImageBox.Image.Save(imageStream, ImageFormat.Jpeg);
                            break;
                        case 2:
                            this.originalImageBox.Image.Save(imageStream, ImageFormat.Gif);
                            break;
                        case 3:
                            this.originalImageBox.Image.Save(imageStream, ImageFormat.Bmp);
                            break;
                        case 4:
                            this.originalImageBox.Image.Save(imageStream, ImageFormat.Png);
                            break;
                    }
                    imageStream.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(@"Oops! It seems there was a problem saving the image. Please try again!");
                    Console.WriteLine(ex.StackTrace);
                }
                ;
            }
        }

        private
            void filterFileExtensions(OpenFileDialog openDialog)
        {
            const string imageFilters =
                "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|PNG (*.png)|*.png|" +
                "Image Files (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png";
            openDialog.Filter = imageFilters;
        }
    }
}