namespace Lesson16_DeskTop
{
    partial class FormRegistercs
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
            textBoxLogin = new TextBox();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            dateTimePickerBirth = new DateTimePicker();
            label1 = new Label();
            buttonOK = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(29, 48);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Введите логин";
            textBoxLogin.Size = new Size(418, 34);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(29, 117);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введите имя";
            textBoxName.Size = new Size(418, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(29, 176);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Введите фамилию";
            textBoxLastName.Size = new Size(418, 27);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(29, 237);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Введите email";
            textBoxEmail.Size = new Size(418, 34);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(32, 303);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Введите пароль";
            textBoxPassword.Size = new Size(415, 34);
            textBoxPassword.TabIndex = 4;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(29, 395);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(418, 27);
            dateTimePickerBirth.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 372);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 6;
            label1.Text = "Выберите дату рождения";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(29, 474);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(183, 53);
            buttonOK.TabIndex = 7;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(265, 474);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(182, 53);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormRegistercs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 575);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(label1);
            Controls.Add(dateTimePickerBirth);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            Controls.Add(textBoxLogin);
            Name = "FormRegistercs";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private DateTimePicker dateTimePickerBirth;
        private Label label1;
        private Button buttonOK;
        private Button buttonCancel;
    }
}