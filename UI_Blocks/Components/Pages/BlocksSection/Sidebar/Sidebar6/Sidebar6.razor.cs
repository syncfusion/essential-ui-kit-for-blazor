using Microsoft.JSInterop;

﻿namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar6
{
    public partial class Sidebar6
    {
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;

        public List<NavigationMenuItem> NavigationMenu = new List<NavigationMenuItem>
        {
            new NavigationMenuItem { Id = 1, Field = "Dashboard", FontIcon = "e-grid-view" },
            new NavigationMenuItem { Id = 2, Field = "Models", FontIcon = "e-send-backward" },
            new NavigationMenuItem { Id = 3, Field = "Bookmarks", FontIcon = "e-bookmark" },
            new NavigationMenuItem { Id = 4, Field = "Issues", FontIcon = "sf-icon-info-octagon" }
        };

        public List<LibraryMenuItem> LibraryMenu = new List<LibraryMenuItem>
        {
            new LibraryMenuItem { Id = 1, Field = "Library" },
            new LibraryMenuItem { Id = 2, Field = "Themesberg" },
            new LibraryMenuItem { Id = 3, Field = "Blocks" },
            new LibraryMenuItem { Id = 4, Field = "Iconsale" }
        };

        public List<NavigationMenuItem> SupportMenu = new List<NavigationMenuItem>
        {
            new NavigationMenuItem { Id = 1, Field = "Settings", FontIcon = "e-settings" },
            new NavigationMenuItem { Id = 2, Field = "Help & Getting Started", FontIcon = "e-circle-info" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                IsBackdropVisible = windowWidth <= 640;
            }
            StateHasChanged();
        }

        public class NavigationMenuItem
        {
            public int Id { get; set; }
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
        }

        public class LibraryMenuItem
        {
            public int Id { get; set; }
            public string Field { get; set; } = string.Empty;
        }
    }
}
