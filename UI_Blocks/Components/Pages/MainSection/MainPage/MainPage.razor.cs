using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using UI_Blocks.Data;

namespace UI_Blocks.Components.Pages.MainSection.MainPage
{
    public partial class MainPage : ComponentBase, IDisposable
    {
        private List<BlockList> _blockList = new List<BlockList>();
        private DotNetObjectReference<MainPage>? _dotNetRef;

        public int ActiveTabIndex { get; private set; }

        public List<BlockList> CurrentBlocks { get; private set; } = new List<BlockList>();

        public List<string> Tabs { get; } = new List<string> { "Authentication", "Layouts", "E-commerce", "Communication" };

        protected override void OnInitialized()
        {
            ActiveTabIndex = DataService.GetSelectedCategoryIndex();
            _blockList = DataService.GetBlockList();
            UpdateCurrentBlocks();

            _dotNetRef = DotNetObjectReference.Create(this);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                Uri uri = new Uri(NavigationManager.Uri);
                if (!string.IsNullOrEmpty(uri.Fragment))
                {
                    string elementId = uri.Fragment.TrimStart('#');
                    await ScrollToElement(elementId);
                }
            }
        }

        private void UpdateCurrentBlocks()
        {
            if (ActiveTabIndex < Tabs.Count)
            {
                string activeTabTitle = Tabs[ActiveTabIndex];
                CurrentBlocks = _blockList
                    .Where(block => block.Category.Equals(activeTabTitle, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            else
            {
                CurrentBlocks.Clear();
            }
        }

        private void HandleKeyDown(KeyboardEventArgs e, int index)
        {
            if (e.Key == "Enter" || e.Key == " ")
            {
                SelectTab(index);
            }
        }

        private void HandleKeyDown(KeyboardEventArgs e, string url)
        {
            if (e.Key == "Enter" || e.Key == " ")
            {
                NavigateToDemo(url);
            }
        }

        private async Task ScrollToElement(string elementId)
        {
            await JSRuntime.InvokeVoidAsync("scrollToElement", elementId);
        }

        public void NavigateToDemo(string url)
        {
            NavigationManager.NavigateTo($"{NavigationManager.BaseUri}blocks/{url}");
        }

        public void SelectTab(int index)
        {
            if (ActiveTabIndex != index)
            {
                ActiveTabIndex = index;
                DataService.SetSelectedCategoryIndex(index);
                UpdateCurrentBlocks();
            }
        }

        public void Dispose()
        {
            _dotNetRef?.Dispose();
            _dotNetRef = null;
        }
    }
}