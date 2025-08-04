using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Header.Header2
{
    public partial class Header2
    {
        public OverflowMode OverflowMode { get; set; } = OverflowMode.Extended;

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