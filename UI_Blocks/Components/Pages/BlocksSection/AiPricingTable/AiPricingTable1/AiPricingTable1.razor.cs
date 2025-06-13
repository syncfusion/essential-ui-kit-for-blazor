using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
namespace UI_Blocks.Components.Pages.BlocksSection.AiPricingTable.AiPricingTable1
{
    public partial class AiPricingTable1
    {
        public SfDialog? Dialog;
        public bool IsMobileView = false;

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
