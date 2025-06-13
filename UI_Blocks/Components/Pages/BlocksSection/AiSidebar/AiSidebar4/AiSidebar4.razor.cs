using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.AiSidebar.AiSidebar4
{
    public partial class AiSidebar4
    {
        public SfContextMenu<MenuItem> ContextMenu;
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;
        public bool IsMobileView = false;

        public List<ChatItem> ChatHistory = new List<ChatItem>
        {
            new ChatItem { Message = "AI Chat", Category = "", FontIcon = "e-comment-show" },
            new ChatItem { Message = "Settings", Category = "", FontIcon = "e-settings" },
            new ChatItem { Message = "FAQs", Category = "", FontIcon = "sf-icon-help-circle" },
            new ChatItem { Message = "How can I improve my time management skills?", Category = "Pinned", FontIcon = "sf-icon-push-pin" },
            new ChatItem { Message = "What's the best way to learn a new language effectively?", Category = "Pinned", FontIcon = "sf-icon-push-pin" },
            new ChatItem { Message = "What's the difference between anxiety and stress?", Category = "Chat history", FontIcon = "e-clock" },
            new ChatItem { Message = "How can I reduce stress at work and stay productive?", Category = "Chat history", FontIcon = "e-clock" },
            new ChatItem { Message = "What are some good health habits to start today?", Category = "Chat history", FontIcon = "e-clock" },
            new ChatItem { Message = "Should I get a pet if I live alone in an apartment?", Category = "Chat history", FontIcon = "e-clock" },
            new ChatItem { Message = "How much sleep do I really need each night?", Category = "Chat history", FontIcon = "e-clock" }
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
            public string FontIcon { get; set; } = string.Empty;
        }
    }
}