using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.DistributionChart.DistributionChart2
{
    public partial class DistributionChart2
    {
        public SfAccumulationChart? Chart;
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;
        public string Height = "230px";
        public string LegendWidth = "200px";
        public string LegendHeight = "180px";

        public List<DoughnutData> SegmentData = new List<DoughnutData>
        {
            new DoughnutData { Id = 1, CategoryName = "Product", SpendingShare = 30, DisplayLabel = "30%" },
            new DoughnutData { Id = 2, CategoryName = "Restaurant and Bars", SpendingShare = 23, DisplayLabel = "23%" },
            new DoughnutData { Id = 3, CategoryName = "Internet and Media", SpendingShare = 18, DisplayLabel = "18%" },
            new DoughnutData { Id = 4, CategoryName = "Pay for workspace", SpendingShare = 17, DisplayLabel = "17%" },
            new DoughnutData { Id = 5, CategoryName = "Other", SpendingShare = 12, DisplayLabel = "12%" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                Height = windowWidth < 767 ? "340px" : "230px";
                LegendHeight = windowWidth < 767 ? "100px" : "180px";
                LegendWidth = windowWidth < 767 ? "300px" : "200px";
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
            public string CategoryName { get; set; } = string.Empty;
            public int SpendingShare { get; set; }
            public string DisplayLabel { get; set; } = string.Empty;
        }
    }
}
