
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?> Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurposeJsonConverter))]
        public global::Vercel.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose? Purpose { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse" /> class.
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="items"></param>
        /// <param name="updatedAt"></param>
        /// <param name="purpose"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse(
            string digest,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?> items,
            double updatedAt,
            global::Vercel.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose? purpose)
        {
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Purpose = purpose;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse" /> class.
        /// </summary>
        public HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse()
        {
        }

    }
}