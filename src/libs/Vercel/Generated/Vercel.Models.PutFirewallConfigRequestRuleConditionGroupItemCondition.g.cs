
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutFirewallConfigRequestRuleConditionGroupItemCondition
    {
        /// <summary>
        /// [Parameter](https://vercel.com/docs/security/vercel-waf/rule-configuration#parameters) from the incoming traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutFirewallConfigRequestRuleConditionGroupItemConditionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigRequestRuleConditionGroupItemConditionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutFirewallConfigRequestRuleConditionGroupItemConditionOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigRequestRuleConditionGroupItemConditionOp Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neg")]
        public bool? Neg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>))]
        public global::Vercel.AnyOf<string, global::System.Collections.Generic.IList<string>, double?>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequestRuleConditionGroupItemCondition" /> class.
        /// </summary>
        /// <param name="type">
        /// [Parameter](https://vercel.com/docs/security/vercel-waf/rule-configuration#parameters) from the incoming traffic.
        /// </param>
        /// <param name="op"></param>
        /// <param name="neg"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigRequestRuleConditionGroupItemCondition(
            global::Vercel.PutFirewallConfigRequestRuleConditionGroupItemConditionType type,
            global::Vercel.PutFirewallConfigRequestRuleConditionGroupItemConditionOp op,
            bool? neg,
            string? key,
            global::Vercel.AnyOf<string, global::System.Collections.Generic.IList<string>, double?>? value)
        {
            this.Type = type;
            this.Op = op;
            this.Neg = neg;
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequestRuleConditionGroupItemCondition" /> class.
        /// </summary>
        public PutFirewallConfigRequestRuleConditionGroupItemCondition()
        {
        }
    }
}