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
using MetroFramework.Components;
using MetroFramework.Forms;
using Tyuiu.IvanovSI.Sprint7.Project0.V2.Lib;
namespace Tyuiu.IvanovSI.Sprint7.Project0.V2
{
    public partial class FormMain : MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();





        private void FormMain_Load(object sender, EventArgs e)
        {


        }



        private void buttonStat_ISI_Click(object sender, EventArgs e)
        {
            /*FormStat formStat = new FormStat();
            formStat.ShowDialog();*/
        }

        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.Default);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;
        }
        private void LoadDataIntoDataGridView(string filePath)
        {
            // загружаем данные из файла с помощью метода LoadFromFileData
            string[,] dataArray = LoadFromFileData(filePath);

            // очищаем DataGridView перед загрузкой новых данных
            dataGridViewIn_ISI.Rows.Clear();
            dataGridViewIn_ISI.Columns.Clear();

            // добавляем столбцы в DataGridView
            for (int i = 0; i < dataArray.GetLength(1); i++)
            {
                dataGridViewIn_ISI.Columns.Add("", dataArray[0, i]);
            }

            // добавляем строки с данными из CSV файла
            for (int i = 1; i < dataArray.GetLength(0); i++)
            {
                List<string> rowData = new List<string>();
                for (int j = 0; j < dataArray.GetLength(1); j++)
                {
                    rowData.Add(dataArray[i, j]);
                }
                dataGridViewIn_ISI.Rows.Add(rowData.ToArray());
            }
        }
        private void buttonHelp_ISI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_ISI_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_IJD = new OpenFileDialog();
            openFileDialog_IJD.Filter = "csv Files|*.csv"; // фильтр для отображения только csv файлов
            if (openFileDialog_IJD.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog_IJD.FileName;

                // загружаем данные в DataGridView с помощью метода LoadDataIntoDataGridView
                LoadDataIntoDataGridView(filePath);
            }
        }

        private void buttonSave_ISI_Click(object sender, EventArgs e)
        {
            saveFileDialog_ISI.FileName = "OutPutMagaz.csv";
            saveFileDialog_ISI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_ISI.ShowDialog();

            string path = saveFileDialog_ISI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewIn_ISI.RowCount;
            int columns = dataGridViewIn_ISI.ColumnCount;

            string str = "Название;Номер;Адрес;Телефон магазина;Фио поставщика;Телефон поставщика;Стоимость поставки\n";
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewIn_ISI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewIn_ISI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine,Encoding.Default);
                str = "";
            }

            DialogResult dialogres = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogres == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }

        private void textBoxSearch_ISI_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch_ISI.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewIn_ISI.Rows)
            {
                if (row.IsNewRow) continue; // пропускаем недобавленные строки

                bool found = false;

                for (int j = 0; j < dataGridViewIn_ISI.Columns.Count; j++)
                {
                    if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found;
            }
        }

        private void buttonSort_ISI_Click(object sender, EventArgs e)
        {
            contextMenuStrip_ISI.Show(buttonSort_ISI, 1, buttonSort_ISI.Height);
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            dataGridViewIn_ISI.Sort(dataGridViewIn_ISI.Columns[6], ListSortDirection.Ascending);
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewIn_ISI.Columns[6].SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridViewIn_ISI.Sort(dataGridViewIn_ISI.Columns[6], ListSortDirection.Descending);
        }

        private void поВозрастаниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewIn_ISI.Rows.Count - 1; i++)
            {
                for (int j = i + 1; j < dataGridViewIn_ISI.Rows.Count; j++)
                {
                    if (dataGridViewIn_ISI.Rows[i].Cells[1].Value != null && dataGridViewIn_ISI.Rows[j].Cells[1].Value != null)
                    {
                        if (Convert.ToDouble(dataGridViewIn_ISI.Rows[i].Cells[1].Value) > Convert.ToDouble(dataGridViewIn_ISI.Rows[j].Cells[1].Value))
                        {
                            
                            for (int k = 0; k < dataGridViewIn_ISI.Columns.Count; k++)
                            {
                                object temp = dataGridViewIn_ISI.Rows[i].Cells[k].Value;
                                dataGridViewIn_ISI.Rows[i].Cells[k].Value = dataGridViewIn_ISI.Rows[j].Cells[k].Value;
                                dataGridViewIn_ISI.Rows[j].Cells[k].Value = temp;
                            }
                        }
                    }
                }
            }
        }

        private void поУбываниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewIn_ISI.Rows.Count - 1; i++)
            {
                for (int j = i + 1; j < dataGridViewIn_ISI.Rows.Count; j++)
                {
                    if (dataGridViewIn_ISI.Rows[i].Cells[1].Value != null && dataGridViewIn_ISI.Rows[j].Cells[1].Value != null)
                    {
                        if (Convert.ToDouble(dataGridViewIn_ISI.Rows[i].Cells[1].Value) < Convert.ToDouble(dataGridViewIn_ISI.Rows[j].Cells[1].Value))
                        {
                            
                            for (int k = 0; k < dataGridViewIn_ISI.Columns.Count; k++)
                            {
                                object temp = dataGridViewIn_ISI.Rows[i].Cells[k].Value;
                                dataGridViewIn_ISI.Rows[i].Cells[k].Value = dataGridViewIn_ISI.Rows[j].Cells[k].Value;
                                dataGridViewIn_ISI.Rows[j].Cells[k].Value = temp;
                            }
                        }
                    }
                }
            }
        }

        private void аЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewIn_ISI.Sort(dataGridViewIn_ISI.Columns[0], ListSortDirection.Ascending);
        }

        private void яАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewIn_ISI.Sort(dataGridViewIn_ISI.Columns[0], ListSortDirection.Descending);
        }

        private void аЯToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridViewIn_ISI.Sort(dataGridViewIn_ISI.Columns[4], ListSortDirection.Ascending);
        }

        private void яАToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridViewIn_ISI.Sort(dataGridViewIn_ISI.Columns[4], ListSortDirection.Descending);
        }
    }
}
    
        

