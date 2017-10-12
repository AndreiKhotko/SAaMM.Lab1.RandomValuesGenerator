using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LemerAlgorithm.Exceptions;

namespace LemerAlgoritm.UI.WinForms
{
    using LemerAlgorithm;
    using LemerAlgoritm.UI.WinForms.Data;
    public partial class MainForm : Form
    {
        private List<double> generatedValuesList;
        public MainForm()
        {
            InitializeComponent();
        }

        private void radiobtnCalcUntilPeriod_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownExpectedNumberOfValues.Visible = !radiobtnCalcUntilPeriod.Checked;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            listBoxValues.Items.Clear();

            generatedValuesList = new List<double>();

            long a = Convert.ToInt32(numericUpDownA.Value);
            long r0 = Convert.ToInt32(numericUpDownR0.Value);
            long m = Convert.ToInt32(numericUpDownM.Value);

            try
            {
                var lemerGenerator = new Generator(a, r0, m);
                if (radiobtnCalcUntilPeriod.Checked)
                {
                    bool isPeriodReached = false;

                    while (!isPeriodReached)
                    {
                        var generatedValue = lemerGenerator.GetNext();

                        if (generatedValuesList.Contains(generatedValue))
                        {
                            isPeriodReached = true;
                        }

                        generatedValuesList.Add(generatedValue);
                        listBoxValues.Items.Add(generatedValue);
                    }


                    lblActualN.Text = $"Итого: {generatedValuesList.Count}";
                }
                else
                {
                    int n = Convert.ToInt32(numericUpDownExpectedNumberOfValues.Value);

                    for (int i = 0; i < n; i++)
                    {
                        var generatedValue = lemerGenerator.GetNext();

                        generatedValuesList.Add(generatedValue);
                        listBoxValues.Items.Add(generatedValue);
                    }

                    lblActualN.Text = $"Итого: {listBoxValues.Items.Count}";
                }

                var average = CalcM(generatedValuesList);
                var d = CalcD(generatedValuesList, average);
                var q = Math.Sqrt(d);

                lblM.Text = average.ToString();
                lblD.Text = d.ToString();
                lblQ.Text = q.ToString();
            }
            catch (NegativeOrZeroNumberException nEx)
            {
                MessageBox.Show($"Ошибка: параметр {nEx.ParamName} должен быть целым положительным числом.");
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show($"Ошибка: параметр \"{argEx.ParamName}\" должен быть больше параметра \"a\"");
            }
        }

        private static double CalcM(List<double> values) => values.Sum() / values.Count;

        private static double CalcD(List<double> values, double m) => values.Sum(number => Sqr(number - m)) / values.Count;

        private static double Sqr(double num) => num * num;

        private void btnDrawBarChart_Click(object sender, EventArgs e)
        {
            var infoForDrawingBarChart = DataTransformer.Transform(generatedValuesList, 20);

            CopyListOfIntsToObjectCollectionInListBox(infoForDrawingBarChart.Counts, listBoxTransformedValues.Items);

            chart1.DataSource = infoForDrawingBarChart.Counts;
            chart1.Series.Clear();
            chart1.Series.Add("CountsBar").YValueMembers = "Count";
            chart1.Series["CountsBar"].ChartType = SeriesChartType.Column;
            chart1.Series["CountsBar"].YValueType = ChartValueType.Int32;
            
            chart1.DataBind();
        }

        private static void CopyListOfIntsToObjectCollectionInListBox(List<YData> src, ListBox.ObjectCollection dest)
        {
            dest.Clear();
            foreach (var i in src)
                dest.Add(i.Count);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var pairs = DivideListOnPairs(generatedValuesList);

            var k = GetK(pairs);

            var result = 2.0 * k / generatedValuesList.Count;

            lbl2KN.Text = result.ToString();
            lblPi4.Text = (Math.PI / 4).ToString();
        }

        private static List<Pair> DivideListOnPairs(List<double> list)
        {
            var pairs = new List<Pair>();
            for (int i = 0; i < list.Count - 1; i += 2)
            {
                if (i + 1 < list.Count)
                    pairs.Add(new Pair(list[i], list[i+1]));
            }

            return pairs;
        }

        private static int GetK(List<Pair> pairs)
        {
            int k = 0;

            foreach (var pair in pairs)
            {
                if (Sqr(pair.Value1) + Sqr(pair.Value2) < 1)
                    k++;
            }

            return k;
        }
    }
}
