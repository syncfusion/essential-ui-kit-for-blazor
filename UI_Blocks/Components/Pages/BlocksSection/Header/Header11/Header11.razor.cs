using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Header.Header11
{
    public partial class Header11
    {
        public int MaxItems = 2;
        public OverflowMode TabOverflowMode { get; set; } = OverflowMode.Extended;
        public BreadcrumbOverflowMode BreadcrumbOverflowMode { get; set; } = BreadcrumbOverflowMode.None;

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                MaxItems = windowWidth <= 640 ? 1 : 2;
                BreadcrumbOverflowMode = MaxItems < 2 ? BreadcrumbOverflowMode.Menu : BreadcrumbOverflowMode.None;
                TabOverflowMode = windowWidth < 640 ? OverflowMode.Popup : OverflowMode.Extended;
            }
            StateHasChanged();
        }
    }
}