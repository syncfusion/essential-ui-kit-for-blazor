namespace UI_Blocks.Components.Pages.BlocksSection.Grid.Grid7
{
    public partial class Grid7
    {
        public class CustomerDetails
        {
            public string Name { get; set; } = string.Empty;
            public string Initial { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string ColorTheme { get; set; } = string.Empty;
        }
        
        public class Product
        {
            public string Name { get; set; } = string.Empty;
            public string Image { get; set; } = string.Empty;
        }

        public class SalesRep
        {
            public string Name { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
        }

        public class Transaction
        {
            public int Id { get; set; }
            public string TransactionId { get; set; } = string.Empty;
            public CustomerDetails CustomerDetails { get; set; } = new CustomerDetails();
            public DateTime Date { get; set; }
            public Product Product { get; set; } = new Product();
            public int Quantity { get; set; }
            public decimal Amount { get; set; }
            public string PaymentMethod { get; set; } = string.Empty;
            public SalesRep SalesRep { get; set; } = new SalesRep();
            public string Status { get; set; } = string.Empty;
        }

        List<Transaction> GridData = new List<Transaction>
        {
            new Transaction
            {
                Id = 1,
                TransactionId = "TRX202401",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Jane Smith",
                    Initial = "JS",
                    Email = "jane.smith@example.com",
                    ColorTheme = "Orange"
                },
                Date = new DateTime(2024, 5, 1),
                Product = new Product
                {
                    Name = "iPhone 15 Pro",
                    Image = "iphone-15-pro.png"
                },
                Quantity = 1,
                Amount = 999.99m,
                PaymentMethod = "Credit Card",
                SalesRep = new SalesRep
                {
                    Name = "Cody Fisher",
                    Avatar = "avatar-1.jpg"
                },
                Status = "Completed"
            },
            new Transaction
            {
                Id = 2,
                TransactionId = "TRX202402",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Mark Johnson",
                    Initial = "MJ",
                    Email = "mark.johnson@example.com",
                    ColorTheme = "Blue"
                },
                Date = new DateTime(2024, 10, 1),
                Product = new Product
                {
                    Name = "MacBook Air M2",
                    Image = "macbook-air-m2.png"
                },
                Quantity = 4,
                Amount = 1299.00m,
                PaymentMethod = "PayPal",
                SalesRep = new SalesRep
                {
                    Name = "Kathryn Murphy",
                    Avatar = "avatar-14.jpg"
                },
                Status = "Pending"
            },
            new Transaction
            {
                Id = 3,
                TransactionId = "TRX202403",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Emily White",
                    Initial = "EW",
                    Email = "emily.white@example.com",
                    ColorTheme = "Red"
                },
                Date = new DateTime(2024, 1, 15),
                Product = new Product
                {
                    Name = "AirPods Pro",
                    Image = "airpods-pro.png"
                },
                Quantity = 3,
                Amount = 449.98m,
                PaymentMethod = "Online Transfer",
                SalesRep = new SalesRep
                {
                    Name = "Cameron Williamson",
                    Avatar = "avatar-4.jpg"
                },
                Status = "Failed"
            },
            new Transaction
            {
                Id = 4,
                TransactionId = "TRX202404",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Tom Harris",
                    Initial = "TB",
                    Email = "tom.harris@example.com",
                    ColorTheme = "Blue"
                },
                Date = new DateTime(2024, 1, 20),
                Product = new Product
                {
                    Name = "iPad Air",
                    Image = "ipad Air.png"
                },
                Quantity = 2,
                Amount = 599.00m,
                PaymentMethod = "Online Transfer",
                SalesRep = new SalesRep
                {
                    Name = "Jenny Wilson",
                    Avatar = "avatar-13.jpg"
                },
                Status = "Processing"
            },
            new Transaction
            {
                Id = 5,
                TransactionId = "TRX202405",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Lisa Green",
                    Initial = "LG",
                    Email = "lisa.green@example.com",
                    ColorTheme = "Purple"
                },
                Date = new DateTime(2024, 1, 25),
                Product = new Product
                {
                    Name = "Apple Watch Series 8",
                    Image = "apple-watch-series-8.png"
                },
                Quantity = 1,
                Amount = 399.00m,
                PaymentMethod = "PayPal",
                SalesRep = new SalesRep
                {
                    Name = "Marvin McKinney",
                    Avatar = "avatar-2.jpg"
                },
                Status = "Completed"
            },
            new Transaction
            {
                Id = 6,
                TransactionId = "TRX202406",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Olivia Adams",
                    Initial = "OA",
                    Email = "olivia.adams@example.com",
                    ColorTheme = "Green"
                },
                Date = new DateTime(2024, 1, 2),
                Product = new Product
                {
                    Name = "iPhone 14 Pro Max",
                    Image = "iphone-14-pro-max.png"
                },
                Quantity = 2,
                Amount = 699.00m,
                PaymentMethod = "Cheque",
                SalesRep = new SalesRep
                {
                    Name = "Theresa Webb",
                    Avatar = "avatar-11.jpg"
                },
                Status = "Pending"
            },
            new Transaction
            {
                Id = 7,
                TransactionId = "TRX202407",
                CustomerDetails = new CustomerDetails
                {
                    Name = "David Clark",
                    Initial = "DC",
                    Email = "david.clark@example.com",
                    ColorTheme = "Orange"
                },
                Date = new DateTime(2024, 5, 2),
                Product = new Product
                {
                    Name = "iPad Air",
                    Image = "ipad Air.png"
                },
                Quantity = 3,
                Amount = 599.00m,
                PaymentMethod = "Online Transfer",
                SalesRep = new SalesRep
                {
                    Name = "Theresa Webb",
                    Avatar = "avatar-11.jpg"
                },
                Status = "Failed"
            },
            new Transaction
            {
                Id = 8,
                TransactionId = "TRX202408",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Rachel Lee",
                    Initial = "RL",
                    Email = "rachel.lee@example.com",
                    ColorTheme = "Purple"
                },
                Date = new DateTime(2024, 10, 2),
                Product = new Product
                {
                    Name = "AirPods Pro",
                    Image = "airpods-pro.png"
                },
                Quantity = 2,
                Amount = 449.98m,
                PaymentMethod = "PayPal",
                SalesRep = new SalesRep
                {
                    Name = "Dianne Russell",
                    Avatar = "avatar-6.jpg"
                },
                Status = "Pending"
            },
            new Transaction
            {
                Id = 9,
                TransactionId = "TRX202409",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Lucas Robinson",
                    Initial = "LR",
                    Email = "lucas.robinson@example.com",
                    ColorTheme = "Green"
                },
                Date = new DateTime(2024, 5, 1),
                Product = new Product
                {
                    Name = "iPhone 15 Plus",
                    Image = "iphone-15-plus.png"
                },
                Quantity = 1,
                Amount = 799.99m,
                PaymentMethod = "PayPal",
                SalesRep = new SalesRep
                {
                    Name = "Eleanor Pena",
                    Avatar = "avatar-9.jpg"
                },
                Status = "Completed"
            },
            new Transaction
            {
                Id = 10,
                TransactionId = "TRX202410",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Sophia Martinez",
                    Initial = "SM",
                    Email = "sophia.martinez@example.com",
                    ColorTheme = "Red"
                },
                Date = new DateTime(2024, 5, 1),
                Product = new Product
                {
                    Name = "MacBook Air M2",
                    Image = "macbook-air-m2.png"
                },
                Quantity = 1,
                Amount = 1299.00m,
                PaymentMethod = "Cheque",
                SalesRep = new SalesRep
                {
                    Name = "Courtney Henry",
                    Avatar = "avatar-3.jpg"
                },
                Status = "Failed"
            }
        };
    }
}