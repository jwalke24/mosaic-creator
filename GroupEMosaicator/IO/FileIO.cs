using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace GroupEMosaicator.IO
{
    public class Fileio
    {
        private readonly PictureBox pictureBox;

        public Fileio(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public Bitmap OpenFile()
        {
            var openDialog = new OpenFileDialog();

            filterFileExtensions(openDialog);

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream imageStream = openDialog.OpenFile();
                    var image = new Bitmap(imageStream);
                    return image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Oops! It seems there was a problem loading the image. Please try again!");
                    Console.WriteLine(ex.StackTrace);
                }
            }
            return null;
        }

        public void SaveFile()
        {
            var saveDialog = new SaveFileDialog();
            filterFileExtensions(saveDialog);
            saveDialog.Title = "Save the File";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream imageStream = saveDialog.OpenFile();

                    switch (saveDialog.FilterIndex)
                    {
                        case 1:
                            this.pictureBox.Image.Save(imageStream, ImageFormat.Jpeg);
                            break;
                        case 2:
                            this.pictureBox.Image.Save(imageStream, ImageFormat.Gif);
                            break;
                        case 3:
                            this.pictureBox.Image.Save(imageStream, ImageFormat.Bmp);
                            break;
                        case 4:
                            this.pictureBox.Image.Save(imageStream, ImageFormat.Png);
                            break;
                    }
                    imageStream.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(@"Oops! It seems there was a problem saving the image. Please try again!");
                    Console.WriteLine(ex.StackTrace);
                }
            }
            //TODO set up saving file
        }

        private void filterFileExtensions(OpenFileDialog openDialog)
        {
            const string imageFilters =
                "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|PNG (*.png)|*.png|" +
                "Image Files (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png";
            openDialog.Filter = imageFilters;
        }

        private void filterFileExtensions(SaveFileDialog saveDialog)
        {
            const string imageFilters =
                "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|PNG (*.png)|*.png|" +
                "Image Files (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png";
            saveDialog.Filter = imageFilters;
        }
    }
}