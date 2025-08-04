using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.AreaChart.AreaChart5
{
    public partial class AreaChart5
    {
        public SfChart? Chart;
        public SfDropDownButton? YearDropDown;
        public bool IsYearDropdownOpen = false;
        public double XAxisLabelRotation = 0;

        public List<ProductSalesData> AreaChartData = new List<ProductSalesData>
        {
            new ProductSalesData { Month = "Jan", Nike = 27, IPhone = 15, PS5 = 6 },
            new ProductSalesData { Month = "Feb", Nike = 30, IPhone = 20, PS5 = 10 },
            new ProductSalesData { Month = "Mar", Nike = 32, IPhone = 21, PS5 = 9 },
            new ProductSalesData { Month = "Apr", Nike = 39, IPhone = 14, PS5 = 10 },
            new ProductSalesData { Month = "May", Nike = 36, IPhone = 13, PS5 = 9 },
            new ProductSalesData { Month = "Jun", Nike = 33, IPhone = 14, PS5 = 9 },
            new ProductSalesData { Month = "Jul", Nike = 31, IPhone = 17, PS5 = 4 },
            new ProductSalesData { Month = "Aug", Nike = 32, IPhone = 17, PS5 = 3 },
            new ProductSalesData { Month = "Sep", Nike = 33, IPhone = 14, PS5 = 4 },
            new ProductSalesData { Month = "Oct", Nike = 30, IPhone = 13, PS5 = 6 },
            new ProductSalesData { Month = "Nov", Nike = 29, IPhone = 18, PS5 = 4 },
            new ProductSalesData { Month = "Dec", Nike = 35, IPhone = 20, PS5 = 3 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                XAxisLabelRotation = windowWidth < 767 ? -90 : 0;
                if (IsYearDropdownOpen && YearDropDown != null)
                {
                    YearDropDown.Toggle();
                }
            }
            StateHasChanged();
        }

        public class ProductSalesData
        {
            public string Month { get; set; } = string.Empty;
            public double Nike { get; set; }
            public double IPhone { get; set; }
            public double PS5 { get; set; }
        }
    }
}
