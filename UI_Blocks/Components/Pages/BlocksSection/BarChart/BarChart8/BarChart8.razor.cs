namespace UI_Blocks.Components.Pages.BlocksSection.BarChart.BarChart8
{
    public partial class BarChart8
    {
        public List<SalesData> BarChartData = new List<SalesData>
        {
            new SalesData { Month = "Month", MoneyMarket = 71590, Stocks = 50113, Bonds = 57272 }
        };

        public class SalesData
        {
            public string Month { get; set; } = string.Empty;
            public double MoneyMarket { get; set; }
            public double Stocks { get; set; }
            public double Bonds { get; set; }
        }
    }
}
