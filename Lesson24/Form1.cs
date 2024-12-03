namespace Lesson24
{
    public partial class Form : System.Windows.Forms.Form
    {
        private List<User> users = new List<User>();
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddUser(textBoxFirstName.Text, textBoxLastName.Text, int.Parse(textBoxAge.Text));
            UpdateList();

        }
        private void AddUser(string name, string lastName, int age)
        {
            users.Add(new User(name, lastName, age));
        }
        private void UpdateList()
        {
            dataGridViewUser.Rows.Clear();
            foreach (User user in users)
            {
                dataGridViewUser.Rows.Add(user.Name, user.SurName, user.Age);
            }
            textBoxAge.Text = textBoxFirstName.Text = textBoxLastName.Text = "";
            buttonEdit.Enabled = false;
        }
        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count > 0)
            {
                buttonEdit.Enabled = true;
                int index = dataGridViewUser.SelectedRows[0].Index;
                textBoxFirstName.Text = users[index].Name;
                textBoxLastName.Text = users[index].SurName;
                textBoxAge.Text = users[index].Age.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count > 0)
            {
                buttonEdit.Enabled = true;
                int index = dataGridViewUser.SelectedRows[0].Index;
                users[index].Name = textBoxFirstName.Text;
                users[index].SurName = textBoxLastName.Text;
                users[index].Age = int.Parse(textBoxAge.Text);
                UpdateList();
                buttonEdit.Enabled = false;
            }
        }

        private void óäàëèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count > 0)
            {
                int index = dataGridViewUser.SelectedRows[0].Index;
                DeleteItem(index);
                UpdateList();
            }
        }
        private void DeleteItem(int index)
        {
            users.RemoveAt(index);
        }

        private void dataGridViewUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int index = dataGridViewUser.SelectedRows[0].Index;
                DeleteItem(index);
                UpdateList();
            }
        }
    }
}
