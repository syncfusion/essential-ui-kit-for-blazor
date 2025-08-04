using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.FilterPanel.FilterPanel1
{
    public partial class FilterPanel1
    {
        public bool IsSidebarOpen = true;
        public string Width = "320px";

        public List<string> Location { get; set; } = new List<string>
        {
            "Headquarters",
            "Remote",
            "On-site",
            "Regional Office",
            "Working from Home"
        };

        public List<string> Department { get; set; } = new List<string>
        {
            "Human Resource",
            "Finance",
            "Marketing",
            "Operation",
            "IT & Support",
            "Research & Development"
        };

        public List<string> Role { get; set; } = new List<string>
        {
            "Developer",
            "Manager",
            "HR",
            "Designer",
            "Product Manager",
            "QA Engineer"
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