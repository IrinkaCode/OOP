namespace Tema28._6_DZ_Работа_с_источниками_сетки_
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
            dataGridView = new DataGridView();
            btnOpen = new Button();
            btnSave = new Button();
            btnAddRow = new Button();
            btnDeleteRow = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 29);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(590, 644);
            dataGridView.TabIndex = 0;
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnOpen.Location = new Point(645, 29);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(128, 51);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Открыть ";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(645, 251);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 49);
            btnSave.TabIndex = 2;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAddRow
            // 
            btnAddRow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddRow.Location = new Point(645, 136);
            btnAddRow.Name = "btnAddRow";
            btnAddRow.Size = new Size(128, 54);
            btnAddRow.TabIndex = 3;
            btnAddRow.Text = "Добавить";
            btnAddRow.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRow
            // 
            btnDeleteRow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteRow.Location = new Point(645, 360);
            btnDeleteRow.Name = "btnDeleteRow";
            btnDeleteRow.Size = new Size(128, 54);
            btnDeleteRow.TabIndex = 4;
            btnDeleteRow.Text = "Удалить";
            btnDeleteRow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 706);
            Controls.Add(btnDeleteRow);
            Controls.Add(btnAddRow);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button btnOpen;
        private Button btnSave;
        private Button btnAddRow;
        private Button btnDeleteRow;
    }
}
