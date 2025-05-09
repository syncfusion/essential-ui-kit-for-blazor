using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.Header.Header6
{
    public partial class Header6
    {
        private bool IsDropdownOpened { get; set; } = false;
        public SfDropDownButton? Dropdown;
        public OverflowMode OverflowMode { get; set; } = OverflowMode.Extended;
        public Dictionary<string, int> HeaderData { get; set; } = new()
        {
            ["New"] = 156,
            ["VerificationDue"] = 23,
            ["ApprovalDue"] = 18
        };

        public void OnDropdownOpened() => IsDropdownOpened = true;
        public void OnDropdownClosed() => IsDropdownOpened = false;

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                OverflowMode = windowWidth < 640 ? OverflowMode.Popup : OverflowMode.Extended;

                if (IsDropdownOpened && Dropdown != null)
                {
                    Dropdown.Toggle();
                }
                StateHasChanged();
            }
        }
    }
}