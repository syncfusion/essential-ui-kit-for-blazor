namespace UI_Blocks.Components.Pages.BlocksSection.Statistics.Statistics8
{
    public partial class Statistics8
    {
        public List<Metric> MetricsData = new List<Metric>
        {
            new Metric { MetricName = "Incoming Calls", CallCount = 435, CurrentPercentage = 3.5, Trend = "up" },
            new Metric { MetricName = "Answered Calls", CallCount = 245, CurrentPercentage = 4.2, Trend = "up" },
            new Metric { MetricName = "Abandoned Calls", CallCount = 146, CurrentPercentage = -0.9, Trend = "down" },
            new Metric { MetricName = "Total Calls", CallCount = 413, CurrentPercentage = 3.7, Trend = "up" }
        };
        
        public class Metric
        {
            public string MetricName { get; set; } = string.Empty;
            public int CallCount { get; set; }
            public double CurrentPercentage { get; set; }
            public string Trend { get; set; } = string.Empty;
        }
    }
}
