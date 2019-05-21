using System.Drawing;

namespace CO453PARTC
{
    class Sprite
    {
        private int maxnImages = 0;
        private int currentImageNo = 0;
        private Image[] images;
        public int Speed { get; set; }

        public Sprite(int maxnImages)
        {
            this.maxnImages = maxnImages;
            images = new Image[maxnImages];
        }

        /// <summary>
        /// This method will load the images.
        /// </summary>
        public void LoadImages(string baseName)
        {
            for (int count = 0; count < maxnImages; count++)
            {
                images[count] = Image.FromFile(baseName + count + ".gif");
            }
        }

        /// <summary>
        /// This method will get the next image (gif).
        /// </summary>
        public Image GetNextImage()
        {
            Image image = images[currentImageNo];

            if (currentImageNo < maxnImages - 1)
                currentImageNo++;
            else
                currentImageNo = 0;

            return image;
        }
    }
}