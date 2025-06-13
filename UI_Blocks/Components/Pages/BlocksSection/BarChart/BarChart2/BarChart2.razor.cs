namespace UI_Blocks.Components.Pages.BlocksSection.BarChart.BarChart2
{
    public partial class BarChart2
    {
        public List<BarData> BarChartData = new List<BarData>
        {
            new BarData { XAxis = "21", YAxis1 = 35, YAxis2 = 28, YAxis3 = 34, YAxis4 = 32 },
            new BarData { XAxis = "22", YAxis1 = 28, YAxis2 = 44, YAxis3 = 25, YAxis4 = 30 },
            new BarData { XAxis = "23", YAxis1 = 34, YAxis2 = 32, YAxis3 = 40, YAxis4 = 34 },
            new BarData { XAxis = "24", YAxis1 = 32, YAxis2 = 36, YAxis3 = 28, YAxis4 = 40 },
            new BarData { XAxis = "25", YAxis1 = 40, YAxis2 = 30, YAxis3 = 35, YAxis4 = 45 },
            new BarData { XAxis = "26", YAxis1 = 32, YAxis2 = 36, YAxis3 = 28, YAxis4 = 40 },
            new BarData {XAxis = "27", YAxis1 = 40, YAxis2 = 30, YAxis3 = 35, YAxis4 = 45}
        };

        public List<PieData> PieChartData = new List<PieData>
        {
            new PieData { XAxis = "Food & Drink", YAxis = 20, DataLabelMappingName = "20%" },
            new PieData { XAxis = "Grocery", YAxis = 30, DataLabelMappingName = "30%" },
            new PieData { XAxis = "Shopping", YAxis = 15, DataLabelMappingName = "15%" },
            new PieData { XAxis = "Transport", YAxis = 35, DataLabelMappingName = "35%" }
        };

        public class BarData
        {
            public string XAxis { get; set; } = string.Empty;
            public double YAxis1 { get; set; }
            public double YAxis2 { get; set; }
            public double YAxis3 { get; set; }
            public double YAxis4 { get; set; }
        }

        public class PieData
        {
            public string XAxis { get; set; } = string.Empty;
            public double YAxis { get; set; }
            public string DataLabelMappingName { get; set; } = string.Empty;
        }
    }
}
