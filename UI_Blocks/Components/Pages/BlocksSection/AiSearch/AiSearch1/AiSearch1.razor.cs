using Syncfusion.Blazor.DropDowns;
using Microsoft.JSInterop;
namespace UI_Blocks.Components.Pages.BlocksSection.AiSearch.AiSearch1
{
    public partial class AiSearch1
    {
        public SfAutoComplete<string, string>? Search;
        public string SearchKeyword = "Documentation";
        public string? Width;
       
        public async Task FocusHandlerAsync()
        {
            if (Search != null)
            {
                await Task.Delay(250);
                await Search.ShowPopupAsync();
            }
        }

        public void SearchResult(FilteringEventArgs args)
        {
            SearchKeyword = !string.IsNullOrWhiteSpace(args.Text) ? args.Text.Trim() : "Documentation";
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Search != null)
            {
                Width = windowWidth > 767 ? "max-width:400px" : "width:100%";
                await Search.ShowPopupAsync();
            }
        } 
    }
}