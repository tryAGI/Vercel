
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetIntegrationResourceResponseProtocolSettingsExperimentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigId")]
        public string? EdgeConfigId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("globalConfigId")]
        public string? GlobalConfigId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponseProtocolSettingsExperimentation" /> class.
        /// </summary>
        /// <param name="edgeConfigId"></param>
        /// <param name="globalConfigId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntegrationResourceResponseProtocolSettingsExperimentation(
            string? edgeConfigId,
            string? globalConfigId)
        {
            this.EdgeConfigId = edgeConfigId;
            this.GlobalConfigId = globalConfigId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponseProtocolSettingsExperimentation" /> class.
        /// </summary>
        public GetIntegrationResourceResponseProtocolSettingsExperimentation()
        {
        }

    }
}