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
            //��������� DataGridView
            dataGridViewTasks.Columns.Add("TaskName", "�������� ������");
            dataGridViewTasks.Columns.Add("Status", "������");
            dataGridViewTasks.Columns.Add("Time", "�����");
            dataGridViewTasks.Columns.Add("Priority", "���������");

            dataGridViewTasks.AllowUserToAddRows = false; // ��������� ���������� ������ �����
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Add("�����");
            comboBoxStatus.Items.Add("���������");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            // ���������� ����� ������
            string taskName = textBoxTaskName.Text;
            string status = comboBoxStatus.SelectedItem.ToString();
            string time = textBoxTime.Text;
            int priority = (int)numericUpDownPriority.Value;

            dataGridViewTasks.Rows.Add(taskName, status, time, priority);
            ClearInputFields();
        }

        private void buttonMarkCompleted_Click(object sender, EventArgs e)
        {
            // ������� ��������� ������ ��� �����������
            // ��������, ���� �� ��������� ������
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewTasks.SelectedRows)
                {
                    if (row.Cells["Status"].Value.ToString() == "���������")
                    {
                        MessageBox.Show("��� ������ ��� ���������.");
                    }
                    else
                    {
                        // ��������� ������� �� "���������"
                        row.Cells["Status"].Value = "���������";
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    }
                }
            }
            else
            {
                MessageBox.Show("����������, �������� ������ ��� ������� ��� �����������.");
            }
        }

        private void ClearInputFields()
        {
            // ������� ����� �����
            textBoxTaskName.Clear();
            comboBoxStatus.SelectedIndex = -1;
            textBoxTime.Clear();
            numericUpDownPriority.Value = 1; // ����� � ���������� ��������
        }
    }
}
