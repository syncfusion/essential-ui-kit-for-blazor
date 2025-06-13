using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;

namespace UI_Blocks.Components.Pages.BlocksSection.BarChart.BarChart4
{
    public partial class BarChart4
    {
        public LegendPosition LegendPosition { get; set; } = LegendPosition.Top;

        public List<RevenueData> BarChartData = new List<RevenueData>
        {
            new RevenueData { Date = "01", Income = 270, Expense = 200 },
            new RevenueData { Date = "02", Income = 150, Expense = 120 },
            new RevenueData { Date = "03", Income = 340, Expense = 150 },
            new RevenueData { Date = "04", Income = 250, Expense = 100 },
            new RevenueData { Date = "05", Income = 280, Expense = 200 },
            new RevenueData { Date = "06", Income = 300, Expense = 200 },
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                LegendPosition = windowWidth < 767 ? LegendPosition.Bottom : LegendPosition.Top;
            }
            StateHasChanged();
        }

        public class RevenueData
        {
            public string Date { get; set; } = string.Empty;
            public double Income { get; set; }
            public double Expense { get; set; }
        }
    }
}
