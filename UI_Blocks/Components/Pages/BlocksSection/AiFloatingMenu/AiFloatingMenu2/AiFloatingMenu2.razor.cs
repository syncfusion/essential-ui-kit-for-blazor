using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.AiFloatingMenu.AiFloatingMenu2
{
    public partial class AiFloatingMenu2
    {
        public SfDialog? Dialog;
        public bool IsMobileView = false;
        public bool IsDialogVisible = true;

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobileView = windowWidth < 640;
                await Dialog.RefreshPositionAsync();
            }
            StateHasChanged();
        }
    }
}
