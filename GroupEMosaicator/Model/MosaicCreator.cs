using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GroupEMosaicator.Model
{
    internal class MosaicCreator
    {
        private List<Color> paletteColors;

        /// <summary>
        ///     Creates the square block mosaic.
        /// </summary>
        /// <param name="blockSize">Size of the block.</param>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        public Image CreateSquareBlockMosaic(int blockSize, Bitmap image)
        {
            if (blockSize <= 0)
            {
                return null;
            }

            var newBitmap = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(newBitmap);

            for (int column = 0; column < image.Height; column += blockSize)
            {
                for (int row = 0; row < image.Width; row += blockSize)
                {
                    var averagingArea = new Rectangle(row, column, blockSize, blockSize);
                    Color averageColor = PixelFactory.GetAverageColor(averagingArea, image);
                    var averageBrush = new SolidBrush(averageColor);
                    graphics.FillRectangle(averageBrush, row, column, blockSize, blockSize);
                }
            }
            return newBitmap;
        }

        /// <summary>
        ///     Creates the triangle block mosaic.
        /// </summary>
        /// <param name="blockSize">Size of the block.</param>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        public Image CreateTriangleBlockMosaic(int blockSize, Bitmap image)
        {
            if (blockSize <= 0)
            {
                return null;
            }

            var newBitmap = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(newBitmap);

            for (int column = 0; column < image.Height; column += blockSize)
            {
                for (int row = 0; row < image.Width; row += blockSize)
                {
                    var averagingArea = new Rectangle(row, column, blockSize, blockSize);
                    Color averageColor = PixelFactory.GetAverageColor(averagingArea, image);
                    var averageBrush = new SolidBrush(averageColor);
                    graphics.FillRectangle(averageBrush, row, column, blockSize, blockSize);
                }
            }
            return newBitmap;
        }

        /// <summary>
        ///     Creates the picture mosaic.
        /// </summary>
        /// <param name="blockSize">Size of the block.</param>
        /// <param name="bitmap">The image.</param>
        /// <param name="palette">The palette.</param>
        /// <returns></returns>
        public Image CreatePictureMosaic(int blockSize, Bitmap bitmap, ImageList.ImageCollection palette)
        {
            Graphics g = Graphics.FromImage(bitmap);

            this.paletteColors = new List<Color>(this.averagePaletteColors(palette));

            for (int y = 0; y < bitmap.Height; y += blockSize)
            {
                for (int x = 0; x < bitmap.Width; x += blockSize)
                {
                    var dstRect = new Rectangle(x, y, blockSize, blockSize);
                    Color averageColor = PixelFactory.GetAverageColor(dstRect, bitmap);
                    Image bestMatchImage = this.getBestMatchPaletteImage(averageColor, palette);
                    var srcRect = new Rectangle(0, 0, bestMatchImage.Width, bestMatchImage.Height);
                    g.DrawImage(bestMatchImage, dstRect, srcRect, GraphicsUnit.Pixel);
                }
            }
            g.Dispose();

            return bitmap;
        }

        private IEnumerable<Color> averagePaletteColors(ImageList.ImageCollection palette)
        {
            var averageColors = new List<Color>();

            for (int i = 0; i < palette.Count; i++)
            {
                var srcRect = new Rectangle(0, 0, palette[i].Width, palette[i].Height);
                Color currentAverage = PixelFactory.GetAverageColor(srcRect, (Bitmap) palette[i]);
                averageColors.Add(currentAverage);
            }

            return averageColors;
        }

        private Image getBestMatchPaletteImage(Color averageColor, ImageList.ImageCollection palette)
        {
            double smallestDifference = Double.MaxValue;
            int bestMatchIndex = 0;

            foreach (Color currentColor in this.paletteColors)
            {
                double colorDifference = this.calculateColorDifference(averageColor, currentColor);

                if (colorDifference < smallestDifference)
                {
                    smallestDifference = colorDifference;
                    bestMatchIndex = this.paletteColors.IndexOf(currentColor);
                }
            }

            return palette[bestMatchIndex];
        }

        private double calculateColorDifference(Color averageColor, Color paletteColor)
        {
            long redMean = (averageColor.R + paletteColor.R)/2;
            long redDifference = averageColor.R - paletteColor.R;
            long greenDifference = averageColor.G - paletteColor.G;
            long blueDifference = averageColor.B - paletteColor.B;
            return
                Math.Sqrt((redDifference*redDifference) + (greenDifference*greenDifference) +
                          (blueDifference*blueDifference));
        }
    }
}