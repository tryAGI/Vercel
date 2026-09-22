
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf70b685b3a570894ConditionGroupItemCondition
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedf70b685b3a570894ConditionGroupItemCondition" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="neg"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf70b685b3a570894ConditionGroupItemCondition(
            global::Vercel.AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp op,
            global::Vercel.AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionType type,
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
        /// Initializes a new instance of the <see cref="AutoSDKSharedf70b685b3a570894ConditionGroupItemCondition" /> class.
        /// </summary>
        public AutoSDKSharedf70b685b3a570894ConditionGroupItemCondition()
        {
        }

    }
}