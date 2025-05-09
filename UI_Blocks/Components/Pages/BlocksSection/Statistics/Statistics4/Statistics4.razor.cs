namespace UI_Blocks.Components.Pages.BlocksSection.Statistics.Statistics4
{
    public partial class Statistics4
    {
        public List<Metric> MetricsData { get; set; } = new List<Metric>
        {
            new Metric { MetricName = "Calories", CurrentValue = 243, CurrentPercentage = 12, MetricAssets = "calories.png", Unit = "kcal", Trend = "up" },
            new Metric { MetricName = "Activity", CurrentValue = 56, CurrentPercentage = -12, MetricAssets = "activity.png", Unit = "min", Trend = "down" },
            new Metric { MetricName = "Total Distance", CurrentValue = 3, CurrentPercentage = 12, MetricAssets = "total-distance.png", Unit = "miles", Trend = "up" },
            new Metric { MetricName = "Sleep", CurrentValue = 7, CurrentPercentage = -12, MetricAssets = "sleep.png", Unit = "h", Trend = "down" }
        };
        
        public class Metric
        {
            public string MetricName { get; set; } = string.Empty;
            public int CurrentValue { get; set; }
            public int CurrentPercentage { get; set; }
            public string MetricAssets { get; set; } = string.Empty;
            public string Unit { get; set; } = string.Empty;
            public string Trend { get; set; } = string.Empty;
        }
    }
}
