using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.Header.Header6
{
    public partial class Header6
    {
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpened = false;
        public OverflowMode OverflowMode { get; set; } = OverflowMode.Extended;
        public Dictionary<string, int> HeaderData { get; set; } = new()
        {
            ["New"] = 156,
            ["VerificationDue"] = 23,
            ["ApprovalDue"] = 18
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                OverflowMode = windowWidth < 640 ? OverflowMode.Popup : OverflowMode.Extended;

                if (IsDropdownOpened && DropDownButton != null)
                {
                    DropDownButton.Toggle();
                }
            }
            StateHasChanged();
        }
    }
}