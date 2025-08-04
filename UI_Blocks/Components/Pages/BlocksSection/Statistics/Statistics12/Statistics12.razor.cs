namespace UI_Blocks.Components.Pages.BlocksSection.Statistics.Statistics12
{
    public partial class Statistics12
    {
        public List<Metric> MetricsData = new List<Metric>
        {
            new Metric { Id = 1, MetricName = "Dream Car", CurrentValue = 26008, Goal = 34678 },
            new Metric { Id = 2, MetricName = "House Savings", CurrentValue = 12567, Goal = 25000 },
            new Metric { Id = 3, MetricName = "Motorcycle", CurrentValue = 12567, Goal = 25000 },
            new Metric { Id = 4, MetricName = "Laptop", CurrentValue = 12567, Goal = 25000 }
        };
        
        public class Metric
        {
            public int Id { get; set; }
            public string MetricName { get; set; } = string.Empty;
            public int CurrentValue { get; set; } 
            public int Goal { get; set; } 
        }
    }
}