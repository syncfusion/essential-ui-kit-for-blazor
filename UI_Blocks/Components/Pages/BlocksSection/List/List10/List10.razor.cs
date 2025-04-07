using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.List.List10
{
    public partial class List10
    {
        private string WidthStyle { get; set; } = "max-width:512px";

        private List<TaskItem> Data { get; set; } = new List<TaskItem>
        {
            new() { Id = 1, Date = new(2024, 10, 5), Content = "Refactor primary components to align with system version 1.4.", Image = "avatar-12.jpg", Logo = "figma.png" },
            new() { Id = 2, Date = new(2024, 10, 18), Content = "Design and schedule the monthly newsletter in MailChimp to keep subscribers informed.", Image = "avatar-14.jpg", Logo = "mailchimp.png" },
            new() { Id = 3, Date = new(2024, 10, 25), Content = "Organize a team meeting in Microsoft Teams", Image = "avatar-7.jpg", Logo = "microsoft.png" },
            new() { Id = 4, Date = new(2024, 11, 8), Content = "Design a visually appealing promotional poster for an upcoming event or product launch using Adobe InDesign.", Image = "avatar-4.jpg", Logo = "adobe.png" },
            new() { Id = 5, Date = new(2024, 12, 15), Content = "Create and structure a collaborative document for your team to brainstorm ideas for an upcoming project", Image = "avatar-13.jpg", Logo = "google.png" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                WidthStyle = windowWidth < 1024 ? "width:100%" : "max-width:512px";
                StateHasChanged();
            }
        }

        public class TaskItem
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public string Content { get; set; } = string.Empty;
            public string Image { get; set; } = string.Empty;
            public string Logo { get; set; } = string.Empty;
        }
    }
}
