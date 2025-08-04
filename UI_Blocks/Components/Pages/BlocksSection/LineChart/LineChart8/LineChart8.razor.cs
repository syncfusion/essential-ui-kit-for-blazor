using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;
using Syncfusion.Blazor.Charts;

namespace UI_Blocks.Components.Pages.BlocksSection.LineChart.LineChart8
{
    public partial class LineChart8
    {
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;

        public List<LineData> LineChartData = new List<LineData>
        {
            new LineData { XAxis = "Mon", YAxis1 = 49, YAxis2 = 25 },
            new LineData { XAxis = "Tue", YAxis1 = 70, YAxis2 = 48 },
            new LineData { XAxis = "Wed", YAxis1 = 76, YAxis2 = 48 },
            new LineData { XAxis = "Thu", YAxis1 = 99, YAxis2 = 51 },
            new LineData { XAxis = "Fri", YAxis1 = 124, YAxis2 = 97 },
            new LineData { XAxis = "Sat", YAxis1 = 112, YAxis2 = 77 },
            new LineData { XAxis = "Sun", YAxis1 = 125, YAxis2 = 97 }
        };

        public void TooltipRender(TooltipRenderEventArgs args)
        {
            double PointYValue = Convert.ToDouble(args.Data.PointY);
            args.Text = $"<b>${PointYValue * 1000}</b>";
        }

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
        }
    }
}