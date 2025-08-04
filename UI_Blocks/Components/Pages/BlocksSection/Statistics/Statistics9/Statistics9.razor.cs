namespace UI_Blocks.Components.Pages.BlocksSection.Statistics.Statistics9
{
    public partial class Statistics9
    {
        public List<Metric> MetricsData = new List<Metric>
        {
            new Metric { MetricName = "Impressions", CurrentValue = "23.5K", CurrentPercentage = 3.5 },
            new Metric { MetricName = "Active Users", CurrentValue = "432K", CurrentPercentage = -0.5 },
            new Metric { MetricName = "User Engagements", CurrentValue = "89%", CurrentPercentage = 9 },
            new Metric { MetricName = "Total Orders", CurrentValue = "56,312", CurrentPercentage = 4 }
        };
        
        public class Metric
        {
            public string MetricName { get; set; } = string.Empty;
            public string CurrentValue { get; set; } = string.Empty;
            public double CurrentPercentage { get; set; } 
        }
    }
}
