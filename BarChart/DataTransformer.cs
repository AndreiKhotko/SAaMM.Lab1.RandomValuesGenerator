using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarChart
{
    public static class DataTransformer
    {
        public static List<ChartData> Transform(List<double> listOfValues, int intervalsCount)
        {
            var result = new List<ChartData>();
            var copiedList = new List<double>(listOfValues);
            var intervalTopBorders = new List<double>(intervalsCount);
            double increment = 1.0 / intervalsCount;
            double currentInterval = 0;

            // Creating a list of topBorders
            for (int i = 0; i < intervalsCount; i++)
            {
                currentInterval += increment;
                intervalTopBorders.Add(currentInterval);
            }

            foreach (var topBorder in intervalTopBorders)
            {
                int counter = 0;
                for (int j = 0; j < copiedList.Count; j++)
                {
                    if (copiedList[j] < topBorder)
                    {
                        counter++;
                        copiedList.Remove(copiedList[j--]);
                    }
                }

                result.Add(new ChartData(counter));
            }

            return result;
        }
    }
}
