namespace UI_Blocks.Components.Pages.BlocksSection.Grid.Grid6
{
    public partial class Grid6
    {
        public List<Transaction> GridData = new List<Transaction>
        {
            new Transaction
            {
                Id = 1,
                TransactionId = "TRX202401",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Jane Smith",
                    Email = "jane.smith@example.com",
                    Avatar = "avatar-8.jpg"
                },
                InvoiceNumber = "INV202401",
                Description = "Payment for invoice",
                Amount = 1300,
                Date = new DateTime(2024, 5, 17),
                PaymentMethod = "Credit Card",
                Status = "Completed"
            },
            new Transaction
            {
                Id = 2,
                TransactionId = "TRX202402",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Mark Johnson",
                    Email = "mark.johnson@example.com",
                    Avatar = "avatar-1.jpg"
                },
                InvoiceNumber = "INV202402",
                Description = "Subscription renewal",
                Amount = 450,
                Date = new DateTime(2024, 11, 12),
                PaymentMethod = "PayPal",
                Status = "Pending"
            },
            new Transaction
            {
                Id = 3,
                TransactionId = "TRX202403",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Emily White",
                    Email = "emily.white@example.com",
                    Avatar = "avatar-9.jpg"
                },
                InvoiceNumber = "INV202403",
                Description = "Consulting services",
                Amount = 2800,
                Date = new DateTime(2024, 1, 15),
                PaymentMethod = "Online Transfer",
                Status = "Failed"
            },
            new Transaction
            {
                Id = 4,
                TransactionId = "TRX202404",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Tom Harris",
                    Email = "tom.harris@example.com",
                    Avatar = "avatar-4.jpg"
                },
                InvoiceNumber = "INV202404",
                Description = "Equipment purchase",
                Amount = 2750,
                Date = new DateTime(2024, 7, 18),
                PaymentMethod = "Online Transfer",
                Status = "Completed"
            },
            new Transaction
            {
                Id = 5,
                TransactionId = "TRX202405",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Lisa Green",
                    Email = "lisa.green@example.com",
                    Avatar = "avatar-10.jpg"
                },
                InvoiceNumber = "INV202405",
                Description = "Event sponsorship",
                Amount = 3870,
                Date = new DateTime(2024, 1, 23),
                PaymentMethod = "PayPal",
                Status = "Cleared"
            },
            new Transaction
            {
                Id = 6,
                TransactionId = "TRX202406",
                CustomerDetails = new CustomerDetails
                {
                    Name = "David Clark",
                    Email = "david.clark@example.com",
                    Avatar = "avatar-5.jpg"
                },
                InvoiceNumber = "INV202406",
                Description = "Online course registration",
                Amount = 580,
                Date = new DateTime(2024, 3, 12),
                PaymentMethod = "Cheque",
                Status = "Failed"
            },
            new Transaction
            {
                Id = 7,
                TransactionId = "TRX202407",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Rachel Lee",
                    Email = "rachel.lee@example.com",
                    Avatar = "avatar-6.jpg"
                },
                InvoiceNumber = "INV202407",
                Description = "Software license renewal",
                Amount = 1250,
                Date = new DateTime(2024, 9, 8),
                PaymentMethod = "Credit Card",
                Status = "Completed"
            },
            new Transaction
            {
                Id = 8,
                TransactionId = "TRX202408",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Olivia Adams",
                    Email = "olivia.adams@example.com",
                    Avatar = "avatar-10.jpg"
                },
                InvoiceNumber = "INV202408",
                Description = "Consulting services",
                Amount = 648,
                Date = new DateTime(2024, 10, 12),
                PaymentMethod = "PayPal",
                Status = "Failed"
            },
            new Transaction
            {
                Id = 9,
                TransactionId = "TRX202409",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Lucas Brown",
                    Email = "lucas.brown@example.com",
                    Avatar = "avatar-11.jpg"
                },
                InvoiceNumber = "INV202409",
                Description = "Membership fee",
                Amount = 792,
                Date = new DateTime(2024, 6, 11),
                PaymentMethod = "Cheque",
                Status = "Pending"
            },
            new Transaction
            {
                Id = 10,
                TransactionId = "TRX202410",
                CustomerDetails = new CustomerDetails
                {
                    Name = "Sophia Martinez",
                    Email = "sophia.martinez@example.com",
                    Avatar = "avatar-14.jpg"
                },
                InvoiceNumber = "INV202410",
                Description = "Training workshop fee",
                Amount = 840,
                Date = new DateTime(2024, 2, 17),
                PaymentMethod = "Cheque",
                Status = "Completed"
            }
        };

        public class CustomerDetails
        {
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
        }

        public class Transaction
        {
            public int Id { get; set; }
            public string TransactionId { get; set; } = string.Empty;
            public CustomerDetails CustomerDetails { get; set; } = new CustomerDetails();
            public string InvoiceNumber { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public decimal Amount { get; set; }
            public DateTime Date { get; set; }
            public string PaymentMethod { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;
        }
    }
}