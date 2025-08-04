using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.AreaChart.AreaChart2
{
    public partial class AreaChart2
    {
        public SfDropDownButton? DesktopDropdown;
        public SfDropDownButton? MobileDropdown;
        public bool IsDesktopDropdown = false;
        public bool IsMobileDropdown = false;
        public string SelectedYear = "Last 6 months";

        public List<DropDownMenuItem> MonthOptions = new List<DropDownMenuItem>
        {
            new DropDownMenuItem { Text = "This month" },
            new DropDownMenuItem { Text = "Last month" },
            new DropDownMenuItem { Text = "Last 3 months" },
            new DropDownMenuItem { Text = "Last 6 months" },
            new DropDownMenuItem { Text = "Last 9 months" }
        };

        public List<AreaData> MetricData = new List<AreaData>
        {
            new AreaData { Month = "Jan", Value = 1200 },
            new AreaData { Month = "Feb", Value = 3200 },
            new AreaData { Month = "Mar", Value = 8989 },
            new AreaData { Month = "Apr", Value = 7600 },
            new AreaData { Month = "May", Value = 5300 },
            new AreaData { Month = "Jun", Value = 3100 },
            new AreaData { Month = "Jul", Value = 2500 },
            new AreaData { Month = "Aug", Value = 4900 },
            new AreaData { Month = "Sep", Value = 6200 },
            new AreaData { Month = "Oct", Value = 2900 },
            new AreaData { Month = "Nov", Value = 2100 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                if (IsDesktopDropdown && DesktopDropdown != null)
                {
                    DesktopDropdown.Toggle();
                }
                if (IsMobileDropdown && MobileDropdown != null)
                {
                    MobileDropdown.Toggle();
                }
            }
            StateHasChanged();
        }

        public class AreaData
        {
            public string Month { get; set; } = string.Empty;
            public double Value { get; set; }
        }
    }
}
