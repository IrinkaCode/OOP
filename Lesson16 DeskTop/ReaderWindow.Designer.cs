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
            textTitle = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textTitle
            // 
            textTitle.Location = new Point(50, 49);
            textTitle.Multiline = true;
            textTitle.Name = "textTitle";
            textTitle.PlaceholderText = "Заголовок";
            textTitle.Size = new Size(410, 34);
            textTitle.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 116);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Тема";
            textBox1.Size = new Size(410, 34);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(47, 190);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Возрастное ограничение";
            textBox2.Size = new Size(413, 34);
            textBox2.TabIndex = 2;
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
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textTitle);
            Name = "ReaderWindow";
            Text = "ReaderWindow";
            Load += ReaderWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTitle;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}