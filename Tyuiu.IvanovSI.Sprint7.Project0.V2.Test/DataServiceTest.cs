using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.IvanovSI.Sprint7.Project0.V2.Lib;
namespace Tyuiu.IvanovSI.Sprint7.Project0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        string filePath = @"C:\Users\seemoon\Desktop\projectX.csv";
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
        [TestMethod]
        
        public void CheckMax()
        {
            double wait = 900;
            double res = ds.Max(LoadFromFileData(filePath));
            Assert.AreEqual(wait, res);
        }
        [TestMethod]

        public void CheckMin()
        {
            double wait = 150;
            double res = ds.Min(LoadFromFileData(filePath));
            Assert.AreEqual(wait, res);
        }
        [TestMethod]

        public void CheckSred()
        {
            double wait = 468.75;
            double res = ds.Sred(LoadFromFileData(filePath));
            Assert.AreEqual(wait, res);
        }
    }
}
