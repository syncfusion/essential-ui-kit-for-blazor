using Microsoft.JSInterop;
using Syncfusion.Blazor.Notifications;

namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar13
{
    public partial class Sidebar13
    {
        public SfToast? ToastInfo;
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;
        public bool IsSupportEnabled;
        public bool IsServiceToolEnabled;
        public bool IsInquiryResolved;
        public bool IsAutoResolveEnabled = true;

        public List<MenuItem> Data = new List<MenuItem>
        {
            new MenuItem { Id = 1, FontIcon = "e-home" },
            new MenuItem { Id = 2, FontIcon = "e-user" },
            new MenuItem { Id = 3, FontIcon = "e-bookmark" },
            new MenuItem { Id = 4, FontIcon = "e-chart" },
            new MenuItem { Id = 5, FontIcon = "e-clock" }
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
            public string FontIcon { get; set; } = string.Empty;
        }
    }
}
