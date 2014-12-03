using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GroupEMosaicator.IO
{
    public static class FileIo
    {
        #region Public Methods

        public static Bitmap OpenFile()
        {
            var openDialog = new OpenFileDialog {Title = @"Open..."};

            filterFileExtensions(openDialog);

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    return new Bitmap(openDialog.OpenFile());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Oops! It seems there was a problem loading the image. Please try again!");
                    Console.WriteLine(ex.StackTrace);
                }
            }
            return null;
        }

        public static void SaveFile(Image image)
        {
            var saveDialog = new SaveFileDialog {Title = @"Save..."};

            filterFileExtensions(saveDialog);

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream imageStream = saveDialog.OpenFile();

                    switch (saveDialog.FilterIndex)
                    {
                        case 1:
                            image.Save(imageStream, ImageFormat.Jpeg);
                            break;
                        case 2:
                            image.Save(imageStream, ImageFormat.Gif);
                            break;
                        case 3:
                            image.Save(imageStream, ImageFormat.Bmp);
                            break;
                        case 4:
                            image.Save(imageStream, ImageFormat.Png);
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
        }

        public static List<Image> ReadImagesFromFolder()
        {
            var images = new List<Image>();

            var folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var directory = new DirectoryInfo(folderDialog.SelectedPath);

                    IEnumerable<FileInfo> files = readImageFilesFromDirectory(directory);

                    foreach (FileInfo fileInfo in files)
                    {
                        images.Add(Image.FromStream(fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.None)));
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(@"Oops! There was a problem reading images from the folder. Please try again!");
                    Console.WriteLine(ex.StackTrace);
                }
            }

            return images;
        }

        #endregion

        #region Private Helper Methods

        private static IEnumerable<FileInfo> readImageFilesFromDirectory(DirectoryInfo directory)
        {
            string[] extensions = {".jpg", ".png", ".bmp", ".gif"};

            return directory.GetFiles()
                .Where(file => extensions.Contains(file.Extension.ToLower()))
                .ToList();
        }

        private static void filterFileExtensions(FileDialog fileDialog)
        {
            const string imageFilters =
                "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|PNG (*.png)|*.png|" +
                "Image Files (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png";
            fileDialog.Filter = imageFilters;
        }

        #endregion
    }
}