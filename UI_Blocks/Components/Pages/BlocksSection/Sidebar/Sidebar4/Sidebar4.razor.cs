using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar4
{
    public partial class Sidebar4
    {
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;

        public List<MenuItem> NavigationMenu = new List<MenuItem>
        {
            new MenuItem { Field = "Dashboard", FontIcon = "e-grid-view" },
            new MenuItem { Field = "Revenue", FontIcon = "sf-icon-dollar" },
            new MenuItem { Field = "Notifications", FontIcon = "sf-icon-notification-bell-01" },
            new MenuItem { Field = "Analytics", FontIcon = "e-chart" },
            new MenuItem { Field = "Wallets", FontIcon = "e-select-all" }
        };

        public List<DataModel> BusinessCategories = new List<DataModel>
        {
            new DataModel { Field = "Sales", FontIcon = "sf-icon-dollar" },
            new DataModel { Field = "Design", FontIcon = "sf-icon-desktop-01" },
            new DataModel { Field = "Fundraising", FontIcon = "sf-icon-dollar" },
            new DataModel { Field = "Internal", FontIcon = "e-comment-show" },
            new DataModel { Field = "Customer Success", FontIcon = "sf-icon-user-tick-02" },
            new DataModel { Field = "Networking", FontIcon = "sf-icon-laptop" },
            new DataModel { Field = "Legal", FontIcon = "e-notes" }
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
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
        }

        public class DataModel
        {
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
        }
    }
}
