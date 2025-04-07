using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.Sidebar.Sidebar12
{
    public partial class Sidebar12
    {
        private bool SidebarToggle { get; set; } = true;

        private List<MenuItem> Data = new()
        {
            new() { Id = 1, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "36,888" },
            new() { Id = 2, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "36,719" },
            new() { Id = 3, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "24,988" },
            new() { Id = 4, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "16,588" },
            new() { Id = 5, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "64,748" },
            new() { Id = 6, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "54,238" },
            new() { Id = 7, Name = "Bitcoin", Image = "bitcoin.png", CurrentValue = "43,777" }
        };
        public class MenuItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Image { get; set; } = string.Empty;
            public string CurrentValue { get; set; } = string.Empty;
        }

        private void ToggleSidebar()
        {
            SidebarToggle = !SidebarToggle;
        }
    }
}
