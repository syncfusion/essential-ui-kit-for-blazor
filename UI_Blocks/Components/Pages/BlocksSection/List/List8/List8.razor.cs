using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.List.List8
{
    public partial class List8
    {
        public string WidthStyle = "max-width:610px";

        public List<ChatMessage> ChatMessages = new List<ChatMessage>
        {
            new ChatMessage { Id = 1, Time = "12:00 PM", Name = "Robert Darlen", Message = "It was worth watching. I had the most fun out today.", Image = "avatar-1.jpg", Badge = "7" },
            new ChatMessage { Id = 2, Time = "10:56 AM", Name = "Arlene McCoy", Message = "How many NPCs are there?", Image = "avatar-8.jpg", Status = new Status { IsViewed = true } },
            new ChatMessage { Id = 3, Time = "Yesterday", Name = "Theresa Webb", Message = "Same here! Work has been a whirlwind. I just got back from a project in Seattle. The coffee there is amazing!", Image = "avatar-9.jpg", Status = new Status { IsViewed = false } },
            new ChatMessage { Id = 4, Time = "24 Sep", Name = "Kristina Watson", Message = "Actually, I started taking a pottery class! It's so much fun. What about you?", Image = "avatar-10.jpg" },
            new ChatMessage { Id = 5, Time = "22 Sep", Name = "Floyd Miles", Message = "Hey, Jamie! It's been ages! How have you been?", Image = "avatar-4.jpg", Status = new Status { IsViewed = false } },
            new ChatMessage { Id = 6, Time = "20 Sep", Name = "Jane Cooper", Message = "That sounds awesome! I've been getting into hiking. There's a great trail near my place.", Image = "avatar-11.jpg", Status = new Status { IsViewed = true } }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                WidthStyle = windowWidth < 1024 ? "width:100%" : "max-width:610px";
            }
            StateHasChanged();
        }

        public class ChatMessage
        {
            public int Id { get; set; }
            public string Time { get; set; } = string.Empty;
            public string Name { get; set; } = string.Empty;
            public string Message { get; set; } = string.Empty;
            public string Image { get; set; } = string.Empty;
            public string Badge { get; set; } = string.Empty;
            public Status Status { get; set; } = new Status();
        }

        public class Status
        {
            public bool IsViewed { get; set; }
        }
    }
}
