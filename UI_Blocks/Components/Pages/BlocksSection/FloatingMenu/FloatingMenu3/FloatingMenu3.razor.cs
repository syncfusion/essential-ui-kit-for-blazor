using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.FloatingMenu.FloatingMenu3
{
    public partial class FloatingMenu3
    {
        private bool _toggleState = false;
        private SfDialog? Dialog;
        private bool IsMobileView = false;
        private string XValue { get; set; } = string.Empty;
        private string YValue { get; set; } = string.Empty;

        private void onOpen(Syncfusion.Blazor.Popups.OpenEventArgs args){ args.PreventFocus = true;}

        private async Task ToggleDialogAsync()
        {
            if (Dialog == null)
            {
                return;
            }
            if (_toggleState)
            {
                await Dialog.ShowAsync();
                StateHasChanged();
            }
            else
            {
                await Dialog.HideAsync();
            }
            _toggleState = !_toggleState;
        }
        public async Task CreatedHandler(Object args)
        {
            XValue = "right";
            YValue = "top";
        }
        
        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobileView = windowWidth < 620;
                await Dialog.RefreshPositionAsync();
                StateHasChanged();
            }
        }
    }
}