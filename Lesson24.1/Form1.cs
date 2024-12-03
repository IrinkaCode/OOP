namespace Lesson24._1
{
    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            bu
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            users.Add(new User(textBoxFirstName.Text, textBoxLastName, int.Parse(textBoxAge)));
            UpdateForm();
        }
        private void UpdateForm()
        {
            dataGridViewUsers.DataSource = users;
            dataGridViewUsers.DataSource = null;
            for (int i = 0; i < dataGridViewUsers.Columns.Count; i++)
            {
                dataGridViewUsers.Columns[i].AutoSizeMode
            }


        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int index = dataGridViewUsers.SelectedRows[0].Index;
                textBoxFirstName.Text = users[index].Name;
                textBoxLastName.Text = users[index].SurName;
                textBoxAge.Text = users[index].Age.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
