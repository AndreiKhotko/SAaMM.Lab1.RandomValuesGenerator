using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemerAlgoritm.UI.WinForms.Data
{
    internal class InfoForBarChart
    {
        public List<YData> Counts { get; private set; }

        public List<XData> IntervalTopBorders { get; private set; }
        
        public InfoForBarChart(List<YData> yData, List<XData> xData)
        {
            Counts = yData;
            IntervalTopBorders = xData;
        }
    }
}
