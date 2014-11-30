using System.Drawing;

namespace GroupEMosaicator.Model
{
    internal class MosaicCreator
    {

        public Image CreateBlockMosaic(int blockSize, Bitmap image)
        {
            if (blockSize <= 0)
            {
                return null;
            }
            // Start with the current image.
            var newBitmap = new Bitmap(image);
            using (Graphics graphics = Graphics.FromImage(newBitmap))
            {
                
                // Pixelate the selected area.
                for (int column = 0; column < image.Height; column += blockSize)
                {
                    for (int row = 0; row < image.Width; row += blockSize)
                    {
                        // Get the average color in the area.
                        Color averageColor = PixelFactory.GetAverageColor(new Rectangle(row, column, blockSize, blockSize), image);

                        // Fill the area.
                        using (var averageBrush = new SolidBrush(averageColor))
                        {
                            graphics.FillRectangle(averageBrush, row,  column, blockSize, blockSize);
                        }
                    }
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