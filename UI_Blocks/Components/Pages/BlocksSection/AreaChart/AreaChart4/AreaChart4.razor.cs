using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.AreaChart.AreaChart4
{
    public partial class AreaChart4
    {
        public SfChart? Chart;
        public SfDropDownButton? YearDropDown;
        public SfDropDownButton? UserMenuDropDown;
        public bool IsYearDropdownOpen = false;
        public bool IsUserMenuOpen = false;
        public double XAxisLabelRotation = 0;

        public List<AreaData> AreaChartData = new List<AreaData>
        {
            new AreaData { Month = "Jan", Teens = 0, YoungAdults = 0, Adults = 0 },
            new AreaData { Month = "Feb", Teens = 250, YoungAdults = 70, Adults = 100 },
            new AreaData { Month = "Mar", Teens = 200, YoungAdults = 100, Adults = 120 },
            new AreaData { Month = "Apr", Teens = 80, YoungAdults = 120, Adults = 80 },
            new AreaData { Month = "May", Teens = 60, YoungAdults = 200, Adults = 70 },
            new AreaData { Month = "Jun", Teens = 150, YoungAdults = 250, Adults = 160 },
            new AreaData { Month = "Jul", Teens = 180, YoungAdults = 200, Adults = 140 },
            new AreaData { Month = "Aug", Teens = 110, YoungAdults = 300, Adults = 100 },
            new AreaData { Month = "Sep", Teens = 130, YoungAdults = 463, Adults = 150 },
            new AreaData { Month = "Oct", Teens = 190, YoungAdults = 400, Adults = 190 },
            new AreaData { Month = "Nov", Teens = 160, YoungAdults = 180, Adults = 100 },
            new AreaData { Month = "Dec", Teens = 30, YoungAdults = 50, Adults = 40 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                XAxisLabelRotation = windowWidth < 767 ? -90 : 0;
                if (IsYearDropdownOpen && YearDropDown != null)
                {
                    YearDropDown.Toggle();
                }
                if (IsUserMenuOpen && UserMenuDropDown != null)
                {
                    UserMenuDropDown.Toggle();
                }
            }
            StateHasChanged();
        }

        public class AreaData
        {
            public string Month { get; set; } = string.Empty;
            public double Teens { get; set; }
            public double YoungAdults { get; set; }
            public double Adults { get; set; }
        }
    }
}
