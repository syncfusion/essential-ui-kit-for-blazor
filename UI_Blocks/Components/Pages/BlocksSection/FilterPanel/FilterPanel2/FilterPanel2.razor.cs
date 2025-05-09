using Syncfusion.Blazor.QueryBuilder;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.FilterPanel.FilterPanel2
{
    public partial class FilterPanel2
    {
        public SfDialog? Dialog;
        public SfQueryBuilder<RuleModel>? QueryBuilder1;
        public SfQueryBuilder<RuleModel>? QueryBuilder2;

        public int RecordLength { get; set; }
        public int RecordData { get; set; }
        public string XValue { get; set; } = string.Empty;

        public List<RuleModel> Rules1 { get; set; } = new List<RuleModel>();
        public List<RuleModel> Rules2 { get; set; } = new List<RuleModel>();

        public List<OperatorsModel> FilterOperators { get; set; } = new List<OperatorsModel>
        {
            new OperatorsModel { Value = "in", Text = "In" },
            new OperatorsModel { Value = "notin", Text = "Not In" },
            new OperatorsModel { Value = "is", Text = "Is" },
            new OperatorsModel { Value = "isnot", Text = "Is not" }
        };

        public async Task OpenDialogAync()
        {
            await Dialog?.ShowAsync();
        }

        public async Task AddNewRulePrimaryAsync()
        {
            QueryBuilder1?.AddRule(new RuleModel(), "group0");
            RecordLength = QueryBuilder1?.GetRules()?.Rules?.Count ?? 0;
        }

        public async Task AddNewRuleSecondaryAsync()
        {
            QueryBuilder2?.AddRule(new RuleModel(), "group0");
            RecordData = QueryBuilder2?.GetRules()?.Rules?.Count ?? 0;
        }
    }
}
