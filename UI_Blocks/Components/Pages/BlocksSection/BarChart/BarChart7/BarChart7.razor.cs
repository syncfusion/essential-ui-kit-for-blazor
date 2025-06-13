using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;
using Microsoft.JSInterop;
using Syncfusion.Blazor.RichTextEditor.Internal;

namespace UI_Blocks.Components.Pages.BlocksSection.BarChart.BarChart7
{
    public partial class BarChart7
    {
        public SfChart? Chart;
        public SfDropDownButton? DropDown;
        public bool IsDropdownOpen = false;
        public double XAxisLabelRotation = 0;
        public string SelectedPlace = "USA";

        public List<DropDownMenuItem> CountryOptions = new List<DropDownMenuItem>
        {
            new DropDownMenuItem { Text = "Canada" },
            new DropDownMenuItem { Text = "United Kingdom" },
            new DropDownMenuItem { Text = "Germany" },
            new DropDownMenuItem { Text = "USA" },
            new DropDownMenuItem { Text = "Australia" }
        };

        public List<WeatherData> BarChartData = new List<WeatherData>
        {
            new WeatherData { Month = "Jan", Temperature = 6 },
            new WeatherData { Month = "Feb", Temperature = 8.9 },
            new WeatherData { Month = "Mar", Temperature = 12 },
            new WeatherData { Month = "Apr", Temperature = 17.5 },
            new WeatherData { Month = "May", Temperature = 22.1 },
            new WeatherData { Month = "Jun", Temperature = 25 },
            new WeatherData { Month = "Jul", Temperature = 29.4 },
            new WeatherData { Month = "Aug", Temperature = 29.6 },
            new WeatherData { Month = "Sep", Temperature = 25.8 },
            new WeatherData { Month = "Oct", Temperature = 21.1 },
            new WeatherData { Month = "Nov", Temperature = 15.5 },
            new WeatherData { Month = "Dec", Temperature = 9.9 }
        };

        public void Place(MenuEventArgs args)
        {
            SelectedPlace = args.Item.Text;
            DropDown.Content = SelectedPlace;
        }

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                XAxisLabelRotation = windowWidth < 767 ? -90 : 0;
                if (IsDropdownOpen && DropDown != null)
                {
                    DropDown.Toggle();
                }
            }
            StateHasChanged();
        }

        public void OnPointRender(PointRenderEventArgs args)
        {
            double temp = Convert.ToDouble(args.Point.Y);
            args.Fill = temp <= 10 ? "#FFD54F" : temp <= 20 ? "#FFB300" : temp <= 25 ? "#FB8C00" : "#F4511E";
        }

        public class WeatherData
        {
            public string Month { get; set; } = string.Empty;
            public double Temperature { get; set; }
        }
    }
}
