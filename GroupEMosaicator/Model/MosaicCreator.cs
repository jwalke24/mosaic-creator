using System.Drawing;

namespace GroupEMosaicator.Model
{
    internal class MosaicCreator
    {
        //private List<Image> images;

        public Image CreateBlockMosaic(int blockSize, Bitmap image)
        {
            // Start with the current image.
            Bitmap newBitmap = new Bitmap(image);
            using (Graphics graphics = Graphics.FromImage(newBitmap))
            {
                

                // Pixelate the selected area.
                for (int x = 0; x < image.Width; x += blockSize)
                {
                    for (int y = 0; y < image.Height; y += blockSize)
                    {
                        // Get the average color in the area.
                        Color averageColor = PixelFactory.GetAverageColor(new Rectangle(x, y, blockSize, blockSize), image);

                        // Fill the area.
                        using (SolidBrush averageBrush = new SolidBrush(averageColor))
                        {
                            graphics.FillRectangle(averageBrush, x, y, blockSize, blockSize);
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