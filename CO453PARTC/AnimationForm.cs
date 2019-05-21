using System;
using System.Drawing;
using System.Windows.Forms;

namespace CO453PARTC
{
    public partial class AnimationForm : Form
    {
        private const int MAXN_IMAGES = 4;
        private const int MAXN_CITIES = 8;

        private Sprite copterSprite = new Sprite(MAXN_IMAGES);
        private Sprite pigSprite = new Sprite(MAXN_IMAGES);
        
        private int backGroundImageNo = 1;

        private Random generator = new Random();

        /// <summary>
        /// This is the method that initializes the form.
        /// </summary>
        public AnimationForm()
        {
            InitializeComponent();

            speedHScrollBar.Value = 30;

            //sprite.LoadImages("Butterflies/bfly");
            //sprite.LoadImages("Horse/horsey");
            copterSprite.LoadImages("Copter/copter");
            copterSprite.Speed = 30;

            pigSprite.LoadImages("Pigs/pig");
            pigSprite.Speed = 10;
        }

        /// <summary>
        /// This method will close the form when the closeButton
        /// is clicked.
        /// </summary>
        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This method will show the copter gif in the copterPictureBox.
        /// </summary>
        private void ShowCopterImage(object sender, EventArgs e)
        {
            ShowPicture(copterPictureBox, copterSprite);
        }
        
        /// <summary>
        /// This method will show the pig gif in the pigPictureBox.
        /// </summary>
        private void ShowPigImage(object sender, EventArgs e)
        {
            ShowPicture(pigPictureBox, pigSprite);
        }

        /// <summary>
        /// This method is used to show an image. It also changes the 
        /// background color.
        /// </summary>
        private void ShowPicture(PictureBox pictureBox, Sprite sprite)
        {
            pictureBox.Image = sprite.GetNextImage();
            pictureBox.Left += sprite.Speed;

            if (pictureBox.Left >= this.Width)
            {
                backGroundImageNo++;
                if (backGroundImageNo > MAXN_CITIES) backGroundImageNo = 1;
                BackgroundImage = new Bitmap("Town and Sky/City" + backGroundImageNo + ".wmf");

                pictureBox.Left = -pictureBox.Width;
                pictureBox.Top += 100;

                if (pictureBox.Top > this.Height - pictureBox.Height)
                {
                    pictureBox.Top = 10;
                }
            }
        }

        /// <summary>
        /// This method will start the application when the start
        /// button is clicked.
        /// </summary>
        private void StartAnimation(object sender, EventArgs e)
        {
            animationTimer.Start();
            pigAnimationTimer.Start();
        }

        /// <summary>
        /// This method will stop the application when the stop
        /// button is clicked.
        /// </summary>
        private void StopAnimation(object sender, EventArgs e)
        {
            animationTimer.Stop();
            pigAnimationTimer.Stop();
        }

        /// <summary>
        /// This method will pick up the date and time
        /// and convert them.
        /// </summary>
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// Called when the scroll bar is changed.
        /// </summary>
        private void UpdateSpeed(object sender, ScrollEventArgs e)
        {
            copterSprite.Speed = speedHScrollBar.Value;
        }
    }
}