
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateConditionalBypassRequestConditionGroupItemConditionVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateConditionalBypassRequestConditionGroupItemConditionVariant1TypeJsonConverter))]
        public global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateConditionalBypassRequestConditionGroupItemConditionVariant1OpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateConditionalBypassRequestConditionGroupItemConditionVariant1KeyJsonConverter))]
        public global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Key? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConditionalBypassRequestConditionGroupItemConditionVariant1" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <param name="key"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConditionalBypassRequestConditionGroupItemConditionVariant1(
            global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op op,
            string value,
            global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Type type,
            global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Key? key)
        {
            this.Type = type;
            this.Op = op;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConditionalBypassRequestConditionGroupItemConditionVariant1" /> class.
        /// </summary>
        public UpdateConditionalBypassRequestConditionGroupItemConditionVariant1()
        {
        }

    }
}