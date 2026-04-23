
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant239Budget
    {
        /// <summary>
        /// Represents a budget for tracking and notifying teams on their spending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budgetItem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant239BudgetBudgetItem BudgetItem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant239Budget" /> class.
        /// </summary>
        /// <param name="budgetItem">
        /// Represents a budget for tracking and notifying teams on their spending.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant239Budget(
            global::Vercel.UserEventPayloadVariant239BudgetBudgetItem budgetItem)
        {
            this.BudgetItem = budgetItem ?? throw new global::System.ArgumentNullException(nameof(budgetItem));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant239Budget" /> class.
        /// </summary>
        public UserEventPayloadVariant239Budget()
        {
        }
    }
}