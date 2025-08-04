using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.AreaChart.AreaChart7
{
    public partial class AreaChart7
    {
        public SfChart? Chart;
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;
        public bool IsMobileView =  false;
   
        public List<WeatherData> AreaChartData = new List<WeatherData>
        {
            new WeatherData { Date = new DateTime(2024, 1, 6), High = 25, Low = 18 },
            new WeatherData { Date = new DateTime(2024, 1, 7), High = 28, Low = 20 },
            new WeatherData { Date = new DateTime(2024, 1, 8), High = 25, Low = 14 },
            new WeatherData { Date = new DateTime(2024, 1, 9), High = 26, Low = 17 },
            new WeatherData { Date = new DateTime(2024, 1, 10), High = 27, Low = 17 },
            new WeatherData { Date = new DateTime(2024, 1, 11), High = 27, Low = 16 },
            new WeatherData { Date = new DateTime(2024, 1, 12), High = 29, Low = 17 },
            new WeatherData { Date = new DateTime(2024, 1, 13), High = 28, Low = 19 },
            new WeatherData { Date = new DateTime(2024, 1, 14), High = 29, Low = 17 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                IsMobileView = windowWidth <= 600;
                if (IsDropdownOpen && DropDownButton != null)
                {
                    DropDownButton.Toggle();
                }
            }
            StateHasChanged();
        }
   
        public class WeatherData
        {
            public DateTime Date { get; set; }
            public int High { get; set; }
            public int Low { get; set; }
        }
    }
}
