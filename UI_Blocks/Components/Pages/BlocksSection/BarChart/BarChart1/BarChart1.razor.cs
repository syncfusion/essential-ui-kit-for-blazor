using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;

namespace UI_Blocks.Components.Pages.BlocksSection.BarChart.BarChart1
{
    public partial class BarChart1
    {
        public SfChart? Chart;
        public double XAxisLabelRotation = -45;

        public List<BarData> BarChartData = new List<BarData>
        {
            new BarData { XAxis = "Accounting", YAxis = 600 },
            new BarData { XAxis = "Implementation", YAxis = 510},
            new BarData { XAxis = "Deployment", YAxis = 400 },
            new BarData { XAxis = "Marketing", YAxis = 420 },
            new BarData { XAxis = "Customer Support", YAxis = 300 },
            new BarData { XAxis = "Project Operations", YAxis = 260 },
            new BarData { XAxis = "Logistics", YAxis = 180 },
            new BarData { XAxis = "Finance", YAxis = 150 },
            new BarData { XAxis = "Development", YAxis = 100 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                XAxisLabelRotation = windowWidth < 767 ? -90 : -45;
            }
            StateHasChanged();
        }

        public class BarData
        {
            public string XAxis { get; set; } = string.Empty;
            public double YAxis { get; set; }
        }
    }
}
