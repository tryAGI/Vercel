
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiGatewayBudgetList
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budgets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AiGatewayBudget> Budgets { get; set; }

        /// <summary>
        /// Paged requests only: `source: 'default'` rows per scope type across the whole `scopeType`-filtered list, independent of the page and of `includeDefaultCovered`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultCoveredCounts")]
        public global::Vercel.AiGatewayBudgetListDefaultCoveredCounts? DefaultCoveredCounts { get; set; }

        /// <summary>
        /// Paged requests only (`limit` or `cursor` set): pass as `cursor` to read the next page; null on the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayBudgetList" /> class.
        /// </summary>
        /// <param name="budgets"></param>
        /// <param name="defaultCoveredCounts">
        /// Paged requests only: `source: 'default'` rows per scope type across the whole `scopeType`-filtered list, independent of the page and of `includeDefaultCovered`.
        /// </param>
        /// <param name="nextCursor">
        /// Paged requests only (`limit` or `cursor` set): pass as `cursor` to read the next page; null on the last page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayBudgetList(
            global::System.Collections.Generic.IList<global::Vercel.AiGatewayBudget> budgets,
            global::Vercel.AiGatewayBudgetListDefaultCoveredCounts? defaultCoveredCounts,
            string? nextCursor)
        {
            this.Budgets = budgets ?? throw new global::System.ArgumentNullException(nameof(budgets));
            this.DefaultCoveredCounts = defaultCoveredCounts;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayBudgetList" /> class.
        /// </summary>
        public AiGatewayBudgetList()
        {
        }

    }
}