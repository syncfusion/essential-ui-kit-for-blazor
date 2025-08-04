using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.AiChat.AiChat2
{
    public partial class AiChat2
    {
        public List<PromptData> PromptDetail = new List<PromptData>
        {
            new PromptData { Id = 1, Name = "You", Time = "20m", Text = "Make a description about this picture", Category = "sender", IsList = false },
            new PromptData { Id = 2, Category = "reply", IsList = true }
        };

        public List<ResourceData> ResourceDetail = new List<ResourceData>
        {
            new ResourceData
            {
                Text = "Visual AI Chat Interface",
                Description = "The image shows a person using a virtual reality viewer made of cardboard, possibly Google Cardboard, while standing indoors. They are facing a framed poster on the wall, which features a minimalist illustration of what appears to be a coffee-making process. The person's hair and sweater are visible, and they are positioned near a window, suggesting natural light in the room."
            }
        };

        /* SB Code - Start */
        [JSInvokable]
        public void ResizeHandler(string message)
        {
            if (message == "resizeAction")
            {
                StateHasChanged();
            }
        }
        /* SB Code - End */

        public class PromptData
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Time { get; set; } = string.Empty;
            public string Text { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
            public bool IsList { get; set; }
        }

        public class ResourceData
        {
            public string Text { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
        }
    }
}
