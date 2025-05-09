namespace UI_Blocks.Components.Pages.BlocksSection.Statistics.Statistics10
{
    public partial class Statistics10
    {
        public List<Metric> MetricsData { get; set; } = new List<Metric>
        {
            new Metric { MetricName = "Total Income", CurrentValue = "$480,500", CurrentPercentage = 12.95, Trend = "up", MetricAssets = "total-income.png" },
            new Metric { MetricName = "Total Profit", CurrentValue = "$72,375", CurrentPercentage = 12.95, Trend = "up", MetricAssets = "total-profit.png" },
            new Metric { MetricName = "Total Revenue", CurrentValue = "$425,000", CurrentPercentage = 5.18, Trend = "down", MetricAssets = "total-revenue.png" },
            new Metric { MetricName = "Total Conversion", CurrentValue = "10.87%", CurrentPercentage = 12.95, Trend = "up", MetricAssets = "total-conversion.png" }
        };
        
        public class Metric
        {
            public string MetricName { get; set; } = string.Empty;
            public string CurrentValue { get; set; } = string.Empty;
            public double CurrentPercentage { get; set; }
            public string Trend { get; set; } = string.Empty;
            public string MetricAssets { get; set; } = string.Empty;
        }
    }
}
