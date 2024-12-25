namespace Lesson29
{
    partial class Form1
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
            dataGridViewTovar = new DataGridView();
            menuStrip2 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            выъодToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            buttonWord = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTovar).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTovar
            // 
            dataGridViewTovar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTovar.Location = new Point(12, 58);
            dataGridViewTovar.Name = "dataGridViewTovar";
            dataGridViewTovar.RowHeadersWidth = 51;
            dataGridViewTovar.Size = new Size(945, 427);
            dataGridViewTovar.TabIndex = 1;
            dataGridViewTovar.ColumnHeaderMouseClick += dataGridViewTovar_ColumnHeaderMouseClick_1;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(969, 28);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, выъодToolStripMenuItem, toolStripSeparator1, сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(166, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // выъодToolStripMenuItem
            // 
            выъодToolStripMenuItem.Name = "выъодToolStripMenuItem";
            выъодToolStripMenuItem.Size = new Size(166, 26);
            выъодToolStripMenuItem.Text = "Выход";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(163, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(166, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // buttonWord
            // 
            buttonWord.Location = new Point(24, 530);
            buttonWord.Name = "buttonWord";
            buttonWord.Size = new Size(130, 53);
            buttonWord.TabIndex = 3;
            buttonWord.Text = "ToWord";
            buttonWord.UseVisualStyleBackColor = true;
            buttonWord.Click += buttonWord_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 612);
            Controls.Add(buttonWord);
            Controls.Add(dataGridViewTovar);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Товарная накладная";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTovar).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewTovar;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem выъодToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private Button buttonWord;
    }
}
