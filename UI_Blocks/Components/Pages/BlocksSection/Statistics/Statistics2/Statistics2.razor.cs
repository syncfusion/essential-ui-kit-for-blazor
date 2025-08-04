using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Statistics.Statistics2
{
    public partial class Statistics2
    {
        private int ScreenWidth;

        public List<Metric> MetricsData = new List<Metric>
        {
            new Metric { MetricName = "Website Visits", CurrentValue = "756", ContextInfo = "", CurrentPercentage = "0.02%", Total = "221,314" },
            new Metric { MetricName = "Bounce Rate", CurrentValue = "36.7%", ContextInfo = "Percentage of visitors who leave after viewing one page.", CurrentPercentage = "3.31", Total = "34.12%" },
            new Metric { MetricName = "Page Views", CurrentValue = "1,593", ContextInfo = "", CurrentPercentage = "0.02%", Total = "651,029" },
            new Metric { MetricName = "Session", CurrentValue = "5.6", ContextInfo = "", CurrentPercentage = "0.01%", Total = "4,231" },
            new Metric { MetricName = "Per Visit Value", CurrentValue = "36.7%", ContextInfo = "Average revenue generated per visit.", CurrentPercentage = "3.31", Total = "34.12%" }
        };

        public (bool IsLastRow, bool IsLastColumn) GetIsLastRowAndColumn(int index, int totalItems)
        {
            int columnCount = ScreenWidth < 576 ? 1 : ScreenWidth < 1024 ? 3 : 5;
            bool isLastRow = Math.Floor((double)index / columnCount) == Math.Ceiling((double)totalItems / columnCount) - 1;
            bool isLastColumn = (index + 1) % columnCount == 0;
            return (isLastRow, isLastColumn);
        }

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                ScreenWidth = windowWidth;
            }
            StateHasChanged();
        }

        public class Metric
        {
            public string MetricName { get; set; } = string.Empty;
            public string CurrentValue { get; set; } = string.Empty;
            public string ContextInfo { get; set; } = string.Empty;
            public string CurrentPercentage { get; set; } = string.Empty;
            public string Total { get; set; } = string.Empty;
        }
    }
}
