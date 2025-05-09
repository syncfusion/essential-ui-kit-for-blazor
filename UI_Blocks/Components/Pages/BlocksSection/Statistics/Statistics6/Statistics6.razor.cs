namespace UI_Blocks.Components.Pages.BlocksSection.Statistics.Statistics6
{
    public partial class Statistics6
    {
        public List<Metric> MetricsData { get; set; } = new List<Metric>
        {
            new Metric { MetricName = "Followers", CurrentValue = 6025, PreviousValue = 6780, CurrentPercentage = 10.32, Trend = "up" },
            new Metric { MetricName = "Likes", CurrentValue = 72094, PreviousValue = 78001, CurrentPercentage = 7.57, Trend = "down" },
            new Metric { MetricName = "Comments", CurrentValue = 16009, PreviousValue = 14911, CurrentPercentage = 7.36, Trend = "up" },
            new Metric { MetricName = "Reach", CurrentValue = 890121, PreviousValue = 501780, CurrentPercentage = 77.39, Trend = "up" }
        };
        
        public class Metric
        {
            public string MetricName { get; set; } = string.Empty;
            public int CurrentValue { get; set; }
            public int PreviousValue { get; set; }
            public double CurrentPercentage { get; set; }
            public string Trend { get; set; } = string.Empty;
        }
    }
}
