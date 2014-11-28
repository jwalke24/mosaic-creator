using System;
using System.Drawing;

namespace GroupEMosaicator.Model
{
    internal class BlockMosaicCreator
    {
        public Bitmap CreateMosaicBlocks(int blockSize, Bitmap image)
        {
            if (image == null)
            {
                throw new Exception("the subimage cannot be null");
            }

            int width = blockSize;
            int height = blockSize;

            var mosaicImage = new Bitmap(image);

            for (int x = 0; x < image.Width; x += width)
            {
                for (int y = 0; y < image.Height; y += height)
                {
                    var rectangle = new Rectangle(x, y, width, height);
                    Color pixelColor = image.GetPixel(x, y);
                    int redValue = pixelColor.R;
                    int blueValue = pixelColor.B;
                    int greenValue = pixelColor.G;
                }
            }
            return null;
        }

        private void GetSubimage()
        {
            
        }
    }
}