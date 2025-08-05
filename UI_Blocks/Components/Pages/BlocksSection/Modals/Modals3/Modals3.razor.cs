using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Modals.Modals3
{
    public partial class Modals3
    {
        public SfDialog? Dialog;
        public SfStepper? Stepper;
        private bool IsMobile;
        public string StepperStyle = string.Empty;
        public string DialogHeight = "auto";
        public StepperOrientation CurrentStepperOrientation = StepperOrientation.Horizontal;
        public StepperLabelPosition LabelPos = StepperLabelPosition.Bottom;
        public int ExpandedIndex = 0;

        public async Task OnDialogOpenAsync(OpenEventArgs args)
        {
            args.PreventFocus = true;
            
            if (Stepper != null)
            {
                await Stepper.RefreshProgressbarAsync();
            }
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobile = windowWidth <= 640;
                CurrentStepperOrientation = IsMobile ? StepperOrientation.Vertical : StepperOrientation.Horizontal;
                StepperStyle = IsMobile ? "min-height:240px" : string.Empty;
                LabelPos = IsMobile ? StepperLabelPosition.End : StepperLabelPosition.Bottom;

                if (Stepper != null)
                {
                    await Stepper.RefreshProgressbarAsync();
                }
                DialogHeight = IsMobile ? "100%" : "auto";
                await Dialog.RefreshPositionAsync();
            }
            await InvokeAsync(StateHasChanged);
        }
    }
}