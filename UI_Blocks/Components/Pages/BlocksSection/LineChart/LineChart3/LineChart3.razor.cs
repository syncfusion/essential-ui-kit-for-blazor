using Microsoft.JSInterop;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.LineChart.LineChart3
{
    public partial class LineChart3
    {
        public string Height = "250px";
        public string Width = "500px";

        public List<DropDownMenuItem> PeriodOptions = new List<DropDownMenuItem>
        {
            new DropDownMenuItem { Text = "Day" },
            new DropDownMenuItem { Text = "Week" },
            new DropDownMenuItem { Text = "Month" },
            new DropDownMenuItem { Text = "Year" },
            new DropDownMenuItem { Text = "Custom" }
        };

        public List<SynchronizedData> LineChartData = new List<SynchronizedData>
        {
            new SynchronizedData { Date = new DateTime(2023, 1, 18), EUR = 0.83316, JPY = 149.10, SGD = 1.3370, INR = 82.814 },
            new SynchronizedData { Date = new DateTime(2023, 1, 19), EUR = 0.83591, JPY = 149.31, SGD = 1.3371, INR = 82.773 },
            new SynchronizedData { Date = new DateTime(2023, 1, 20), EUR = 0.83604, JPY = 149.32, SGD = 1.3359, INR = 82.721 },
            new SynchronizedData { Date = new DateTime(2023, 1, 21), EUR = 0.83881, JPY = 149.97, SGD = 1.3402, INR = 82.899 },
            new SynchronizedData { Date = new DateTime(2023, 1, 22), EUR = 0.84289, JPY = 149.93, SGD = 1.3408, INR = 82.843 },
            new SynchronizedData { Date = new DateTime(2023, 1, 23), EUR = 0.84358, JPY = 149.63, SGD = 1.3428, INR = 82.636 },
            new SynchronizedData { Date = new DateTime(2023, 1, 24), EUR = 0.84473, JPY = 151.47, SGD = 1.3500, INR = 82.933 },
            new SynchronizedData { Date = new DateTime(2023, 1, 25), EUR = 0.84584, JPY = 151.48, SGD = 1.3499, INR = 82.929 },
            new SynchronizedData { Date = new DateTime(2023, 1, 26), EUR = 0.84745, JPY = 151.40, SGD = 1.3498, INR = 82.928 },
            new SynchronizedData { Date = new DateTime(2023, 1, 27), EUR = 0.84262, JPY = 151.32, SGD = 1.3469, INR = 82.673 },
            new SynchronizedData { Date = new DateTime(2023, 1, 28), EUR = 0.84548, JPY = 151.35, SGD = 1.3484, INR = 82.641 },
            new SynchronizedData { Date = new DateTime(2023, 2, 1), EUR = 0.83722, JPY = 151.20, SGD = 1.3420, INR = 82.418 },
            new SynchronizedData { Date = new DateTime(2023, 2, 2), EUR = 0.84344, JPY = 151.70, SGD = 1.3473, INR = 82.349 },
            new SynchronizedData { Date = new DateTime(2023, 2, 3), EUR = 0.83901, JPY = 150.85, SGD = 1.3452, INR = 81.712 },
            new SynchronizedData { Date = new DateTime(2023, 2, 4), EUR = 0.83968, JPY = 150.84, SGD = 1.3452, INR = 81.713 },
            new SynchronizedData { Date = new DateTime(2023, 2, 5), EUR = 0.84106, JPY = 151.02, SGD = 1.3455, INR = 81.742 },
            new SynchronizedData { Date = new DateTime(2023, 2, 6), EUR = 0.83573, JPY = 150.99, SGD = 1.3451, INR = 81.858 },
            new SynchronizedData { Date = new DateTime(2023, 2, 7), EUR = 0.84792, JPY = 152.38, SGD = 1.3544, INR = 82.072 },
            new SynchronizedData { Date = new DateTime(2023, 2, 8), EUR = 0.84793, JPY = 152.24, SGD = 1.3533, INR = 81.960 },
            new SynchronizedData { Date = new DateTime(2023, 2, 9), EUR = 0.84480, JPY = 149.41, SGD = 1.3532, INR = 82.011 },
            new SynchronizedData { Date = new DateTime(2023, 2, 10), EUR = 0.83842, JPY = 149.00, SGD = 1.3488, INR = 82.018 },
            new SynchronizedData { Date = new DateTime(2023, 2, 11), EUR = 0.83926, JPY = 150.99, SGD = 1.3489, INR = 81.966 },
            new SynchronizedData { Date = new DateTime(2023, 2, 12), EUR = 0.83600, JPY = 149.98, SGD = 1.3475, INR = 82.019 },
            new SynchronizedData { Date = new DateTime(2023, 2, 13), EUR = 0.83246, JPY = 148.12, SGD = 1.3474, INR = 82.422 },
            new SynchronizedData { Date = new DateTime(2023, 2, 14), EUR = 0.83219, JPY = 148.40, SGD = 1.3452, INR = 82.309 },
            new SynchronizedData { Date = new DateTime(2023, 2, 15), EUR = 0.84490, JPY = 150.94, SGD = 1.3512, INR = 82.713 },
            new SynchronizedData { Date = new DateTime(2023, 2, 16), EUR = 0.84220, JPY = 149.38, SGD = 1.3461, INR = 82.642 },
            new SynchronizedData { Date = new DateTime(2023, 2, 17), EUR = 0.83006, JPY = 148.84, SGD = 1.3416, INR = 82.531 },
            new SynchronizedData { Date = new DateTime(2023, 2, 18), EUR = 0.82806, JPY = 148.85, SGD = 1.3415, INR = 82.536 },
            new SynchronizedData { Date = new DateTime(2023, 2, 19), EUR = 0.83648, JPY = 148.29, SGD = 1.3406, INR = 82.544 },
            new SynchronizedData { Date = new DateTime(2023, 2, 20), EUR = 0.83295, JPY = 148.40, SGD = 1.3377, INR = 82.520 },
            new SynchronizedData { Date = new DateTime(2023, 2, 21), EUR = 0.82817, JPY = 148.36, SGD = 1.3370, INR = 82.663 },
            new SynchronizedData { Date = new DateTime(2023, 2, 22), EUR = 0.82003, JPY = 148.18, SGD = 1.3297, INR = 82.520 },
            new SynchronizedData { Date = new DateTime(2023, 2, 23), EUR = 0.82290, JPY = 148.80, SGD = 1.3278, INR = 82.253 },
            new SynchronizedData { Date = new DateTime(2023, 2, 24), EUR = 0.82795, JPY = 148.75, SGD = 1.3329, INR = 82.347 },
            new SynchronizedData { Date = new DateTime(2023, 2, 25), EUR = 0.82795, JPY = 149.75, SGD = 1.3329, INR = 82.347 },
            new SynchronizedData { Date = new DateTime(2023, 2, 26), EUR = 0.82789, JPY = 149.79, SGD = 1.3316, INR = 82.348 },
            new SynchronizedData { Date = new DateTime(2023, 2, 27), EUR = 0.82601, JPY = 149.48, SGD = 1.3312, INR = 82.240 },
            new SynchronizedData { Date = new DateTime(2023, 2, 28), EUR = 0.82242, JPY = 149.85, SGD = 1.3277, INR = 82.164 },
            new SynchronizedData { Date = new DateTime(2023, 3, 1), EUR = 0.82021, JPY = 149.77, SGD = 1.3308, INR = 82.181 },
            new SynchronizedData { Date = new DateTime(2023, 3, 2), EUR = 0.82422, JPY = 149.26, SGD = 1.3328, INR = 82.201 },
            new SynchronizedData { Date = new DateTime(2023, 3, 3), EUR = 0.81706, JPY = 149.34, SGD = 1.3269, INR = 82.147 },
            new SynchronizedData { Date = new DateTime(2023, 3, 4), EUR = 0.81257, JPY = 149.68, SGD = 1.3255, INR = 82.138 },
            new SynchronizedData { Date = new DateTime(2023, 3, 5), EUR = 0.81665, JPY = 149.12, SGD = 1.3281, INR = 81.960 },
            new SynchronizedData { Date = new DateTime(2023, 3, 6), EUR = 0.81605, JPY = 149.84, SGD = 1.3306, INR = 81.825 },
            new SynchronizedData { Date = new DateTime(2023, 3, 7), EUR = 0.80949, JPY = 149.15, SGD = 1.3321, INR = 81.875 },
            new SynchronizedData { Date = new DateTime(2023, 3, 8), EUR = 0.80951, JPY = 150.15, SGD = 1.3298, INR = 81.841 },
            new SynchronizedData { Date = new DateTime(2023, 3, 9), EUR = 0.80951, JPY = 150.15, SGD = 1.3298, INR = 81.841 },
            new SynchronizedData { Date = new DateTime(2023, 3, 10), EUR = 0.82040, JPY = 150.54, SGD = 1.3324, INR = 81.977 },
            new SynchronizedData { Date = new DateTime(2023, 3, 11), EUR = 0.81601, JPY = 150.62, SGD = 1.3324, INR = 82.079 },
            new SynchronizedData { Date = new DateTime(2023, 3, 12), EUR = 0.80951, JPY = 150.07, SGD = 1.3279, INR = 81.951 },
            new SynchronizedData { Date = new DateTime(2023, 3, 13), EUR = 0.80513, JPY = 150.59, SGD = 1.3222, INR = 81.691 },
            new SynchronizedData { Date = new DateTime(2023, 3, 14), EUR = 0.80199, JPY = 150.83, SGD = 1.3303, INR = 81.852 },
            new SynchronizedData { Date = new DateTime(2023, 3, 15), EUR = 0.80167, JPY = 150.81, SGD = 1.3304, INR = 81.842 },
            new SynchronizedData { Date = new DateTime(2023, 3, 16), EUR = 0.81013, JPY = 151.91, SGD = 1.3311, INR = 81.857 },
            new SynchronizedData { Date = new DateTime(2023, 3, 17), EUR = 0.81539, JPY = 151.46, SGD = 1.3342, INR = 82.004 },
            new SynchronizedData { Date = new DateTime(2023, 3, 18), EUR = 0.81132, JPY = 151.05, SGD = 1.3325, INR = 82.107 },
            new SynchronizedData { Date = new DateTime(2023, 3, 19), EUR = 0.81297, JPY = 151.73, SGD = 1.3349, INR = 82.334 },
            new SynchronizedData { Date = new DateTime(2023, 3, 20), EUR = 0.81182, JPY = 151.18, SGD = 1.3326, INR = 82.153 },
            new SynchronizedData { Date = new DateTime(2023, 3, 21), EUR = 0.80117, JPY = 151.16, SGD = 1.3351, INR = 82.041 },
            new SynchronizedData { Date = new DateTime(2023, 3, 22), EUR = 0.80117, JPY = 151.16, SGD = 1.3351, INR = 82.041 },
            new SynchronizedData { Date = new DateTime(2023, 3, 23), EUR = 0.80977, JPY = 151.09, SGD = 1.3341, INR = 82.036 },
            new SynchronizedData { Date = new DateTime(2023, 3, 24), EUR = 0.80489, JPY = 151.12, SGD = 1.3334, INR = 81.855 },
            new SynchronizedData { Date = new DateTime(2023, 3, 25), EUR = 0.81085, JPY = 151.72, SGD = 1.3380, INR = 81.978 },
            new SynchronizedData { Date = new DateTime(2023, 3, 26), EUR = 0.80584, JPY = 151.58, SGD = 1.3354, INR = 81.748 },
            new SynchronizedData { Date = new DateTime(2023, 3, 27), EUR = 0.80684, JPY = 151.90, SGD = 1.3351, INR = 81.716 },
            new SynchronizedData { Date = new DateTime(2023, 3, 28), EUR = 0.81872, JPY = 152.31, SGD = 1.3355, INR = 81.745 },
            new SynchronizedData { Date = new DateTime(2023, 3, 29), EUR = 0.81861, JPY = 152.32, SGD = 1.3353, INR = 81.742 },
            new SynchronizedData { Date = new DateTime(2023, 3, 30), EUR = 0.81810, JPY = 152.24, SGD = 1.3349, INR = 81.764 },
            new SynchronizedData { Date = new DateTime(2023, 4, 1), EUR = 0.81123, JPY = 152.45, SGD = 1.3363, INR = 81.780 },
            new SynchronizedData { Date = new DateTime(2023, 4, 2), EUR = 0.81859, JPY = 152.52, SGD = 1.3346, INR = 81.770 },
            new SynchronizedData { Date = new DateTime(2023, 4, 3), EUR = 0.81346, JPY = 152.61, SGD = 1.3303, INR = 81.804 },
            new SynchronizedData { Date = new DateTime(2023, 4, 4), EUR = 0.81740, JPY = 152.29, SGD = 1.3277, INR = 81.698 },
            new SynchronizedData { Date = new DateTime(2023, 4, 5), EUR = 0.81849, JPY = 152.84, SGD = 1.3261, INR = 81.730 },
            new SynchronizedData { Date = new DateTime(2023, 4, 6), EUR = 0.81200, JPY = 152.83, SGD = 1.3261, INR = 81.730 },
            new SynchronizedData { Date = new DateTime(2023, 4, 7), EUR = 0.80768, JPY = 152.04, SGD = 1.3257, INR = 81.720 },
            new SynchronizedData { Date = new DateTime(2023, 4, 8), EUR = 0.80893, JPY = 152.01, SGD = 1.3251, INR = 81.787 },
            new SynchronizedData { Date = new DateTime(2023, 4, 9), EUR = 0.81193, JPY = 151.20, SGD = 1.3271, INR = 82.102 },
            new SynchronizedData { Date = new DateTime(2023, 4, 10), EUR = 0.81019, JPY = 151.20, SGD = 1.3247, INR = 81.913 },
            new SynchronizedData { Date = new DateTime(2023, 4, 11), EUR = 0.81601, JPY = 151.52, SGD = 1.3315, INR = 82.094 },
            new SynchronizedData { Date = new DateTime(2023, 4, 12), EUR = 0.81412, JPY = 151.75, SGD = 1.3388, INR = 82.256 },
            new SynchronizedData { Date = new DateTime(2023, 4, 13), EUR = 0.81429, JPY = 151.73, SGD = 1.3384, INR = 82.197 },
            new SynchronizedData { Date = new DateTime(2023, 4, 14), EUR = 0.82153, JPY = 151.78, SGD = 1.3385, INR = 82.228 },
            new SynchronizedData { Date = new DateTime(2023, 4, 15), EUR = 0.81939, JPY = 151.02, SGD = 1.3362, INR = 82.270 },
            new SynchronizedData { Date = new DateTime(2023, 4, 16), EUR = 0.82062, JPY = 151.39, SGD = 1.3404, INR = 82.295 },
            new SynchronizedData { Date = new DateTime(2023, 4, 17), EUR = 0.82249, JPY = 151.59, SGD = 1.3421, INR = 82.458 },
            new SynchronizedData { Date = new DateTime(2023, 4, 18), EUR = 0.82798, JPY = 151.65, SGD = 1.3478, INR = 82.726 },
            new SynchronizedData { Date = new DateTime(2023, 4, 19), EUR = 0.82391, JPY = 151.97, SGD = 1.3444, INR = 82.842 },
            new SynchronizedData { Date = new DateTime(2023, 4, 20), EUR = 0.82447, JPY = 151.97, SGD = 1.3444, INR = 82.843 },
            new SynchronizedData { Date = new DateTime(2023, 4, 21), EUR = 0.82428, JPY = 151.66, SGD = 1.3451, INR = 82.883 },
            new SynchronizedData { Date = new DateTime(2023, 4, 22), EUR = 0.82482, JPY = 151.57, SGD = 1.3464, INR = 82.822 },
            new SynchronizedData { Date = new DateTime(2023, 4, 23), EUR = 0.82833, JPY = 151.53, SGD = 1.3469, INR = 82.897 },
            new SynchronizedData { Date = new DateTime(2023, 4, 24), EUR = 0.82982, JPY = 150.22, SGD = 1.3490, INR = 82.705 },
            new SynchronizedData { Date = new DateTime(2023, 4, 25), EUR = 0.83225, JPY = 150.94, SGD = 1.3544, INR = 82.734 },
            new SynchronizedData { Date = new DateTime(2023, 4, 26), EUR = 0.83188, JPY = 150.66, SGD = 1.3502, INR = 82.565 },
            new SynchronizedData { Date = new DateTime(2023, 4, 27), EUR = 0.83188, JPY = 150.66, SGD = 1.3502, INR = 82.565 },
            new SynchronizedData { Date = new DateTime(2023, 4, 28), EUR = 0.83286, JPY = 150.78, SGD = 1.3530, INR = 82.569 },
            new SynchronizedData { Date = new DateTime(2023, 4, 29), EUR = 0.83372, JPY = 150.49, SGD = 1.3538, INR = 82.580 },
            new SynchronizedData { Date = new DateTime(2023, 4, 30), EUR = 0.83174, JPY = 149.76, SGD = 1.3506, INR = 82.682 },
            new SynchronizedData { Date = new DateTime(2023, 5, 1), EUR = 0.82911, JPY = 148.77, SGD = 1.3473, INR = 82.280 },
            new SynchronizedData { Date = new DateTime(2023, 5, 2), EUR = 0.83342, JPY = 149.95, SGD = 1.3505, INR = 82.402 },
            new SynchronizedData { Date = new DateTime(2023, 5, 3), EUR = 0.83341, JPY = 149.96, SGD = 1.3504, INR = 82.402 },
            new SynchronizedData { Date = new DateTime(2023, 5, 4), EUR = 0.83425, JPY = 150.06, SGD = 1.3504, INR = 82.407 },
            new SynchronizedData { Date = new DateTime(2023, 5, 5), EUR = 0.83341, JPY = 149.46, SGD = 1.3493, INR = 82.506 },
            new SynchronizedData { Date = new DateTime(2023, 5, 6), EUR = 0.83505, JPY = 149.61, SGD = 1.3483, INR = 82.520 },
            new SynchronizedData { Date = new DateTime(2023, 5, 7), EUR = 0.83464, JPY = 150.03, SGD = 1.3487, INR = 82.625 },
            new SynchronizedData { Date = new DateTime(2023, 5, 8), EUR = 0.82739, JPY = 148.90, SGD = 1.3427, INR = 82.481 },
            new SynchronizedData { Date = new DateTime(2023, 5, 9), EUR = 0.83028, JPY = 149.40, SGD = 1.3441, INR = 82.425 },
            new SynchronizedData { Date = new DateTime(2023, 5, 10), EUR = 0.82992, JPY = 149.39, SGD = 1.3440, INR = 82.421 },
            new SynchronizedData { Date = new DateTime(2023, 5, 11), EUR = 0.83066, JPY = 149.43, SGD = 1.3438, INR = 82.435 },
            new SynchronizedData { Date = new DateTime(2023, 5, 12), EUR = 0.82927, JPY = 149.56, SGD = 1.3435, INR = 82.329 },
            new SynchronizedData { Date = new DateTime(2023, 5, 13), EUR = 0.82665, JPY = 150.14, SGD = 1.3421, INR = 82.290 },
            new SynchronizedData { Date = new DateTime(2023, 5, 14), EUR = 0.82307, JPY = 150.06, SGD = 1.3414, INR = 82.045 },
            new SynchronizedData { Date = new DateTime(2023, 5, 15), EUR = 0.81334, JPY = 150.18, SGD = 1.3361, INR = 81.910 },
            new SynchronizedData { Date = new DateTime(2023, 5, 16), EUR = 0.81266, JPY = 151.83, SGD = 1.3404, INR = 81.907 },
            new SynchronizedData { Date = new DateTime(2023, 5, 17), EUR = 0.81266, JPY = 151.83, SGD = 1.3404, INR = 81.907 },
            new SynchronizedData { Date = new DateTime(2023, 5, 18), EUR = 0.81401, JPY = 151.89, SGD = 1.3374, INR = 81.916 },
            new SynchronizedData { Date = new DateTime(2023, 5, 19), EUR = 0.81539, JPY = 151.92, SGD = 1.3405, INR = 81.982 },
            new SynchronizedData { Date = new DateTime(2023, 5, 20), EUR = 0.81579, JPY = 151.36, SGD = 1.3431, INR = 81.992 },
            new SynchronizedData { Date = new DateTime(2023, 5, 21), EUR = 0.81008, JPY = 151.72, SGD = 1.3402, INR = 81.944 },
            new SynchronizedData { Date = new DateTime(2023, 5, 22), EUR = 0.81292, JPY = 153.06, SGD = 1.3452, INR = 81.900 },
            new SynchronizedData { Date = new DateTime(2023, 5, 23), EUR = 0.81498, JPY = 153.72, SGD = 1.3508, INR = 81.971 },
            new SynchronizedData { Date = new DateTime(2023, 5, 24), EUR = 0.81608, JPY = 153.69, SGD = 1.3518, INR = 81.985 },
            new SynchronizedData { Date = new DateTime(2023, 5, 25), EUR = 0.81684, JPY = 153.46, SGD = 1.3518, INR = 81.961 },
            new SynchronizedData { Date = new DateTime(2023, 5, 26), EUR = 0.81655, JPY = 153.43, SGD = 1.3535, INR = 82.005 },
            new SynchronizedData { Date = new DateTime(2023, 5, 27), EUR = 0.81254, JPY = 153.97, SGD = 1.3493, INR = 82.000 },
            new SynchronizedData { Date = new DateTime(2023, 5, 28), EUR = 0.81607, JPY = 154.35, SGD = 1.3528, INR = 82.025 },
            new SynchronizedData { Date = new DateTime(2023, 5, 29), EUR = 0.82032, JPY = 154.77, SGD = 1.3561, INR = 82.073 },
            new SynchronizedData { Date = new DateTime(2023, 5, 30), EUR = 0.81610, JPY = 154.31, SGD = 1.3523, INR = 82.099 },
            new SynchronizedData { Date = new DateTime(2023, 6, 1), EUR = 0.81610, JPY = 154.34, SGD = 1.3523, INR = 82.099 },
            new SynchronizedData { Date = new DateTime(2023, 6, 2), EUR = 0.81660, JPY = 154.33, SGD = 1.3521, INR = 82.097 },
            new SynchronizedData { Date = new DateTime(2023, 6, 3), EUR = 0.81631, JPY = 154.67, SGD = 1.3511, INR = 81.967 },
            new SynchronizedData { Date = new DateTime(2023, 6, 4), EUR = 0.81908, JPY = 154.46, SGD = 1.3494, INR = 82.005 },
            new SynchronizedData { Date = new DateTime(2023, 6, 5), EUR = 0.82119, JPY = 154.54, SGD = 1.3533, INR = 82.395 },
            new SynchronizedData { Date = new DateTime(2023, 6, 6), EUR = 0.81822, JPY = 154.05, SGD = 1.3531, INR = 82.770 },
            new SynchronizedData { Date = new DateTime(2023, 6, 7), EUR = 0.81113, JPY = 152.09, SGD = 1.3503, INR = 82.651 },
            new SynchronizedData { Date = new DateTime(2023, 6, 8), EUR = 0.81152, JPY = 152.11, SGD = 1.3499, INR = 82.647 },
            new SynchronizedData { Date = new DateTime(2023, 6, 9), EUR = 0.81190, JPY = 152.18, SGD = 1.3465, INR = 82.628 },
            new SynchronizedData { Date = new DateTime(2023, 6, 10), EUR = 0.80896, JPY = 151.31, SGD = 1.3444, INR = 82.536 },
            new SynchronizedData { Date = new DateTime(2023, 6, 11), EUR = 0.80808, JPY = 150.22, SGD = 1.3406, INR = 82.384 },
            new SynchronizedData { Date = new DateTime(2023, 6, 12), EUR = 0.81801, JPY = 148.38, SGD = 1.3300, INR = 81.975 },
            new SynchronizedData { Date = new DateTime(2023, 6, 13), EUR = 0.81080, JPY = 148.22, SGD = 1.3223, INR = 82.031 },
            new SynchronizedData { Date = new DateTime(2023, 6, 14), EUR = 0.81939, JPY = 148.69, SGD = 1.3211, INR = 82.134 },
            new SynchronizedData { Date = new DateTime(2023, 6, 15), EUR = 0.81992, JPY = 148.69, SGD = 1.3209, INR = 82.116 },
            new SynchronizedData { Date = new DateTime(2023, 6, 16), EUR = 0.81084, JPY = 148.76, SGD = 1.3219, INR = 82.075 },
            new SynchronizedData { Date = new DateTime(2023, 6, 17), EUR = 0.81965, JPY = 148.71, SGD = 1.3216, INR = 82.057 },
            new SynchronizedData { Date = new DateTime(2023, 6, 18), EUR = 0.81041, JPY = 148.94, SGD = 1.3225, INR = 82.076 },
            new SynchronizedData { Date = new DateTime(2023, 6, 19), EUR = 0.81269, JPY = 149.62, SGD = 1.3251, INR = 82.065 },
            new SynchronizedData { Date = new DateTime(2023, 6, 20), EUR = 0.81814, JPY = 149.98, SGD = 1.3267, INR = 82.084 },
            new SynchronizedData { Date = new DateTime(2023, 6, 21), EUR = 0.81824, JPY = 151.78, SGD = 1.3309, INR = 82.003 },
            new SynchronizedData { Date = new DateTime(2023, 6, 22), EUR = 0.81857, JPY = 151.78, SGD = 1.3306, INR = 82.004 },
            new SynchronizedData { Date = new DateTime(2023, 6, 23), EUR = 0.81864, JPY = 151.75, SGD = 1.3308, INR = 82.005 },
            new SynchronizedData { Date = new DateTime(2023, 6, 24), EUR = 0.80382, JPY = 151.51, SGD = 1.3317, INR = 81.814 },
            new SynchronizedData { Date = new DateTime(2023, 6, 25), EUR = 0.80485, JPY = 150.92, SGD = 1.3278, INR = 81.956 },
            new SynchronizedData { Date = new DateTime(2023, 6, 26), EUR = 0.80178, JPY = 150.41, SGD = 1.3254, INR = 81.976 },
            new SynchronizedData { Date = new DateTime(2023, 6, 27), EUR = 0.81046, JPY = 149.18, SGD = 1.3305, INR = 82.373 },
            new SynchronizedData { Date = new DateTime(2023, 6, 28), EUR = 0.80651, JPY = 151.15, SGD = 1.3309, INR = 82.260 },
            new SynchronizedData { Date = new DateTime(2023, 6, 29), EUR = 0.80651, JPY = 151.15, SGD = 1.3309, INR = 82.266 },
            new SynchronizedData { Date = new DateTime(2023, 6, 30), EUR = 0.80709, JPY = 150.93, SGD = 1.3319, INR = 82.263 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                Height = windowWidth < 767 ? "130px" : "250px";
                Width = windowWidth < 767 ? "328px" : "500px";
            }
            StateHasChanged();
        }

        public class SynchronizedData
        {
            public DateTime Date { get; set; }
            public double EUR { get; set; }
            public double JPY { get; set; }
            public double SGD { get; set; }
            public double INR { get; set; }
        }
    }
}
