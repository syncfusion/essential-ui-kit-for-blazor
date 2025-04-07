using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.NavBar.NavBar4
{
    public partial class NavBar4
    {
        private SfDropDownButton? ResourcesDropdown;
        private SfDropDownButton? BrandDropdown;

        private bool _isResourcesDropdownOpen = false;
        private bool _isBrandDropdownOpen = false;

        private void OnResourcesDropdownOpened() => _isResourcesDropdownOpen = true;

        private void OnResourcesDropdownClosed() => _isResourcesDropdownOpen = false;

        private void OnBrandDropdownOpened() => _isBrandDropdownOpen = true;

        private void OnBrandDropdownClosed() => _isBrandDropdownOpen = false;

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                if (_isResourcesDropdownOpen && ResourcesDropdown != null)
                {
                    ResourcesDropdown.Toggle();
                }

                if (_isBrandDropdownOpen && BrandDropdown != null)
                {
                    BrandDropdown.Toggle();
                }
            }
        }
    }
}
