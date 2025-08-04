using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.CheckOut.CheckOut5
{
    public partial class CheckOut5
    {
        public SfDialog? Dialog;

        public string SelectedPaymentMethod = "Payment on delivery";

        public string SelectedDeliveryMethod = "Free delivery - FedEx";
    
        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                await Dialog.RefreshPositionAsync();
            }
            StateHasChanged();
        }
    }
}
