using System;
using System.Drawing;
using System.Windows.Forms;
using GroupEMosaicator.Controller;
using GroupEMosaicator.IO;
using GroupEMosaicator.View.Overlays;

namespace GroupEMosaicator.View
{
    public partial class MosaicForm : Form
    {
        private readonly MosaicController mosaicManager;
        private Image originalImage;

        public MosaicForm()
        {
            this.InitializeComponent();
            this.mosaicManager = new MosaicController();
            this.imagePalette = new ImageList();
        }

        public int BlockSizeTextBox
        {
            get
            {
                int number = 0;
                try
                {
                    number = Convert.ToInt32(this.blockSizeTextBox.Text);
                    if (number < 0)
                    {
                        MessageBox.Show(@"Cannot be a negative number");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"oops! Must be an integer!");
                }

                return number;
            }
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            this.originalImage = FileIo.OpenFile();

            if (this.originalImage != null)
            {
                this.originalImageBox.Image = (Image) this.originalImage.Clone();
                this.enableBlockMosaicControls();
                this.enablePictureMosaicControls();
            }
        }

        private void enableBlockMosaicControls()
        {
            this.createBlockMosaicToolStripMenuItem.Enabled = true;
            this.solidBlockMosaicToolStripMenuItem.Enabled = true;
            this.toolStripGridButton.Enabled = true;
            this.blockSizeTextBox.Enabled = true;
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (this.mosaicImageBox.Image != null)
            {
                FileIo.SaveFile(this.mosaicImageBox.Image);
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void squareGridToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            try
            {
                this.removeGridToolStripMenuItem_Click(sender, eventArgs);
                ShapeOverlay squareOverlay = new SquareOverlay();
                this.originalImageBox.Image = squareOverlay.CreateGrid(this.originalImageBox.Image,
                    this.BlockSizeTextBox);
            }
            catch (Exception)
            {
                MessageBox.Show(@"oops! Must be an integer!");
            }
        }

        private void removeGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.originalImageBox.Image = null;
            this.originalImageBox.Image = (Image) this.originalImage.Clone();
        }

        private void traingleGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.removeGridToolStripMenuItem_Click(sender, e);
                ShapeOverlay triangleOverlay = new TriangleOverlay();
                this.originalImageBox.Image = triangleOverlay.CreateGrid(this.originalImageBox.Image,
                    this.BlockSizeTextBox);
            }
            catch (Exception)
            {
                MessageBox.Show(@"oops! Must be an integer!");
            }
        }

        private void blockSizeTextBox_Click(object sender, EventArgs e)
        {
            this.blockSizeTextBox.Clear();
        }

        private void blockSizeTextBox_Left(object sender, EventArgs e)
        {
            if (this.blockSizeTextBox.Text.Equals(""))
            {
                this.blockSizeTextBox.Text = @"Enter Block Size";
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            this.openMenuItem_Click(sender, e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.saveMenuItem_Click(sender, e);
        }

        private void enableSavingControls()
        {
            this.saveButton.Enabled = true;
            this.saveMenuItem.Enabled = true;
        }

        private void createPictureMosaicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mosaicImageBox.Image = this.mosaicManager.CreatePictureMosaic(this.BlockSizeTextBox,
                (Image) this.originalImage.Clone(), this.imagePalette.Images);

            if (this.mosaicImageBox.Image != null)
            {
                this.enableSavingControls();
            }
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.imagePalette.Images.Clear();
            this.imagePalette.Images.AddRange(FileIo.ReadImagesFromFolder().ToArray());

            if (this.imagePalette.Images.Count > 0)
            {
                this.imagePaletteLabel.Text = this.imagePalette.Images.Count + @" images in palette";
                this.enablePictureMosaicControls();
            }
        }

        private void enablePictureMosaicControls()
        {
            if (this.pictureMosaicCanBeCreated())
            {
                this.pictureMosaicToolStripMenuItem.Enabled = true;
                this.createPictureMosaicToolStripMenuItem.Enabled = true;
            }
        }

        private bool pictureMosaicCanBeCreated()
        {
            return (this.originalImageBox.Image != null) && (this.imagePalette.Images.Count > 0);
        }

        private void solidBlockMosaicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.squareBlocksToolStripMenuItem_Click(sender, e);
        }

        private void pictureMosaicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.createPictureMosaicToolStripMenuItem_Click(sender, e);
        }

        private void squareBlocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mosaicImageBox.Image = this.mosaicManager.CreateSquareBlockMosaic(this.BlockSizeTextBox,
                this.originalImage);

            if (this.mosaicImageBox.Image != null)
            {
                this.enableSavingControls();
            }
        }
    }
}