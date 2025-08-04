using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.FilterPanel.FilterPanel7
{
    public partial class FilterPanel7
    {
        public bool IsSidebarOpen = true;
        public string SelectedExperienceLevel = "entry-level";
        public string SelectedSalaryRange = "$0-$50k";
        public string Width = "320px";

        public string[] JobTypeChips =
        {
            "Remote",
            "Immediate start",
            "Full-Time"
        };

        public string[] SelectedJobTypes =
        {
            "Remote",
            "Immediate start",
            "Full-Time"
        };

        public string[] SkillChips =
        {
            "React",
            "TypeScript",
            "Node.js",
            "Python",
            "AWS"
        };

        public string[] SelectedSkills =
        {
            "React",
            "TypeScript"
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