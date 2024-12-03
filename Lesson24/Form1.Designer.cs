namespace Lesson24
{
    partial class Form
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
            dataGridViewUser = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            UserLastName = new DataGridViewTextBoxColumn();
            UserAge = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxAge = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Columns.AddRange(new DataGridViewColumn[] { UserName, UserLastName, UserAge });
            dataGridViewUser.ContextMenuStrip = contextMenuStrip1;
            dataGridViewUser.Location = new Point(15, 29);
            dataGridViewUser.Margin = new Padding(6);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 51;
            dataGridViewUser.Size = new Size(820, 600);
            dataGridViewUser.TabIndex = 0;
            dataGridViewUser.KeyDown += dataGridViewUser_KeyDown;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserName.HeaderText = "Имя";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            // 
            // UserLastName
            // 
            UserLastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserLastName.HeaderText = "Фамилия";
            UserLastName.MinimumWidth = 6;
            UserLastName.Name = "UserLastName";
            // 
            // UserAge
            // 
            UserAge.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserAge.HeaderText = "Возраст";
            UserAge.MinimumWidth = 6;
            UserAge.Name = "UserAge";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(135, 28);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(134, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(878, 29);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Имя";
            textBoxFirstName.Size = new Size(395, 43);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(878, 109);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Фамилия";
            textBoxLastName.Size = new Size(395, 43);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(878, 194);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.PlaceholderText = "Возраст";
            textBoxAge.Size = new Size(395, 43);
            textBoxAge.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(1090, 276);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(183, 60);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Enabled = false;
            buttonEdit.Location = new Point(1090, 376);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(183, 59);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 654);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(dataGridViewUser);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            Name = "Form";
            Text = "Урок 24";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUser;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxAge;
        private Button buttonAdd;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserLastName;
        private DataGridViewTextBoxColumn UserAge;
        private Button buttonEdit;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
    }
}
