
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Global Config.
    /// </summary>
    public sealed partial class GlobalConfigItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EdgeConfigId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GlobalConfigItemValueJsonConverter))]
        public global::Vercel.GlobalConfigItemValue? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalConfigItem" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="edgeConfigId"></param>
        /// <param name="key"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlobalConfigItem(
            double createdAt,
            string edgeConfigId,
            string key,
            double updatedAt,
            string? description,
            global::Vercel.GlobalConfigItemValue? value)
        {
            this.CreatedAt = createdAt;
            this.Description = description;
            this.EdgeConfigId = edgeConfigId ?? throw new global::System.ArgumentNullException(nameof(edgeConfigId));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.UpdatedAt = updatedAt;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalConfigItem" /> class.
        /// </summary>
        public GlobalConfigItem()
        {
        }

    }
}