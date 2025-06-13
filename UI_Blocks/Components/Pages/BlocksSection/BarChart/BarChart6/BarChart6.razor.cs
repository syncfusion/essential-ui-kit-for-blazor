using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.BarChart.BarChart6
{
    public partial class BarChart6
    {
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;
        public int XAxisLabelRotation = 0;

        public List<TicketActivityData> BarChartData = new List<TicketActivityData>
        {
            new TicketActivityData { Date = "Dec 1", DraftTickets = 27, ProcessedTickets = 15, Country = "Great Britain" },
            new TicketActivityData { Date = "Dec 2", DraftTickets = 20, ProcessedTickets = 9, Country = "China" },
            new TicketActivityData { Date = "Dec 3", DraftTickets = 31, ProcessedTickets = 17, Country = "Australia" },
            new TicketActivityData { Date = "Dec 4", DraftTickets = 13, ProcessedTickets = 8, Country = "Russia" },
            new TicketActivityData { Date = "Dec 5", DraftTickets = 18, ProcessedTickets = 12, Country = "Germany" },
            new TicketActivityData { Date = "Dec 6", DraftTickets = 8, ProcessedTickets = 5, Country = "Ukraine" },
            new TicketActivityData { Date = "Dec 7", DraftTickets = 19, ProcessedTickets = 19, Country = "Spain" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                XAxisLabelRotation = windowWidth < 767 ? -45 : 0;
                if (IsDropdownOpen && DropDownButton != null)
                {
                    DropDownButton.Toggle();
                }
            }
            StateHasChanged();
        }

        public class TicketActivityData
        {
            public string Date { get; set; } = string.Empty;
            public int DraftTickets { get; set; }
            public int ProcessedTickets { get; set; }
            public string Country { get; set; } = string.Empty;
        }
    }
}
