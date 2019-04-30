using System;
using System.Drawing;
using System.Windows.Forms;

namespace CO453PARTC
{
    public partial class AnimationForm : Form
    {
        private Sprite sprite = new Sprite(8);

        public AnimationForm()
        {
            InitializeComponent();

            //sprite.LoadImages("Butterflies/bfly");
            sprite.LoadImages("Horse/horsey");
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
        
        private void ShowImage(object sender, EventArgs e)
        {
            butterflyPictureBox.Image = sprite.GetNextImage();
        }

        private void StartAnimation(object sender, EventArgs e)
        {
            animationTimer.Start();
        }

        private void StopAnimation(object sender, EventArgs e)
        {
            animationTimer.Stop();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}