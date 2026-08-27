
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypePhoton
    {
        /// <summary>
        /// Photon project ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Photon project secret.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectSecret")]
        public string? ProjectSecret { get; set; }

        /// <summary>
        /// Photon webhook verification secret.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookSecret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypePhoton" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Photon project ID.
        /// </param>
        /// <param name="projectSecret">
        /// Photon project secret.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="webhookSecret">
        /// Photon webhook verification secret.<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypePhoton(
            string projectId,
            string? projectSecret,
            string? webhookSecret)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectSecret = projectSecret;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypePhoton" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypePhoton()
        {
        }

    }
}