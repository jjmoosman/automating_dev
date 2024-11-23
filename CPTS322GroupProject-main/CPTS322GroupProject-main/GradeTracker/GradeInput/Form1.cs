using System;
using System.IO;
using System.Windows.Forms;

namespace GradeInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Save data to file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string[] rowData = new string[dataGridView1.ColumnCount];
                                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                                {
                                    rowData[i] = row.Cells[i].Value?.ToString() ?? string.Empty;
                                }
                                writer.WriteLine(string.Join(",", rowData));
                            }
                        }
                    }
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Load data from file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();

                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] rowData = line.Split(',');
                            dataGridView1.Rows.Add(rowData);
                        }
                    }
                }
            }
        }
        
        // will work on this later
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
