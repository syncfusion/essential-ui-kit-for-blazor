using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.NavBar.NavBar5
{
    public partial class NavBar5
    {
        public SfBreadcrumb? Breadcrumb;
        public SfDropDownButton? MainDropdown;
        public SfDropDownButton? MoreOptionsDropdown;

        public bool IsMoreOptionsDropdownOpen = false;
        public bool IsMainOptionsDropdownOpen = false;
        private string activeBreadcrumbText = "Personal";
        
        public void BreadcrumbItemClicked(BreadcrumbClickedEventArgs args)
        {
            if (!string.IsNullOrEmpty(args.Item.Text))
            {
                activeBreadcrumbText = args.Item.Text;
                StateHasChanged();
            }
        }

        public void OnMenuItemSelected(MenuEventArgs args)
        {
            if (args.Item.Text == "CompanyName.com")
            {
                activeBreadcrumbText = "CompanyName.com";

                if (Breadcrumb != null)
                {
                    Breadcrumb.ActiveItem = activeBreadcrumbText;
                }
                StateHasChanged();
            }
        }

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                if (IsMoreOptionsDropdownOpen && MoreOptionsDropdown != null)
                {
                    MoreOptionsDropdown.Toggle();
                }
                if (IsMainOptionsDropdownOpen && MainDropdown != null)
                {
                    MainDropdown.Toggle();
                }
            }
        }
    }
}
