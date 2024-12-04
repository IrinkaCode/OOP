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

            StreamReader reader = new StreamReader("inventoryControl.csv");
            CsvReader csvReader = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
            records = csvReader.GetRecords<Inventory>().ToList();
            reader.Close();
            UpdateForm();
        }
        private void UpdateForm()
        {
            dataGridViewInventors.DataSource = null;
            dataGridViewInventors.DataSource = records;
            for (int i = 0; i < dataGridViewInventors.Columns.Count; i++)
            {
                dataGridViewInventors.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewInventors.Columns[i].ReadOnly = true;
            }
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
                textBoxDescription.Text = records[index].Description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Name = textBoxName.Text;
            inventory.Quattity = int.Parse(textBoxCount.Text);
            inventory.Price = decimal.Parse(textBoxPrice.Text);
            inventory.Description = textBoxDescription.Text;
            records.Add(inventory);
            UpdateForm();
        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("inventoryControl.csv");
            CsvWriter csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));
            csvWriter.WriteRecords(records);
            writer.Close();
            MessageBox.Show("Ôàéë óñïåøíî ñîõðàíåí");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventors.SelectedRows.Count > 0)
            {
                int index = dataGridViewInventors.SelectedRows[0].Index;
                records[index].Quattity = int.Parse(textBoxCount.Text);
                records[index].Name = textBoxName.Text;
                records[index].Price = decimal.Parse(textBoxPrice.Text);
                records[index].Description = textBoxDescription.Text;
                UpdateForm();
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
                    UpdateForm();   
                }
            }

        }
    }
}
