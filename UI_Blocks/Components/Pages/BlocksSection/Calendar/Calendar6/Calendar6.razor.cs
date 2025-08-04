using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.Calendar.Calendar6
{
    public partial class Calendar6
    {
        public bool IsSidebarOpen = true;
        public string SelectedItem = "Holiday";
        public List<string> UniqueMonthsDescription = new();
        public string Width = "310px";
        public List<DropDownMenuItem> MenuItems = new List<DropDownMenuItem>
        {
            new DropDownMenuItem { Text = "Holiday", IconCss = "e-icons e-check" },
            new DropDownMenuItem { Text = "My PTO", IconCss = "" }
        };
        public List<TimelineDay> TimelineData = new List<TimelineDay>
        {
            new TimelineDay { Title = "Labor Day", Description = "Mon, Sep 2" },
            new TimelineDay { Title = "Patriot Day", Description = "Wed, Sep 11" },
            new TimelineDay { Title = "Eid e Milad", Description = "Wed, Sep 16" },
            new TimelineDay { Title = "Columbus Day", Description = "Mon, Oct 14" },
            new TimelineDay { Title = "Halloween", Description = "Thu, Oct 31" },
            new TimelineDay { Title = "Veterans Day", Description = "Mon, Nov 11" },
            new TimelineDay { Title = "Thanksgiving Day", Description = "Thu, Nov 28" },
            new TimelineDay { Title = "Black Friday", Description = "Fri, Nov 29" }
        };

        protected override async Task OnInitializedAsync()
        {
            GetUniqueMonths();
            await Task.CompletedTask;
        }

        public void GetUniqueMonths()
        {
            var months = new HashSet<string>();
            var descriptions = new List<string>();

            foreach (var item in TimelineData)
            {
                var month = GetMonthAbbreviation(item.Description);
                if (months.Add(month))
                {
                    descriptions.Add(item.Description);
                }
            }
            UniqueMonthsDescription = descriptions;
        }

        public void LeaveOptions(MenuEventArgs args)
        {
            SelectedItem = args.Item.Text;
            MenuItems.ForEach(item => item.IconCss = item.Text == SelectedItem ? "e-icons e-check" : "");
        }

        public string GetMonthAbbreviation(string date) => date.Split(", ")[1].Split(" ")[0];

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                Width = windowWidth < 540 ? "100%" : "310px";
            }
            StateHasChanged();
        }

        public class TimelineDay
        {
            public string Title { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
        }
    }
}