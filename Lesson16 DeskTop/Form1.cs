using Lesson16.Console;
using System.Windows.Forms;

namespace Lesson16_DeskTop
{
    public partial class Form1 : Form
    {
        private UserRegistration userRegistration;
        public Form1()
        {
            InitializeComponent();
            userRegistration = new UserRegistration();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            FormRegistercs formRegister = new FormRegistercs();
            formRegister.ShowDialog();
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            if (userRegistration.AuthenticateUser(textBoxLogin.Text, textBoxPassword.Text))
            {
                LCForm2 lCForm = new LCForm2();
                lCForm.Show();
                this.Hide();
            }
        }
    }
}
