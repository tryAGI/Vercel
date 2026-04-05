
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant2ValueConditionGroupItemCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp Op { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>, double?>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant2ValueConditionGroupItemCondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="op"></param>
        /// <param name="neg"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant2ValueConditionGroupItemCondition(
            global::Vercel.UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionType type,
            global::Vercel.UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp op,
            bool? neg,
            string? key,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>, double?>? value)
        {
            this.Type = type;
            this.Op = op;
            this.Neg = neg;
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant2ValueConditionGroupItemCondition" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant2ValueConditionGroupItemCondition()
        {
        }
    }
}