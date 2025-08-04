using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar9
{
    public partial class Sidebar9
    {
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;

        public List<IconMenuItem> NavigationMenu = new List<IconMenuItem>
        {
            new IconMenuItem { Id = 1, FontIcon = "e-home" },
            new IconMenuItem { Id = 2, FontIcon = "e-user" },
            new IconMenuItem { Id = 3, FontIcon = "e-bookmark" },
            new IconMenuItem { Id = 4, FontIcon = "e-chart" },
            new IconMenuItem { Id = 5, FontIcon = "e-clock" }
        };

        public List<InboxMenuItem> InboxMenu = new List<InboxMenuItem>
        {
            new InboxMenuItem { Id = 1, Field = "My Inbox", FontIcon = "e-folder" },
            new InboxMenuItem { Id = 2, Field = "Chats", FontIcon = "sf-icon-user-chat" },
            new InboxMenuItem { Id = 3, Field = "Assigned to me", FontIcon = "e-user" },
            new InboxMenuItem { Id = 4, Field = "Scheduled", FontIcon = "e-day" },
            new InboxMenuItem { Id = 5, Field = "Archived", FontIcon = "sf-icon-arrow-broken-square-down" },
            new InboxMenuItem { Id = 6, Field = "Closed", FontIcon = "e-circle-close" }
        };

        public List<SupportMenuItem> SupportMenu = new List<SupportMenuItem>
        {
            new SupportMenuItem { Id = 1, Field = "Docs" },
            new SupportMenuItem { Id = 2, Field = "Help"}
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                IsBackdropVisible = windowWidth <= 640;
            }
            StateHasChanged();
        }

        public class IconMenuItem
        {
            public int Id { get; set; }
            public string FontIcon { get; set; } = string.Empty;
        }

        public class InboxMenuItem
        {
            public int Id { get; set; }
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
        }

        public class SupportMenuItem
        {
            public int Id { get; set; }
            public string Field { get; set; } = string.Empty;
        }
    }
}
