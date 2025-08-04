using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar7
{
    public partial class Sidebar7
    {
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;

        public List<MenuItem> NavigationMenu = new List<MenuItem>
        {
            new MenuItem { Id = 1, Field = "Dashboard", FontIcon = "e-grid-view" },
            new MenuItem { Id = 2, Field = "Models", FontIcon = "e-send-backward" },
            new MenuItem { Id = 3, Field = "Bookmarks", FontIcon = "e-bookmark" },
            new MenuItem { Id = 4, Field = "Issues", FontIcon = "sf-icon-info-octagon" }
        };

        public List<MenuItem> SupportMenu = new List<MenuItem>
        {
            new MenuItem { Id = 1, Field = "Docs", FontIcon = "e-file-new" },
            new MenuItem { Id = 2, Field = "Component", FontIcon = "e-send-to-back" },
            new MenuItem { Id = 3, Field = "Help", FontIcon = "e-circle-info" }
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

        public class MenuItem
        {
            public int Id { get; set; }
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
        }
    }
}
