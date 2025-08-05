using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.AiDialog.AiDialog3
{
    public partial class AiDialog3
    {
        public SfDialog? Dialog;
        public string DialogHeight = "238px";

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                DialogHeight = windowWidth <= 640 ? "100%" : "238px";
                await Dialog.RefreshPositionAsync();
            }
            await InvokeAsync(StateHasChanged);
        }
    }
}
