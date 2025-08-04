using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.List.List7
{
    public partial class List7
    {
        public string WidthStyle = "max-width:610px";

        public List<NotificationItem> Notifications = new List<NotificationItem>
        {
            new NotificationItem { Id = 1, Name = "Kristina", Date = "02:25 PM on 29, July 2024", Type = "sent you a photo", Image = "avatar-10.jpg" },
            new NotificationItem { Id = 2, Name = "Report created successfully", Date = "02:25 PM on 29, July 2024", Letter = "PM", Tag = "report" },
            new NotificationItem { Id = 3, Name = "Alex Johnson", Date = "02:25 PM on 29, July 2024", Type = "sent you a photo", Image = "avatar-4.jpg" },
            new NotificationItem { Id = 4, Name = "Reminder: Employee Welfare Meeting today!", Date = "02:25 PM on 29, July 2024", Letter = "HR", Tag = "remainder" },
            new NotificationItem { Id = 5, Name = "Floyd Miles", Date = "02:25 PM on 29, July 2024", Type = "sent you a photo", Image = "avatar-6.jpg" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                WidthStyle = windowWidth < 1024 ? "width:100%" : "max-width:610px";
            }
            StateHasChanged();
        }

        public class NotificationItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Date { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
            public string Image { get; set; } = string.Empty;
            public string Letter { get; set; } = string.Empty;
            public string Tag { get; set; } = string.Empty;
        }
    }
}
