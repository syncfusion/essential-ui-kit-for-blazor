using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.AreaChart.AreaChart9
{
    public partial class AreaChart9
    {
        public SfChart? Chart;
        public SfDropDownButton? RangeDropdown;
        public double XAxisLabelRotation = 0;
        public bool IsRangeDropdownOpen = false;

        public List<ExpenseData> AreaChartData = new List<ExpenseData>
        {
            new ExpenseData { Month = "Jan", CharleExpense = 250, SteveExpense = 160, PeterExpense = 110, JohnExpense = 80 },
            new ExpenseData { Month = "Feb", CharleExpense = 260, SteveExpense = 130, PeterExpense = 175, JohnExpense = 90 },
            new ExpenseData { Month = "Mar", CharleExpense = 340, SteveExpense = 210, PeterExpense = 140, JohnExpense = 43 },
            new ExpenseData { Month = "Apr", CharleExpense = 245, SteveExpense = 190, PeterExpense = 135, JohnExpense = 78 },
            new ExpenseData { Month = "May", CharleExpense = 350, SteveExpense = 260, PeterExpense = 70, JohnExpense = 11 },
            new ExpenseData { Month = "Jun", CharleExpense = 320, SteveExpense = 240, PeterExpense = 115, JohnExpense = 16 },
            new ExpenseData { Month = "Jul", CharleExpense = 330, SteveExpense = 188, PeterExpense = 195, JohnExpense = 72 },
            new ExpenseData { Month = "Aug", CharleExpense = 320, SteveExpense = 225, PeterExpense = 180, JohnExpense = 72 },
            new ExpenseData { Month = "Sep", CharleExpense = 270, SteveExpense = 220, PeterExpense = 125, JohnExpense = 94 },
            new ExpenseData { Month = "Oct", CharleExpense = 320, SteveExpense = 250, PeterExpense = 220, JohnExpense = 48 },
            new ExpenseData { Month = "Nov", CharleExpense = 310, SteveExpense = 235, PeterExpense = 78, JohnExpense = 94 },
            new ExpenseData { Month = "Dec", CharleExpense = 370, SteveExpense = 270, PeterExpense = 150, JohnExpense = 78 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                XAxisLabelRotation = windowWidth <= 640 ? -90 : 0;
                if (IsRangeDropdownOpen && RangeDropdown != null)
                {
                    RangeDropdown.Toggle();
                }
            }
            StateHasChanged();
        }

        public class ExpenseData
        {
            public string Month { get; set; } = string.Empty;
            public int CharleExpense { get; set; }
            public int SteveExpense { get; set; }
            public int PeterExpense { get; set; }
            public int JohnExpense { get; set; }
        }
    }
}
