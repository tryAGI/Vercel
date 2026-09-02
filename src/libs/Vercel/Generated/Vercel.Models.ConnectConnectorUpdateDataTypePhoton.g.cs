
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypePhoton
    {
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
        /// Whether Connect should recreate the Photon webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repairWebhook")]
        public bool? RepairWebhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypePhoton" /> class.
        /// </summary>
        /// <param name="projectSecret">
        /// Photon project secret.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="webhookSecret">
        /// Photon webhook verification secret.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="repairWebhook">
        /// Whether Connect should recreate the Photon webhook.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypePhoton(
            string? projectSecret,
            string? webhookSecret,
            bool? repairWebhook)
        {
            this.ProjectSecret = projectSecret;
            this.WebhookSecret = webhookSecret;
            this.RepairWebhook = repairWebhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypePhoton" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypePhoton()
        {
        }

    }
}