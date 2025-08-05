using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.Rating.Rating16
{
    public partial class Rating16
    {
        public SfDialog? Dialog;
        public bool IsMobile;
        public string experienceLevel = "smile";
        public string DialogHeight = "auto";

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobile = windowWidth <= 640;
                DialogHeight = IsMobile ? "100%" : "auto";
                await Dialog.RefreshPositionAsync();
            }
            await InvokeAsync(StateHasChanged);
        }
    }
}
