namespace UI_Blocks.Components.Pages.BlocksSection.Statistics.Statistics7
{
    public partial class Statistics7
    {
        public List<Metric> MetricsData = new List<Metric>
        {
            new Metric { MetricName = "Total Revenue", CurrentValue = 4185.82, ValueDescription = "+1.23% (45.32)" },
            new Metric { MetricName = "Trending Volume", CurrentValue = 2.38, ValueDescription = "Shares Traded" },
            new Metric { MetricName = "Market Breadth", CurrentValue = 1.5, ValueDescription = "Advance / Decline Ratio" },
            new Metric { MetricName = "VIX", CurrentValue = 18.62, ValueDescription = "-0.54 (-282%)" }
        };
        
        public class Metric
        {
            public string MetricName { get; set; } = string.Empty;
            public double CurrentValue { get; set; }
            public string ValueDescription { get; set; } = string.Empty;
        }
    }
}
