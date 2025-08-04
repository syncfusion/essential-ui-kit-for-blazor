using Microsoft.JSInterop;

﻿namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar12
{
    public partial class Sidebar12
    {
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;

        public List<MenuItem> Data = new List<MenuItem>
        {
            new MenuItem { Id = 1, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "36,888" },
            new MenuItem { Id = 2, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "36,719" },
            new MenuItem { Id = 3, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "24,988" },
            new MenuItem { Id = 4, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "16,588" },
            new MenuItem { Id = 5, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "64,748" },
            new MenuItem { Id = 6, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "54,238" },
            new MenuItem { Id = 7, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "43,777" }
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
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Image { get; set; } = string.Empty;
            public string CurrentValue { get; set; } = string.Empty;
        }
    }
}
