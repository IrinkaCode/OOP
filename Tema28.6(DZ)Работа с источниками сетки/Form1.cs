using System.Data;
using System.Windows.Forms;

namespace Tema28._6_DZ_Работа_с_источниками_сетки_
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;
        private HandlerExcel excelHandler = new HandlerExcel();
        public Form1()
        {
            InitializeComponent();
        }

        public void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        dataTable = excelHandler.LoadExcel(openFileDialog.FileName);
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}");
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        excelHandler.SaveExcel(saveFileDialog.FileName, dataTable);
                        MessageBox.Show("Файл успешно сохранен.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
        }

        public void btnAddRow_Click(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                dataTable.Rows.Add(dataTable.NewRow());
            }
            else
            {
                MessageBox.Show("Сначала откройте файл Excel.");
            }
        }

        public void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                foreach (DataGridViewRow selectedRow in dataGridView.SelectedRows)
                {
                    if (!selectedRow.IsNewRow)
                    {
                        dataGridView.Rows.Remove(selectedRow);
                    }
                }
            }
            else
            {
                MessageBox.Show("Сначала откройте файл Excel.");
            }
        }

    }
}

