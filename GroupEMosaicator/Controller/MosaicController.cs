using System.Drawing;
using System.Windows.Forms;
using GroupEMosaicator.Model;

namespace GroupEMosaicator.Controller
{
    /// <summary>
    ///     This class controls the creation of block and picture mosaics.
    /// </summary>
    public class MosaicController
    {
        private readonly MosaicCreator creator;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MosaicController" /> class.
        /// </summary>
        public MosaicController()
        {
            this.creator = new MosaicCreator();
        }

        /// <summary>
        ///     Creates a square block mosaic.
        /// </summary>
        /// <param name="blockSize">Size of the block.</param>
        /// <param name="image">The image.</param>
        /// <returns>A square-block mosaic image.</returns>
        public Image CreateSquareBlockMosaic(int blockSize, Image image)
        {
            var bitmap = new Bitmap(image);
            return this.creator.CreateSquareBlockMosaic(blockSize, bitmap);
        }

        /// <summary>
        ///     Creates a triangle block mosaic.
        /// </summary>
        /// <param name="blockSize">Size of the block.</param>
        /// <param name="image">The image.</param>
        /// <returns>A triangle-block mosaic image.</returns>
        public Image CreateTriangleBlockMosaic(int blockSize, Image image)
        {
            var bitmap = new Bitmap(image);
            return this.creator.CreateTriangleBlockMosaic(blockSize, bitmap);
        }

        /// <summary>
        ///     Creates a picture mosaic.
        /// </summary>
        /// <param name="blockSize">Size of the block.</param>
        /// <param name="image">The image.</param>
        /// <param name="palette">The palette.</param>
        /// <returns>
        ///     A picture mosaic image.
        /// </returns>
        public Image CreatePictureMosaic(int blockSize, Image image, ImageList.ImageCollection palette)
        {
            Image mosaicImage = null;

            if (palette.Count > 0)
            {
                var bitmap = new Bitmap(image);
                mosaicImage = this.creator.CreatePictureMosaic(blockSize, bitmap, palette);
            }

            return mosaicImage;
        }
    }
}