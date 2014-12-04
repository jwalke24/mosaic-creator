using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GroupEMosaicator.View
{
    /// <summary>
    ///     This class represents the image palette gallery form.
    /// </summary>
    public partial class PaletteForm : Form
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PaletteForm" /> class.
        /// </summary>
        /// <param name="imageList">The image list.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if the image list is null.</exception>
        public PaletteForm(ImageList imageList)
        {
            if (imageList == null)
            {
                throw new ArgumentNullException();
            }

            this.InitializeComponent();
            this.setUpPaletteView(imageList);
        }

        private void setUpPaletteView(ImageList imageList)
        {
            this.imagePaletteView.LargeImageList = imageList;
            this.imagePaletteView.LargeImageList.ImageSize = new Size(100, 100);
            this.imagePaletteView.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;

            for (int i = 0; i < this.imagePaletteView.LargeImageList.Images.Count; i++)
            {
                int imageNumber = i + 1;
                var item = new ListViewItem(imageNumber.ToString(CultureInfo.CurrentCulture), i);
                this.imagePaletteView.Items.Add(item);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}