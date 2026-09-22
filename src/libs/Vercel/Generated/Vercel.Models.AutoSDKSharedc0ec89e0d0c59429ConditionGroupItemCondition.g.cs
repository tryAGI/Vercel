
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemCondition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neg")]
        public bool? Neg { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemCondition" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="neg"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemCondition(
            global::Vercel.AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp op,
            global::Vercel.AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionType type,
            string? key,
            bool? neg,
            global::Vercel.OneOf<string, double?, global::System.Collections.Generic.IList<string>>? value)
        {
            this.Key = key;
            this.Neg = neg;
            this.Op = op;
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemCondition" /> class.
        /// </summary>
        public AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemCondition()
        {
        }

    }
}