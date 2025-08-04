using Microsoft.JSInterop;

﻿namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar3
{
    public partial class Sidebar3
    {
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;

        public List<MenuItem> Data = new List<MenuItem>
        {
            new MenuItem { Field = "Dashboard", FontIcon = "e-icons e-grid-view" },
            new MenuItem { Field = "Models", FontIcon = "e-icons e-send-backward" },
            new MenuItem { Field = "Bookmarks", FontIcon = "e-icons e-bookmark" },
            new MenuItem { Field = "Issues", FontIcon = "sf-icon-info-octagon" },
            new MenuItem { Field = "Milestones", FontIcon = "sf-icon-clock-rewind" },
            new MenuItem { Field = "Labels", FontIcon = "e-circle-check" },
            new MenuItem { Field = "Documents", FontIcon = "e-file-new" },
            new MenuItem { Field = "Libraries", FontIcon = "sf-icon-light-bulb" },
            new MenuItem { Field = "Members", FontIcon = "e-user" }
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

        public class MenuItem
        {
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
        }
    }
}
