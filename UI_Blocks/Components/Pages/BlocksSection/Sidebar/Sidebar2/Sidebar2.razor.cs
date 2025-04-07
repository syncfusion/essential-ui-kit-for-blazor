using Syncfusion.Blazor.Notifications;

namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar2
{
    public partial class Sidebar2
    {
        private SfToast? ToastInfo;
        private bool SidebarToggle { get; set; } = true;
        private List<MenuItem> Data = new()
        {
            new MenuItem { Field = "Home", FontIcon = "e-icons e-home" },
            new MenuItem { Field = "My Dashboard", FontIcon = "e-icons e-grid-view" },
            new MenuItem { Field = "Notifications", FontIcon = "sf-icon-notification-bell-01" },
        };

        public class MenuItem
        {
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
        }
        public async Task CreatedHandler(SfToast? toast)
        {
            if (toast != null)
            {
                await toast.ShowAsync();
            }
        }

        private void ToggleSidebar()
        {
            SidebarToggle = !SidebarToggle;
        }
    }
}
