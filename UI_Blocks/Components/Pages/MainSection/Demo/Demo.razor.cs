using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;
using Microsoft.JSInterop;
using System.Text.RegularExpressions;

namespace UI_Blocks.Components.Pages.MainSection
{
    public partial class Demo : ComponentBase, IDisposable
    {
        private DotNetObjectReference<Demo> _dotNetObjectReference;
        private bool _switchingMode;
        private string _selectedTab = "html";
        private readonly Dictionary<ViewMode, string> _widths = new()
        {
            { ViewMode.Desktop, "100%" },
            { ViewMode.Tablet, "48rem" },
            { ViewMode.Mobile, "22.5rem" }
        };
        private readonly List<string> _availableThemes = new() { "tailwind", "bootstrap5.3" };
        private readonly List<string> _tabs = new() { "html", "css", "csharp" };
        private record ThemeDetails(string SyncfusionStyleUrl, string FrameworkStyleUrl, string FrameworkSupportStyleUrl, string FontIconsUrl, string ThemeMode);

        protected ElementReference PreviewBlock;
        protected string CurrentTheme { get; set; } = "tailwind-light";

        [Parameter]
        public string BlockName { get; set; } = string.Empty;
        [Parameter]
        public string BlockUrl { get; set; } = string.Empty;

        public bool IsDarkMode { get; set; } = false;
        public bool IsPreviewMode { get; set; } = true;
        public bool ShowLoadingIndicator { get; set; } = true;
        public bool IsDropdownOpen { get; set; } = false;
        public ViewMode CurrentView { get; private set; } = ViewMode.Desktop;
        public string PreviewStyle { get; private set; } = "min-width: 100%;";
        public enum ViewMode { Desktop, Tablet, Mobile }
        public string HtmlContent { get; set; } = string.Empty;
        public string CssContent { get; set; } = string.Empty;
        public string CSharpContent { get; set; } = string.Empty;

        protected override void OnInitialized()
        {
            Uri uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
            Dictionary<string, StringValues> queryParams = QueryHelpers.ParseQuery(uri.Query);
            if (queryParams.TryGetValue("CurrentTheme", out StringValues theme))
            {
                CurrentTheme = theme!;
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _dotNetObjectReference = DotNetObjectReference.Create(this);
                if (this.GetType().Name != "Demo")
                {
                    await JSRuntime.InvokeVoidAsync("initializeiFrameMessageListener", _dotNetObjectReference);
                }
                else
                {
                    await JSRuntime.InvokeVoidAsync("initializeDemoMessageListener", _dotNetObjectReference);
                }
            }
            if (!firstRender && !IsPreviewMode)
            {
                await InitializeHighlightJs();
            }
            else if (_switchingMode)
            {
                ThemeDetails themeDetails = GetThemeDetails();
                await JSRuntime.InvokeAsync<bool>("updateStyleSheet", PreviewBlock, CurrentTheme, themeDetails.ThemeMode);
            }
        }

        private async Task InitializeHighlightJs()
        {
            try
            {
                await JSRuntime.InvokeVoidAsync("initializeHighlightJs");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error initializing highlight.js: {ex.Message}");
            }
        }

        private ThemeDetails GetThemeDetails()
        {
            string syncfusionStyleUrl, frameworkStyleUrl, frameworkSupportStyleUrl, fontIconsUrl, themeMode;

            switch (CurrentTheme)
            {
                case "tailwind":
                case "tailwind-light":
                    syncfusionStyleUrl = "_content/Syncfusion.Blazor.Themes/tailwind.css";
                    frameworkStyleUrl = "assets/themes/tailwind/tailwind.css";
                    frameworkSupportStyleUrl = "assets/themes/tailwind/indigo.css";
                    fontIconsUrl = "assets/font-icons/tailwind/tailwind-icons.css";
                    themeMode = "dark";
                    break;

                case "tailwind-dark":
                    syncfusionStyleUrl = "_content/Syncfusion.Blazor.Themes/tailwind-dark.css";
                    frameworkStyleUrl = "assets/themes/tailwind/tailwind.css";
                    frameworkSupportStyleUrl = "assets/themes/tailwind/cyan.css";
                    fontIconsUrl = "assets/font-icons/tailwind/tailwind-icons.css";
                    themeMode = "dark";
                    break;

                case "bootstrap5.3":
                case "bootstrap5.3-light":
                    syncfusionStyleUrl = "_content/Syncfusion.Blazor.Themes/bootstrap5.3.css";
                    frameworkStyleUrl = "https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css";
                    frameworkSupportStyleUrl = string.Empty;
                    fontIconsUrl = "assets/font-icons/bootstrap5_3/bootstrap5_3-icons.css";
                    themeMode = "bs-theme-dark";
                    break;

                case "bootstrap5.3-dark":
                    syncfusionStyleUrl = "_content/Syncfusion.Blazor.Themes/bootstrap5.3-dark.css";
                    frameworkStyleUrl = "https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css";
                    frameworkSupportStyleUrl = string.Empty;
                    fontIconsUrl = "assets/font-icons/bootstrap5_3/bootstrap5_3-icons.css";
                    themeMode = "bs-theme-dark";
                    break;

                default:
                    syncfusionStyleUrl = "_content/Syncfusion.Blazor.Themes/tailwind.css";
                    frameworkStyleUrl = "assets/themes/tailwind/tailwind.css";
                    frameworkSupportStyleUrl = "assets/themes/tailwind/indigo.css";
                    fontIconsUrl = "assets/font-icons/tailwind/tailwind-icons.css";
                    themeMode = "dark";
                    break;
            }

            return new ThemeDetails(syncfusionStyleUrl, frameworkStyleUrl, frameworkSupportStyleUrl, fontIconsUrl, themeMode);
        }

        protected RenderFragment ThemeLinks => builder =>
        {
            ThemeDetails theme = GetThemeDetails();
            builder.OpenElement(0, "link");
            builder.AddAttribute(1, "href", theme.SyncfusionStyleUrl);
            builder.AddAttribute(2, "rel", "stylesheet");
            builder.CloseElement();

            builder.OpenElement(3, "link");
            builder.AddAttribute(4, "href", theme.FontIconsUrl);
            builder.AddAttribute(5, "rel", "stylesheet");
            builder.CloseElement();

            builder.OpenElement(6, "link");
            builder.AddAttribute(7, "href", theme.FrameworkStyleUrl);
            builder.AddAttribute(8, "rel", "stylesheet");
            builder.CloseElement();

            builder.OpenElement(9, "link");
            builder.AddAttribute(10, "href", theme.FrameworkSupportStyleUrl);
            builder.AddAttribute(11, "rel", "stylesheet");
            builder.CloseElement();
        };

        private async Task OnPreviewLoad()
        {
            ThemeDetails themeDetails = GetThemeDetails();
            await JSRuntime.InvokeAsync<bool>("updateStyleSheet", PreviewBlock, CurrentTheme, themeDetails.ThemeMode, true);
        }

        private void OnThemeChange(string theme)
        {
            if (!CurrentTheme.Contains(theme))
            {
                CurrentTheme = IsDarkMode ? $"{theme}-dark" : $"{theme}-light";
                ShowLoadingIndicator = true;
            }
            IsDropdownOpen = false;
        }

        private void ToggleDropdown() => IsDropdownOpen = !IsDropdownOpen;

        private async Task SwitchMode(ViewMode mode)
        {
            ShowLoadingIndicator = true;
            CurrentView = mode;
            PreviewStyle = $"min-width: {_widths[mode]};";
            _switchingMode = true;
            await Task.CompletedTask;
        }

        private async Task LoadAndDisplaySourceCode()
        {
            try
            {
                string sampleName = this.BlockName.Replace("-", "");
                string[] files = Directory.GetFiles("wwwroot/code-snippet/" + sampleName);
                await GetHTMLContent(files, sampleName);
                await GetCssContent(files, sampleName);
                await GetCSharpContent(files, sampleName);
            }
            catch (Exception ex)
            {
                HtmlContent = ex.Message;
            }
        }

        private async Task GetHTMLContent(string[] files, string sampleName)
        {
            try
            {
                var matchedFile = files.FirstOrDefault(file =>
                    Path.GetFileName(file).Equals(sampleName + ".razor.html", StringComparison.OrdinalIgnoreCase));
                var fileContent = await System.IO.File.ReadAllTextAsync(matchedFile ?? "");

                HtmlContent = ExtractSectionContent(fileContent, this.CurrentTheme);
            }
            catch (Exception)
            {
                HtmlContent = "No content available !!!";
            }
        }

        private async Task GetCssContent(string[] files, string sampleName)
        {
            try
            {
                var matchedFile = files.FirstOrDefault(file =>
                    Path.GetFileName(file).Equals(sampleName + ".razor.css.html", StringComparison.OrdinalIgnoreCase));
                CssContent = await System.IO.File.ReadAllTextAsync(matchedFile ?? "");
            }
            catch (Exception)
            {
                CssContent = "No content available !!!";
            }
        }

        private async Task GetCSharpContent(string[] files, string sampleName)
        {
            try
            {
                var matchedFile = files.FirstOrDefault(file =>
                    Path.GetFileName(file).Equals(sampleName + ".razor.cs.html", StringComparison.OrdinalIgnoreCase));
                CSharpContent = await System.IO.File.ReadAllTextAsync(matchedFile ?? "");
                string pattern = @"namespace\s+UI_Blocks\.Components\.Pages\.BlocksSection\.[A-Za-z]+?\.[A-Za-z0-9_]+\s*\{([\s\S]*?)\n\}";
                Match match = Regex.Match(CSharpContent, pattern);
                if (match.Success)
                {
                    CSharpContent = RemoveCustomCode(match.Groups[1].Value);
                }
            }
            catch (Exception)
            {
                CSharpContent = "No content available !!!";
            }
        }

        private string RemoveCustomCode(string content)
        {
            string pattern = @"/\* SB Code - Start \*/[\s\S]*?/\* SB Code - End \*/";
            string result = Regex.Replace(content, pattern, string.Empty);
            return result;
        }

        private string ExtractSectionContent(string htmlString, string currentTheme)
        {
            var theme = currentTheme.Split("-").FirstOrDefault();
            var patterns = new Dictionary<string, Regex>
            {
                {"tailwind", new Regex(@"@if \(CurrentTheme\.Contains\(""tailwind""\)\)\r?\n\{([\s\S]*?)</section>", RegexOptions.Compiled)},
                {"bootstrap5.3", new Regex(@"else if \(CurrentTheme\.Contains\(""bootstrap5.3""\)\)\r?\n\{([\s\S]*?)</section>", RegexOptions.Compiled)}
            };

            patterns.TryGetValue(theme ?? "", out var pattern);
            if (pattern == null)
            {
                return "An invalid theme name has been provided.";
            }

            var match = pattern.Match(htmlString);
            if (match.Success)
            {
                int matchCount = match.Groups.Count - 1;
                string value = match.Groups[matchCount].Value.TrimStart().Replace("    ", "\t");
                string result = Regex.Replace(value, @"\t+", m => m.Value.Length > 1 ? m.Value.Substring(1) : "");
                return result.Replace("\t", "    ").TrimEnd() + "\r\n</section>";
            }

            return "An error occurred while parsing the HTML code.";
        }

        private async Task ToggleLightDarkHandleKeyDown(KeyboardEventArgs e, string tabText)
        {
            await PreviewCodeHandleKeyDown(e, tabText, true);
        }

        private async Task PreviewCodeHandleKeyDown(KeyboardEventArgs e, string tabText, bool isLightDarkMode = false)
        {
            if (e.Key == "Enter" || e.Key == " ")
            {
                await TogglePreviewCode(tabText);
                if (isLightDarkMode)
                {
                    ToggleLightDarkModes();
                }
            }
        }

        private async Task TogglePreviewCode(string tabText)
        {
            IsPreviewMode = tabText == "preview";
            if (!IsPreviewMode)
            {
                ShowLoadingIndicator = true;
                await LoadAndDisplaySourceCode();
                ShowLoadingIndicator = false;
            }
            else
            {
                ShowLoadingIndicator = true;
            }
            await Task.CompletedTask;
        }

        private void ToggleLightDarkModes()
        {
            ShowLoadingIndicator = true;
            IsDarkMode = !IsDarkMode;
            CurrentTheme = CurrentTheme.Replace("-dark", "").Replace("-light", "");
            CurrentTheme = IsDarkMode ? $"{CurrentTheme}-dark" : $"{CurrentTheme}-light";
        }

        private async Task SwitchHandleKeyDown(KeyboardEventArgs e, ViewMode mode)
        {
            if (e.Key == "Enter" || e.Key == " ")
            {
                await SwitchMode(mode);
            }
        }

        private void OnTabKeyDown(KeyboardEventArgs e, string tabName)
        {
            if (e.Key == "Enter" || e.Key == "Space")
            {
                ShowTab(tabName);
            }
        }

        private void ShowTab(string tabName)
        {
            _selectedTab = tabName;
        }

        private string GetViewModeImage(ViewMode mode) =>
            mode == ViewMode.Desktop ? "monitor" : mode == ViewMode.Tablet ? "tablet" : "smartphone";

        private string GetThemeName(string theme) =>
            theme switch
            {
                "tailwind" => "Tailwind",
                "bootstrap5.3" => "Bootstrap 5.3",
                _ => theme
            };

        private string GetTabContent(string tab)
        {
            return tab switch
            {
                "html" => HtmlContent,
                "css" => CssContent,
                "csharp" => CSharpContent,
                _ => string.Empty
            };
        }

        private string GetCodeStyle(string tab)
        {
            bool HasCSS = !CssContent.Contains("No content");
            bool HasCSharp = !CSharpContent.Contains("No content");
            string RightBorderStyle = !HasCSS && !HasCSharp ? "border-top-right-radius: 4px; border-bottom-right-radius: 4px;" : "";
            if ((tab == "csharp" && !HasCSharp) ||
                (tab == "css" && !HasCSS))
            {
                return "display: none;";
            }
            return RightBorderStyle;
        }

        [JSInvokable]
        public void ToggleLoadingIndicator(bool show)
        {
            if (_switchingMode)
            {
                _switchingMode = false;
                Thread.Sleep(1500);
            }
            ShowLoadingIndicator = show;
            StateHasChanged();
        }

        public void Dispose()
        {
            JSRuntime.InvokeVoidAsync("removeMessageListener", PreviewBlock);
            _dotNetObjectReference?.Dispose();
        }
    }
}