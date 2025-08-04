using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.FilterPanel.FilterPanel3
{
    public partial class FilterPanel3
    {
        public bool IsSidebarOpen = true;
        public string Width = "320px";

        public List<string> Category { get; set; } = new List<string>
        {
            "Technical Support",
            "Account Management",
            "Billing",
            "Feature Request",
            "Bug Report",
            "Security",
            "Performance",
            "Documentation"
        };

        public List<string> Tags { get; set; } = new List<string>
        {
            "Frontend",
            "Backend",
            "Database",
            "Network",
            "API",
            "UI/UX",
            "Mobile"
        };

        public List<string> Priority { get; set; } = new List<string>
        {
            "Critical",
            "High",
            "Medium",
            "Low"
        };

        public List<string> Requester { get; set; } = new List<string>
        {
            "Jane Smith",
            "Mark Johnson",
            "Emily White",
            "Tom Harris"
        };

        public List<string> Status { get; set; } = new List<string>
        {
            "Open",
            "In Progress",
            "Pending",
            "On Hold",
            "Resolved",
            "Closed"
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                Width = windowWidth < 540 ? "100%" : "320px";
            }
            StateHasChanged();
        }
    }
}
