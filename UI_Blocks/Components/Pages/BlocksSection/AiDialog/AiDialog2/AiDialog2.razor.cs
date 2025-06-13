using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.AiDialog.AiDialog2
{
    public partial class AiDialog2
    {
        public SfDialog? Dialog;
        public bool IsMobileView;

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobileView = windowWidth <= 640;
                await Dialog.HideAsync();
                await Dialog.ShowAsync(IsMobileView);
            }
        }
    }
}
