using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.AiDialog.AiDialog1
{
    public partial class AiDialog1
    {
        public SfDialog? Dialog;
        public SfStepper? Stepper;

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                await Dialog.HideAsync();
                await Dialog.ShowAsync(windowWidth <= 640);
            }
        }
    }
}
