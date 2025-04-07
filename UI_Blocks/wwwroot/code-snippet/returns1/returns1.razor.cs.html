using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Returns.Returns1
{
    public partial class Returns1
    {
        private SfStepper? Stepper;
        private string StepperStyle = "";
        private StepperOrientation StepperOrientation = StepperOrientation.Horizontal;
        private StepperLabelPosition LabelPos = StepperLabelPosition.Bottom;

        private List<ProductData> Data = new()
        {
            new() { Product = new Product { ProductName = "Apple iPhone 15 Pro Max (256 GB) - Blue Titanium", ProductImage = "apple-iphone-15" }, OrderNumber = "#49463", ReturnTerm = new DateTime(2017, 8, 15) },
            new() { Product = new Product { ProductName = "Apple MacBook Air 2022 (13.6-inch, M2, 8GB, 256GB, macOS, Midnight)", ProductImage = "apple-macbook-air-2022" }, OrderNumber = "#40938", ReturnTerm = new DateTime(2022, 10, 28) },
            new() { Product = new Product { ProductName = "Apple AirPods Pro (2nd Generation - USB-C) TWS Earbuds with Active Noise", ProductImage = "apple-airpods-pro" }, OrderNumber = "#50929", ReturnTerm = new DateTime(2020, 6, 12) },
            new() { Product = new Product { ProductName = "Apple AirPods (2nd Generation) with Charging Case", ProductImage = "apple-airpods" }, OrderNumber = "#50924", ReturnTerm = new DateTime(2016, 9, 18) },
            new() { Product = new Product { ProductName = "Apple Watch SE GPS with Starlight Sport Band - S/M (40mm Display, Starlight Aluminium Case)", ProductImage = "apple-watch" }, OrderNumber = "#19340", ReturnTerm = new DateTime(2016, 5, 7) },
            new() { Product = new Product { ProductName = "Apple MacBook Air 2024 (13.6-inch, M3, 8GB, 256GB, macOS, Space Grey)", ProductImage = "apple-macbook-air-2024" }, OrderNumber = "#36101", ReturnTerm = new DateTime(2024, 8, 16) }
        };

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                bool isVertical = windowWidth < 640;
                StepperOrientation = isVertical ? StepperOrientation.Vertical : StepperOrientation.Horizontal;
                StepperStyle = isVertical ? "min-height:286px" : "";
                LabelPos = isVertical ? StepperLabelPosition.End : StepperLabelPosition.Bottom;

                if (Stepper != null)
                {
                    await Stepper.RefreshProgressbarAsync();
                }

                StateHasChanged();
            }
        }

        private class ProductData
        {
            public Product? Product { get; set; }
            public string? OrderNumber { get; set; }
            public DateTime ReturnTerm { get; set; }
        }

        private class Product
        {
            public string? ProductName { get; set; }
            public string? ProductImage { get; set; }
        }
    }
}
