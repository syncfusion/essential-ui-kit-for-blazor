using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.Notification.Notification7
{
    public partial class Notification7
    {
        private bool IsDropdownVisible { get; set; } = false;

        public SfSidebar? Sidebar;
        public SfDropDownButton? Dropdown;
        public string Width = "418px";

        public List<NotificationItem> TransactionData { get; set; } = new List<NotificationItem>
        {
            new NotificationItem
            {
                Id = 1,
                Name = "Gift Card Sale Confirmation",
                Content = "Your sale UK Steam card worth $200 has been successfully completed, funds are now in your wallet.",
                Avatar = "avatar-3.jpg",
                Date = new DateTime(2024, 2, 10, 9, 32, 12)
            },
            new NotificationItem
            {
                Id = 2,
                Name = "BTC Transaction Confirmation",
                Content = "Your BTC transaction of 0.00008 BTC has been successfully processed, funds are now in your wallet.",
                Avatar = "avatar-4.jpg",
                Date = new DateTime(2024, 2, 10, 8, 16, 12)
            },
            new NotificationItem
            {
                Id = 3,
                Name = "Failed Transactions",
                Content = "We were unable to process your PayPal payment of N600. Please try again.",
                Avatar = "avatar-5.jpg",
                Date = new DateTime(2024, 2, 10, 8, 0, 12)
            },
            new NotificationItem
            {
                Id = 4,
                Name = "BTC Transaction Confirmation",
                Content = "Your BTC transaction of 0.00008 BTC has been successfully processed, funds are now in your wallet.",
                Avatar = "avatar-14.jpg",
                Date = new DateTime(2024, 2, 10, 7, 46, 12)
            }
        };

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Sidebar != null)
            {
                Width = windowWidth < 640 ? "360px" : "420px";
                if (IsDropdownVisible && Dropdown != null)
                {
                    Dropdown.Toggle();
                }
                StateHasChanged();
            }
        }

        public class NotificationItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
            public DateTime Date { get; set; }
        }
    }
}
