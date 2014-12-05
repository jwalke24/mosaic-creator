using System.Drawing;

namespace GroupEMosaicator.Model
{
    internal class MosaicCreator
    {
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

                    var topPoints = new Point[3];
                    topPoints[0].X = row;
                    topPoints[0].Y = column;
                    topPoints[1].X = row + blockSize;
                    topPoints[1].Y = column;
                    topPoints[2].X = row;
                    topPoints[2].Y = column + blockSize;

                    graphics.FillPolygon(averageTopBrush, topPoints);

                    Color averageBottomColor = PixelFactory.GetAverageColorOfBottomTriangle(averagingArea, image);
                    var averageBottomBrush = new SolidBrush(averageBottomColor);

                    var botPoints = new Point[3];
                    botPoints[0].X = row + blockSize;
                    botPoints[0].Y = column + blockSize;
                    botPoints[1].X = row + blockSize;
                    botPoints[1].Y = column;
                    botPoints[2].X = row;
                    botPoints[2].Y = column + blockSize;

                    graphics.FillPolygon(averageBottomBrush, botPoints);
                }
            }
            return newBitmap;
        }

        public Image CreatePictureMosaic()
        {
            return null;
        }
    }
}