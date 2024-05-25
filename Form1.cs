using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using LinqForEEPlus;
using System.Xml.Linq;
using Newtonsoft.Json;
using OfficeOpenXml.Drawing.Chart;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ComboBox comboBoxSort;
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load_1);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "№ з/п";
            dataGridView1.Columns[1].Name = "№ договору";
            dataGridView1.Columns[2].Name = "Дата договору";
            dataGridView1.Columns[3].Name = "Контрагент";
            dataGridView1.Columns[4].Name = "Дата початку договору";
            dataGridView1.Columns[5].Name = "Дата закінчення";
            dataGridView1.Columns[6].Name = "Сума, грн";
            dataGridView1.Columns[7].Name = "Предмет договору";
        }

        // Кнопка "Зберегти файл"
        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json|*.json)";
            saveFileDialog.Title = "Збереження даних";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    var data = new List<Dictionary<string, object>>();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var rowData = new Dictionary<string, object>();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            rowData[dataGridView1.Columns[cell.ColumnIndex].HeaderText] = cell.Value ?? string.Empty;
                        }

                        data.Add(rowData);
                    }

                    string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                    File.WriteAllText(filePath, json);

                    MessageBox.Show("Дані збережені в JSON!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалося зберегти: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Кнопка "Експорт у Excel"
        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files *.xlsx|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Збереження файла Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Лист 1");

                        // Заголовки стовбців
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                        }

                        // Дані строк
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value;
                            }
                        }

                        // Збереження файла
                        File.WriteAllBytes(filePath, package.GetAsByteArray());
                        MessageBox.Show("Файл успішно експортован у Excel!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при експорті файла: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Кнопка "Імпорт даних"
        private void ImportToJSON_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.Title = "Імпорт даних";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    string jsonData = File.ReadAllText(filePath);
                    var documents = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(jsonData);

                    dataGridView1.Rows.Clear();
                    foreach (var document in documents)
                    {
                        var row = new DataGridViewRow();
                        row.CreateCells(dataGridView1);

                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            string columnName = dataGridView1.Columns[i].Name;
                            row.Cells[i].Value = document.ContainsKey(columnName) ? document[columnName] : string.Empty;
                        }

                        dataGridView1.Rows.Add(row);
                    }

                    MessageBox.Show("Дані успішно імпортовані!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка при імпорті даних" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Кнопка "Додати запис"
        private void AddDocument_Click(object sender, EventArgs e)
        {
            Add_document Add_document = new Add_document();
            Add_document.DataEntered += Add_document_DataEntered;
            Add_document.ShowDialog();
        }

        private void Add_document_DataEntered(object sender, DataEnteredEventArgs e)
        {
            // Додаємо введені дані в DataGridView
            dataGridView1.Rows.Add(e.ContractID, e.ContractNumber, e.ContractDateTime1, e.ContractCounterparty, e.ContractDateTime2, e.ContractDateTime3, e.ContractSum, e.ContractContent);
        }

        // Кнопка "Редагувати запис"
        private void RedactionDocument_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Edit_document editDocument = new Edit_document();

                editDocument.ContractID = selectedRow.Cells["№ з/п"].Value.ToString();
                editDocument.ContractNumber = selectedRow.Cells["№ договору"].Value.ToString();
                editDocument.ContractDateTime1 = selectedRow.Cells["Дата договору"].Value.ToString();
                editDocument.ContractCounterparty = selectedRow.Cells["Контрагент"].Value.ToString();
                editDocument.ContractDateTime2 = selectedRow.Cells["Дата початку договору"].Value.ToString();
                editDocument.ContractDateTime3 = selectedRow.Cells["Дата закінчення"].Value.ToString();
                editDocument.ContractSum = selectedRow.Cells["Сума, грн"].Value.ToString();
                editDocument.ContractContent = selectedRow.Cells["Предмет договору"].Value.ToString();

                editDocument.DataEntered += (s, ev) =>
                {
                    selectedRow.Cells["№ з/п"].Value = ev.ContractID;
                    selectedRow.Cells["№ договору"].Value = ev.ContractNumber;
                    selectedRow.Cells["Дата договору"].Value = ev.ContractDateTime1;
                    selectedRow.Cells["Контрагент"].Value = ev.ContractCounterparty;
                    selectedRow.Cells["Дата початку договору"].Value = ev.ContractDateTime2;
                    selectedRow.Cells["Дата закінчення"].Value = ev.ContractDateTime3;
                    selectedRow.Cells["Сума, грн"].Value = ev.ContractSum;
                    selectedRow.Cells["Предмет договору"].Value = ev.ContractContent;
                };

                editDocument.ShowDialog();
            }
            else
            {
                MessageBox.Show("Будь-ласка, оберіть рядок для редагування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка "Видалити запис"
        private void DeleteDocument_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Будь-ласка, оберіть рядок для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка "Вихід"
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}