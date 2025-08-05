using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.Inputs;

namespace UI_Blocks.Components.Pages.BlocksSection.Modals.Modals5
{
    public partial class Modals5
    {
        public SfDialog? Dialog;
        public SfTextBox? CompanyNameTextbox;
        public SfTextBox? LocationTextbox;
        public string DialogHeight = "auto";

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