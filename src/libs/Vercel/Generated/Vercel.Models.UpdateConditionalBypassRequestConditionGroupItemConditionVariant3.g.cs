
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateConditionalBypassRequestConditionGroupItemConditionVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateConditionalBypassRequestConditionGroupItemConditionVariant3TypeJsonConverter))]
        public global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateConditionalBypassRequestConditionGroupItemConditionVariant3OpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConditionalBypassRequestConditionGroupItemConditionVariant3" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConditionalBypassRequestConditionGroupItemConditionVariant3(
            global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op op,
            string key,
            string value,
            global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Type type)
        {
            this.Type = type;
            this.Op = op;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConditionalBypassRequestConditionGroupItemConditionVariant3" /> class.
        /// </summary>
        public UpdateConditionalBypassRequestConditionGroupItemConditionVariant3()
        {
        }

    }
}