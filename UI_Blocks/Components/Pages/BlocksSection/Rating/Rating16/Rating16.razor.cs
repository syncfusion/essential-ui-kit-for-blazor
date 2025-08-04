using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.Rating.Rating16
{
    public partial class Rating16
    {
        public SfDialog? Dialog;
        public bool IsMobile;
        public string experienceLevel = "smile";

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobile = windowWidth <= 640;
                await Dialog.HideAsync();
                await Dialog.ShowAsync(IsMobile);
            }
        }
    }
}
