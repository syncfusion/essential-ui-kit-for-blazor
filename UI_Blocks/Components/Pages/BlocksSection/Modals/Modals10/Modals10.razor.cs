using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Modals.Modals10
{
    public partial class Modals10
    {
        public SfDialog? Dialog;
        public SfSidebar? Sidebar;
        public bool IsMobile;
        public bool IsDockModeEnabled = true;
        public bool IsBackdropVisible = false;
        public SidebarType SidebarDisplayType = SidebarType.Auto;
        public bool IsSidebarOpen = true;

        public List<ListItem> NavigationMenu = new List<ListItem>
        {
            new ListItem { Id = 1, CategoryName = "Account Settings", Field = "My Account", FontIcon = "e-user" },
            new ListItem { Id = 2, CategoryName = "Account Settings", Field = "Subscription", FontIcon = "sf-icon-star-02" },
            new ListItem { Id = 3, CategoryName = "General Preferences", Field = "Appearance", FontIcon = "e-brightness" },
            new ListItem { Id = 4, CategoryName = "General Preferences", Field = "Advanced", FontIcon = "e-adjustment" },
            new ListItem { Id = 5, CategoryName = "General Preferences", Field = "About", FontIcon = "e-circle-info" }
        };

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobile = windowWidth <= 640;
                IsDockModeEnabled = !IsMobile;
                IsBackdropVisible = IsMobile;
                SidebarDisplayType = IsMobile ? SidebarType.Over : SidebarType.Auto;
                await Dialog.HideAsync();
                await Dialog.ShowAsync(IsMobile);
            }
        }

        public class ListItem
        {
            public int Id { get; set; }
            public string CategoryName { get; set; } = string.Empty;
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
        }
    }
}