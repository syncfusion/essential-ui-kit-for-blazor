using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.Modals.Modals7
{
    public partial class Modals7
    {
        public SfDialog? Dialog;
        public bool IsMobile;

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobile = windowWidth <= 640;
                await Dialog.HideAsync();
                await Dialog.ShowAsync(IsMobile);
            }
        }
    }
}