using System.Collections.Generic;
using System.Drawing;
using GroupEMosaicator.IO;
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
        ///     Gets the palette images.
        /// </summary>
        /// <value>
        ///     The palette images.
        /// </value>
        public List<Image> PaletteImages { get; private set; }

        /// <summary>
        /// Gets the average colors of the palette images.
        /// </summary>
        /// <value>
        ///     The average palette colors.
        /// </value>
        public List<Color> PaletteColors { get; private set; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="MosaicController"/> class.
        /// </summary>
        public MosaicController()
        {
            this.creator = new MosaicCreator();
            this.PaletteImages = new List<Image>();
            this.PaletteColors = new List<Color>();
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
        /// <returns>A picture mosaic image.</returns>
        public Image CreatePictureMosaic(int blockSize, Image image)
        {
            Image mosaicImage = null;

            if (this.PaletteImages.Capacity != 0 && this.PaletteColors.Capacity != 0)
            {
                var bitmap = new Bitmap(image);
                mosaicImage = this.creator.CreatePictureMosaic(blockSize, bitmap, this.PaletteImages, this.PaletteColors);
            }

            return mosaicImage;
        }

        /// <summary>
        ///     Reads the palette images from a folder.
        /// </summary>
        public void ReadImagesFromFolder()
        {
            var images = FileIo.ReadImagesFromFolder();
            this.PaletteImages = new List<Image>(images);

            if (this.PaletteImages.Capacity != 0)
            {
                this.PaletteColors = new List<Color>(this.getPaletteColors());
            }
            
        }

        private IEnumerable<Color> getPaletteColors()
        {
            var paletteColors = new List<Color>();

            foreach (var image in this.PaletteImages)
            {
                var imgRect = new Rectangle(0, 0, image.Width, image.Height);
                var bitmap = (Bitmap) image;
                paletteColors.Add(PixelFactory.GetAverageColor(imgRect, bitmap));
            }

            return paletteColors;
        }
    }
}
