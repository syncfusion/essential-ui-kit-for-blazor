using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Header.Header4
{
    public partial class Header4
    {
        private int ActiveTabIndex = 0;
        public OverflowMode OverflowMode { get; set; } = OverflowMode.Extended;

        public void TabSelected(SelectEventArgs args)
        {
            ActiveTabIndex = args.SelectedIndex;
        }

        public string GetBadgeClass(int index)
        {
            return index == ActiveTabIndex ? "e-badge-primary" : string.Empty;
        }

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                OverflowMode = windowWidth < 640 ? OverflowMode.Popup : OverflowMode.Extended;
            }
            StateHasChanged();
        }
    }
}