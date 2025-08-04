using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Returns.Returns3
{
    public partial class Returns3
    {
        public SfStepper? Stepper;
        public string StepperStyle = "";
        public StepperOrientation StepperOrientation = StepperOrientation.Horizontal;
        public StepperLabelPosition LabelPos = StepperLabelPosition.Bottom;
        public string SelectedDeliveryMethod { get; set; } = "Express Courier - $19";

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                bool isVertical = windowWidth < 640;
                StepperOrientation = isVertical ? StepperOrientation.Vertical : StepperOrientation.Horizontal;
                StepperStyle = isVertical ? "min-height:286px" : "";
                LabelPos = isVertical ? StepperLabelPosition.End : StepperLabelPosition.Bottom;

                if (Stepper != null)
                {
                    await Stepper.RefreshProgressbarAsync();
                }
            }
            StateHasChanged();
        }
    }
}
