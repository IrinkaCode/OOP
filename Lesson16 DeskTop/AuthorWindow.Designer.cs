
namespace Lesson16_DeskTop
{
    partial class AuthorWindow
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            txtTitle = new TextBox();
            txtTopic = new TextBox();
            txtContent = new TextBox();
            numAgeLimit = new NumericUpDown();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numAgeLimit).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(29, 386);
            button1.Name = "button1";
            button1.Size = new Size(217, 49);
            button1.TabIndex = 0;
            button1.Text = "Создать статью";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(298, 384);
            button2.Name = "button2";
            button2.Size = new Size(214, 52);
            button2.TabIndex = 1;
            button2.Text = "Редактировать статью";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(295, 452);
            button3.Name = "button3";
            button3.Size = new Size(217, 48);
            button3.TabIndex = 2;
            button3.Text = "Сохранить изменения";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(36, 452);
            button4.Name = "button4";
            button4.Size = new Size(214, 51);
            button4.TabIndex = 3;
            button4.Text = "Отменить изменения";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(183, 509);
            button5.Name = "button5";
            button5.Size = new Size(210, 51);
            button5.TabIndex = 4;
            button5.Text = "Выход";
            button5.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(36, 36);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Введите название статьи";
            txtTitle.Size = new Size(493, 34);
            txtTitle.TabIndex = 5;
            // 
            // txtTopic
            // 
            txtTopic.Location = new Point(36, 110);
            txtTopic.Multiline = true;
            txtTopic.Name = "txtTopic";
            txtTopic.PlaceholderText = "Введите тему";
            txtTopic.Size = new Size(493, 34);
            txtTopic.TabIndex = 6;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(36, 266);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.PlaceholderText = "Содержание";
            txtContent.Size = new Size(493, 34);
            txtContent.TabIndex = 8;
            // 
            // numAgeLimit
            // 
            numAgeLimit.Location = new Point(36, 192);
            numAgeLimit.Name = "numAgeLimit";
            numAgeLimit.Size = new Size(493, 27);
            numAgeLimit.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 27);
            textBox1.TabIndex = 10;
            textBox1.Text = "Возрастное ограничение";
            // 
            // AuthorWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 572);
            Controls.Add(textBox1);
            Controls.Add(numAgeLimit);
            Controls.Add(txtContent);
            Controls.Add(txtTopic);
            Controls.Add(txtTitle);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AuthorWindow";
            Text = "Окно Автора";
            Load += AuthorWindow_Load;
            ((System.ComponentModel.ISupportInitialize)numAgeLimit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox txtTitle;
        private TextBox txtTopic;
        private TextBox txtContent;
        private NumericUpDown numAgeLimit;
        private TextBox textBox1;
    }
}