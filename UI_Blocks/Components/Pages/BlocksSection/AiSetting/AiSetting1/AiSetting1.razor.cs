using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.AiSetting.AiSetting1
{
    public partial class AiSetting1
    {
        public SfSidebar? Sidebar;
        public SfDropDownButton? ThemeDropdown;
        public SfDropDownButton? LanguageDropdown;
        public string SidebarViewMode = "desktop-view";
        public bool IsMobileView = false;
        public bool IsSidebarClosable = true;
        public bool IsSidebarOpen = true;
        public SidebarType SidebarDisplayType = SidebarType.Push;
        public bool IsThemeDropdownOpen = false;
        public bool IsLanguageDropdownOpen = false;

        public List<ListItem> NavigationMenu = new List<ListItem>
        {
            new ListItem { Id = 1, Field = "General", FontIcon = "e-settings" },
            new ListItem { Id = 2, Field = "Account", FontIcon = "e-user" },
            new ListItem { Id = 3, Field = "Data controls", FontIcon = "e-increase-indent" },
            new ListItem { Id = 4, Field = "Chat settings", FontIcon = "e-comment-show" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Sidebar != null)
            {
                IsMobileView = windowWidth <= 680;
                SidebarDisplayType = IsMobileView ? SidebarType.Over : SidebarType.Push;
                IsSidebarClosable = !IsMobileView;
                IsSidebarOpen = true;
                SidebarViewMode = IsMobileView ? "mobile-view" : "desktop-view";

                if (IsThemeDropdownOpen && ThemeDropdown != null)
                {
                    ThemeDropdown.Toggle();
                }
                if (IsLanguageDropdownOpen && LanguageDropdown != null)
                {
                    LanguageDropdown.Toggle();
                }
                StateHasChanged();
            }
        }

        public class ListItem
        {
            public int Id { get; set; }
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
        }
    }
}
