
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurposeJsonConverter))]
        public global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="updatedAt"></param>
        /// <param name="digest"></param>
        /// <param name="purpose"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponse(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?> items,
            double updatedAt,
            string digest,
            global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose? purpose)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.UpdatedAt = updatedAt;
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponse" /> class.
        /// </summary>
        public ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponse()
        {
        }
    }
}