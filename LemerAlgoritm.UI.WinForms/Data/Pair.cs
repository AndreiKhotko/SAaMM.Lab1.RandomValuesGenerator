using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemerAlgoritm.UI.WinForms.Data
{
    internal class Pair
    {
        public double Value1 { get; private set; }
        public double Value2 { get; private set; }

        public Pair(double value1, double value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }
}
