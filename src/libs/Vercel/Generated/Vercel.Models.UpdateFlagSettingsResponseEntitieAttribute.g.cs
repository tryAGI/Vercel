
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSettingsResponseEntitieAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSettingsResponseEntitieAttributeLabel>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSettingsResponseEntitieAttribute" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="labels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSettingsResponseEntitieAttribute(
            string key,
            string type,
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSettingsResponseEntitieAttributeLabel>? labels)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSettingsResponseEntitieAttribute" /> class.
        /// </summary>
        public UpdateFlagSettingsResponseEntitieAttribute()
        {
        }
    }
}