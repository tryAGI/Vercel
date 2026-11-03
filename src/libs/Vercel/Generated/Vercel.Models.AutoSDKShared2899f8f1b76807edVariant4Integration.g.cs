
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared2899f8f1b76807edVariant4Integration
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigurationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2899f8f1b76807edVariant4Integration" /> class.
        /// </summary>
        /// <param name="configurationId"></param>
        /// <param name="integrationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared2899f8f1b76807edVariant4Integration(
            string configurationId,
            string integrationId)
        {
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2899f8f1b76807edVariant4Integration" /> class.
        /// </summary>
        public AutoSDKShared2899f8f1b76807edVariant4Integration()
        {
        }

    }
}