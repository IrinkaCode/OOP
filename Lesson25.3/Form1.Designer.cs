namespace Lesson25._3
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridViewInventors = new DataGridView();
            statusStrip = new StatusStrip();
            textBoxName = new TextBox();
            textBoxCount = new TextBox();
            textBoxPrice = new TextBox();
            textBoxDesc = new TextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            buttonEdit = new Button();
            contextMenuStrip2 = new ContextMenuStrip(components);
            comboBoxFilter = new ComboBox();
            textBoxSearch = new TextBox();
            toolStripStatusLabelCount = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventors).BeginInit();
            statusStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridViewInventors
            // 
            dataGridViewInventors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventors.Location = new Point(12, 141);
            dataGridViewInventors.Name = "dataGridViewInventors";
            dataGridViewInventors.RowHeadersWidth = 51;
            dataGridViewInventors.Size = new Size(621, 476);
            dataGridViewInventors.TabIndex = 1;
            dataGridViewInventors.CellClick += dataGridViewInventors_CellClick;
            dataGridViewInventors.KeyDown += dataGridViewInventors_KeyDown;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCount });
            statusStrip.Location = new Point(0, 616);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(992, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(672, 53);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Название";
            textBoxName.Size = new Size(280, 42);
            textBoxName.TabIndex = 3;
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(672, 112);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.PlaceholderText = "Количество";
            textBoxCount.Size = new Size(280, 38);
            textBoxCount.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(672, 170);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Цена";
            textBoxPrice.Size = new Size(280, 38);
            textBoxPrice.TabIndex = 5;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(672, 229);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.PlaceholderText = "Пояснение";
            textBoxDesc.Size = new Size(280, 324);
            textBoxDesc.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(992, 50);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, сохранитьToolStripMenuItem, открытьToolStripMenuItem, toolStripSeparator2, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 46);
            файлToolStripMenuItem.Text = "Файл";
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
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(166, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(163, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(166, 26);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // button1
            // 
            button1.Location = new Point(672, 569);
            button1.Name = "button1";
            button1.Size = new Size(130, 48);
            button1.TabIndex = 8;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(808, 569);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(137, 48);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Название", "Количество", "Цена" });
            comboBoxFilter.Location = new Point(337, 74);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(296, 39);
            comboBoxFilter.TabIndex = 10;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 74);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Введите строку для поиска";
            textBoxSearch.Size = new Size(308, 38);
            textBoxSearch.TabIndex = 11;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // toolStripStatusLabelCount
            // 
            toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            toolStripStatusLabelCount.Size = new Size(151, 20);
            toolStripStatusLabelCount.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(992, 642);
            Controls.Add(textBoxSearch);
            Controls.Add(comboBoxFilter);
            Controls.Add(buttonEdit);
            Controls.Add(button1);
            Controls.Add(textBoxDesc);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxCount);
            Controls.Add(textBoxName);
            Controls.Add(statusStrip);
            Controls.Add(dataGridViewInventors);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Урок 25";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventors).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridViewInventors;
        private StatusStrip statusStrip;
        private TextBox textBoxName;
        private TextBox textBoxCount;
        private TextBox textBoxPrice;
        private TextBox textBoxDesc;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Button button1;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Button buttonEdit;
        private ContextMenuStrip contextMenuStrip2;
        private ComboBox comboBoxFilter;
        private TextBox textBoxSearch;
        private ToolStripStatusLabel toolStripStatusLabelCount;
    }
}
