using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemerAlgoritm.UI.WinForms.Data
{
    internal static class DataTransformer
    {
        public static InfoForBarChart Transform(List<double> listOfValues, int intervalsCount)
        {
            var yData = new List<YData>();
            var xData = new List<XData>();
            var copiedList = new List<double>(listOfValues);
            var intervalTopBorders = new List<double>(intervalsCount);

            double increment = (listOfValues.Max() - listOfValues.Min()) / intervalsCount;
            //double increment = 1.0 / intervalsCount;
            double currentInterval = listOfValues.Min();

            // Creating a list of topBorders
            for (int i = 0; i < intervalsCount; i++)
            {
                currentInterval += increment;
                xData.Add(new XData(currentInterval));
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

                yData.Add(new YData(counter));
            }

            var result = new InfoForBarChart(yData, xData);


            return result;
        }
    }
}
