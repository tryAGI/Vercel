
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutFirewallConfigRequestRuleConditionGroupItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigRequestRuleConditionGroupItemCondition> Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequestRuleConditionGroupItem" /> class.
        /// </summary>
        /// <param name="conditions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigRequestRuleConditionGroupItem(
            global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigRequestRuleConditionGroupItemCondition> conditions)
        {
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequestRuleConditionGroupItem" /> class.
        /// </summary>
        public PutFirewallConfigRequestRuleConditionGroupItem()
        {
        }
    }
}