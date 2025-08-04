using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.DistributionChart.DistributionChart4
{
    public partial class DistributionChart4
    {
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;
        public bool ShowDataLabels { get; set; } = true;
        public bool ShowToolTip { get; set; } = false;

        public List<PieData> PieChartData = new List<PieData>
        {
            new PieData { XAxis = "Chrome", YAxis = 67.48, Text = "Chrome (67.48%)", Fill = "url(#DiagonalLine)" },
            new PieData { XAxis = "Safari", YAxis = 18.2, Text = "Safari (18.2%)", Fill = "url(#Grid)" },
            new PieData { XAxis = "Edge", YAxis = 4.84, Text = "Edge (4.84%)", Fill = "url(#VerticalStripe)" },
            new PieData { XAxis = "Firefox", YAxis = 2.60, Text = "Firefox (2.6%)", Fill = "url(#VerticalDash)" },
            new PieData { XAxis = "Opera", YAxis = 2.0, Text = "Opera (2%)", Fill = "url(#HorizontalStripe)" },
            new PieData { XAxis = "Others", YAxis = 4.88, Text = "Others (4.88%)", Fill = "url(#Dots)" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                ShowDataLabels = windowWidth > 570; 
                ShowToolTip = windowWidth <= 640; 
                if (IsDropdownOpen && DropDownButton != null)
                {
                    DropDownButton.Toggle();
                }
            }
            StateHasChanged();
        }

        public class PieData
        {
            public string XAxis { get; set; } = string.Empty;
            public double YAxis { get; set; }
            public string Fill { get; set; } = string.Empty;
            public string Text { get; set; } = string.Empty;
        }
    }
}