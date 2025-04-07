namespace UI_Blocks.Components.Pages.BlocksSection.TileView.TileView1
{
    public partial class TileView1
    {
        private readonly List<TicketDetail> TicketDetails = new()
        {
            new TicketDetail { TicketId = 98724, DueDate = new DateTime(2024, 8, 15), CreatedTime = "Creates 3 hrs ago", Title = "Update payment gateway integration", Category = "Development", Requester = "Emma Thompson", Assignee = "Michael Chen", Status = "Open", PriorityLevel = "High", CommentCount = 0 },
            new TicketDetail { TicketId = 98725, DueDate = new DateTime(2024, 9, 30), CreatedTime = "Creates 5 hrs ago", Title = "Create onboarding email sequence", Category = "Marketing", Requester = "Sophie Martin", Assignee = "Alex Johnson", Status = "In-progress", PriorityLevel = "Medium", CommentCount = 5 },
            new TicketDetail { TicketId = 98726, DueDate = new DateTime(2024, 8, 10), CreatedTime = "Creates 1 day ago", Title = "Fix mobile responsiveness issues", Category = "UX/UI Design", Requester = "David Lee", Assignee = "Emily Wang", Status = "Open", PriorityLevel = "High", CommentCount = 0 },
            new TicketDetail { TicketId = 98727, DueDate = new DateTime(2024, 8, 5), CreatedTime = "Creates 2 days ago", Title = "Implement two-factor authentication", Category = "Security", Requester = "Robert Brown", Assignee = "Sarah Davis", Status = "Closed", PriorityLevel = "Low", CommentCount = 7 }
        };

        private string GetPriorityClass(string priority)
        {
            return priority switch
            {
                "Medium" => "e-success",
                "High" => "e-danger",
                "Low" => "e-info",
                _ => ""
            };
        }

        private string GetPriorityIcon(string priority)
        {
            return priority switch
            {
                "Medium" => "normal",
                "High" => "high",
                "Low" => "low",
                _ => ""
            };
        }

        private string GetStatusClass(string status)
        {
            return status switch
            {
                "In-progress" => "e-info",
                "Open" => "e-primary",
                "Closed" => "e-success",
                _ => ""
            };
        }

        public class TicketDetail
        {
            public int TicketId { get; set; }
            public DateTime DueDate { get; set; }
            public string CreatedTime { get; set; } = string.Empty;
            public string Title { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
            public string Requester { get; set; } = string.Empty;
            public string Assignee { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;
            public string PriorityLevel { get; set; } = string.Empty;
            public int CommentCount { get; set; }
        }
    }
}
