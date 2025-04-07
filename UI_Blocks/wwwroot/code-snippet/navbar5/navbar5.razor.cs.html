using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.NavBar.NavBar5
{
    public partial class NavBar5
    {
        private SfBreadcrumb? Breadcrumb;
        private SfDropDownButton? MainDropdown;
        private SfDropDownButton? MoreOptionsDropdown;

        private bool _isMoreOptionsDropdownOpen = false;
        private bool _isMainOptionsDropdownOpen = false;
        private string _activeBreadcrumbText = "Personal";

        private void OnMoreOptionsOpened() => _isMoreOptionsDropdownOpen = true;

        private void OnMoreOptionsClosed() => _isMoreOptionsDropdownOpen = false;

        private void OnMainOptionsOpened() => _isMainOptionsDropdownOpen = true;

        private void OnMainOptionsClosed() => _isMainOptionsDropdownOpen = false;

        

        private void OnBreadcrumbItemClicked(BreadcrumbClickedEventArgs args)
        {
            if (!string.IsNullOrEmpty(args.Item.Text))
            {
                _activeBreadcrumbText = args.Item.Text;
                StateHasChanged();
            }
        }

        private void OnMenuItemSelected(MenuEventArgs args)
        {
            if (args.Item.Text == "CompanyName.com")
            {
                _activeBreadcrumbText = "CompanyName.com";

                if (Breadcrumb != null)
                {
                    Breadcrumb.ActiveItem = _activeBreadcrumbText;
                }
                StateHasChanged();
            }
        }

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                if (_isMoreOptionsDropdownOpen && MoreOptionsDropdown != null)
                {
                    MoreOptionsDropdown.Toggle();
                }
                if (_isMainOptionsDropdownOpen && MainDropdown != null)
                {
                    MainDropdown.Toggle();
                }
            }
        }
    }
}
