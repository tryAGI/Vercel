
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFirewallConfigResponseRuleVariant2ConditionGroupItemCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp Op { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>))]
        public global::Vercel.OneOf<string, double?, global::System.Collections.Generic.IList<string>>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFirewallConfigResponseRuleVariant2ConditionGroupItemCondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="op"></param>
        /// <param name="neg"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFirewallConfigResponseRuleVariant2ConditionGroupItemCondition(
            global::Vercel.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionType type,
            global::Vercel.GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp op,
            bool? neg,
            string? key,
            global::Vercel.OneOf<string, double?, global::System.Collections.Generic.IList<string>>? value)
        {
            this.Type = type;
            this.Op = op;
            this.Neg = neg;
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFirewallConfigResponseRuleVariant2ConditionGroupItemCondition" /> class.
        /// </summary>
        public GetFirewallConfigResponseRuleVariant2ConditionGroupItemCondition()
        {
        }
    }
}