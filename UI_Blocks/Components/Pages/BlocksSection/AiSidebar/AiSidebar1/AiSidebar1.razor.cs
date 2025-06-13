using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.AiSidebar.AiSidebar1
{
    public partial class AiSidebar1
    {
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;
        public bool IsMobileView = false;

        public List<MenuItem> NavigationMenu = new List<MenuItem>
        {
            new MenuItem { Id = 1, Field = "Home", FontIcon = "sf-icon-home-10" },
            new MenuItem { Id = 2, Field = "Prompt box", FontIcon = "e-notes" },
            new MenuItem { Id = 3, Field = "AI chat", FontIcon = "e-comment-show" },
            new MenuItem { Id = 4, Field = "Library", FontIcon = "e-print-layout" },
            new MenuItem { Id = 5, Field = "Art", FontIcon = "e-edit" }
        };

        public List<MenuItem> SupportMenu = new List<MenuItem>
        {
            new MenuItem { Id = 1, Field = "Settings", FontIcon = "e-settings" },
            new MenuItem { Id = 2, Field = "Help", FontIcon = "sf-icon-help-circle" },
            new MenuItem { Id = 3, Field = "Upgrade Plan", FontIcon = "e-arrow-right" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                IsBackdropVisible = windowWidth <= 660;
                IsMobileView = IsBackdropVisible;
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
