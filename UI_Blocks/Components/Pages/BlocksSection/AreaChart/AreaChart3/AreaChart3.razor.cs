using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;

namespace UI_Blocks.Components.Pages.BlocksSection.AreaChart.AreaChart3
{
    public partial class AreaChart3
    {
        public SfChart? Chart;
        public double XAxisLabelRotation = 0;

        public List<AreaData> AreaChartData = new List<AreaData>
        {
            new AreaData { XAxis = "Jan", YAxis1 = 13000, YAxis2 = 8000, YAxis3 = 6000 },
            new AreaData { XAxis = "Feb", YAxis1 = 14000, YAxis2 = 9000, YAxis3 = 5000 },
            new AreaData { XAxis = "Mar", YAxis1 = 15000, YAxis2 = 10000, YAxis3 = 2000 },
            new AreaData { XAxis = "Apr", YAxis1 = 12000, YAxis2 = 7000, YAxis3 = 5000 },
            new AreaData { XAxis = "May", YAxis1 = 16000, YAxis2 = 11000, YAxis3 = 5000 },
            new AreaData { XAxis = "Jun", YAxis1 = 16000, YAxis2 = 11000, YAxis3 = 13000 },
            new AreaData { XAxis = "Jul", YAxis1 = 19000, YAxis2 = 14000, YAxis3 = 13000 },
            new AreaData { XAxis = "Aug", YAxis1 = 19000, YAxis2 = 14000, YAxis3 = 7000 },
            new AreaData { XAxis = "Sep", YAxis1 = 12000, YAxis2 = 7000, YAxis3 = 7000 },
            new AreaData { XAxis = "Oct", YAxis1 = 10000, YAxis2 = 7000, YAxis3 = 5000 },
            new AreaData { XAxis = "Nov", YAxis1 = 12000, YAxis2 = 5000, YAxis3 = 7000 },
            new AreaData { XAxis = "Dec", YAxis1 = 12500, YAxis2 = 7500, YAxis3 = 6500 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" & Chart != null)
            {
                XAxisLabelRotation = windowWidth < 767 ? -90 : 0;
            }
            StateHasChanged();
        }

        public class AreaData
        {
            public string XAxis { get; set; } = string.Empty;
            public double YAxis1 { get; set; }
            public double YAxis2 { get; set; }
            public double YAxis3 { get; set; }
        }
    }
}
