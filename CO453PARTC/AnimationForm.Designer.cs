namespace CO453PARTC
{
    partial class AnimationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationForm));
            this.copterPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.speedHScrollBar = new System.Windows.Forms.HScrollBar();
            this.pigPictureBox = new System.Windows.Forms.PictureBox();
            this.pigAnimationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.copterPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pigPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // copterPictureBox
            // 
            this.copterPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.copterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copterPictureBox.Enabled = false;
            this.copterPictureBox.Location = new System.Drawing.Point(248, 63);
            this.copterPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.copterPictureBox.Name = "copterPictureBox";
            this.copterPictureBox.Size = new System.Drawing.Size(100, 100);
            this.copterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copterPictureBox.TabIndex = 0;
            this.copterPictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(256, 343);
            this.startButton.Margin = new System.Windows.Forms.Padding(6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(92, 39);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartAnimation);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(360, 343);
            this.stopButton.Margin = new System.Windows.Forms.Padding(6);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(92, 39);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopAnimation);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(464, 343);
            this.quitButton.Margin = new System.Windows.Forms.Padding(6);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(92, 39);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.CloseForm);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 30;
            this.animationTimer.Tick += new System.EventHandler(this.ShowCopterImage);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 68);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(4, 42);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(43, 20);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Time";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(4, 4);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 20);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // speedHScrollBar
            // 
            this.speedHScrollBar.Location = new System.Drawing.Point(12, 343);
            this.speedHScrollBar.Name = "speedHScrollBar";
            this.speedHScrollBar.Size = new System.Drawing.Size(238, 23);
            this.speedHScrollBar.TabIndex = 5;
            this.speedHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.UpdateSpeed);
            // 
            // pigPictureBox
            // 
            this.pigPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pigPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pigPictureBox.Enabled = false;
            this.pigPictureBox.Location = new System.Drawing.Point(385, 63);
            this.pigPictureBox.Name = "pigPictureBox";
            this.pigPictureBox.Size = new System.Drawing.Size(100, 100);
            this.pigPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pigPictureBox.TabIndex = 6;
            this.pigPictureBox.TabStop = false;
            // 
            // pigAnimationTimer
            // 
            this.pigAnimationTimer.Tick += new System.EventHandler(this.ShowPigImage);
            // 
            // AnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 397);
            this.Controls.Add(this.pigPictureBox);
            this.Controls.Add(this.speedHScrollBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.copterPictureBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AnimationForm";
            this.Text = "Ana\'s Animation";
            ((System.ComponentModel.ISupportInitialize)(this.copterPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pigPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox copterPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.HScrollBar speedHScrollBar;
        private System.Windows.Forms.PictureBox pigPictureBox;
        private System.Windows.Forms.Timer pigAnimationTimer;
    }
}

