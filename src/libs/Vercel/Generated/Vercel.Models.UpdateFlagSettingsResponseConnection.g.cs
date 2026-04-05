
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSettingsResponseConnection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EdgeConfigId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigItemKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EdgeConfigItemKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSettingsResponseConnection" /> class.
        /// </summary>
        /// <param name="edgeConfigId"></param>
        /// <param name="edgeConfigItemKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSettingsResponseConnection(
            string edgeConfigId,
            string edgeConfigItemKey)
        {
            this.EdgeConfigId = edgeConfigId ?? throw new global::System.ArgumentNullException(nameof(edgeConfigId));
            this.EdgeConfigItemKey = edgeConfigItemKey ?? throw new global::System.ArgumentNullException(nameof(edgeConfigItemKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSettingsResponseConnection" /> class.
        /// </summary>
        public UpdateFlagSettingsResponseConnection()
        {
        }
    }
}