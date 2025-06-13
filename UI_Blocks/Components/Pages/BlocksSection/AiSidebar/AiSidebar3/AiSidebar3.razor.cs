using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.AiSidebar.AiSidebar3
{
    public partial class AiSidebar3
    {
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;
        public bool IsMobileView = false;
        public string Width = "304px";
        public string DockWidth = "48px";
  
        public List<ChatItem> ChatHistory = new List<ChatItem>
        {
            new ChatItem { Message = "CSS classes", Date = "12 Mar" },
            new ChatItem { Message = "Explain quantum computing", Date = "10 Feb" },
            new ChatItem { Message = "How to create ERP diagram?", Date = "22 Jan" },
            new ChatItem { Message = "API scaling strategies", Date = "1 Jan" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                IsBackdropVisible = windowWidth <= 660;
                IsMobileView = IsBackdropVisible;
                Width = windowWidth <= 768 ? "312px" : "304px";
                DockWidth = windowWidth <= 768 ? "56px" : "48px";
            }
            StateHasChanged();
        }

        public class ChatItem
        {
            public string Message { get; set; } = string.Empty;
            public string Date { get; set; } = string.Empty;
        }
    }
}
