using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Notification.Notification6
{
    public partial class Notification6
    {
        public SfSidebar? Sidebar;
        public OverflowMode OverflowMode = OverflowMode.Extended;
        public string Width = "310px";
        public bool IsSidebarToggle = true;
        public List<NotificationItem> TicketData { get; set; } = new List<NotificationItem>();

        public List<NotificationItem> Data = new List<NotificationItem>
        {
            new NotificationItem
            {
                Id = 98724,
                Title = "Resolution SLA Escalation",
                Content = "Due on Dec 16, 2024 10:58 AM (IST) for \"Hover and selection color are inconsistent across all themes- Gantt\".",
                Avatar = "JS",
                Tag = "warning",
                Date = new DateTime(2024, 12, 16, 10, 58, 0),
                Category = "others"
            },
            new NotificationItem
            {
                Id = 98725,
                Title = "Reply Added",
                Content = "Tom Harris added a reply to \"Can you suggest providing the icon shown when we drop as child in Tree Grid?\".",
                Avatar = "MJ",
                Tag = "warning",
                Date = new DateTime(2024, 12, 16, 10, 58, 0),
                Category = "focused"
            },
            new NotificationItem
            {
                Id = 98726,
                Title = "Ticket Assigned to You",
                Content = "Oliva Adams assigned \"Can you suggest providing the icon shown when we drop as child in Tree Grid?\" to you.",
                Avatar = "DC",
                Tag = "danger",
                Date = new DateTime(2024, 12, 16, 10, 58, 0),
                Category = "others"
            },
            new NotificationItem
            {
                Id = 98727,
                Title = "Resolution SLA Escalation",
                Content = "Due on Dec 16, 2024 10:58 AM (IST) for \"Hover and selection color are inconsistent across all themes- Gantt\".",
                Avatar = "LR",
                Tag = "warning",
                Date = new DateTime(2024, 12, 16, 10, 58, 0),
                Category = "others"
            },
            new NotificationItem
            {
                Id = 98728,
                Title = "Public Note Added",
                Content = "System Automation added a public note to \"Review the Tailwind theme for File Manager team components\".",
                Avatar = "DC",
                Tag = "danger",
                Date = new DateTime(2024, 12, 16, 10, 58, 0),
                Category = "focused"
            }
        };
        public void TabCreated()
        {
            TicketData = Data.Take(5).ToList();
        }

        public async Task OnTabSelectAsync(SelectEventArgs args)
        {
            switch (args.SelectedIndex)
            {
                case 0:
                    TicketData = Data.Take(5).ToList();
                    break;
                case 1:
                    TicketData = Data.Where(list => list.Category == "focused").ToList();
                    break;
                case 2:
                    TicketData = Data.Where(list => list.Category == "others").ToList();
                    break;
                default:
                    TicketData = new List<NotificationItem>();
                    break;
            }
            await InvokeAsync(StateHasChanged);
        }
        
        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Sidebar != null)
            {
                if (windowWidth < 640)
                {
                    Width = "100%";
                    OverflowMode = OverflowMode.Popup;
                    await InvokeAsync(StateHasChanged);
                }
                else
                {
                    Width = "540px";
                    OverflowMode = OverflowMode.Extended;
                }
                await InvokeAsync(StateHasChanged);
            }
        }

        public class NotificationItem
        {
            public int Id { get; set; } 
            public string Title { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
            public string Tag { get; set; } = string.Empty;
            public DateTime Date { get; set; }
            public string Category { get; set; } = string.Empty;
        }
    }
}
