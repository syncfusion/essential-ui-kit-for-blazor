using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.BarChart.BarChart5
{
    public partial class BarChart5
    {
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;
        public int XAxisLabelRotation = 0;

        public List<BarData> BarChartData = new List<BarData>
        {
            new BarData { XAxis = "Jan", YAxis1 = 1.5, YAxis2 = -10 },
            new BarData { XAxis = "Feb", YAxis1 = 2.5, YAxis2 = 20 },
            new BarData { XAxis = "Mar", YAxis1 = 4, YAxis2 = 70 },
            new BarData { XAxis = "Apr", YAxis1 = 2.3, YAxis2 = -10 },
            new BarData { XAxis = "May", YAxis1 = 2.5, YAxis2 = 15 },
            new BarData { XAxis = "Jun", YAxis1 = 2.9, YAxis2 = 25 },
            new BarData { XAxis = "Jul", YAxis1 = 2.3, YAxis2 = -5 },
            new BarData { XAxis = "Aug", YAxis1 = 3.2, YAxis2 = 15 },
            new BarData { XAxis = "Sep", YAxis1 = 2, YAxis2 = 10 },
            new BarData { XAxis = "Oct", YAxis1 = 3.7, YAxis2 = 30 },
            new BarData { XAxis = "Nov", YAxis1 = 2.9, YAxis2 = -5 },
            new BarData { XAxis = "Dec", YAxis1 = 1.25, YAxis2 = 5 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                XAxisLabelRotation = windowWidth < 767 ? -90 : 0;
                if (IsDropdownOpen && DropDownButton != null)
                {
                    DropDownButton.Toggle();
                }
            }
            StateHasChanged();
        }

        public class BarData
        {
            public string XAxis { get; set; } = string.Empty;
            public double YAxis1 { get; set; }
            public double YAxis2 { get; set; }
        }
    }
}
