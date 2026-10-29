
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateConditionalBypassRequestConditionGroupItemConditionVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2TypeJsonConverter))]
        public global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2OpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op Op { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateConditionalBypassRequestConditionGroupItemConditionVariant2" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConditionalBypassRequestConditionGroupItemConditionVariant2(
            global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op op,
            string value,
            global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Type type)
        {
            this.Type = type;
            this.Op = op;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConditionalBypassRequestConditionGroupItemConditionVariant2" /> class.
        /// </summary>
        public UpdateConditionalBypassRequestConditionGroupItemConditionVariant2()
        {
        }

    }
}