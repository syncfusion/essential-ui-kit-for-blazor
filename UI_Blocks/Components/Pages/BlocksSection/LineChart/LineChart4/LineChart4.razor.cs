namespace UI_Blocks.Components.Pages.BlocksSection.LineChart.LineChart4
{
    public partial class LineChart4
    {
        public List<LineData> LineChartData = new List<LineData>
        {
            new LineData { Month = "Jan", YAxis1 = 600, YAxis2 = 550 },
            new LineData { Month = "Feb", YAxis1 = 720, YAxis2 = 690 },
            new LineData { Month = "Mar", YAxis1 = 670, YAxis2 = 710 },
            new LineData { Month = "Apr", YAxis1 = 780, YAxis2 = 740 },
            new LineData { Month = "May", YAxis1 = 610, YAxis2 = 700 },
            new LineData { Month = "Jun", YAxis1 = 800, YAxis2 = 770 },
            new LineData { Month = "Jul", YAxis1 = 850, YAxis2 = 800 },
            new LineData { Month = "Aug", YAxis1 = 770, YAxis2 = 740 },
            new LineData { Month = "Sep", YAxis1 = 680, YAxis2 = 690 },
            new LineData { Month = "Oct", YAxis1 = 740, YAxis2 = 720 },
            new LineData { Month = "Nov", YAxis1 = 810, YAxis2 = 780 },
            new LineData { Month = "Dec", YAxis1 = 790, YAxis2 = 760 }
        };

        public class LineData
        {
            public string Month { get; set; } = string.Empty;
            public double YAxis1 { get; set; }
            public double YAxis2 { get; set; }
        }
    }
}
