using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.FilterPanel.FilterPanel6
{
    public partial class FilterPanel6
    {
        public bool IsSidebarOpen { get; set; } = true;
        public string Width { get; set; } = "320px";

        public void ToggleSidebar()
        {
            IsSidebarOpen = !IsSidebarOpen;
        }

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                Width = windowWidth < 540 ? "100%" : "320px";
                StateHasChanged();
            }
        }
    }
}