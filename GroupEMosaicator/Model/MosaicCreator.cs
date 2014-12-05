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
                    Color averageColor = PixelFactory.GetAverageColorOfSquareBlock(averagingArea, image);
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

                    Color averageTopColor = PixelFactory.GetAverageColorOfTopTriangle(averagingArea, image);
                    var averageTopBrush = new SolidBrush(averageTopColor);
                    Point[] topPoints = this.getTopTrianglePoints(blockSize, row, column);
                    graphics.FillPolygon(averageTopBrush, topPoints);

                    Color averageBottomColor = PixelFactory.GetAverageColorOfBottomTriangle(averagingArea, image);
                    var averageBottomBrush = new SolidBrush(averageBottomColor);
                    Point[] botPoints = this.getBottomTriangePoints(blockSize, row, column);
                    graphics.FillPolygon(averageBottomBrush, botPoints);
                }
            }
            return newBitmap;
        }

        private Point[] getTopTrianglePoints(int blockSize, int row, int column)
        {
            var topPoints = new Point[3];
            topPoints[0].X = row;
            topPoints[0].Y = column;
            topPoints[1].X = row + blockSize;
            topPoints[1].Y = column;
            topPoints[2].X = row;
            topPoints[2].Y = column + blockSize;
            return topPoints;
        }

        private Point[] getBottomTriangePoints(int blockSize, int row, int column)
        {
            var botPoints = new Point[3];
            botPoints[0].X = row + blockSize;
            botPoints[0].Y = column + blockSize;
            botPoints[1].X = row + blockSize;
            botPoints[1].Y = column;
            botPoints[2].X = row;
            botPoints[2].Y = column + blockSize;
            return botPoints;
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
                    Color averageColor = PixelFactory.GetAverageColorOfSquareBlock(dstRect, bitmap);
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
                Color currentAverage = PixelFactory.GetAverageColorOfSquareBlock(srcRect, (Bitmap) palette[i]);
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
            
            long redDifference = averageColor.R - paletteColor.R;
            long greenDifference = averageColor.G - paletteColor.G;
            long blueDifference = averageColor.B - paletteColor.B;
            return
                Math.Sqrt((redDifference*redDifference) + (greenDifference*greenDifference) +
                          (blueDifference*blueDifference));
        }
    }
}