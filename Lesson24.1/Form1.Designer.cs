namespace Lesson24._1
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
            buttonAdd = new Button();
            buttonEdit = new Button();
            dataGridViewUsers = new DataGridView();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxAge = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(947, 437);
            buttonAdd.Margin = new Padding(6);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(242, 94);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(947, 591);
            buttonEdit.Margin = new Padding(6);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(242, 107);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(12, 12);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(757, 707);
            dataGridViewUsers.TabIndex = 2;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(843, 77);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Имя";
            textBoxFirstName.Size = new Size(448, 43);
            textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(843, 195);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Фамилия";
            textBoxLastName.Size = new Size(448, 43);
            textBoxLastName.TabIndex = 4;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(843, 317);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.PlaceholderText = "Возраст";
            textBoxAge.Size = new Size(448, 43);
            textBoxAge.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 832);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(dataGridViewUsers);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Урок 24";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonEdit;
        private DataGridView dataGridViewUsers;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxAge;
    }
}
