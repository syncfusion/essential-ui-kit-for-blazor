using Syncfusion.Blazor.Charts;

namespace UI_Blocks.Components.Pages.BlocksSection.Statistics.Statistics11
{
    public partial class Statistics11
    {
        public List<Metric> MetricsData { get; set; } = new List<Metric>
        {
            new Metric
            {
                MetricName = "Total Revenue",
                CurrentValue = "$54,231",
                CurrentPercentage = 14.5,
                MetricPoints = new List<MetricPoint>
                {
                    new MetricPoint { X = 1, Y = 0.3 },
                    new MetricPoint { X = 2, Y = 1.1 },
                    new MetricPoint { X = 3, Y = 1.1 },
                    new MetricPoint { X = 4, Y = 0.9 },
                    new MetricPoint { X = 5, Y = 1.8 },
                    new MetricPoint { X = 6, Y = 2.2 },
                    new MetricPoint { X = 7, Y = 2.0 },
                    new MetricPoint { X = 8, Y = 2.0 },
                    new MetricPoint { X = 9, Y = 2.5 },
                    new MetricPoint { X = 10, Y = 3.0 }
                }
            },
            new Metric
            {
                MetricName = "Total Orders",
                CurrentValue = "1,234",
                CurrentPercentage = 5.2,
                MetricPoints = new List<MetricPoint>
                {
                    new MetricPoint { X = 1, Y = 3.0 },
                    new MetricPoint { X = 2, Y = 2.5 },
                    new MetricPoint { X = 3, Y = 2.0 },
                    new MetricPoint { X = 4, Y = 2.0 },
                    new MetricPoint { X = 5, Y = 2.2 },
                    new MetricPoint { X = 6, Y = 1.8 },
                    new MetricPoint { X = 7, Y = 0.9 },
                    new MetricPoint { X = 8, Y = 1.1 },
                    new MetricPoint { X = 9, Y = 1.1 },
                    new MetricPoint { X = 10, Y = 0.3 }
                }
            },
            new Metric
            {
                MetricName = "Conversion Rate",
                CurrentValue = "3.8%",
                CurrentPercentage = 18.8,
                MetricPoints = new List<MetricPoint>
                {
                    new MetricPoint { X = 1, Y = 0.3 },
                    new MetricPoint { X = 2, Y = 1.1 },
                    new MetricPoint { X = 3, Y = 1.1 },
                    new MetricPoint { X = 4, Y = 0.9 },
                    new MetricPoint { X = 5, Y = 1.8 },
                    new MetricPoint { X = 6, Y = 2.2 },
                    new MetricPoint { X = 7, Y = 2.0 },
                    new MetricPoint { X = 8, Y = 2.0 },
                    new MetricPoint { X = 9, Y = 2.5 },
                    new MetricPoint { X = 10, Y = 3.0 }
                }
            },
            new Metric
            {
                MetricName = "New Customers",
                CurrentValue = "321",
                CurrentPercentage = 18.5,
                MetricPoints = new List<MetricPoint>
                {
                    new MetricPoint { X = 1, Y = 3.0 },
                    new MetricPoint { X = 2, Y = 2.5 },
                    new MetricPoint { X = 3, Y = 2.0 },
                    new MetricPoint { X = 4, Y = 2.0 },
                    new MetricPoint { X = 5, Y = 2.2 },
                    new MetricPoint { X = 6, Y = 1.8 },
                    new MetricPoint { X = 7, Y = 0.9 },
                    new MetricPoint { X = 8, Y = 1.1 },
                    new MetricPoint { X = 9, Y = 1.1 },
                    new MetricPoint { X = 10, Y = 0.3 }
                }
            }
        };
        
        public ChartAreaBorder ChartAreaBorderSettings = new ChartAreaBorder
        {
            Width = 0,
            Color = "transparent"
        };

        public class Metric
        {
            public string MetricName { get; set; } = string.Empty;
            public string CurrentValue { get; set; } = string.Empty;
            public double CurrentPercentage { get; set; }
            public List<MetricPoint> MetricPoints { get; set; } = new List<MetricPoint>();
        }

        public class MetricPoint
        {
            public int X { get; set; }
            public double Y { get; set; }
        }
    }
}