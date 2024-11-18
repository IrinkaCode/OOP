namespace Lesson19._2
{
    partial class FormGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxPlayer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.BackColor = SystemColors.ActiveCaption;
            pictureBoxPlayer.Location = new Point(234, 681);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(100, 100);
            pictureBoxPlayer.TabIndex = 0;
            pictureBoxPlayer.TabStop = false;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(982, 953);
            Controls.Add(pictureBoxPlayer);
            Name = "FormGame";
            Text = "Битва космических кораблей";
            KeyDown += FormGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPlayer;
    }
}
