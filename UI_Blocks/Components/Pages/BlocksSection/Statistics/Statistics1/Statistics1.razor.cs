namespace UI_Blocks.Components.Pages.BlocksSection.Statistics.Statistics1
{
    public partial class Statistics1
    {
        public List<Metric> MetricsData = new List<Metric>
        {
            new Metric { MetricName = "Total Revenue", CurrentValue = "$6,435", CurrentPercentage = 15 },
            new Metric { MetricName = "Total Visitors", CurrentValue = "3,356", CurrentPercentage = 5 },
            new Metric { MetricName = "Total Transactions", CurrentValue = "6,435", CurrentPercentage = -2 },
            new Metric { MetricName = "Total Products", CurrentValue = "3,260", CurrentPercentage = 3 }
        };

        public class Metric
        {
            public string MetricName { get; set; } = string.Empty;
            public string CurrentValue { get; set; } = string.Empty;
            public int CurrentPercentage { get; set; }
        }
    }
}
