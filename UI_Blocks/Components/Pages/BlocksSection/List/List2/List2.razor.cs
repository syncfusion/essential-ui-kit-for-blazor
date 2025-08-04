using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.List.List2
{
    public partial class List2
    {
        public string WidthStyle = "max-width:608px";

        public List<NotificationItem> Notifications = new List<NotificationItem>
        {
            new NotificationItem { Id = 1, Name = "Esther Howard", Content = "New Product Launch: Get 20% Off!", SubContent = "Discover our latest product range and enjoy an exclusive discount for a limited time.", Time = "02:13 PM", Avatar = "avatar-8.jpg", Read = false },
            new NotificationItem { Id = 2, Name = "Jenny Wilson", Content = "Webinar Invite: Boost Your Sales in 2024", SubContent = "Join our free webinar and learn top strategies to enhance your marketing campaigns next year.", Time = "03:15 PM", Avatar = "avatar-9.jpg", Read = false },
            new NotificationItem { Id = 3, Name = "Eleanor Pena", Content = "Limited-Time Offer: Early Access to Premium Features", SubContent = "Be the first to try our premium marketing tools with this exclusive early access offer.", Time = "03:25 PM", Avatar = "avatar-10.jpg", Read = true },
            new NotificationItem { Id = 4, Name = "Brooklyn Simmons", Content = "Unlock Your Marketing Potential with Our New Toolkit", SubContent = "Discover how our comprehensive marketing toolkit can help you optimize campaigns and drive better results.", Time = "04:00 PM", Avatar = "avatar-13.jpg", Read = false },
            new NotificationItem { Id = 5, Name = "Jane Cooper", Content = "Special Event: Meet Us at Marketing Expo 2024", SubContent = "Don't miss our booth at the Marketing Expo—get insights on the latest industry trends.", Time = "04:14 PM", Avatar = "avatar-11.jpg", Read = true },
            new NotificationItem { Id = 6, Name = "Floyd Miles", Content = "Case Study: How XYZ Company Increased ROI by 50%", SubContent = "Explore our latest case study on how targeted marketing helped boost ROI for a leading brand.", Time = "06:12 PM", Avatar = "avatar-2.jpg", Read = true }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                WidthStyle = windowWidth < 1024 ? "width:100%" : "max-width:608px";
            }
            StateHasChanged();
        }

        public class NotificationItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public string SubContent { get; set; } = string.Empty;
            public string Time { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
            public bool Read { get; set; }
        }
    }
}
