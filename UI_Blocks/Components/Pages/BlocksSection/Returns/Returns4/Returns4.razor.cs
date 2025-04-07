using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Returns.Returns4
{
    public partial class Returns4
    {
        private SfStepper? Stepper;
        private string StepperStyle = "";
        private StepperOrientation StepperOrientation = StepperOrientation.Horizontal;
        private StepperLabelPosition LabelPos = StepperLabelPosition.Bottom;
        private string SelectedReturnMethod { get; set; } = "I want a shop voucher";

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

                StateHasChanged();
            }
        }
    }
}
