using Microsoft.AspNetCore.Components;
using UI_Blocks.Data;

namespace UI_Blocks.Components.Pages.MainSection
{
    public partial class Blocks : ComponentBase
    {
        [Parameter]
        public string BlockName { get; set; } = string.Empty;
        public BlockList CurrentBlock { get; set; } = new BlockList();
        public List<Block> SamplesList { get; set; } = new List<Block>();

        protected override void OnParametersSet()
        {
            LoadBlockDetails();
        }

        private void NavigateToMainPage()
        {
            NavigationManager.NavigateTo($"{NavigationManager.BaseUri}blocks#block-tab");
        }

        private void LoadBlockDetails()
        {
            List<BlockList> blockList = DataService.GetBlockList();
            CurrentBlock = blockList.FirstOrDefault(block => block.Url == BlockName) ?? new BlockList();
            SamplesList = CurrentBlock.SubBlockList ?? new List<Block>();
        }
    }
}