
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Updated connector and any required provider follow-up actions.
    /// </summary>
    public sealed partial class ConnectConnectorUpdateResult
    {
        /// <summary>
        /// A connector that defines how Vercel accesses an external service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectConnector Connector { get; set; }

        /// <summary>
        /// Existing authorizations no longer cover the connector's configured scopes, so they must be re-authorized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reconsentNeeded")]
        public global::Vercel.ConnectReconsent? ReconsentNeeded { get; set; }

        /// <summary>
        /// When true, prompt a team owner or administrator to reinstall the connector before relying on the change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reinstallNeeded")]
        public bool? ReinstallNeeded { get; set; }

        /// <summary>
        /// Provider-side configuration synchronization result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceSync")]
        public global::Vercel.ConnectServiceSync? ServiceSync { get; set; }

        /// <summary>
        /// When true, scopes were removed. The provider keeps scopes it already granted, so remove the app from the provider workspace and install it again before the removal takes effect. Reinstalling alone does not remove scopes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uninstallNeeded")]
        public bool? UninstallNeeded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateResult" /> class.
        /// </summary>
        /// <param name="connector">
        /// A connector that defines how Vercel accesses an external service.
        /// </param>
        /// <param name="reconsentNeeded">
        /// Existing authorizations no longer cover the connector's configured scopes, so they must be re-authorized.
        /// </param>
        /// <param name="reinstallNeeded">
        /// When true, prompt a team owner or administrator to reinstall the connector before relying on the change.
        /// </param>
        /// <param name="serviceSync">
        /// Provider-side configuration synchronization result.
        /// </param>
        /// <param name="uninstallNeeded">
        /// When true, scopes were removed. The provider keeps scopes it already granted, so remove the app from the provider workspace and install it again before the removal takes effect. Reinstalling alone does not remove scopes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateResult(
            global::Vercel.ConnectConnector connector,
            global::Vercel.ConnectReconsent? reconsentNeeded,
            bool? reinstallNeeded,
            global::Vercel.ConnectServiceSync? serviceSync,
            bool? uninstallNeeded)
        {
            this.Connector = connector ?? throw new global::System.ArgumentNullException(nameof(connector));
            this.ReconsentNeeded = reconsentNeeded;
            this.ReinstallNeeded = reinstallNeeded;
            this.ServiceSync = serviceSync;
            this.UninstallNeeded = uninstallNeeded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateResult" /> class.
        /// </summary>
        public ConnectConnectorUpdateResult()
        {
        }

    }
}