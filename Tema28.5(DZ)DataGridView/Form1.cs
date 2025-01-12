namespace Tema28._5_DZ_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            //Настройка DataGridView
            dataGridViewTasks.Columns.Add("TaskName", "Название задачи");
            dataGridViewTasks.Columns.Add("Status", "Статус");
            dataGridViewTasks.Columns.Add("Time", "Время");
            dataGridViewTasks.Columns.Add("Priority", "Приоритет");

            dataGridViewTasks.AllowUserToAddRows = false; // Отключаем добавление пустых строк
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Add("Новая");
            comboBoxStatus.Items.Add("Выполнена");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            // Добавление новой задачи
            string taskName = textBoxTaskName.Text;
            string status = comboBoxStatus.SelectedItem.ToString();
            string time = textBoxTime.Text;
            int priority = (int)numericUpDownPriority.Value;

            dataGridViewTasks.Rows.Add(taskName, status, time, priority);
            ClearInputFields();
        }

        private void buttonMarkCompleted_Click(object sender, EventArgs e)
        {
            // Отметка выбранной задачи как выполненной
            // Проверка, есть ли выбранные строки
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewTasks.SelectedRows)
                {
                    if (row.Cells["Status"].Value.ToString() == "Выполнена")
                    {
                        MessageBox.Show("Эта задача уже выполнена.");
                    }
                    else
                    {
                        // Изменение статуса на "Выполнена"
                        row.Cells["Status"].Value = "Выполнена";
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите задачу для отметки как выполненную.");
            }
        }

        private void ClearInputFields()
        {
            // Очистка полей ввода
            textBoxTaskName.Clear();
            comboBoxStatus.SelectedIndex = -1;
            textBoxTime.Clear();
            numericUpDownPriority.Value = 1; // Сброс к начальному значению
        }
    }
}
