using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.AiSidebar.AiSidebar5
{
    public partial class AiSidebar5
    {
        public bool IsSidebarOpen = true;
        public bool IsBackdropVisible = false;
        public bool IsMobileView = false;

        public List<SearchItem> SearchItems = new List<SearchItem>
        {
            new SearchItem { Title = "Generate 5 attention-grabbing headlines", SubTitle = "Get 5 compelling headlines to make your content stand out." },
            new SearchItem { Title = "Text to emoji", SubTitle = "Convert plain text into expressive emoji-based messages." },
            new SearchItem { Title = "What does a senior lead designer do?", SubTitle = "Understand key qualities and skills valued by senior leaders." },
            new SearchItem { Title = "Article introduction", SubTitle = "Generate a strong and engaging introduction for your article." }
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
    
        public class SearchItem
        {
            public string Title { get; set; } = string.Empty;
            public string SubTitle { get; set; } = string.Empty;
        }
    }
}
