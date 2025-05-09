using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.FilterPanel.FilterPanel8
{
    public partial class FilterPanel8
    {
        public bool IsSidebarOpen { get; set; } = true;
        public string Width { get; set; } = "320px";
        public string SelectedTopics { get; set; } = "welcome-guide";
        public string SelectedBilling { get; set; } = "subscription-overview";
        public string SelectedTechnical { get; set; } = "API-documentation";

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