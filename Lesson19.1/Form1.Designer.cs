namespace Lesson19._1
{
    partial class StartBTN
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
            Strartbutton1 = new Button();
            progressPB = new ProgressBar();
            SuspendLayout();
            // 
            // Strartbutton1
            // 
            Strartbutton1.Location = new Point(541, 114);
            Strartbutton1.Name = "Strartbutton1";
            Strartbutton1.Size = new Size(247, 77);
            Strartbutton1.TabIndex = 0;
            Strartbutton1.Text = "Запуск";
            Strartbutton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            Strartbutton1.UseVisualStyleBackColor = true;
            Strartbutton1.Click += strartbutton1_Click;
            // 
            // progressPB
            // 
            progressPB.ForeColor = SystemColors.ButtonHighlight;
            progressPB.Location = new Point(31, 33);
            progressPB.Name = "progressPB";
            progressPB.Size = new Size(757, 29);
            progressPB.TabIndex = 1;
            // 
            // StartBTN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 322);
            Controls.Add(progressPB);
            Controls.Add(Strartbutton1);
            Name = "StartBTN";
            Text = "Потоки";
            ResumeLayout(false);
        }

        #endregion

        private Button Strartbutton1;
        private ProgressBar progressPB;
    }
}
