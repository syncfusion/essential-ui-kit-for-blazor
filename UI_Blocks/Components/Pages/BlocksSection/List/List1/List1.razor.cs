using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.List.List1
{
    public partial class List1
    {
        public string WidthStyle = "max-width:544px";

        public List<TaskItem> TaskData = new List<TaskItem>
        {
            new TaskItem { Id = 1, Name = "Sarah Lee", Header = "Finalize Project Plan", Content = "Refine the project plan to ensure all phases are outlined clearly.", Date = new DateTime(2024, 3, 15), Completed = true },
            new TaskItem { Id = 2, Name = "Alex Carter", Header = "Prepare Budget Report", Content = "Compile and review the budget report for stakeholder presentation.", Date = new DateTime(2024, 4, 10), Completed = true },
            new TaskItem { Id = 3, Name = "Emily Brown", Header = "Schedule Team Meeting", Content = "Organize a meeting to discuss milestones and next steps for the project.", Date = new DateTime(2024, 4, 18), Completed = false },
            new TaskItem { Id = 4, Name = "Michael Green", Header = "Client Feedback Review", Content = "Review the feedback provided by the client and identify actionable items.", Date = new DateTime(2024, 4, 22), Completed = false },
            new TaskItem { Id = 5, Name = "David Smith", Header = "Update Documentation", Content = "Ensure all project documentation is up-to-date and accessible for the team.", Date = new DateTime(2024, 4, 29), Completed = false }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                WidthStyle = windowWidth < 1024 ? "width:100%" : "max-width:544px";
            }
            StateHasChanged();
        }

        public class TaskItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Header { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public DateTime Date { get; set; }
            public bool Completed { get; set; }
        }
    }
}