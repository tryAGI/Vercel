
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemCondition
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemCondition" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="neg"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemCondition(
            global::Vercel.AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp op,
            global::Vercel.AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionType type,
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
        /// Initializes a new instance of the <see cref="AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemCondition" /> class.
        /// </summary>
        public AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemCondition()
        {
        }

    }
}