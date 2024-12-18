using CsvHelper;
using CsvHelper.Configuration;
using System.Formats.Asn1;
using System.Globalization;

namespace Lesson25._3
{
    public partial class Form1 : Form
    {
        private List<Inventory> records;
        public Form1()
        {
            InitializeComponent();

            try
            {
                using (StreamReader reader = new StreamReader("inventoryControl.csv"))
                {
                    CsvReader csvReader = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
                    records = csvReader.GetRecords<Inventory>().ToList();
                }
                dataGridViewInventors.DataSource = records;
                UpdateForm(records);
                comboBoxFilter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }

            //StreamReader reader = new StreamReader("inventoryControl.csv");
            //CsvReader csvReader = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
            //records = csvReader.GetRecords<Inventory>().ToList();
            //dataGridViewInventors.DataSource = records;
            //reader.Close();
            //UpdateForm(records);
            //comboBoxFilter.SelectedIndex = 0;
        }
        private void UpdateForm(List<Inventory> list)
        {
            dataGridViewInventors.DataSource = null;
            dataGridViewInventors.DataSource = list;
            for (int i = 0; i < dataGridViewInventors.Columns.Count; i++)
            {
                dataGridViewInventors.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewInventors.Columns[i].ReadOnly = true;
            }
            toolStripStatusLabelCount.Text = "Файл обновлен:"
                + list.Count.ToString();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewInventors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewInventors.SelectedRows.Count > 0)
            {
                int index = dataGridViewInventors.SelectedRows[0].Index;
                textBoxCount.Text = records[index].Quattity.ToString();
                textBoxName.Text = records[index].Name;
                textBoxPrice.Text = records[index].Price.ToString();
                textBoxDesc.Text = records[index].Description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Name = textBoxName.Text;
            inventory.Quattity = int.Parse(textBoxCount.Text);
            inventory.Price = decimal.Parse(textBoxPrice.Text);
            inventory.Description = textBoxDesc.Text;
            records.Add(inventory);
            UpdateForm(records);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StreamWriter writer = new StreamWriter("inventoryControl.csv");
            //CsvWriter csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));
            //csvWriter.WriteRecords(records);
            //writer.Close();
            //MessageBox.Show("Файл успешно сохранен");

            try
            {
                using (StreamWriter writer = new StreamWriter("inventoryControl.csv"))
                {
                    CsvWriter csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));
                    csvWriter.WriteRecords(records);
                }
                MessageBox.Show("Файл успешно сохранен");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventors.SelectedRows.Count > 0)
            {
                int index = dataGridViewInventors.SelectedRows[0].Index;
                records[index].Quattity = int.Parse(textBoxCount.Text);
                records[index].Name = textBoxName.Text;
                records[index].Price = decimal.Parse(textBoxPrice.Text);
                records[index].Description = textBoxDesc.Text;
                UpdateForm(records);
            }
        }

        private void dataGridViewInventors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridViewInventors.SelectedRows.Count > 0)
                {
                    int index = dataGridViewInventors.SelectedRows[0].Index;
                    records.RemoveAt(index);
                    UpdateForm(records);
                }
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length != 0)
            {
                switch (comboBoxFilter.SelectedIndex)
                {
                    case 0:
                        {
                            List<Inventory> list = records.
                                Where(p => p.Name!.ToLower().StartsWith(textBoxSearch.Text.ToLower())).ToList();
                            UpdateForm(list);
                        }
                        break;
                    case 1:
                        {
                            List<Inventory> list = records.
                                Where(p => p.Quattity == int.Parse(textBoxSearch.Text)).ToList();
                            UpdateForm(list);
                        }
                        break;
                    case 2:
                        {
                            List<Inventory> list = records.
                                Where(p => p.Price == int.Parse(textBoxSearch.Text)).ToList();
                            UpdateForm(list);
                        }
                        break;
                }
            }
            else UpdateForm(records);
        }
    }

}
    



