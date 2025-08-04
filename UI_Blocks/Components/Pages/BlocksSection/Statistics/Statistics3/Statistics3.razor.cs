namespace UI_Blocks.Components.Pages.BlocksSection.Statistics.Statistics3
{
    public partial class Statistics3
    {
        public List<Metric> MetricsData = new List<Metric>
        {
            new Metric { MetricName = "Total Revenue", CurrentValue = "$825,000", CurrentPercentage = 26, Trend = "up" },
            new Metric { MetricName = "Total Leads", CurrentValue = "99", CurrentPercentage = -9, Trend = "down" },
            new Metric { MetricName = "High Interest Leads", CurrentValue = "36", CurrentPercentage = 69, Trend = "up" },
            new Metric { MetricName = "Qualified Leads", CurrentValue = "17", CurrentPercentage = -21, Trend = "down" }
        };
        
        public class Metric
        {
            public string MetricName { get; set; } = string.Empty;
            public string CurrentValue { get; set; } = string.Empty;
            public int CurrentPercentage { get; set; }
            public string Trend { get; set; } = string.Empty;
        }
    }
}
