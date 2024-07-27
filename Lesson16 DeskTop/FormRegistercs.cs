using Lesson16.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lesson16_DeskTop
{
    public partial class FormRegistercs : Form

    {
        private UserRegistration userRegistration;
    
        public FormRegistercs()
        {
            InitializeComponent();
            UserRegistration userRegistration = new UserRegistration();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            User user = new User 
            { UserName = textBoxLogin.Text, FirstName = textBoxName.Text, SecondName = textBoxLastName.Text, Email = textBoxEmail.Text, Password = textBoxPassword.Text, RegistrationDate = DateTime.Now, BirthDate = dateTimePickerBirth.Value
            };

            if (userRegistration.RegisterUser(user))
            {
                MessageBox.Show("Пользователь успешно зарегистрирован");
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Пользователь с таким именем или паролем существует");
        }
    }
}
