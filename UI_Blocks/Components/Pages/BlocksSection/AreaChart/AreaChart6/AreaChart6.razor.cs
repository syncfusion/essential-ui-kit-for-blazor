using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.AreaChart.AreaChart6
{
    public partial class AreaChart6
    {
        public SfChart? Chart;
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;
        public double XAxisLabelRotation = 0;

        public List<RevenueData> AreaChartData = new List<RevenueData>
        {
            new RevenueData { Date = "Feb 14", CurrentWeek = 14500, LastWeek = 15500 },
            new RevenueData { Date = "Feb 15", CurrentWeek = 16259, LastWeek = 14033 },
            new RevenueData { Date = "Feb 16", CurrentWeek = 16000, LastWeek = 16500 },
            new RevenueData { Date = "Feb 17", CurrentWeek = 19000, LastWeek = 17500 },
            new RevenueData { Date = "Feb 18", CurrentWeek = 17000, LastWeek = 16000 },
            new RevenueData { Date = "Feb 19", CurrentWeek = 18500, LastWeek = 17000 },
            new RevenueData { Date = "Feb 20", CurrentWeek = 19000, LastWeek = 16500 }
        };

        public void AxisLabelRender(AxisLabelRenderEventArgs args)
        {
            if (args.Axis.Name == "PrimaryYAxis")
            {
                args.Text = "$" + (Convert.ToDouble(args.Text) / 1000) + "K";
            }
        }

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
            public string Date { get; set; } = string.Empty;
            public int CurrentWeek { get; set; }
            public int LastWeek { get; set; }
        }
    }
}
