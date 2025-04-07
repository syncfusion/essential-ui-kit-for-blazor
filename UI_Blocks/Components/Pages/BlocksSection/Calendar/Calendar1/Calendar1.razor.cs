using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Calendar.Calendar1
{
    public partial class Calendar1
    {
        private bool SidebarToggle { get; set; } = true;
        private string Width { get; set; } = "310px";
        private void ToggleSidebar()
        {
            SidebarToggle = !SidebarToggle;
        }

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                Width = windowWidth < 540 ? "100%" : "310px";
                StateHasChanged();
            }
        }

    }
}