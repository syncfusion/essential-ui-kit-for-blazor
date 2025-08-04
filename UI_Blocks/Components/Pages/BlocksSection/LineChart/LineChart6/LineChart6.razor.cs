using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.LineChart.LineChart6
{
    public partial class LineChart6
    {
        public SfDropDownButton? DropDownButton;
        public bool IsDropdownOpen = false;
        public string XValue = "80%";
        public string YValue = "68%";
        public List<SplineData> SplineChartData { get; set; } = new();

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                var Data = new List<SplineData>();
                var RandomInterval = new Random();
                for (int i = 0; ; i++)
                {
                    var DateValue = new DateTime(2023, 12, 20).AddDays(i * 10);
                    if (DateValue > new DateTime(2025, 3, 20)) break;
                    Data.Add(new SplineData
                    {
                        XAxis = DateValue,
                        YAxis1 = Math.Round(10000 + RandomInterval.Next(0, 10000) + Math.Sin(i) * 3000),
                        YAxis2 = Math.Round(5000 + RandomInterval.Next(0, 5000) + Math.Cos(i) * 2000)
                    });
                }
                SplineChartData = Data;
                if (IsDropdownOpen && DropDownButton != null)
                {
                    DropDownButton.Toggle();
                }
            }
            StateHasChanged();
        }

        public class SplineData
        {
            public DateTime XAxis { get; set; }
            public double YAxis1 { get; set; }
            public double YAxis2 { get; set; }
        }
    }
}