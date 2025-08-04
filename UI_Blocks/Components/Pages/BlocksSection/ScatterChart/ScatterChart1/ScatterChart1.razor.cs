using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.ScatterChart.ScatterChart1
{
    public partial class ScatterChart1
    {
        public SfChart? Chart;
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;
        public double XAxisLabelRotation = 0;

        public List<ProductPerformance> SlackPerformanceData = new List<ProductPerformance>
        {
            new ProductPerformance { ProductSales = 980, CSATScore = 82 },
            new ProductPerformance { ProductSales = 1080, CSATScore = 80 },
            new ProductPerformance { ProductSales = 1230, CSATScore = 81 },
            new ProductPerformance { ProductSales = 1380, CSATScore = 79.5 },
            new ProductPerformance { ProductSales = 1500, CSATScore = 84.5 }
        };

        public List<ProductPerformance> ZoomPerformanceData = new List<ProductPerformance>
        {
            new ProductPerformance { ProductSales = 940, CSATScore = 78 },
            new ProductPerformance { ProductSales = 1050, CSATScore = 77.5 },
            new ProductPerformance { ProductSales = 1170, CSATScore = 75.5 },
            new ProductPerformance { ProductSales = 1220, CSATScore = 79 },
            new ProductPerformance { ProductSales = 1290, CSATScore = 78 }
        };

        public List<ProductPerformance> TeamsPerformanceData = new List<ProductPerformance>
        {
            new ProductPerformance { ProductSales = 920, CSATScore = 74.5 },
            new ProductPerformance { ProductSales = 975, CSATScore = 77.8 },
            new ProductPerformance { ProductSales = 1008, CSATScore = 75 },
            new ProductPerformance { ProductSales = 1150, CSATScore = 77 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                XAxisLabelRotation = windowWidth < 767 ? -90 : 0;
                if (IsDropdownOpen && DropDownButton != null)
                {
                    DropDownButton.Toggle();
                }
            }
            StateHasChanged();
        }

        public class ProductPerformance
        {
            public double ProductSales { get; set; }
            public double CSATScore { get; set; }
        }
    }
}
