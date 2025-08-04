using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.InteractiveChat;

namespace UI_Blocks.Components.Pages.BlocksSection.AiFloatingWidget.AiFloatingWidget1
{
    public partial class AiFloatingWidget1
    {
        public SfDialog? Dialog;
        public SfAIAssistView? AIAssist;
        public bool IsMobileView = false;
        public bool IsDialogVisible = true;

        public List<AssistViewPrompt> prompts = new List<AssistViewPrompt>
        {
            new AssistViewPrompt { Response = "Hi there. I'm the AI Assistant. How can I help you today?" }
        };

        public async Task PromptRequestAsync(AssistViewPromptRequestedEventArgs args)
        {
            await Task.Delay(1000);
            var defaultResponse = "For real-time prompt processing, connect AI AssistView to your AI service, such as OpenAI or Azure Cognitive Services, using API credentials.";
            args.Response = defaultResponse;
            AIAssist.ScrollToBottomAsync();
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobileView = windowWidth < 640;
                await Dialog.RefreshPositionAsync();
            }
            StateHasChanged();
        }
    }
}
