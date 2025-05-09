using Syncfusion.Blazor.DropDowns;
using Microsoft.JSInterop;
namespace UI_Blocks.Components.Pages.BlocksSection.Search.Search4
{
    public partial class Search4
    {
        private SfAutoComplete<string, SearchItem>? Search;
        public string? Width;
        private List<SearchItem> Data = new List<SearchItem>()
        {
            new () { Id = 1, Name = "Mark Johnson", Initial = "MJ", EmailId = "mark.johnson@example.com", ColorTheme = "Orange",},
            new () { Id = 2, Name = "Emily White", Initial = "EW", EmailId = "emily.white@example.com", ColorTheme = "Blue",},
            new () { Id = 3, Name = "Tom Harris", Initial = "TH", EmailId = "tom.harris@example.com", ColorTheme = "Blue",},
            new () {  Id = 4,Name = "Lisa Green", Initial = "LG",EmailId = "lisa.green@example.com",ColorTheme = "Orange",},
            new () {  Id = 5, Name = "David Clark", Initial = "DC",  EmailId = "david.clark@example.com", ColorTheme = "Red",},
            new () { Id = 6,  Name = "Rachel Lee", Initial = "RL",EmailId = "rachel.lee@example.com", ColorTheme = "Blue",},
        };

        private async Task FocusHandlerAsync()
        {
            if (Search != null)
            {
                await Task.Delay(250);
                await Search.ShowPopupAsync();
            }
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Search != null)
            {
                Width = windowWidth < 767 ? "max-width:480px" : "width:100%";
                await Search.ShowPopupAsync();
            }
        }
        
        public class SearchItem
        {
            public int Id { get; set; }
            public string? Name { get; set; } = string.Empty;
            public string? Initial { get; set; } = string.Empty;
            public string? EmailId { get; set; } = string.Empty;
            public string? ColorTheme { get; set; } = string.Empty;

        }
    }
}
