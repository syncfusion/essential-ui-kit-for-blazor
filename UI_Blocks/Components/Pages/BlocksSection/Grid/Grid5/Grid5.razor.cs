namespace UI_Blocks.Components.Pages.BlocksSection.Grid.Grid5
{
    public partial class Grid5
    {
        public List<Asset> GridData = new List<Asset>
        {
            new Asset
            {
                Id = 1,
                AssetId = "AS001",
                Hardware = "Lenovo Yoga",
                Category = "Laptop",
                SerialNum = "CB27932009",
                Invoice = "INV-2878",
                Assigned = "John Doe",
                PurchaseDate = new DateTime(2018, 4, 10),
                WarrantyEndDate = new DateTime(2021, 5, 1),
                Status = "Assigned"
            },
            new Asset
            {
                Id = 2,
                AssetId = "AS002",
                Hardware = "Acer Aspire",
                Category = "Miscellaneous",
                SerialNum = "CB27932032",
                Invoice = "INV-5436",
                Assigned = null,
                PurchaseDate = new DateTime(2018, 2, 12),
                WarrantyEndDate = new DateTime(2023, 3, 1),
                Status = "In-repair"
            },
            new Asset
            {
                Id = 3,
                AssetId = "AS003",
                Hardware = "Apple MacBook",
                Category = "Laptop",
                SerialNum = "CB27932054",
                Invoice = "INV-2345",
                Assigned = null,
                PurchaseDate = new DateTime(2018, 4, 10),
                WarrantyEndDate = new DateTime(2021, 4, 3),
                Status = "In-repair"
            },
            new Asset
            {
                Id = 4,
                AssetId = "AS004",
                Hardware = "Lenovo Thinkpad",
                Category = "Laptop",
                SerialNum = "CB27932044",
                Invoice = "INV-8753",
                Assigned = null,
                PurchaseDate = new DateTime(2018, 3, 9),
                WarrantyEndDate = new DateTime(2021, 5, 12),
                Status = "Pending"
            },
            new Asset
            {
                Id = 5,
                AssetId = "AS005",
                Hardware = "Dell Inspiron",
                Category = "Laptop",
                SerialNum = "CB27932065",
                Invoice = "INV-3735",
                Assigned = "David Anto",
                PurchaseDate = new DateTime(2018, 1, 10),
                WarrantyEndDate = new DateTime(2021, 4, 1),
                Status = "Assigned"
            },
            new Asset
            {
                Id = 6,
                AssetId = "AS006",
                Hardware = "HP Pavilion",
                Category = "Laptop",
                SerialNum = "CB27932345",
                Invoice = "INV-6643",
                Assigned = "Mary Saveloy",
                PurchaseDate = new DateTime(2018, 4, 10),
                WarrantyEndDate = new DateTime(2021, 9, 1),
                Status = "Assigned"
            },
            new Asset
            {
                Id = 7,
                AssetId = "AS007",
                Hardware = "Asus ZenBook",
                Category = "Laptop",
                SerialNum = "CB27932088",
                Invoice = "INV-8426",
                Assigned = null,
                PurchaseDate = new DateTime(2018, 6, 16),
                WarrantyEndDate = new DateTime(2021, 5, 21),
                Status = "Pending"
            },
            new Asset
            {
                Id = 8,
                AssetId = "AS008",
                Hardware = "HP EliteBook",
                Category = "Laptop",
                SerialNum = "CB27932011",
                Invoice = "INV-2351",
                Assigned = null,
                PurchaseDate = new DateTime(2018, 2, 12),
                WarrantyEndDate = new DateTime(2022, 10, 2),
                Status = "Ordered"
            },
            new Asset
            {
                Id = 9,
                AssetId = "AS009",
                Hardware = "Apple MacBook Air",
                Category = "Laptop",
                SerialNum = "CB27932005",
                Invoice = "INV-5553",
                Assigned = null,
                PurchaseDate = new DateTime(2018, 3, 12),
                WarrantyEndDate = new DateTime(2023, 3, 1),
                Status = "Pending"
            },
            new Asset
            {
                Id = 10,
                AssetId = "AS010",
                Hardware = "Apple iPad Air",
                Category = "Tablet",
                SerialNum = "CB27932007",
                Invoice = "INV-1212",
                Assigned = null,
                PurchaseDate = new DateTime(2018, 4, 10),
                WarrantyEndDate = new DateTime(2021, 6, 1),
                Status = "Pending"
            }
        };

        public class Asset
        {
            public int Id { get; set; }
            public string AssetId { get; set; } = string.Empty;
            public string Hardware { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
            public string SerialNum { get; set; } = string.Empty;
            public string Invoice { get; set; } = string.Empty;
            public string? Assigned { get; set; } = string.Empty;
            public DateTime PurchaseDate { get; set; }
            public DateTime? WarrantyEndDate { get; set; }
            public string Status { get; set; } = string.Empty;
        }
    }
}