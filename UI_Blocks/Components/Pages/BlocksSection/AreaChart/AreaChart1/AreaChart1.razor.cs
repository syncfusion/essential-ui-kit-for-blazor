namespace UI_Blocks.Components.Pages.BlocksSection.AreaChart.AreaChart1
{
    public partial class AreaChart1
    {
        public List<AreaData> FinancialData = new List<AreaData>
        {
            new AreaData { Day = "Mon", Revenue = 8000, Expense = 6000 },
            new AreaData { Day = "Tue", Revenue = 12000 , Expense = 10000 },
            new AreaData { Day = "Wed", Revenue = 12000 , Expense = 22000 },
            new AreaData { Day = "Thu", Revenue = 18000, Expense = 20000 },
            new AreaData { Day = "Fri", Revenue = 20000, Expense = 20000 },
            new AreaData { Day = "Sat", Revenue = 26000, Expense = 12000 },
            new AreaData { Day = "Sun", Revenue = 25000, Expense = 14000 }
        };

        public class AreaData
        {
            public string Day { get; set; } = string.Empty;
            public double Revenue { get; set; }
            public double Expense { get; set; }
        }
    }
}
