using Microsoft.JSInterop;

using Syncfusion.Blazor.Notifications;

namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar2
{
    public partial class Sidebar2
    {
        public SfToast? ToastInfo;
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;

        public List<MenuItem> Data = new List<MenuItem>
        {
            new MenuItem { Field = "Home", FontIcon = "e-icons e-home" },
            new MenuItem { Field = "My Dashboard", FontIcon = "e-icons e-grid-view" },
            new MenuItem { Field = "Notifications", FontIcon = "sf-icon-notification-bell-01" }
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
    }
}
