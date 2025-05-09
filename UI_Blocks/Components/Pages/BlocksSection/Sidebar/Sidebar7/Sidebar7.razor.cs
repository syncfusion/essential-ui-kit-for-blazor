namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar7
{
    public partial class Sidebar7
    {
        private bool SidebarToggle { get; set; } = true;

        private List<MenuItem> NavigationMenu = new()
        {
            new() { Id = 1, Field = "Dashboard", FontIcon = "e-grid-view" },
            new() { Id = 2, Field = "Models", FontIcon = "e-send-backward" },
            new() { Id = 3, Field = "Bookmarks", FontIcon = "e-bookmark" },
            new() { Id = 4, Field = "Issues", FontIcon = "sf-icon-info-octagon" }
        };
        private List<MenuItem> SupportMenu = new()
        {
            new() { Id = 1, Field = "Docs", FontIcon = "e-file-new" },
            new() { Id = 2, Field = "Component", FontIcon = "e-send-to-back" },
            new() { Id = 3, Field = "Help", FontIcon = "e-circle-info" }
        };

        public class MenuItem
        {
            public int Id { get; set; }
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
        }

        private void ToggleSidebar()
        {
            SidebarToggle = !SidebarToggle;
        }
    }
}
