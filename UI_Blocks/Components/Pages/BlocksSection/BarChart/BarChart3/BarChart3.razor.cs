using Syncfusion.Blazor.SplitButtons;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.RichTextEditor.Internal;

namespace UI_Blocks.Components.Pages.BlocksSection.BarChart.BarChart3
{
    public partial class BarChart3
    {
        public SfChart? Chart;
        public SfDropDownButton? PeriodDropDown;
        public SfDropDownButton? WeatherDropDown;
        public bool IsPeriodDropdownOpen = false;
        public bool IsTempDropdownOpen = false;
        public double XAxisLabelRotation = 0;

        public List<DropDownMenuItem> PeriodOptions = new List<DropDownMenuItem>
        {
            new DropDownMenuItem { Text = "Day" },
            new DropDownMenuItem { Text = "Week" },
            new DropDownMenuItem { Text = "Month" },
            new DropDownMenuItem { Text = "Year" },
            new DropDownMenuItem { Text = "Custom" }
        };

        public List<DropDownMenuItem> WeatherOptions = new List<DropDownMenuItem>
        {
            new DropDownMenuItem { Text = "Temperature" },
            new DropDownMenuItem { Text = "Wind speed" },
            new DropDownMenuItem { Text = "Air pressure" },
            new DropDownMenuItem { Text = "Snowfall" },
            new DropDownMenuItem { Text = "Visibility" }
        };

        public List<WeatherData> BarChartData = new List<WeatherData>
        {
            new WeatherData { Days = "Jan", LowTemp = 8, HighTemp = 14 },
            new WeatherData { Days = "Feb", LowTemp = 12, HighTemp = 20 },
            new WeatherData { Days = "Mar", LowTemp = 16, HighTemp = 26 },
            new WeatherData { Days = "Apr", LowTemp = 18, HighTemp = 30 },
            new WeatherData { Days = "May", LowTemp = 17, HighTemp = 27 },
            new WeatherData { Days = "Jun", LowTemp = 19, HighTemp = 30 },
            new WeatherData { Days = "Jul", LowTemp = 18, HighTemp = 28 },
            new WeatherData { Days = "Aug", LowTemp = 16, HighTemp = 25 },
            new WeatherData { Days = "Sep", LowTemp = 17, HighTemp = 25 },
            new WeatherData { Days = "Oct", LowTemp = 15, HighTemp = 27 },
            new WeatherData { Days = "Nov", LowTemp = 13, HighTemp = 23 },
            new WeatherData { Days = "Dec", LowTemp = 12, HighTemp = 24 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                XAxisLabelRotation = windowWidth < 767 ? -90 : 0;
                if (IsPeriodDropdownOpen && PeriodDropDown != null)
                {
                    PeriodDropDown.Toggle();
                }
                if (IsTempDropdownOpen && WeatherDropDown != null)
                {
                    WeatherDropDown.Toggle();
                }
            }
            StateHasChanged();
        }

        public class WeatherData
        {
            public string Days { get; set; } = string.Empty;
            public double HighTemp { get; set; }
            public double LowTemp { get; set; }
        }
    }
}
