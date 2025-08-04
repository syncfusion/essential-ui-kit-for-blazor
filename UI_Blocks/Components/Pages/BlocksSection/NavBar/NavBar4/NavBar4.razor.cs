using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.NavBar.NavBar4
{
    public partial class NavBar4
    {
        public SfDropDownButton? ResourcesDropdown;
        public SfDropDownButton? BrandDropdown;

        public bool IsResourcesDropdownOpen = false;
        public bool IsBrandDropdownOpen = false;

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                if (IsResourcesDropdownOpen && ResourcesDropdown != null)
                {
                    ResourcesDropdown.Toggle();
                }

                if (IsBrandDropdownOpen && BrandDropdown != null)
                {
                    BrandDropdown.Toggle();
                }
            }
        }
    }
}
