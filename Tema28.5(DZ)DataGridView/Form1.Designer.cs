namespace Tema28._5_DZ_DataGridView
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
            dataGridViewTasks = new DataGridView();
            textBoxTaskName = new TextBox();
            comboBoxStatus = new ComboBox();
            textBox1 = new TextBox();
            textBoxTime = new TextBox();
            numericUpDownPriority = new NumericUpDown();
            buttonAddTask = new Button();
            buttonMarkCompleted = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriority).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(12, 27);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 51;
            dataGridViewTasks.Size = new Size(553, 483);
            dataGridViewTasks.TabIndex = 0;
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new Point(609, 47);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.PlaceholderText = "Введите название задачи";
            textBoxTaskName.Size = new Size(279, 27);
            textBoxTaskName.TabIndex = 1;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Новая", "Выполнена" });
            comboBoxStatus.Location = new Point(609, 140);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(279, 28);
            comboBoxStatus.TabIndex = 2;
            comboBoxStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(610, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "Выберите статус задачи";
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(610, 205);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.PlaceholderText = "Введите время";
            textBoxTime.Size = new Size(278, 27);
            textBoxTime.TabIndex = 4;
            // 
            // numericUpDownPriority
            // 
            numericUpDownPriority.Location = new Point(609, 292);
            numericUpDownPriority.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownPriority.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPriority.Name = "numericUpDownPriority";
            numericUpDownPriority.Size = new Size(178, 27);
            numericUpDownPriority.TabIndex = 5;
            numericUpDownPriority.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(610, 379);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(186, 60);
            buttonAddTask.TabIndex = 6;
            buttonAddTask.Text = "Добавить задачу";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // buttonMarkCompleted
            // 
            buttonMarkCompleted.Location = new Point(610, 458);
            buttonMarkCompleted.Name = "buttonMarkCompleted";
            buttonMarkCompleted.Size = new Size(186, 52);
            buttonMarkCompleted.TabIndex = 7;
            buttonMarkCompleted.Text = "Отметить как выполненную";
            buttonMarkCompleted.UseVisualStyleBackColor = true;
            buttonMarkCompleted.Click += buttonMarkCompleted_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(609, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 27);
            textBox2.TabIndex = 8;
            textBox2.Text = "Выберите приоритет";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 539);
            Controls.Add(textBox2);
            Controls.Add(buttonMarkCompleted);
            Controls.Add(buttonAddTask);
            Controls.Add(numericUpDownPriority);
            Controls.Add(textBoxTime);
            Controls.Add(textBox1);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxTaskName);
            Controls.Add(dataGridViewTasks);
            HelpButton = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriority).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTasks;
        private TextBox textBoxTaskName;
        private ComboBox comboBoxStatus;
        private TextBox textBox1;
        private TextBox textBoxTime;
        private NumericUpDown numericUpDownPriority;
        private Button buttonAddTask;
        private Button buttonMarkCompleted;
        private TextBox textBox2;
    }
}
