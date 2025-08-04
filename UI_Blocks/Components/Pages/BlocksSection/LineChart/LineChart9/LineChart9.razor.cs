using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.LineChart.LineChart9
{
    public partial class LineChart9
    {
        public SfDropDownButton? RangeDropdown;
        public SfDropDownButton? MobileDropdown;
        public bool IsRangeDropdownOpen = false;
        public bool IsMobileDropdown = false;

        public List<SalesData> LineChartData = new List<SalesData>
        {
            new SalesData { Day = "2", ProjectedAverage = 3.8, SalesGrowth = 2.5 },
            new SalesData { Day = "4", ProjectedAverage = 3.8, SalesGrowth = 2.2 },
            new SalesData { Day = "6", ProjectedAverage = 3.8, SalesGrowth = 2.8 },
            new SalesData { Day = "8", ProjectedAverage = 3.8, SalesGrowth = 3.0 },
            new SalesData { Day = "10", ProjectedAverage = 3.8, SalesGrowth = 3.6 },
            new SalesData { Day = "12", ProjectedAverage = 3.8, SalesGrowth = 4.1 },
            new SalesData { Day = "14", ProjectedAverage = 3.8, SalesGrowth = 4.0 },
            new SalesData { Day = "16", ProjectedAverage = 3.8, SalesGrowth = 4.2 },
            new SalesData { Day = "18", ProjectedAverage = 3.8, SalesGrowth = 3.2 },
            new SalesData { Day = "20", ProjectedAverage = 3.8, SalesGrowth = 4.4 },
            new SalesData { Day = "22", ProjectedAverage = 3.8, SalesGrowth = 4.8 },
            new SalesData { Day = "24", ProjectedAverage = 3.8, SalesGrowth = 5.0 },
            new SalesData { Day = "26", ProjectedAverage = 3.8, SalesGrowth = 4.6 },
            new SalesData { Day = "28", ProjectedAverage = 3.8, SalesGrowth = 4.9 },
            new SalesData { Day = "30", ProjectedAverage = 3.8, SalesGrowth = 5.2 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                if (IsRangeDropdownOpen && RangeDropdown != null)
                {
                    RangeDropdown.Toggle();
                }
                if (IsMobileDropdown && MobileDropdown != null)
                {
                    MobileDropdown.Toggle();
                }
            }
        }

        public class SalesData
        {
            public string Day { get; set; } = string.Empty;
            public double ProjectedAverage { get; set; }
            public double SalesGrowth { get; set; }
        }
    }
}
