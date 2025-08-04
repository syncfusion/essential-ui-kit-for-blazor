using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.DistributionChart.DistributionChart3
{
    public partial class DistributionChart3
    {
        public SfAccumulationChart? Chart;
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;
        public string Height = "300px";

        public List<DoughnutData> DoughnutChartData = new List<DoughnutData>
        {
            new DoughnutData { Id = 1, XAxis = "Product", YAxis = 48 },
            new DoughnutData { Id = 2, XAxis = "Restaurant and Bars", YAxis = 13 },
            new DoughnutData { Id = 3, XAxis = "Internet and Media", YAxis = 12 },
            new DoughnutData { Id = 4, XAxis = "Pay for workspace", YAxis = 27 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                Height = windowWidth < 767 ? "240px" : "300px";
                if (IsDropdownOpen && DropDownButton != null)
                {
                    DropDownButton.Toggle();
                }
            }
            StateHasChanged();
        }

        public class DoughnutData
        {
            public int Id { get; set; }
            public string XAxis { get; set; } = string.Empty;
            public int YAxis { get; set; }
        }
    }
}
