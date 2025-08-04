using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.FilterPanel.FilterPanel5
{
    public partial class FilterPanel5
    {
        public bool IsSidebarOpen = true;
        public string SelectedPaymentMethod = "basic";
        public double[] Range { get; set; } = [0, 4.5];
        public string Width = "320px";

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