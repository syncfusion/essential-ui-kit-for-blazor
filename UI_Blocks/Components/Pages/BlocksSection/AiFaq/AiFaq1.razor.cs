using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.AiFaq
{
    public partial class AiFaq1
    {
        public SfAccordion? Accordion;

        public List<FaqItem> FAQData = new List<FaqItem>
        {
            new FaqItem { Id = 1, Question = "What do we do?", Answer = "We are designed to assist you with [specific tasks or functions], provide information, and enhance your overall experience by offering support through conversational interactions." },
            new FaqItem { Id = 2, Question = "How do I get started with Fusion AI?", Answer = "To get started with Fusion AI, sign up for an account on our website. Once registered, follow the onboarding guide to set up your workspace, connect your tools, and explore the dashboard." },
            new FaqItem { Id = 3, Question = "How do I install Fusion AI?", Answer = "Fusion AI is a cloud-based platform, so no installation is required. Simply log in through your browser. For integrations, follow the setup instructions in the \"Integrations\" tab." },
            new FaqItem { Id = 4, Question = "What is the messenger in Fusion AI?", Answer = "The messenger is a real-time communication tool that allows you to chat with customers, team members, or support agents directly within the platform." },
            new FaqItem { Id = 5, Question = "What is the next-gen inbox?", Answer = "The next-gen inbox consolidates all your messages, tickets, and notifications into a single, streamlined interface, making it easier to manage conversations and tasks." },
            new FaqItem { Id = 6, Question = "How do tickets work?", Answer = "Tickets are used to track customer issues or internal tasks. You can create, assign, prioritize, and resolve tickets through the support dashboard." },
            new FaqItem { Id = 7, Question = "How does support work?", Answer = "Fusion AI offers 24/7 support through live chat, email, and a comprehensive help center. You can also submit tickets for more complex issues." },
            new FaqItem { Id = 8, Question = "How does billing work?", Answer = "Billing is handled monthly or annually based on your subscription plan. You can view invoices, update payment methods, and manage your plan in the billing section." },
            new FaqItem { Id = 9, Question = "How do I cancel my subscription?", Answer = "To cancel your subscription, go to the billing settings and click on \"Cancel Plan.\" Your access will remain active until the end of the billing cycle." },
            new FaqItem { Id = 10, Question = "How do I integrate this with other tools?", Answer = "Fusion AI supports integrations with popular tools like Slack, Zapier, and CRMs. Visit the \"Integrations\" page to connect and configure them." },
            new FaqItem { Id = 11, Question = "What are the pricing plans for the Fusion AI?", Answer = "We offer flexible pricing plans including Free, Pro, and Enterprise tiers. Each plan comes with different features and usage limits. Visit our pricing page for full details." }
        };

        public class FaqItem
        {
            public int Id { get; set; }
            public string Question { get; set; }
            public string Answer { get; set; }
        }
    }
}
