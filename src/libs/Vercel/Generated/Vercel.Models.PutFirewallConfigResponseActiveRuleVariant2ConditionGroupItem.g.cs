
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemCondition> Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItem" /> class.
        /// </summary>
        /// <param name="conditions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItem(
            global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemCondition> conditions)
        {
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItem" /> class.
        /// </summary>
        public PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItem()
        {
        }
    }
}