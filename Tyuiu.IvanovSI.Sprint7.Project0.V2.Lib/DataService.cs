using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.IvanovSI.Sprint7.Project0.V2.Lib
{
    public class DataService
    {
        public double Max(string[,] path)
        {
            double max = 0;
            int columnIndex = 6;
            for (int i = 1; i < path.GetLength(0); i++)
            {
                if (Convert.ToDouble(path[i, columnIndex]) > max)
                {
                    max = Convert.ToDouble(path[i, columnIndex]);
                }
            }
            return max;
        }
        public double Min(string[,] path)
        {
            double min = 1000000000000000;
            int columnIndex = 6;
            for (int i = 1; i < path.GetLength(0); i++)
            {
                if (Convert.ToDouble(path[i, columnIndex]) < min)
                {
                    min = Convert.ToDouble(path[i, columnIndex]);
                }
            }
            return min;
        }
        public double Sred(string[,] path)
        {
            double sum = 0;
            
            for (int i = 1; i < path.GetLength(0); i++)
            {
                sum += Convert.ToDouble(path[i, 6]);
            }
            double average = sum / (path.GetLength(0) - 1);
            return Math.Round(average, 2);
        }
        
    }
}
