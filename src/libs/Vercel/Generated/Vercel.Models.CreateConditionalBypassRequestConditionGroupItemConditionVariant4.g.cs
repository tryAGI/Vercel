
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateConditionalBypassRequestConditionGroupItemConditionVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateConditionalBypassRequestConditionGroupItemConditionVariant4TypeJsonConverter))]
        public global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant4Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateConditionalBypassRequestConditionGroupItemConditionVariant4OpJsonConverter))]
        public global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant4Op Op { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateConditionalBypassRequestConditionGroupItemConditionVariant4" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="op"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConditionalBypassRequestConditionGroupItemConditionVariant4(
            string key,
            global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant4Type type,
            global::Vercel.CreateConditionalBypassRequestConditionGroupItemConditionVariant4Op op)
        {
            this.Type = type;
            this.Op = op;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConditionalBypassRequestConditionGroupItemConditionVariant4" /> class.
        /// </summary>
        public CreateConditionalBypassRequestConditionGroupItemConditionVariant4()
        {
        }

    }
}