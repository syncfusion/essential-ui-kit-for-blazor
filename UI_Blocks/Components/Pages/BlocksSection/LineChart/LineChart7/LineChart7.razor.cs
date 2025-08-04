using Microsoft.JSInterop;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.LineChart.LineChart7
{
    public partial class LineChart7
    {
        public SfChart? Chart;
        public SfDropDownButton? ChartOptions;
        public SfDropDownButton? PeriodOptions;
        public bool IsChartDropdownOpen = false;
        public bool IsPeriodDropdownOpen = false;

        public List<StockData> StockPerformanceData = new List<StockData>
        {
            new StockData { Date = new DateTime(2023,01,18), Low = 275.33, Open = 275.10, High = 275.83, Close = 275.81, Volume = 30741 },
            new StockData { Date = new DateTime(2023,01,19), Low = 275.33, Open = 275.31, High = 275.83, Close = 275.77, Volume = 46879 },
            new StockData { Date = new DateTime(2023,01,20), Low = 275.33, Open = 275.32, High = 275.83, Close = 275.72, Volume = 20833 },
            new StockData { Date = new DateTime(2023,01,21), Low = 275.34, Open = 275.97, High = 275.83, Close = 275.89, Volume = 11141 },
            new StockData { Date = new DateTime(2023,01,22), Low = 275.34, Open = 275.93, High = 275.84, Close = 275.84, Volume = 40384 },
            new StockData { Date = new DateTime(2023,01,23), Low = 275.34, Open = 275.63, High = 275.84, Close = 275.63, Volume = 45120 },
            new StockData { Date = new DateTime(2023,01,24), Low = 275.35, Open = 275.47, High = 275.84, Close = 275.93, Volume = 39202 },
            new StockData { Date = new DateTime(2023,01,25), Low = 275.34, Open = 275.48, High = 275.84, Close = 275.92, Volume = 49759 },
            new StockData { Date = new DateTime(2023,01,26), Low = 275.34, Open = 275.40, High = 275.84, Close = 275.92, Volume = 10490 },
            new StockData { Date = new DateTime(2023,01,27), Low = 275.34, Open = 275.32, High = 275.84, Close = 275.67, Volume = 34241 },
            new StockData { Date = new DateTime(2023,01,28), Low = 275.34, Open = 275.35, High = 275.84, Close = 275.64, Volume = 10482 },
            new StockData { Date = new DateTime(2023,02,01), Low = 275.34, Open = 275.20, High = 275.83, Close = 275.41, Volume = 31460 },
            new StockData { Date = new DateTime(2023,02,02), Low = 275.34, Open = 275.70, High = 275.84, Close = 275.34, Volume = 25901 },
            new StockData { Date = new DateTime(2023,02,03), Low = 275.34, Open = 275.85, High = 275.83, Close = 274.71, Volume = 46065 },
            new StockData { Date = new DateTime(2023,02,04), Low = 275.34, Open = 275.84, High = 275.83, Close = 274.71, Volume = 12459 },
            new StockData { Date = new DateTime(2023,02,05), Low = 275.34, Open = 275.02, High = 275.84, Close = 274.74, Volume = 13484 },
            new StockData { Date = new DateTime(2023,02,06), Low = 275.34, Open = 275.99, High = 275.83, Close = 274.85, Volume = 20799 },
            new StockData { Date = new DateTime(2023,02,07), Low = 275.35, Open = 275.38, High = 275.84, Close = 275.07, Volume = 28706 },
            new StockData { Date = new DateTime(2023,02,08), Low = 275.35, Open = 275.24, High = 275.84, Close = 274.96, Volume = 42325 },
            new StockData { Date = new DateTime(2023,02,09), Low = 275.35, Open = 275.41, High = 275.84, Close = 275.01, Volume = 46607 },
            new StockData { Date = new DateTime(2023,02,10), Low = 275.34, Open = 275.00, High = 275.83, Close = 275.01, Volume = 24645 },
            new StockData { Date = new DateTime(2023,02,11), Low = 275.34, Open = 275.99, High = 275.83, Close = 274.96, Volume = 25885 },
            new StockData { Date = new DateTime(2023,02,12), Low = 275.34, Open = 275.98, High = 275.83, Close = 275.01, Volume = 14780 },
            new StockData { Date = new DateTime(2023,02,13), Low = 275.34, Open = 275.12, High = 275.83, Close = 275.42, Volume = 48208 },
            new StockData { Date = new DateTime(2023,02,14), Low = 275.34, Open = 275.40, High = 275.83, Close = 275.30, Volume = 35457 },
            new StockData { Date = new DateTime(2023,02,15), Low = 275.35, Open = 275.94, High = 275.84, Close = 275.71, Volume = 38966 },
            new StockData { Date = new DateTime(2023,02,16), Low = 275.34, Open = 275.38, High = 275.84, Close = 275.64, Volume = 36798 },
            new StockData { Date = new DateTime(2023,02,17), Low = 275.34, Open = 275.84, High = 275.83, Close = 275.53, Volume = 19840 },
            new StockData { Date = new DateTime(2023,02,18), Low = 275.34, Open = 275.85, High = 275.82, Close = 275.53, Volume = 27074 },
            new StockData { Date = new DateTime(2023,02,19), Low = 275.34, Open = 275.29, High = 275.83, Close = 275.54, Volume = 36860 },
            new StockData { Date = new DateTime(2023,02,20), Low = 275.33, Open = 275.40, High = 275.83, Close = 275.52, Volume = 20279 },
            new StockData { Date = new DateTime(2023,02,21), Low = 275.33, Open = 275.36, High = 275.82, Close = 275.66, Volume = 21891 },
            new StockData { Date = new DateTime(2023,02,22), Low = 275.32, Open = 275.18, High = 275.82, Close = 275.52, Volume = 36595 },
            new StockData { Date = new DateTime(2023,02,23), Low = 275.32, Open = 275.80, High = 275.82, Close = 275.25, Volume = 16506 },
            new StockData { Date = new DateTime(2023,02,24), Low = 275.33, Open = 275.75, High = 275.82, Close = 275.34, Volume = 16431 },
            new StockData { Date = new DateTime(2023,02,25), Low = 275.33, Open = 275.75, High = 275.82, Close = 275.34, Volume = 16903 },
            new StockData { Date = new DateTime(2023,02,26), Low = 275.33, Open = 275.79, High = 275.82, Close = 275.34, Volume = 16537 },
            new StockData { Date = new DateTime(2023,02,27), Low = 275.33, Open = 275.48, High = 275.82, Close = 275.24, Volume = 45484 },
            new StockData { Date = new DateTime(2023,02,28), Low = 275.32, Open = 275.85, High = 275.82, Close = 275.16, Volume = 29762 },
            new StockData { Date = new DateTime(2023,03,01), Low = 275.33, Open = 275.77, High = 275.82, Close = 275.18, Volume = 48674 },
            new StockData { Date = new DateTime(2023,03,02), Low = 275.33, Open = 275.26, High = 275.82, Close = 275.20, Volume = 24469 },
            new StockData { Date = new DateTime(2023,03,03), Low = 275.32, Open = 275.34, High = 275.81, Close = 275.14, Volume = 15025 },
            new StockData { Date = new DateTime(2023,03,04), Low = 275.32, Open = 275.68, High = 275.81, Close = 275.13, Volume = 11960 },
            new StockData { Date = new DateTime(2023,03,05), Low = 275.32, Open = 275.12, High = 275.81, Close = 274.96, Volume = 41237 },
            new StockData { Date = new DateTime(2023,03,06), Low = 275.33, Open = 275.84, High = 275.81, Close = 274.82, Volume = 33241 },
            new StockData { Date = new DateTime(2023,03,07), Low = 275.33, Open = 275.15, High = 275.80, Close = 274.87, Volume = 49667 },
            new StockData { Date = new DateTime(2023,03,08), Low = 275.32, Open = 275.15, High = 275.80, Close = 274.84, Volume = 19022 },
            new StockData { Date = new DateTime(2023,03,09), Low = 275.32, Open = 275.15, High = 275.80, Close = 274.84, Volume = 15162 },
            new StockData { Date = new DateTime(2023,03,10), Low = 275.33, Open = 275.54, High = 275.82, Close = 274.97, Volume = 48516 },
            new StockData { Date = new DateTime(2023,03,11), Low = 275.33, Open = 275.62, High = 275.81, Close = 275.07, Volume = 19327 },
            new StockData { Date = new DateTime(2023,03,12), Low = 275.32, Open = 275.07, High = 275.80, Close = 274.95, Volume = 23474 },
            new StockData { Date = new DateTime(2023,03,13), Low = 275.32, Open = 275.59, High = 275.80, Close = 274.69, Volume = 49687 },
            new StockData { Date = new DateTime(2023,03,14), Low = 275.33, Open = 275.83, High = 275.80, Close = 274.85, Volume = 36322 },
            new StockData { Date = new DateTime(2023,03,15), Low = 275.33, Open = 275.81, High = 275.80, Close = 274.84, Volume = 14343 },
            new StockData { Date = new DateTime(2023,03,16), Low = 275.33, Open = 275.91, High = 275.81, Close = 274.85, Volume = 11980 },
            new StockData { Date = new DateTime(2023,03,17), Low = 275.33, Open = 275.46, High = 275.81, Close = 275.00, Volume = 21441 },
            new StockData { Date = new DateTime(2023,03,18), Low = 275.33, Open = 275.05, High = 275.81, Close = 275.10, Volume = 31703 },
            new StockData { Date = new DateTime(2023,03,19), Low = 275.33, Open = 275.73, High = 275.81, Close = 275.33, Volume = 37935 },
            new StockData { Date = new DateTime(2023,03,20), Low = 275.33, Open = 275.18, High = 275.81, Close = 275.15, Volume = 15153 },
            new StockData { Date = new DateTime(2023,03,21), Low = 275.33, Open = 275.16, High = 275.80, Close = 275.04, Volume = 27191 },
            new StockData { Date = new DateTime(2023,03,22), Low = 275.33, Open = 275.16, High = 275.80, Close = 275.04, Volume = 35402 },
            new StockData { Date = new DateTime(2023,03,23), Low = 275.33, Open = 275.09, High = 275.80, Close = 275.03, Volume = 15238 },
            new StockData { Date = new DateTime(2023,03,24), Low = 275.33, Open = 275.12, High = 275.80, Close = 274.85, Volume = 40675 },
            new StockData { Date = new DateTime(2023,03,25), Low = 275.33, Open = 275.72, High = 275.81, Close = 274.97, Volume = 14130 },
            new StockData { Date = new DateTime(2023,03,26), Low = 275.33, Open = 275.58, High = 275.80, Close = 274.74, Volume = 28575 },
            new StockData { Date = new DateTime(2023,03,27), Low = 275.33, Open = 275.90, High = 275.80, Close = 274.71, Volume = 32886 },
            new StockData { Date = new DateTime(2023,03,28), Low = 275.33, Open = 275.31, High = 275.81, Close = 274.74, Volume = 22233 },
            new StockData { Date = new DateTime(2023,03,29), Low = 275.33, Open = 275.32, High = 275.81, Close = 274.74, Volume = 41203 },
            new StockData { Date = new DateTime(2023,03,30), Low = 275.33, Open = 275.24, High = 275.81, Close = 274.76, Volume = 33356 },
            new StockData { Date = new DateTime(2023,04,01), Low = 275.33, Open = 275.45, High = 275.81, Close = 274.78, Volume = 49517 },
            new StockData { Date = new DateTime(2023,04,02), Low = 275.33, Open = 275.52, High = 275.81, Close = 274.77, Volume = 13498 },
            new StockData { Date = new DateTime(2023,04,03), Low = 275.33, Open = 275.61, High = 275.81, Close = 274.80, Volume = 20274 },
            new StockData { Date = new DateTime(2023,04,04), Low = 275.32, Open = 275.29, High = 275.81, Close = 274.69, Volume = 17438 },
            new StockData { Date = new DateTime(2023,04,05), Low = 275.32, Open = 275.84, High = 275.81, Close = 274.73, Volume = 32034 },
            new StockData { Date = new DateTime(2023,04,06), Low = 275.32, Open = 275.83, High = 275.81, Close = 274.73, Volume = 46531 },
            new StockData { Date = new DateTime(2023,04,07), Low = 275.32, Open = 275.04, High = 275.80, Close = 274.72, Volume = 45832 },
            new StockData { Date = new DateTime(2023,04,08), Low = 275.32, Open = 275.01, High = 275.80, Close = 274.78, Volume = 12374 },
            new StockData { Date = new DateTime(2023,04,09), Low = 275.32, Open = 275.20, High = 275.81, Close = 275.10, Volume = 40808 },
            new StockData { Date = new DateTime(2023,04,10), Low = 275.32, Open = 275.20, High = 275.81, Close = 274.91, Volume = 17982 },
            new StockData { Date = new DateTime(2023,04,11), Low = 275.33, Open = 275.52, High = 275.81, Close = 275.09, Volume = 49175 },
            new StockData { Date = new DateTime(2023,04,12), Low = 275.33, Open = 275.75, High = 275.81, Close = 275.25, Volume = 27041 },
            new StockData { Date = new DateTime(2023,04,13), Low = 275.33, Open = 275.73, High = 275.81, Close = 275.19, Volume = 24036 },
            new StockData { Date = new DateTime(2023,04,14), Low = 275.33, Open = 275.78, High = 275.82, Close = 275.22, Volume = 31023 },
            new StockData { Date = new DateTime(2023,04,15), Low = 275.33, Open = 275.02, High = 275.81, Close = 275.27, Volume = 18062 },
            new StockData { Date = new DateTime(2023,04,16), Low = 275.34, Open = 275.39, High = 275.82, Close = 275.29, Volume = 15390 },
            new StockData { Date = new DateTime(2023,04,17), Low = 275.34, Open = 275.59, High = 275.82, Close = 275.45, Volume = 29951 },
            new StockData { Date = new DateTime(2023,04,18), Low = 275.34, Open = 275.65, High = 275.82, Close = 275.72, Volume = 18436 },
            new StockData { Date = new DateTime(2023,04,19), Low = 275.34, Open = 275.97, High = 275.82, Close = 275.84, Volume = 14916 },
            new StockData { Date = new DateTime(2023,04,20), Low = 275.34, Open = 275.97, High = 275.82, Close = 275.84, Volume = 19245 },
            new StockData { Date = new DateTime(2023,04,21), Low = 275.34, Open = 275.66, High = 275.82, Close = 275.88, Volume = 40550 },
            new StockData { Date = new DateTime(2023,04,22), Low = 275.34, Open = 275.57, High = 275.82, Close = 275.82, Volume = 36940 },
            new StockData { Date = new DateTime(2023,04,23), Low = 275.34, Open = 275.53, High = 275.82, Close = 275.89, Volume = 27476 },
            new StockData { Date = new DateTime(2023,04,24), Low = 275.34, Open = 275.22, High = 275.82, Close = 275.70, Volume = 21195 },
            new StockData { Date = new DateTime(2023,04,25), Low = 275.35, Open = 275.94, High = 275.83, Close = 275.73, Volume = 10546 },
            new StockData { Date = new DateTime(2023,04,26), Low = 275.35, Open = 275.66, High = 275.83, Close = 275.56, Volume = 27942 },
            new StockData { Date = new DateTime(2023,04,27), Low = 275.35, Open = 275.66, High = 275.83, Close = 275.56, Volume = 41330 },
            new StockData { Date = new DateTime(2023,04,28), Low = 275.35, Open = 275.78, High = 275.83, Close = 275.56, Volume = 47065 },
            new StockData { Date = new DateTime(2023,04,29), Low = 275.35, Open = 275.49, High = 275.83, Close = 275.58, Volume = 39847 },
            new StockData { Date = new DateTime(2023,04,30), Low = 275.35, Open = 275.76, High = 275.83, Close = 275.68, Volume = 47693 },
            new StockData { Date = new DateTime(2023,05,01), Low = 275.34, Open = 275.77, High = 275.82, Close = 275.28, Volume = 19808 },
            new StockData { Date = new DateTime(2023,05,02), Low = 275.35, Open = 275.95, High = 275.83, Close = 275.40, Volume = 49959 },
            new StockData { Date = new DateTime(2023,05,03), Low = 275.35, Open = 275.96, High = 275.83, Close = 275.40, Volume = 47409 },
            new StockData { Date = new DateTime(2023,05,04), Low = 275.35, Open = 275.06, High = 275.83, Close = 275.40, Volume = 32494 },
            new StockData { Date = new DateTime(2023,05,05), Low = 275.34, Open = 275.46, High = 275.83, Close = 275.50, Volume = 43152 },
            new StockData { Date = new DateTime(2023,05,06), Low = 275.34, Open = 275.61, High = 275.83, Close = 275.52, Volume = 19889 },
            new StockData { Date = new DateTime(2023,05,07), Low = 275.34, Open = 275.03, High = 275.83, Close = 275.62, Volume = 29138 },
            new StockData { Date = new DateTime(2023,05,08), Low = 275.34, Open = 275.90, High = 275.82, Close = 275.48, Volume = 47768 },
            new StockData { Date = new DateTime(2023,05,09), Low = 275.34, Open = 275.40, High = 275.83, Close = 275.42, Volume = 31394 },
            new StockData { Date = new DateTime(2023,05,10), Low = 275.34, Open = 275.39, High = 275.82, Close = 275.42, Volume = 35510 },
            new StockData { Date = new DateTime(2023,05,11), Low = 275.34, Open = 275.43, High = 275.83, Close = 275.43, Volume = 35281 },
            new StockData { Date = new DateTime(2023,05,12), Low = 275.34, Open = 275.56, High = 275.82, Close = 275.32, Volume = 36620 },
            new StockData { Date = new DateTime(2023,05,13), Low = 275.34, Open = 275.14, High = 275.82, Close = 275.29, Volume = 28713 },
            new StockData { Date = new DateTime(2023,05,14), Low = 275.34, Open = 275.06, High = 275.82, Close = 275.04, Volume = 46038 },
            new StockData { Date = new DateTime(2023,05,15), Low = 275.33, Open = 275.18, High = 275.81, Close = 274.91, Volume = 10683 },
            new StockData { Date = new DateTime(2023,05,16), Low = 275.34, Open = 275.83, High = 275.81, Close = 274.90, Volume = 27852 },
            new StockData { Date = new DateTime(2023,05,17), Low = 275.34, Open = 275.83, High = 275.81, Close = 274.90, Volume = 48763 },
            new StockData { Date = new DateTime(2023,05,18), Low = 275.33, Open = 275.89, High = 275.81, Close = 274.91, Volume = 47953 },
            new StockData { Date = new DateTime(2023,05,19), Low = 275.34, Open = 275.92, High = 275.81, Close = 274.98, Volume = 11303 },
            new StockData { Date = new DateTime(2023,05,20), Low = 275.34, Open = 275.36, High = 275.81, Close = 274.99, Volume = 13657 },
            new StockData { Date = new DateTime(2023,05,21), Low = 275.34, Open = 275.72, High = 275.81, Close = 274.94, Volume = 41692 },
            new StockData { Date = new DateTime(2023,05,22), Low = 275.34, Open = 275.06, High = 275.81, Close = 274.90, Volume = 27070 },
            new StockData { Date = new DateTime(2023,05,23), Low = 275.35, Open = 275.72, High = 275.81, Close = 274.97, Volume = 42111 },
            new StockData { Date = new DateTime(2023,05,24), Low = 275.35, Open = 275.69, High = 275.81, Close = 274.98, Volume = 10972 },
            new StockData { Date = new DateTime(2023,05,25), Low = 275.35, Open = 275.46, High = 275.81, Close = 274.96, Volume = 20666 },
            new StockData { Date = new DateTime(2023,05,26), Low = 275.35, Open = 275.43, High = 275.81, Close = 275.00, Volume = 30277 },
            new StockData { Date = new DateTime(2023,05,27), Low = 275.34, Open = 275.97, High = 275.81, Close = 275.00, Volume = 12143 },
            new StockData { Date = new DateTime(2023,05,28), Low = 275.35, Open = 275.35, High = 275.81, Close = 275.02, Volume = 26277 },
            new StockData { Date = new DateTime(2023,05,29), Low = 275.35, Open = 275.77, High = 275.82, Close = 275.07, Volume = 33451 },
            new StockData { Date = new DateTime(2023,05,30), Low = 275.35, Open = 275.31, High = 275.81, Close = 275.09, Volume = 11001 },
            new StockData { Date = new DateTime(2023,05,31), Low = 275.35, Open = 275.18, High = 275.81, Close = 275.06, Volume = 43511 },
            new StockData { Date = new DateTime(2023,06,01), Low = 275.35, Open = 275.34, High = 275.81, Close = 275.09, Volume = 19770 },
            new StockData { Date = new DateTime(2023,06,02), Low = 275.35, Open = 275.33, High = 275.81, Close = 275.09, Volume = 47184 },
            new StockData { Date = new DateTime(2023,06,03), Low = 275.35, Open = 275.67, High = 275.81, Close = 274.96, Volume = 27080 },
            new StockData { Date = new DateTime(2023,06,04), Low = 275.34, Open = 275.46, High = 275.81, Close = 275.00, Volume = 49628 },
            new StockData { Date = new DateTime(2023,06,05), Low = 275.35, Open = 275.54, High = 275.82, Close = 275.39, Volume = 40620 },
            new StockData { Date = new DateTime(2023,06,06), Low = 275.35, Open = 275.05, High = 275.81, Close = 275.77, Volume = 21661 },
            new StockData { Date = new DateTime(2023,06,07), Low = 275.35, Open = 275.09, High = 275.81, Close = 275.65, Volume = 35499 },
            new StockData { Date = new DateTime(2023,06,08), Low = 275.34, Open = 275.11, High = 275.81, Close = 275.64, Volume = 39051 },
            new StockData { Date = new DateTime(2023,06,09), Low = 275.34, Open = 275.18, High = 275.81, Close = 275.62, Volume = 41517 },
            new StockData { Date = new DateTime(2023,06,10), Low = 275.34, Open = 275.31, High = 275.80, Close = 275.53, Volume = 10218 },
            new StockData { Date = new DateTime(2023,06,11), Low = 275.34, Open = 275.22, High = 275.80, Close = 275.38, Volume = 11291 },
            new StockData { Date = new DateTime(2023,06,12), Low = 275.33, Open = 275.38, High = 275.81, Close = 274.97, Volume = 34724 },
            new StockData { Date = new DateTime(2023,06,13), Low = 275.32, Open = 275.22, High = 275.81, Close = 275.03, Volume = 27170 },
            new StockData { Date = new DateTime(2023,06,14), Low = 275.32, Open = 275.69, High = 275.81, Close = 275.13, Volume = 26901 },
            new StockData { Date = new DateTime(2023,06,15), Low = 275.32, Open = 275.69, High = 275.81, Close = 275.11, Volume = 22757 },
            new StockData { Date = new DateTime(2023,06,16), Low = 275.32, Open = 275.76, High = 275.81, Close = 275.07, Volume = 41677 },
            new StockData { Date = new DateTime(2023,06,17), Low = 275.32, Open = 275.71, High = 275.81, Close = 275.05, Volume = 33741 },
            new StockData { Date = new DateTime(2023,06,18), Low = 275.32, Open = 275.94, High = 275.81, Close = 275.07, Volume = 35768 },
            new StockData { Date = new DateTime(2023,06,19), Low = 275.32, Open = 275.62, High = 275.81, Close = 275.06, Volume = 11646 },
            new StockData { Date = new DateTime(2023,06,20), Low = 275.32, Open = 275.98, High = 275.81, Close = 275.08, Volume = 33972 },
            new StockData { Date = new DateTime(2023,06,21), Low = 275.33, Open = 275.78, High = 275.81, Close = 275.00, Volume = 43149 },
            new StockData { Date = new DateTime(2023,06,22), Low = 275.33, Open = 275.78, High = 275.81, Close = 275.00, Volume = 18141 },
            new StockData { Date = new DateTime(2023,06,23), Low = 275.33, Open = 275.75, High = 275.81, Close = 275.00, Volume = 15363 },
            new StockData { Date = new DateTime(2023,06,24), Low = 275.33, Open = 275.51, High = 275.80, Close = 274.81, Volume = 19602 },
            new StockData { Date = new DateTime(2023,06,25), Low = 275.32, Open = 275.92, High = 275.80, Close = 274.95, Volume = 33355 },
            new StockData { Date = new DateTime(2023,06,26), Low = 275.32, Open = 275.41, High = 275.80, Close = 274.97, Volume = 41722 },
            new StockData { Date = new DateTime(2023,06,27), Low = 275.33, Open = 275.18, High = 275.81, Close = 275.37, Volume = 47205 },
            new StockData { Date = new DateTime(2023,06,28), Low = 275.33, Open = 275.15, High = 275.80, Close = 275.26, Volume = 15032 },
            new StockData { Date = new DateTime(2023,06,29), Low = 275.33, Open = 275.15, High = 275.80, Close = 275.26, Volume = 41561 },
            new StockData { Date = new DateTime(2023,06,30), Low = 275.33, Open = 275.93, High = 275.80, Close = 275.26, Volume = 15001 }
        };
        
        public void TooltipRender(TooltipRenderEventArgs args)
        {
            var data = StockPerformanceData[(int)args.Data.PointIndex];
            args.Text = $"Date : {data.Date:dd MMM yyyy}<br>" + $"Close : ${data.Close}<br>" + $"Open : ${data.Open}<br>" + $"High : ${data.High}<br>" + $"Low : ${data.Low}<br>" + $"Volume : ${data.Volume:N0}";
        }

        [JSInvokable]
        public void ResizeHandler(string message,int windowWidth)
        {
            if (message == "resizeAction" && Chart != null)
            {
                if (ChartOptions != null && IsChartDropdownOpen)
                {
                    ChartOptions.Toggle();
                }
                if (PeriodOptions != null && IsPeriodDropdownOpen)
                {
                    PeriodOptions.Toggle();
                }
            }
            StateHasChanged();
        }

        public class StockData
        {
            public DateTime Date { get; set; }
            public double Low { get; set; }
            public double Open { get; set; }
            public double High { get; set; }
            public double Close { get; set; }
            public double Volume { get; set; }
        }
    }
}
