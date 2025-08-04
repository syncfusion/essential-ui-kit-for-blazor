using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.AreaChart.AreaChart8
{
    public partial class AreaChart8
    {
        public SfChart? Chart;
        public SfDropDownButton? RangeDropdown;
        public SfDropDownButton? CountryDropdown;
        public double XAxisLabelRotation = 0;
        public bool IsMobileView = false;
        public bool IsRangeDropdownOpen = false;
        public bool IsCountryDropdownOpen = false;

        public List<TemperatureData> AreaChartData = new List<TemperatureData>
        {
            new TemperatureData { Date = new DateTime(2025, 1, 1), High = 20, Low = -10 },
            new TemperatureData { Date = new DateTime(2025, 1, 5), High = 18, Low = -12 },
            new TemperatureData { Date = new DateTime(2025, 1, 10), High = 17, Low = -11 },
            new TemperatureData { Date = new DateTime(2025, 1, 15), High = 19, Low = -10 },
            new TemperatureData { Date = new DateTime(2025, 1, 20), High = 21, Low = -12 },
            new TemperatureData { Date = new DateTime(2025, 2, 1), High = 23, Low = -9 },
            new TemperatureData { Date = new DateTime(2025, 2, 5), High = 21, Low = -10 },
            new TemperatureData { Date = new DateTime(2025, 2, 10), High = 20, Low = -7 },
            new TemperatureData { Date = new DateTime(2025, 2, 15), High = 18, Low = -6 },
            new TemperatureData { Date = new DateTime(2025, 2, 20), High = 19, Low = -5 },
            new TemperatureData { Date = new DateTime(2025, 3, 1), High = 21, Low = -4 },
            new TemperatureData { Date = new DateTime(2025, 3, 5), High = 20, Low = -4 },
            new TemperatureData { Date = new DateTime(2025, 3, 10), High = 18, Low = -5 },
            new TemperatureData { Date = new DateTime(2025, 3, 15), High = 17, Low = -4 },
            new TemperatureData { Date = new DateTime(2025, 3, 20), High = 16, Low = -2 },
            new TemperatureData { Date = new DateTime(2025, 4, 1), High = 32, Low = 0 },
            new TemperatureData { Date = new DateTime(2025, 4, 5), High = 34, Low = 2 },
            new TemperatureData { Date = new DateTime(2025, 4, 10), High = 30, Low = 5 },
            new TemperatureData { Date = new DateTime(2025, 4, 15), High = 31, Low = 6 },
            new TemperatureData { Date = new DateTime(2025, 4, 20), High = 34, Low = 7 },
            new TemperatureData { Date = new DateTime(2025, 5, 1), High = 32, Low = 4 },
            new TemperatureData { Date = new DateTime(2025, 5, 5), High = 30, Low = 5 },
            new TemperatureData { Date = new DateTime(2025, 5, 10), High = 31, Low = 6 },
            new TemperatureData { Date = new DateTime(2025, 5, 15), High = 32, Low = 7 },
            new TemperatureData { Date = new DateTime(2025, 5, 20), High = 29, Low = 10 },
            new TemperatureData { Date = new DateTime(2025, 6, 1), High = 31, Low = 10 },
            new TemperatureData { Date = new DateTime(2025, 6, 5), High = 29, Low = 12 },
            new TemperatureData { Date = new DateTime(2025, 6, 10), High = 27, Low = 13 },
            new TemperatureData { Date = new DateTime(2025, 6, 15), High = 30, Low = 15 },
            new TemperatureData { Date = new DateTime(2025, 6, 20), High = 32, Low = 16 },
            new TemperatureData { Date = new DateTime(2025, 7, 1), High = 34, Low = 12 },
            new TemperatureData { Date = new DateTime(2025, 7, 5), High = 33, Low = 14 },
            new TemperatureData { Date = new DateTime(2025, 7, 10), High = 33, Low = 16 },
            new TemperatureData { Date = new DateTime(2025, 7, 15), High = 34, Low = 17 },
            new TemperatureData { Date = new DateTime(2025, 7, 20), High = 35, Low = 19 },
            new TemperatureData { Date = new DateTime(2025, 8, 1), High = 34, Low = 15 },
            new TemperatureData { Date = new DateTime(2025, 8, 5), High = 32, Low = 17 },
            new TemperatureData { Date = new DateTime(2025, 8, 10), High = 31, Low = 18 },
            new TemperatureData { Date = new DateTime(2025, 8, 15), High = 30, Low = 19 },
            new TemperatureData { Date = new DateTime(2025, 8, 20), High = 32, Low = 21 },
            new TemperatureData { Date = new DateTime(2025, 9, 1), High = 39, Low = 18 },
            new TemperatureData { Date = new DateTime(2025, 9, 5), High = 37, Low = 17 },
            new TemperatureData { Date = new DateTime(2025, 9, 10), High = 33, Low = 16 },
            new TemperatureData { Date = new DateTime(2025, 9, 15), High = 34, Low = 17 },
            new TemperatureData { Date = new DateTime(2025, 9, 20), High = 34, Low = 18 },
            new TemperatureData { Date = new DateTime(2025, 10, 1), High = 32, Low = 17 },
            new TemperatureData { Date = new DateTime(2025, 10, 5), High = 31, Low = 18 },
            new TemperatureData { Date = new DateTime(2025, 10, 10), High = 29, Low = 20 },
            new TemperatureData { Date = new DateTime(2025, 10, 15), High = 30, Low = 19 },
            new TemperatureData { Date = new DateTime(2025, 10, 20), High = 31, Low = 18 },
            new TemperatureData { Date = new DateTime(2025, 11, 1), High = 34, Low = 18 },
            new TemperatureData { Date = new DateTime(2025, 11, 5), High = 32, Low = 19 },
            new TemperatureData { Date = new DateTime(2025, 11, 10), High = 31, Low = 17 },
            new TemperatureData { Date = new DateTime(2025, 11, 15), High = 33, Low = 18 },
            new TemperatureData { Date = new DateTime(2025, 11, 20), High = 30, Low = 16 },
            new TemperatureData { Date = new DateTime(2025, 12, 1), High = 26, Low = 13 },
            new TemperatureData { Date = new DateTime(2025, 12, 5), High = 24, Low = 14 },
            new TemperatureData { Date = new DateTime(2025, 12, 10), High = 23, Low = 15 },
            new TemperatureData { Date = new DateTime(2025, 12, 15), High = 20, Low = 13 },
            new TemperatureData { Date = new DateTime(2025, 12, 20), High = 21, Low = 14 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                IsMobileView = windowWidth <= 640;
                XAxisLabelRotation = IsMobileView ? -90 : 0;
                if (IsRangeDropdownOpen && RangeDropdown != null)
                {
                    RangeDropdown.Toggle();
                }
                if (IsCountryDropdownOpen && CountryDropdown != null)
                {
                    CountryDropdown.Toggle();
                }
            }
            StateHasChanged();
        }

        public class TemperatureData
        {
            public DateTime Date { get; set; }
            public double High { get; set; }
            public double Low { get; set; }
        }
    }
}
