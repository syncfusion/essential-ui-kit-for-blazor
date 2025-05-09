using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.FilterPanel.FilterPanel4
{
    public partial class FilterPanel4
    {
        public bool IsSidebarOpen { get; set; } = true;
        public string Width { get; set; } = "320px";

        public List<string> Assignee { get; set; } = new List<string>
        {
            "Jane Smith - Support Engineer",
            "Mark Johnson - Technical Lead",
            "Emily White - Support Specialist",
            "Tom Harris - Product Expert"
        };

        public List<string> Tags { get; set; } = new List<string>
        {
            "Technical Issue (Type)",
            "Bug (Type)",
            "Feature Request (Type)",
            "High Priority (Priority)",
            "Customer Impact (Impact)",
            "Backend (Area)",
            "Frontend (Area)"
        };

        public List<string> Status { get; set; } = new List<string>
        {
            "Open",
            "In Progress",
            "Closed"
        };

        public void ToggleSidebar()
        {
            IsSidebarOpen = !IsSidebarOpen;
        }

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                Width = windowWidth < 540 ? "100%" : "320px";
                StateHasChanged();
            }
        }
    }
}