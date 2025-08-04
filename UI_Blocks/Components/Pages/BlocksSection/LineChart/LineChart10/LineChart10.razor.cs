using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.LineChart.LineChart10
{
    public partial class LineChart10
    {
        public SfChart? Chart;
        public SfDropDownButton? MonthOptions;
        public bool IsMonthDropdownOpen = false;

        public List<LineData> LineChartData = new List<LineData>
        {
            new LineData { XAxis = 4, YAxis = 0 },
            new LineData { XAxis = 8, YAxis = 12 },
            new LineData { XAxis = 12, YAxis = 25 },
            new LineData { XAxis = 16, YAxis = 37 },
            new LineData { XAxis = 20, YAxis = 50 },
            new LineData { XAxis = 24, YAxis = 75 }
        };

        [JSInvokable]
        public void ResizeHandler(string message,int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                if (IsMonthDropdownOpen && MonthOptions != null)
                {
                    MonthOptions.Toggle();
                }
            }
            StateHasChanged();
        }

        public class LineData
        {
            public int XAxis { get; set; }
            public double YAxis { get; set; }
        }
    }
}
