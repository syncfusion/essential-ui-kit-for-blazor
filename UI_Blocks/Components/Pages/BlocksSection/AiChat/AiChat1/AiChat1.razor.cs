using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.AiChat.AiChat1
{
    public partial class AiChat1
    {
        public List<PromptData> PromptDetail = new List<PromptData>
        {
            new PromptData { Id = 1, Text = "Suggest 3 websites about ethical hacking", Category = "sender", IsList = false },
            new PromptData { Id = 2, Category = "reply", IsList = true }
        };

        public List<ResourceData> ResourceDetail = new List<ResourceData>
        {
            new ResourceData { Type = "Header", Text = "Here are four websites where you can improve your ethical hacking skills:" },
            new ResourceData { Type = "Resource", Text = "Cybrary (cybrary.it):", Description = "Cybrary offers a wide range of free and paid courses on cybersecurity, including ethical hacking. There are beginner to advanced level courses that cover various aspects of cybersecurity, including penetration testing and threat intelligence." },
            new ResourceData { Type = "Resource", Text = "Hack The Box (hackthebox.eu):", Description = "Hack The Box is an online platform that allows you to practice penetration testing and improve your hacking skills through challenges and labs. It's a great way to learn by doing, and you can interact with a large community of ethical hackers." },
            new ResourceData { Type = "Resource", Text = "Offensive Security (offensive-security.com):", Description = "Known for their OSCP (Offensive Security Certified Professional) certification, Offensive Security provides high-quality training for ethical hackers. Their courses are comprehensive and widely recognized in the industry." }
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
            public string Text { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
            public bool IsList { get; set; }
        }

        public class ResourceData
        {
            public string Type { get; set; } = string.Empty;
            public string Text { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
        }
    }
}
