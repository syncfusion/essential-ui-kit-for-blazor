using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.RichTextEditor;

namespace UI_Blocks.Components.Pages.BlocksSection.Modals.Modals9
{
    public partial class Modals9
    {
        public SfDialog? Dialog;
        public SfRichTextEditor? Rte;
        public bool IsMobile;

        public List<ToolbarItemModel> ToolbarItems = new List<ToolbarItemModel>
        {
            new ToolbarItemModel { Command = ToolbarCommand.Bold },
            new ToolbarItemModel { Command = ToolbarCommand.Italic },
            new ToolbarItemModel { Command = ToolbarCommand.Underline },
            new ToolbarItemModel { Command = ToolbarCommand.Separator },
            new ToolbarItemModel { Command = ToolbarCommand.FontName },
            new ToolbarItemModel { Command = ToolbarCommand.Separator },
            new ToolbarItemModel { Command = ToolbarCommand.Alignments },
            new ToolbarItemModel { Command = ToolbarCommand.OrderedList },
            new ToolbarItemModel { Command = ToolbarCommand.UnorderedList }
        };

        public async Task OnDialogOpenAsync(OpenEventArgs args)
        {
            args.PreventFocus = true;

            if (Rte != null)
            {
                await Rte.RefreshUIAsync();
            }
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobile = windowWidth <= 640;
                await Dialog.HideAsync();
                await Dialog.ShowAsync(IsMobile);
            }
        }
    }
}