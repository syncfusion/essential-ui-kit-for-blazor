using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Modals.Modals8
{
    public partial class Modals8
    {
        public SfDialog? Dialog;
        public SfTab? Tab;
        public string DialogHeight = "auto";

        public async Task OnDialogOpenAsync(OpenEventArgs args)
        {
            args.PreventFocus = true;

            if (Tab != null)
            {
                await Tab.RefreshAsync();
            }
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                DialogHeight = windowWidth <= 640 ? "100%" : "auto";
                await Dialog.RefreshPositionAsync();
            }
            await InvokeAsync(StateHasChanged);
        }
    }
}