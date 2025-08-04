using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar11
{
    public partial class Sidebar11
    {
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;
        
        public List<MenuItem> Data = new List<MenuItem>
        {
            new MenuItem { Id = 1, Name = "Darlene Robertson", ProfileImage = "avatar-10.jpg" },
            new MenuItem { Id = 2, Name = "Marvin McKinney", ProfileImage = "avatar-7.jpg" },
            new MenuItem { Id = 3, Name = "Ralph Edwards", ProfileImage = "avatar-3.jpg" },
            new MenuItem { Id = 4, Name = "Courtney Henry", ProfileImage = "avatar-12.jpg" },
            new MenuItem { Id = 5, Name = "Darrell Steward", ProfileImage = "avatar-1.jpg" },
            new MenuItem { Id = 6, Name = "Jacobs Jones", ProfileImage = "avatar-6.jpg" },
            new MenuItem { Id = 7, Name = "Robert Fox", ProfileImage = "avatar-4.jpg" }
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
            public string ProfileImage { get; set; } = string.Empty;
        }
    }
}
