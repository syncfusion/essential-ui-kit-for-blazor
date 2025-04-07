using Syncfusion.Blazor.Notifications;

namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar13
{
    public partial class Sidebar13
    {
        private bool SidebarToggle { get; set; } = true;
        private bool SupportsManagement;
        private bool IsCustomerServiceToolEnabled;
        private bool HasResolvedInquiries;
        private bool ShouldAutoResolveInquiries = true;
        private SfToast? ToastInfo;

        private List<MenuItem> Data = new()
        {
            new() { Id = 1, FontIcon = "e-home" },
            new() { Id = 2, FontIcon = "e-user" },
            new() { Id = 3, FontIcon = "e-bookmark" },
            new() { Id = 4, FontIcon = "e-chart" },
            new() { Id = 5, FontIcon = "e-clock" }
        };

        public async Task CreatedHandler(SfToast? toast)
        {
            if (toast != null)
            {
                await toast.ShowAsync();
            }
        }
        private class MenuItem
        {
            public int Id { get; set; }
            public string FontIcon { get; set; } = string.Empty;
        }

        private void ToggleSidebar()
        {
            SidebarToggle = !SidebarToggle;
        }
    }
}
