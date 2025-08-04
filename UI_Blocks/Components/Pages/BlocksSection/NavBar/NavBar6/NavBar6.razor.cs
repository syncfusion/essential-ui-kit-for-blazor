using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.NavBar.NavBar6
{
    public partial class NavBar6
    {
        public SfDropDownButton? ProfileDropdown;
        public bool IsProfileDropdownOpen = false;

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && IsProfileDropdownOpen && ProfileDropdown != null)
            {
                ProfileDropdown.Toggle();
            }
        }
    }
}
