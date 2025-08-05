using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
namespace UI_Blocks.Components.Pages.BlocksSection.AiPricingTable.AiPricingTable1
{
    public partial class AiPricingTable1
    {
        public SfDialog? Dialog;
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
