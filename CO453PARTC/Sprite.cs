using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453PARTC
{
    class Sprite
    {
        private int maxnImages = 0;

        private Image[] images;

        private int currentImageNo = 0;

        public Sprite(int maxnImages)
        {
            this.maxnImages = maxnImages;
            images = new Image[maxnImages];
        }

        public void LoadImages(string baseName)
        {
            for (int count = 0; count < maxnImages; count++)
            {
                images[count] = Image.FromFile(baseName + count + ".gif");
            }
        }

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