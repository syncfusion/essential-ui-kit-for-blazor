namespace UI_Blocks.Components.Pages.BlocksSection.Grid.Grid3
{
    public partial class Grid3
    {
        public class CustomerDetails
        {
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
        }
        
        public class Invoice
        {
            public int Id { get; set; }
            public string InvoiceId { get; set; } = string.Empty;
            public CustomerDetails CustomerDetails { get; set; } = new CustomerDetails();
            public DateTime InvoiceDate { get; set; }
            public string ItemsPurchased { get; set; } = string.Empty;
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Tax { get; set; }
            public decimal Discount { get; set; }
            public decimal Total { get; set; }
            public string Status { get; set; } = string.Empty;
            public DateTime DueDate { get; set; }
            public DateTime? PaymentDate { get; set; }
            public string? PaymentMethod { get; set; }
        }

        List<Invoice> GridData = new List<Invoice>
        {
            new Invoice
            {
                Id = 1,
                InvoiceId = "INV202401",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Alice Johnson",
                    Email = "alice.johnson@example.com",
                    Avatar = "avatar-8.jpg"
                },
                InvoiceDate = new DateTime(2024, 2, 1),
                ItemsPurchased = "Helpdesk - Team",
                Quantity = 1,
                Price = 1000,
                Tax = 72,
                Discount = 0,
                Total = 1072,
                Status = "Paid",
                DueDate = new DateTime(2024, 5, 1),
                PaymentDate = new DateTime(2024, 5, 1),
                PaymentMethod = "Credit card"
            },
            new Invoice
            {
                Id = 2,
                InvoiceId = "INV202402",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Bob Smith",
                    Email = "bob.smith@example.com",
                    Avatar = "avatar-1.jpg"
                },
                InvoiceDate = new DateTime(2024, 10, 28),
                ItemsPurchased = "AI Content Creator",
                Quantity = 2,
                Price = 2000,
                Tax = 160,
                Discount = 10,
                Total = 2150,
                Status = "Pending",
                DueDate = new DateTime(2024, 5, 1),
                PaymentDate = null,
                PaymentMethod = null
            },
            new Invoice
            {
                Id = 3,
                InvoiceId = "INV202403",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Carol Davis",
                    Email = "carol.davis@example.com",
                    Avatar = "avatar-2.jpg"
                },
                InvoiceDate = new DateTime(2024, 1, 15),
                ItemsPurchased = "Helpdesk - Single User",
                Quantity = 2,
                Price = 1450,
                Tax = 110,
                Discount = 20,
                Total = 1600,
                Status = "Paid",
                DueDate = new DateTime(2024, 4, 15),
                PaymentDate = new DateTime(2024, 4, 15),
                PaymentMethod = "Paypal"
            },
            new Invoice
            {
                Id = 4,
                InvoiceId = "INV202404",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Dave White",
                    Email = "dave.white@example.com",
                    Avatar = "avatar-4.jpg"
                },
                InvoiceDate = new DateTime(2024, 3, 12),
                ItemsPurchased = "Miro App",
                Quantity = 1,
                Price = 4600,
                Tax = 320,
                Discount = 0,
                Total = 4920,
                Status = "Pending",
                DueDate = new DateTime(2024, 5, 3),
                PaymentDate = null,
                PaymentMethod = null
            },
            new Invoice
            {
                Id = 5,
                InvoiceId = "INV202405",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Eve Wilson",
                    Email = "eve.wilson@example.com",
                    Avatar = "avatar-9.jpg"
                },
                InvoiceDate = new DateTime(2024, 1, 25),
                ItemsPurchased = "Canva",
                Quantity = 1,
                Price = 820,
                Tax = 30,
                Discount = 0,
                Total = 850,
                Status = "Paid",
                DueDate = new DateTime(2024, 1, 30),
                PaymentDate = new DateTime(2024, 1, 30),
                PaymentMethod = "Cash"
            },
            new Invoice
            {
                Id = 6,
                InvoiceId = "INV202406",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Frank Harris",
                    Email = "frank.harris@example.com",
                    Avatar = "avatar-6.jpg"
                },
                InvoiceDate = new DateTime(2024, 5, 8),
                ItemsPurchased = "Remove BG App",
                Quantity = 3,
                Price = 220,
                Tax = 25,
                Discount = 0,
                Total = 245,
                Status = "Pending",
                DueDate = new DateTime(2024, 6, 8),
                PaymentDate = null,
                PaymentMethod = null
            },
            new Invoice
            {
                Id = 7,
                InvoiceId = "INV202407",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Grace Brown",
                    Email = "grace.brown@example.com",
                    Avatar = "avatar-10.jpg"
                },
                InvoiceDate = new DateTime(2024, 1, 8),
                ItemsPurchased = "Affinity Designer",
                Quantity = 2,
                Price = 235,
                Tax = 25,
                Discount = 0,
                Total = 260,
                Status = "Pending",
                DueDate = new DateTime(2024, 5, 1),
                PaymentDate = null,
                PaymentMethod = null
            },
            new Invoice
            {
                Id = 8,
                InvoiceId = "INV202408",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Henry King",
                    Email = "henry.king@example.com",
                    Avatar = "avatar-3.jpg"
                },
                InvoiceDate = new DateTime(2024, 4, 15),
                ItemsPurchased = "Corel Draw",
                Quantity = 2,
                Price = 2500,
                Tax = 200,
                Discount = 0,
                Total = 2700,
                Status = "Pending",
                DueDate = new DateTime(2024, 6, 15),
                PaymentDate = null,
                PaymentMethod = null
            },
            new Invoice
            {
                Id = 9,
                InvoiceId = "INV202409",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Ivy Anderson",
                    Email = "ivy.anderson@example.com",
                    Avatar = "avatar-14.jpg"
                },
                InvoiceDate = new DateTime(2024, 7, 21),
                ItemsPurchased = "Affinity Designer",
                Quantity = 1,
                Price = 3200,
                Tax = 210,
                Discount = 30,
                Total = 3380,
                Status = "Paid",
                DueDate = new DateTime(2024, 9, 21),
                PaymentDate = new DateTime(2024, 9, 20),
                PaymentMethod = "Credit card"
            },
            new Invoice
            {
                Id = 10,
                InvoiceId = "INV202410",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Jack Scott",
                    Email = "jack.scott@example.com",
                    Avatar = "avatar-6.jpg"
                },
                InvoiceDate = new DateTime(2024, 2, 25),
                ItemsPurchased = "Microsoft 365",
                Quantity = 1,
                Price = 1000,
                Tax = 72,
                Discount = 0,
                Total = 1072,
                Status = "Paid",
                DueDate = new DateTime(2024, 3, 20),
                PaymentDate = new DateTime(2024, 3, 20),
                PaymentMethod = "Cash"
            }
        };
    }
}