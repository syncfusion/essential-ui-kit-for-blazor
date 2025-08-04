using Microsoft.JSInterop;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Grids.Internal;

namespace UI_Blocks.Components.Pages.BlocksSection.Search.Search1
{
    public partial class Search1
    {
        public SfAutoComplete<string, SearchItem>? Search;
        public string? Width;
        public List<SearchItem> Data = new List<SearchItem>
        {
            new SearchItem { Id = 1, Category = "Frequently used", Title = "Linear", Text = "Fix login bug", Avatar = new List<string> { "avatar-1.jpg", "avatar-2.jpg", "avatar-3.jpg", "avatar-4.jpg" }, Image = "linear.svg" },
            new SearchItem { Id = 2, Category = "Frequently used", Title = "Zoom", Text = "Team meeting on project planning", Avatar = new List<string> { "avatar-1.jpg", "avatar-2.jpg", "avatar-3.jpg" }, Image = "zoom.svg" },
            new SearchItem { Id = 3, Category = "Frequently used", Title = "GitHub", Text = "Code review for development", Avatar = new List<string> { "avatar-1.jpg", "avatar-2.jpg" }, Image = "github.svg" },
            new SearchItem { Id = 4, Category = "Utilities", Title = "Automations", Text = "Set up automations and shortcuts", Tag = "Automation" },
            new SearchItem { Id = 5, Category = "Utilities", Title = "Log History", Text = "Search and monitor logs and achieved logs", Tag = "Logging" },
            new SearchItem { Id = 6, Category = "Utilities", Title = "Import Integration", Text = "Add a new integration to your organization", Tag = "Integration" }
        };

        public async Task FocusHandlerAsync()
        {
            if (Search != null)
            {
                await Search.ShowPopupAsync();
            }
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Search != null)
            {
                Width= windowWidth > 767 ? "max-width:520px" : "width:100%";
                await Search.ShowPopupAsync();
            }
        }

        public class SearchItem
        {
            public int Id { get; set; }
            public string Category { get; set; } = string.Empty;
            public string Title { get; set; } = string.Empty;
            public string Text { get; set; } = string.Empty;
            public List<string> Avatar { get; set; } = new List<string>();
            public string Image { get; set; } = string.Empty;
            public string Tag { get; set; } = string.Empty;
            private string SearchText { get; set; } = string.Empty;
        }
    }
}
