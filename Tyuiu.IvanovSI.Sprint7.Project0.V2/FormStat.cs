using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.IvanovSI.Sprint7.Project0.V2.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint7.Project0.V2
{
    public partial class FormStat : MetroForm
    {
        
        public FormStat()
        {
            InitializeComponent();
        }
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
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
        
        DataService ds = new DataService();
        string filePath = $@"C:\Users\seemoon\Desktop\projectX.csv";
        private void buttonOk_ISI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void FormStat_Load(object sender, EventArgs e)
        {

            

            string[,] dataArray = LoadFromFileData(filePath);
            textBoxMax_ISI.Text = Convert.ToString(ds.Max(dataArray));
            textBoxMin_ISI.Text = Convert.ToString(ds.Min(dataArray));
            textBoxMid_ISI.Text = Convert.ToString(ds.Sred(dataArray));
            

        }
    }
}
