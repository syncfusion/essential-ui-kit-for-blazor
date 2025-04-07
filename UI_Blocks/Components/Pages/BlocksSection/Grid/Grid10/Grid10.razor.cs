namespace UI_Blocks.Components.Pages.BlocksSection.Grid.Grid10
{
    public partial class Grid10
    {
        public class SalesRep
        {
            public string Name { get; set; } = string.Empty;
            public string Initial { get; set; } = string.Empty;
            public string ColorTheme { get; set; } = string.Empty;
        }

        public class ProductSales
        {
            public int Id { get; set; }
            public string Product { get; set; } = string.Empty;
            public string ProductImage { get; set; } = string.Empty;
            public int UnitSold { get; set; }
            public int TotalRevenue { get; set; }
            public decimal AverageSellingPrice { get; set; }
            public string PercentOfTotalSales { get; set; } = string.Empty;
            public SalesRep TotalSalesRep { get; set; } = new SalesRep();
            public string ReturnRate { get; set; } = string.Empty;
        }

        List<ProductSales> GridData = new List<ProductSales>
        {
            new ProductSales
            {
                Id = 1,
                Product = "iPhone 13",
                ProductImage = "iphone-3.png",
                UnitSold = 15000,
                TotalRevenue = 11250000,
                AverageSellingPrice = 750m,
                PercentOfTotalSales = "18%",
                TotalSalesRep = new SalesRep
                {
                    Name = "John Smith",
                    Initial = "JS",
                    ColorTheme = "Orange"
                },
                ReturnRate = "2.5%"
            },
            new ProductSales
            {
                Id = 2,
                Product = "MacBook Air",
                ProductImage = "ma-book-air.png",
                UnitSold = 8000,
                TotalRevenue = 8800000,
                AverageSellingPrice = 1100m,
                PercentOfTotalSales = "14%",
                TotalSalesRep = new SalesRep
                {
                    Name = "Emily Brown",
                    Initial = "EB",
                    ColorTheme = "Green"
                },
                ReturnRate = "1.8%"
            },
            new ProductSales
            {
                Id = 3,
                Product = "AirPods Pro",
                ProductImage = "airpods-pro.png",
                UnitSold = 25000,
                TotalRevenue = 6250000,
                AverageSellingPrice = 250m,
                PercentOfTotalSales = "10%",
                TotalSalesRep = new SalesRep
                {
                    Name = "Michael Davis",
                    Initial = "MD",
                    ColorTheme = "Purple"
                },
                ReturnRate = "3.2%"
            },
            new ProductSales
            {
                Id = 4,
                Product = "iPad Air",
                ProductImage = "ipad Air.png",
                UnitSold = 12000,
                TotalRevenue = 7200000,
                AverageSellingPrice = 600m,
                PercentOfTotalSales = "11%",
                TotalSalesRep = new SalesRep
                {
                    Name = "Sarah Wilson",
                    Initial = "SW",
                    ColorTheme = "Orange"
                },
                ReturnRate = "2%"
            },
            new ProductSales
            {
                Id = 5,
                Product = "Apple Watch Series 7",
                ProductImage = "apple-watch-series-7.png",
                UnitSold = 10000,
                TotalRevenue = 4000000,
                AverageSellingPrice = 400m,
                PercentOfTotalSales = "6%",
                TotalSalesRep = new SalesRep
                {
                    Name = "David Thompson",
                    Initial = "DT",
                    ColorTheme = "Orange"
                },
                ReturnRate = "2.8%"
            },
            new ProductSales
            {
                Id = 6,
                Product = "iMac 24\"",
                ProductImage = "imac-24.png",
                UnitSold = 5000,
                TotalRevenue = 7500000,
                AverageSellingPrice = 1500m,
                PercentOfTotalSales = "12%",
                TotalSalesRep = new SalesRep
                {
                    Name = "Lisa Martinez",
                    Initial = "LM",
                    ColorTheme = "Red"
                },
                ReturnRate = "1.5%"
            },
            new ProductSales
            {
                Id = 7,
                Product = "Mac Mini",
                ProductImage = "mac-mini.png",
                UnitSold = 7000,
                TotalRevenue = 4900000,
                AverageSellingPrice = 700m,
                PercentOfTotalSales = "8%",
                TotalSalesRep = new SalesRep
                {
                    Name = "Robert Johnson",
                    Initial = "RJ",
                    ColorTheme = "Green"
                },
                ReturnRate = "1.2%"
            },
            new ProductSales
            {
                Id = 8,
                Product = "Air Tag",
                ProductImage = "air-tag.png",
                UnitSold = 50000,
                TotalRevenue = 1500000,
                AverageSellingPrice = 30m,
                PercentOfTotalSales = "2%",
                TotalSalesRep = new SalesRep
                {
                    Name = "Jennifer Lee",
                    Initial = "JL",
                    ColorTheme = "Blue"
                },
                ReturnRate = "0.8%"
            },
            new ProductSales
            {
                Id = 9,
                Product = "HomePod Mini",
                ProductImage = "homepad-mini.png",
                UnitSold = 15000,
                TotalRevenue = 1500000,
                AverageSellingPrice = 100m,
                PercentOfTotalSales = "2%",
                TotalSalesRep = new SalesRep
                {
                    Name = "William Turner",
                    Initial = "WT",
                    ColorTheme = "Purple"
                },
                ReturnRate = "1.2%"
            },
            new ProductSales
            {
                Id = 10,
                Product = "Apple TV 4K",
                ProductImage = "apple-tv-4k.png",
                UnitSold = 8000,
                TotalRevenue = 1440000,
                AverageSellingPrice = 180m,
                PercentOfTotalSales = "2%",
                TotalSalesRep = new SalesRep
                {
                    Name = "Emma Watson",
                    Initial = "EW",
                    ColorTheme = "Purple"
                },
                ReturnRate = "0.8%"
            }
        };
    }
}