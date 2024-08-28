namespace Lesson16_DeskTop
{
    partial class ReaderWindow
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
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(47, 285);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Содержание";
            textBox3.Size = new Size(413, 153);
            textBox3.TabIndex = 3;
            // 
            // ReaderWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 605);
            Controls.Add(textBox3);
            Name = "ReaderWindow";
            Text = "ReaderWindow";
            Load += ReaderWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
    }
}