using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.List.List3
{
    public partial class List3
    {
        public string WidthStyle = "max-width:608px";

        public List<MessageItem> Messages = new List<MessageItem>
        {
            new MessageItem { Id = 1, Name = "Wade Warren", Content = "Hey team, I've updated the project timeline. Please review the new deadlines and provide feedback by tomorrow.", Avatar = "avatar-3.jpg", Time = "5 min ago" },
            new MessageItem { Id = 2, Name = "Albert Flores", Content = "The client has approved the initial design draft. Let's move forward with the next phase of development.", Avatar = "avatar-4.jpg", Time = "32 min ago" },
            new MessageItem { Id = 3, Name = "Ralph Edwards", Content = "Reminder: Our weekly project sync is scheduled for 10 AM tomorrow. Please come prepared with your progress updates.", Avatar = "avatar-5.jpg", Time = "45 min ago" },
            new MessageItem { Id = 4, Name = "Annette Black", Content = "We've encountered an issue with the current build. I'll need everyone's input to troubleshoot and find a quick solution.", Avatar = "avatar-14.jpg", Time = "48 min ago" },
            new MessageItem { Id = 5, Name = "Kristin Watson", Content = "Great news! We've hit the project milestone ahead of schedule. Let's keep this momentum going for the final phase.", Avatar = "avatar-13.jpg", Time = "1 hr ago" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                WidthStyle = windowWidth < 1024 ? "width:100%" : "max-width:608px";
            }
            StateHasChanged();
        }

        public class MessageItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
            public string Time { get; set; } = string.Empty;
        }
    }
}
