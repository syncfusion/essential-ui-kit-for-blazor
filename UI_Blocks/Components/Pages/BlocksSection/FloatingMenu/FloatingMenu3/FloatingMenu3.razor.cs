using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.FloatingMenu.FloatingMenu3
{
    public partial class FloatingMenu3
    {
        public SfDialog? Dialog;
        public bool IsToggleState = true;
        public bool IsMobileView = false;

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobileView = windowWidth < 620;
                await Dialog.RefreshPositionAsync();
            }
            StateHasChanged();
        }
    }
}