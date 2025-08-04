using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.NavBar.NavBar3
{
    public partial class NavBar3
    {
        public SfDropDownButton? StateDropdown;
        public SfDropDownButton? AddressDropdown;
        public bool IsStateDropdownOpen = false;
        public bool IsAddressDropdownOpen = false;

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                if (IsStateDropdownOpen && StateDropdown != null)
                {
                    StateDropdown.Toggle();
                }

                if (IsAddressDropdownOpen && AddressDropdown != null)
                {
                    AddressDropdown.Toggle();
                }
            }
        }
    }
}
