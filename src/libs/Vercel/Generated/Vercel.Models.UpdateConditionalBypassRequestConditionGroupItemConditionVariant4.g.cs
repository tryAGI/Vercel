
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateConditionalBypassRequestConditionGroupItemConditionVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateConditionalBypassRequestConditionGroupItemConditionVariant4TypeJsonConverter))]
        public global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant4Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateConditionalBypassRequestConditionGroupItemConditionVariant4OpJsonConverter))]
        public global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant4Op Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConditionalBypassRequestConditionGroupItemConditionVariant4" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="op"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConditionalBypassRequestConditionGroupItemConditionVariant4(
            string key,
            global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant4Type type,
            global::Vercel.UpdateConditionalBypassRequestConditionGroupItemConditionVariant4Op op)
        {
            this.Type = type;
            this.Op = op;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConditionalBypassRequestConditionGroupItemConditionVariant4" /> class.
        /// </summary>
        public UpdateConditionalBypassRequestConditionGroupItemConditionVariant4()
        {
        }

    }
}