using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.Modals.Modals6
{
    public partial class Modals6
    {
        public SfDialog? Dialog;
        public string DialogHeight = "auto";

        public List<TransactionData> Data = new List<TransactionData>
        {
            new TransactionData
            {
                Id = 1,
                TransactionId = "TRX202401",
                CustomerDetails = new Customer
                {
                    Name = "Jane Smith",
                    Email = "jane.smith@example.com",
                    Avatar = "avatar-8.jpg"
                },
                InvoiceNumber = "INV202401",
                Description = "Payment for invoice"
            },
            new TransactionData
            {
                Id = 2,
                TransactionId = "TRX202402",
                CustomerDetails = new Customer
                {
                    Name = "Mark Johnson",
                    Email = "mark.johnson@example.com",
                    Avatar = "avatar-1.jpg"
                },
                InvoiceNumber = "INV202402",
                Description = "Subscription renewal"
            },
            new TransactionData
            {
                Id = 3,
                TransactionId = "TRX202403",
                CustomerDetails = new Customer
                {
                    Name = "Emily White",
                    Email = "emily.white@example.com",
                    Avatar = "avatar-9.jpg"
                },
                InvoiceNumber = "INV202403",
                Description = "Consulting services"
            },
            new TransactionData
            {
                Id = 4,
                TransactionId = "TRX202404",
                CustomerDetails = new Customer
                {
                    Name = "Tom Harris",
                    Email = "tom.harris@example.com",
                    Avatar = "avatar-4.jpg"
                },
                InvoiceNumber = "INV202404",
                Description = "Equipment purchase"
            },
            new TransactionData
            {
                Id = 5,
                TransactionId = "TRX202405",
                CustomerDetails = new Customer
                {
                    Name = "Lisa Green",
                    Email = "lisa.green@example.com",
                    Avatar = "avatar-10.jpg"
                },
                InvoiceNumber = "INV202405",
                Description = "Event sponsorship"
            },
            new TransactionData
            {
                Id = 6,
                TransactionId = "TRX202406",
                CustomerDetails = new Customer
                {
                    Name = "David Clark",
                    Email = "david.clark@example.com",
                    Avatar = "avatar-5.jpg"
                },
                InvoiceNumber = "INV202406",
                Description = "Online course registration"
            }
        };

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                DialogHeight = windowWidth <= 640 ? "100%" : "auto";
                await Dialog.RefreshPositionAsync();
            }
            await InvokeAsync(StateHasChanged);
        }

        public class TransactionData
        {
            public int Id { get; set; }
            public string TransactionId { get; set; } = string.Empty;
            public Customer CustomerDetails { get; set; } = new Customer();
            public string InvoiceNumber { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
        }

        public class Customer
        {
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
        }
    }
}