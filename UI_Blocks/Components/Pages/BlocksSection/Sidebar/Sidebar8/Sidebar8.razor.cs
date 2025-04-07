
namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar8
{
    public partial class Sidebar8
    {
        private bool SidebarToggle { get; set; } = true;
        
        private List<MenuItem> ContactList = new()
        {
            new() { Id = 1, Name = "Darlene Robertson", ProfileImage = "avatar-11.jpg" },
            new() { Id = 2, Name = "Marvin McKinney", ProfileImage = "avatar-5.jpg" },
            new() { Id = 3, Name = "Ralph Edwards", ProfileImage = "avatar-3.jpg" },
            new() { Id = 4, Name = "Courtney Henry", ProfileImage = "avatar-9.jpg" },
            new() { Id = 5, Name = "Darrell Steward", ProfileImage = "avatar-1.jpg" },
            new() { Id = 6, Name = "Jacobs Jones", ProfileImage = "avatar-6.jpg" },
            new() { Id = 7, Name = "Robert Fox", ProfileImage = "avatar-4.jpg" }
        };

        public class MenuItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string ProfileImage { get; set; } = string.Empty;
        }

        private void ToggleSidebar()
        {
            SidebarToggle = !SidebarToggle;
        }
    }
}
