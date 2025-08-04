using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.Header.Header9
{
    public partial class Header9
    {
        public SfDropDownButton? DropDownButton;
        public SfSplitButton? NewCourseDropdown;
        public bool IsDropdownOpen = false;
        public bool IsNewCourseDropdownOpen = false;
        public int MaxItems = 2;
        public BreadcrumbOverflowMode OverflowMode { get; set; } = BreadcrumbOverflowMode.None;

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                MaxItems = windowWidth <= 640 ? 1 : 2;
                OverflowMode = MaxItems < 2 ? BreadcrumbOverflowMode.Menu : BreadcrumbOverflowMode.None;

                if (IsDropdownOpen && DropDownButton != null)
                {
                    DropDownButton.Toggle();
                }
                if (IsNewCourseDropdownOpen && NewCourseDropdown != null)
                {
                    NewCourseDropdown.Toggle();
                }
            }
            StateHasChanged();
        }
    }
}