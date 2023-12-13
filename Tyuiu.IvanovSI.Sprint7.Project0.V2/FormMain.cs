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
namespace Tyuiu.IvanovSI.Sprint7.Project0.V2
{
    public partial class FormMain : MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static string openFilePath;
        static int rows;
        static int colums;
        
       
        private DataTable ReadCSVFile(string pathToCsvFile)
        {
            DataTable dt = new DataTable();

            DataColumn colMagaz;
            colMagaz = new DataColumn("Магазин", typeof(String));
            DataColumn colName;
            colName = new DataColumn("Название", typeof(String));
            DataColumn colFio; // Fio Vladeltsev magazina
            colFio = new DataColumn("ФИО", typeof(String));
            DataColumn colFioP; // Fio Vladeltsev magazina
            colFioP = new DataColumn("ФИО Поставщика", typeof(String));
            DataColumn colAdress;
            colAdress = new DataColumn("Адресс Магазина", typeof(String));
            DataColumn colTN; // Telephone number magazina
            colTN = new DataColumn("Номер телефона магазина", typeof(Double));
            DataColumn colTNP; // Telophone number postavshika
            colTNP = new DataColumn("Номер телефона поставщика", typeof(Double));
            DataColumn colSP;
            colSP = new DataColumn("Стоимость поставки", typeof(Double)); // Cтоимость поставки у поставщика
            //добавляем колонки в таблицу
            dt.Columns.AddRange(new DataColumn[] { colMagaz, colName, colFio, colAdress, colTN, colTNP, colSP });
            try
            {
                DataRow dr = null;
                string[] magValues = null;
                string[] mag = File.ReadAllLines(pathToCsvFile);
                for (int i = 0; i < mag.Length; i++)
                {
                    if (!string.IsNullOrEmpty(mag[i]))
                    {
                        magValues = mag[i].Split(';');

                        // Проверка, что в массиве достаточно элементов
                        if (magValues.Length >= 8)
                        {
                            dr = dt.NewRow();
                            dr["Магазин"] = magValues[0];
                            dr["Название"] = magValues[1];
                            dr["ФИО"] = magValues[2];
                            dr["ФИО поставщика"] = magValues[3];

                            int numberOfCores;
                            if (int.TryParse(magValues[4], out numberOfCores))
                                dr["Адресс Магазина"] = numberOfCores;

                            double ramSize;
                            if (double.TryParse(magValues[5], out ramSize))
                                dr["Номер телефона магазина"] = ramSize;

                            double diagonalSize;
                            if (double.TryParse(magValues[6], out diagonalSize))
                                dr["Номер телефона поставщика"] = diagonalSize;

                            double releaseYear;
                            if (double.TryParse(magValues[7], out releaseYear))
                                dr["Стоимость поставки"] = releaseYear;

                            // добавляем строку в таблицу
                            dt.Rows.Add(dr);
                        }
                        else
                        {
                            MessageBox.Show($"Ошибка в строке {i + 1}. Недостаточно данных.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при чтении файла: {ex.Message}");
            }
            return dt;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            

        }
    }
   
}   

