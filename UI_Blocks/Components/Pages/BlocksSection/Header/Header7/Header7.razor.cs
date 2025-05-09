using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Header.Header7
{
    public partial class Header7
    {
        public int MaxItems { get; set; } = 2;
        public BreadcrumbOverflowMode OverflowMode { get; set; } = BreadcrumbOverflowMode.None;

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                MaxItems = windowWidth <= 640 ? 1 : 2;
                OverflowMode = MaxItems < 2 ? BreadcrumbOverflowMode.Menu : BreadcrumbOverflowMode.None;
                StateHasChanged();
            }
        }
    }
}