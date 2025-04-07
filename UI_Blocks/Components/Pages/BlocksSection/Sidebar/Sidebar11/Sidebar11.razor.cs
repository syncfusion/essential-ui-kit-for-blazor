namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar11
{
    public partial class Sidebar11
    {
        private bool SidebarToggle { get; set; } = true;
        
        private List<MenuItem> Data = new()
        {
            new () { Id = 1, Name = "Darlene Robertson", ProfileImage = "avatar-10.jpg" },
            new () { Id = 2, Name = "Marvin McKinney", ProfileImage = "avatar-7.jpg" },
            new () { Id = 3, Name = "Ralph Edwards", ProfileImage = "avatar-3.jpg" },
            new () { Id = 4, Name = "Courtney Henry", ProfileImage = "avatar-12.jpg" },
            new () { Id = 5, Name = "Darrell Steward", ProfileImage = "avatar-1.jpg" },
            new () { Id = 6, Name = "Jacobs Jones", ProfileImage = "avatar-6.jpg" },
            new () { Id = 7, Name = "Robert Fox", ProfileImage = "avatar-4.jpg" }
        };

        private class MenuItem
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
