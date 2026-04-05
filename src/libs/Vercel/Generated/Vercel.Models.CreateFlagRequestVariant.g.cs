
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagRequestVariant
    {
        /// <summary>
        /// The id of the variant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A label for the variant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// A description of the variant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequestVariant" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the variant
        /// </param>
        /// <param name="value"></param>
        /// <param name="label">
        /// A label for the variant
        /// </param>
        /// <param name="description">
        /// A description of the variant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagRequestVariant(
            string id,
            global::Vercel.AnyOf<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string> value,
            string? label,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label;
            this.Description = description;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequestVariant" /> class.
        /// </summary>
        public CreateFlagRequestVariant()
        {
        }
    }
}