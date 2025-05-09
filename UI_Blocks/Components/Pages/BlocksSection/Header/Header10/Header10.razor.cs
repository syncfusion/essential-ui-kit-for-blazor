using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.Header.Header10
{
    public partial class Header10
    {
        private bool IsDropdownOpened { get; set; } = false;
        public SfDropDownButton? Dropdown;
        public int MaxItems { get; set; } = 3;
        public BreadcrumbOverflowMode OverflowMode { get; set; } = BreadcrumbOverflowMode.None;

        public void OnDropdownOpened() => IsDropdownOpened = true;
        public void OnDropdownClosed() => IsDropdownOpened = false;

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                MaxItems = windowWidth <= 640 ? 1 : 3;
                OverflowMode = MaxItems < 3 ? BreadcrumbOverflowMode.Menu : BreadcrumbOverflowMode.None;

                if (IsDropdownOpened && Dropdown != null)
                {
                    Dropdown.Toggle();
                }
                StateHasChanged();
            }
        }
    }
}