using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.FilterPanel.FilterPanel8
{
    public partial class FilterPanel8
    {
        public bool IsSidebarOpen = true;
        public string Width = "320px";
        public string SelectedTopics = "welcome-guide";
        public string SelectedBilling = "subscription-overview";
        public string SelectedTechnical = "API-documentation";

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                Width = windowWidth < 540 ? "100%" : "320px";
            }
            StateHasChanged();
        }
    }
}