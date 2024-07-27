using Lesson16.Console;

namespace Lesson16_DeskTop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            FormRegistercs formRegistercs = new FormRegistercs();
            formRegistercs.ShowDialog();
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            if(UserRegistration.AuthenticateUser(textBoxLogin.Text))
        }
    }
}
