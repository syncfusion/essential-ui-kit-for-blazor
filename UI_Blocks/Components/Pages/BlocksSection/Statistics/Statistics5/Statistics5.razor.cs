using Syncfusion.Blazor.Charts;

namespace UI_Blocks.Components.Pages.BlocksSection.Statistics.Statistics5
{
    public partial class Statistics5
    {
        public List<Metric> MetricsData { get; set; } = new List<Metric>
        {
            new Metric
            {
                Id = 1,
                MetricName = "Patients",
                CurrentValue = 6025,
                CurrentPercentage = 8.95,
                Trend = "up",
                MetricPoints = new List<MetricPoint>
                {
                    new MetricPoint { X = 1, Y = 5520 },
                    new MetricPoint { X = 2, Y = 5580 },
                    new MetricPoint { X = 3, Y = 5510 },
                    new MetricPoint { X = 4, Y = 5650 },
                    new MetricPoint { X = 5, Y = 5800 },
                    new MetricPoint { X = 6, Y = 5750 },
                    new MetricPoint { X = 7, Y = 5900 },
                    new MetricPoint { X = 8, Y = 6100 },
                    new MetricPoint { X = 9, Y = 5950 },
                    new MetricPoint { X = 10, Y = 6025 }
                }
            },
            new Metric
            {
                Id = 2,
                MetricName = "New This Week",
                CurrentValue = 452,
                CurrentPercentage = 4.11,
                Trend = "up",
                MetricPoints = new List<MetricPoint>
                {
                    new MetricPoint { X = 1, Y = 425 },
                    new MetricPoint { X = 2, Y = 418 },
                    new MetricPoint { X = 3, Y = 430 },
                    new MetricPoint { X = 4, Y = 442 },
                    new MetricPoint { X = 5, Y = 410 },
                    new MetricPoint { X = 6, Y = 435 },
                    new MetricPoint { X = 7, Y = 445 },
                    new MetricPoint { X = 8, Y = 450 },
                    new MetricPoint { X = 9, Y = 448 },
                    new MetricPoint { X = 10, Y = 452 }
                }
            },
            new Metric
            {
                Id = 3,
                MetricName = "Critical Alerts",
                CurrentValue = 948,
                CurrentPercentage = 12.05,
                Trend = "down",
                MetricPoints = new List<MetricPoint>
                {
                    new MetricPoint { X = 1, Y = 1050 },
                    new MetricPoint { X = 2, Y = 1090 },
                    new MetricPoint { X = 3, Y = 1020 },
                    new MetricPoint { X = 4, Y = 1080 },
                    new MetricPoint { X = 5, Y = 980 },
                    new MetricPoint { X = 6, Y = 1010 },
                    new MetricPoint { X = 7, Y = 970 },
                    new MetricPoint { X = 8, Y = 940 },
                    new MetricPoint { X = 9, Y = 960 },
                    new MetricPoint { X = 10, Y = 948 }
                }
            },
            new Metric
            {
                Id = 4,
                MetricName = "Appointments",
                CurrentValue = 5626,
                CurrentPercentage = 27.47,
                Trend = "up",
                MetricPoints = new List<MetricPoint>
                {
                    new MetricPoint { X = 1, Y = 4650 },
                    new MetricPoint { X = 2, Y = 4410 },
                    new MetricPoint { X = 3, Y = 4800 },
                    new MetricPoint { X = 4, Y = 5100 },
                    new MetricPoint { X = 5, Y = 5300 },
                    new MetricPoint { X = 6, Y = 5250 },
                    new MetricPoint { X = 7, Y = 5400 },
                    new MetricPoint { X = 8, Y = 5550 },
                    new MetricPoint { X = 9, Y = 5590 },
                    new MetricPoint { X = 10, Y = 5626 }
                }
            }
        };

        public ChartAreaBorder ChartAreaBorderSettings = new ChartAreaBorder
        {
            Width = 0,
            Color = "transparent"
        };

        public string GetGradientFill(string trend)
        {
            return trend == "up" ? "url(#gradient-up)" : "url(#gradient-down)";
        }

        public int GetYMinimum(List<MetricPoint> data)
        {
            if (data == null || !data.Any())
                return 0;

            double minValue = data.Min(p => p.Y);
            double maxValue = data.Max(p => p.Y);
            double buffer = (maxValue - minValue) * 0.05;
            return (int)Math.Floor(minValue - buffer);
        }

        public int GetYMaximum(List<MetricPoint> data)
        {
            if (data == null || !data.Any())
                return 100;

            double minValue = data.Min(p => p.Y);
            double maxValue = data.Max(p => p.Y);
            double buffer = (maxValue - minValue) * 0.05;
            return (int)Math.Ceiling(maxValue + buffer);
        }

        public class Metric
        {
            public int Id { get; set; }
            public string MetricName { get; set; } = string.Empty;
            public int CurrentValue { get; set; }
            public double CurrentPercentage { get; set; }
            public string Trend { get; set; } = string.Empty;
            public List<MetricPoint> MetricPoints { get; set; } = new List<MetricPoint>();
        }

        public class MetricPoint
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
