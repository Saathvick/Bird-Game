
namespace Bird_Game
{
    partial class Form1
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
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeUp
            // 
            this.pipeUp.Image = global::Bird_Game.Properties.Resources.pipedown;
            this.pipeUp.Location = new System.Drawing.Point(644, -172);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(157, 482);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 2;
            this.pipeUp.TabStop = false;
            this.pipeUp.Click += new System.EventHandler(this.pipeTop);
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::Bird_Game.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(213, 260);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(100, 68);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ground
            // 
            this.ground.Image = global::Bird_Game.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-23, 823);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(929, 114);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::Bird_Game.Properties.Resources.pipe;
            this.pipeDown.Location = new System.Drawing.Point(508, 538);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(169, 303);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 1;
            this.pipeDown.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("MineCrafter 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(-4, 19);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(209, 52);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0\r\n";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 901);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeDown);
            this.Name = "Form1";
            this.Text = "Flappy Game Bird";
            this.Load += new System.EventHandler(this.gameTimerEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

