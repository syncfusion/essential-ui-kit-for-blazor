using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.Header.Header9
{
    public partial class Header9
    {
        private bool IsNewCourseDropdownOpen { get; set; } = false;
        private bool IsAdditionalOptionDropdownOpen { get; set; } = false;
        public SfSplitButton? NewCourseDropdown;
        public SfDropDownButton? AdditionalOptionDropdown;
        public int MaxItems { get; set; } = 2;
        public BreadcrumbOverflowMode OverflowMode { get; set; } = BreadcrumbOverflowMode.None;

        public void OnNewCourseDropdownOpened() => IsNewCourseDropdownOpen = true;
        public void OnNewCourseDropdownClosed() => IsNewCourseDropdownOpen = false;
        public void OnAdditionalOptionDropdownOpened() => IsAdditionalOptionDropdownOpen = true;
        public void OnAdditionalOptionDropdownClosed() => IsAdditionalOptionDropdownOpen = false;

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                MaxItems = windowWidth <= 640 ? 1 : 2;
                OverflowMode = MaxItems < 2 ? BreadcrumbOverflowMode.Menu : BreadcrumbOverflowMode.None;

                if (IsNewCourseDropdownOpen && NewCourseDropdown != null)
                {
                    NewCourseDropdown.Toggle();
                }
                if (IsAdditionalOptionDropdownOpen && AdditionalOptionDropdown != null)
                {
                    AdditionalOptionDropdown.Toggle();
                }
                StateHasChanged();
            }
        }
    }
}