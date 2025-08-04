using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.LineChart.LineChart11
{
    public partial class LineChart11
    {
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;

        public List<LineData> LineChartData = new List<LineData>
        {
            new LineData { XAxis = "Sun", YAxis1 = 14, YAxis2 = 9, YAxis3 = 5 },
            new LineData { XAxis = "Mon", YAxis1 = 23, YAxis2 = 18, YAxis3 = 14 },
            new LineData { XAxis = "Tue", YAxis1 = 31, YAxis2 = 27, YAxis3 = 22 },
            new LineData { XAxis = "Wed", YAxis1 = 27, YAxis2 = 25, YAxis3 = 21 },
            new LineData { XAxis = "Thu", YAxis1 = 27, YAxis2 = 24, YAxis3 = 20 },
            new LineData { XAxis = "Fri", YAxis1 = 26, YAxis2 = 22, YAxis3 = 16 },
            new LineData { XAxis = "Sat", YAxis1 = 17, YAxis2 = 15, YAxis3 = 12 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                if (IsDropdownOpen && DropDownButton != null)
                {
                    DropDownButton.Toggle();
                }
            }
            StateHasChanged();
        }

        public class LineData
        {
            public string XAxis { get; set; } = string.Empty;
            public double YAxis1 { get; set; }
            public double YAxis2 { get; set; }
            public double YAxis3 { get; set; }
        }
    }
}