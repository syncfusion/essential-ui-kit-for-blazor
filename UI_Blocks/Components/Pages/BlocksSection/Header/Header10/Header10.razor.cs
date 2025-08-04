using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.Header.Header10
{
    public partial class Header10
    {
        public SfDropDownButton? DropDownButton;
        private bool IsDropdownOpen = false;
        public int MaxItems { get; set; } = 3;
        public BreadcrumbOverflowMode OverflowMode { get; set; } = BreadcrumbOverflowMode.None;

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                MaxItems = windowWidth <= 640 ? 1 : 3;
                OverflowMode = MaxItems < 3 ? BreadcrumbOverflowMode.Menu : BreadcrumbOverflowMode.None;

                if (IsDropdownOpen && DropDownButton != null)
                {
                    DropDownButton.Toggle();
                }
                StateHasChanged();
            }
        }
    }
}