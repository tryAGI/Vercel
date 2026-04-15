
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant232Budget
    {
        /// <summary>
        /// Represents a budget for tracking and notifying teams on their spending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budgetItem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant232BudgetBudgetItem BudgetItem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant232Budget" /> class.
        /// </summary>
        /// <param name="budgetItem">
        /// Represents a budget for tracking and notifying teams on their spending.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant232Budget(
            global::Vercel.UserEventPayloadVariant232BudgetBudgetItem budgetItem)
        {
            this.BudgetItem = budgetItem ?? throw new global::System.ArgumentNullException(nameof(budgetItem));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant232Budget" /> class.
        /// </summary>
        public UserEventPayloadVariant232Budget()
        {
        }
    }
}