using System.Drawing;

namespace GroupEMosaicator.View.Overlays
{

    /// <summary>
    /// Parent class for shape overlays
    /// </summary>
    public abstract class ShapeOverlay
    {


        public abstract Image CreateGrid(Image image, int blockSize);

    }
}