using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.CheckOut.CheckOut1
{
    public partial class CheckOut1
    {
        public SfStepper? Stepper;

        public string SelectedPaymentMethod = "Payment on delivery";
        public string SelectedDeliveryMethod = "Free delivery - FedEx";

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Stepper != null)
            {
                await Stepper.RefreshProgressbarAsync();
            }
            StateHasChanged();
        }
    }
}
