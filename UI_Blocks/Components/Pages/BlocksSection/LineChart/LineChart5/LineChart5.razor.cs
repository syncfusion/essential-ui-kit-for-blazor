using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.LineChart.LineChart5
{
    public partial class LineChart5
    {
        public SfChart? Chart;
        public SfDropDownButton? PeriodOptions;
        public bool IsPeriodDropdownOpen = false;
        public double XAxisLabelRotation = 0;
       
        public List<LineData> LineChartData = new List<LineData>
        {
            new LineData { XAxis = "Jan", YAxis1 = 30, YAxis2 = 30 },
            new LineData { XAxis = "Feb", YAxis1 = 20, YAxis2 = 20 },
            new LineData { XAxis = "Mar", YAxis1 = 29, YAxis2 = 26 },
            new LineData { XAxis = "Apr", YAxis1 = 37, YAxis2 = 16 },
            new LineData { XAxis = "May", YAxis1 = 40, YAxis2 = 30 },
            new LineData { XAxis = "Jun", YAxis1 = 25, YAxis2 = 40 },
            new LineData { XAxis = "Jul", YAxis1 = 35, YAxis2 = 18 },
            new LineData { XAxis = "Aug", YAxis1 = 48, YAxis2 = 40 },
            new LineData { XAxis = "Sep", YAxis1 = 23, YAxis2 = 50 },
            new LineData { XAxis = "Oct", YAxis1 = 26, YAxis2 = 37 },
            new LineData { XAxis = "Nov", YAxis1 = 29, YAxis2 = 29 },
            new LineData { XAxis = "Dec", YAxis1 = 40, YAxis2 = 40 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                XAxisLabelRotation = windowWidth < 767 ? -90 : 0;
                if (IsPeriodDropdownOpen && PeriodOptions != null)
                {
                    PeriodOptions.Toggle();
                }
            }
            StateHasChanged();
        }

        public class LineData
        {
            public string XAxis { get; set; } = string.Empty;
            public double YAxis1 { get; set; }
            public double YAxis2 { get; set; }
        }
    }
}
