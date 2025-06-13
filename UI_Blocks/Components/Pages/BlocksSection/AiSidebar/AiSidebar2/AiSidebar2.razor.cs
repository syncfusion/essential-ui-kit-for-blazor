using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.AiSidebar.AiSidebar2
{
    public partial class AiSidebar2
    {
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;
        public bool IsMobileView = false;
        
        public List<ChatItem> ChatHistory = new List<ChatItem>
        {
            new ChatItem { Message = "How do I design an interface for a mobile application?", Category = "Today" },
            new ChatItem { Message = "What is design?", Category = "Yesterday" },
            new ChatItem { Message = "How is visual hierarchy achieved?", Category = "Yesterday" },
            new ChatItem { Message = "FAANG design practices", Category = "Yesterday" },
            new ChatItem { Message = "Quantitative research types", Category = "Yesterday" }
        };

        public List<SupportItem> SupportMenu = new List<SupportItem>
        {
            new SupportItem { Field = "Settings", FontIcon = "e-settings" },
            new SupportItem { Field = "Download for iOS", FontIcon = "e-rectangle" },
            new SupportItem { Field = "AI Policy", FontIcon = "e-upload-1" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                IsBackdropVisible = windowWidth <= 660;
                IsMobileView = IsBackdropVisible;
            }
            StateHasChanged();
        }

        public class ChatItem
        {
            public string Message { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
        }

        public class SupportItem
        {
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
        }
    }
}
