using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.BarChart.BarChart9
{
    public partial class BarChart9
    {
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;

        public List<BarData> BarChartData = new List<BarData>
        {
            new BarData { XAxis = "China", YAxis = 95 },
            new BarData { XAxis = "USA", YAxis = 120 },
            new BarData { XAxis = "Japan", YAxis = 50 },
            new BarData { XAxis = "Australia", YAxis = 65 },
            new BarData { XAxis = "France", YAxis = 80 }
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

        public class BarData
        {
            public string XAxis { get; set; } = string.Empty;
            public double YAxis { get; set; }
        }
    }
}
