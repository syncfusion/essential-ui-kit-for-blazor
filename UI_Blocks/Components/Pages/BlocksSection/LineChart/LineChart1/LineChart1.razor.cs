using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.LineChart.LineChart1
{
    public partial class LineChart1
    {
        public SfChart? Chart;
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;
        public double XAxisLabelRotation = 0;

        public List<RevenueData> LineChartData = new List<RevenueData>
        {
            new RevenueData { Month = "Jan", Amount = 2000 },
            new RevenueData { Month = "Feb", Amount = 5000 },
            new RevenueData { Month = "Mar", Amount = 4000 },
            new RevenueData { Month = "Apr", Amount = 20000 },
            new RevenueData { Month = "May", Amount = 10000 },
            new RevenueData { Month = "Jun", Amount = 3000 },
            new RevenueData { Month = "Jul", Amount = 11000 },
            new RevenueData { Month = "Aug", Amount = 9000 },
            new RevenueData { Month = "Sep", Amount = 10000 },
            new RevenueData { Month = "Oct", Amount = 4000 },
            new RevenueData { Month = "Nov", Amount = 18000 },
            new RevenueData { Month = "Dec", Amount = 13000 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                XAxisLabelRotation = windowWidth < 767 ? -90 : 0;
                if (IsDropdownOpen && DropDownButton != null)
                {
                    DropDownButton.Toggle();
                }
            }
            StateHasChanged();
        }

        public class RevenueData
        {
            public string Month { get; set; } = string.Empty;
            public double Amount { get; set; }
        }
    }
}
