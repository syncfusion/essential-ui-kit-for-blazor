namespace UI_Blocks.Components.Pages.BlocksSection.DistributionChart.DistributionChart1
{
    public partial class DistributionChart1
    {
        public List<DoughnutData> DoughnutChartData = new List<DoughnutData>
        {
            new DoughnutData { Id = 1, XAxis = "Food & Drink", YAxis = 48 },
            new DoughnutData { Id = 2, XAxis = "Grocery", YAxis = 32 },
            new DoughnutData { Id = 3, XAxis = "Shopping", YAxis = 13 },
            new DoughnutData { Id = 4, XAxis = "Transport", YAxis = 7 }
        };

        public class DoughnutData
        {
            public int Id { get; set; }
            public string XAxis { get; set; } = string.Empty;
            public int YAxis { get; set; }
        }
    }
}
