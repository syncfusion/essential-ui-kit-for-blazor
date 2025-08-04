using Syncfusion.Blazor.Charts;

namespace UI_Blocks.Components.Pages.BlocksSection.BubbleChart.BubbleChart1
{
    public partial class BubbleChart1
    {
        public string[] ColorPalette = { "#267DDA", "#91BD34", "#D83B01", "#DE4383" };
        
        public void DataLabelEvent(TextRenderEventArgs args)
        {
            args.Font.Color = ColorPalette[args.Point.Index];
        }

        public List<ExpenseCategory> CategoryExpenseData { get; set; } = new List<ExpenseCategory>
        {
            new ExpenseCategory { Id = 1, Literacy = 74, GDPGrowth = 48, Expense = 720, BubbleSize = 15, Category = "Groceries", Color = "#267DDA" },
            new ExpenseCategory { Id = 2, Literacy = 90, GDPGrowth = 32, Expense = 480, BubbleSize = 10, Category = "Food & Drinks", Color = "#91BD34" },
            new ExpenseCategory { Id = 3, Literacy = 91, GDPGrowth = 7, Expense = 195, BubbleSize = 2, Category = "Shopping", Color = "#D83B01" },
            new ExpenseCategory { Id = 4, Literacy = 80, GDPGrowth = 13, Expense = 105, BubbleSize = 8, Category = "Transportation", Color = "#DE4383" }
        };

        public class ExpenseCategory
        {
            public int Id { get; set; }
            public double Literacy { get; set; }
            public double GDPGrowth { get; set; }
            public double BubbleSize { get; set; }
            public double Expense { get; set; }
            public string Category { get; set; } = string.Empty;
            public string Color { get; set; } = string.Empty;
        }
    }
}
