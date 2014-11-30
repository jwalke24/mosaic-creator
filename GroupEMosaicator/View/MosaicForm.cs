using System;
using System.Drawing;
using System.Windows.Forms;
using GroupEMosaicator.IO;
using GroupEMosaicator.Model;
using GroupEMosaicator.View.Overlays;

namespace GroupEMosaicator.View
{
    public partial class MosaicForm : Form
    {
        private readonly MosaicCreator blockManager;
        private Image originalImage;

        public MosaicForm()
        {
            this.InitializeComponent();
            this.blockManager = new MosaicCreator();
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
                        MessageBox.Show("Cannot be a negative number");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("oops! Must be an integer!");
                }

                return number;
            }
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            var iO = new Fileio(this.originalImageBox);
            this.originalImage = iO.OpenFile();
            if (this.originalImage != null)
            {
                this.originalImageBox.Image = (Image) this.originalImage.Clone();
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            var iO = new Fileio(this.mosaicImageBox);
            iO.SaveFile();
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
                MessageBox.Show("oops! Must be an integer!");
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
                MessageBox.Show("oops! Must be an integer!");
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
                this.blockSizeTextBox.Text = "Enter Block Size";
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

        private void createBlockMosaicToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void createPictureMosaicToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void squareBlocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mosaicImageBox.Image = this.blockManager.CreateSquareBlockMosaic(this.BlockSizeTextBox,
                (Bitmap)this.originalImage);
        }
    }
}