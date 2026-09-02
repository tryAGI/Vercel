
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A connection between a connector and a Vercel project, including the environments where the connector is enabled.
    /// </summary>
    public sealed partial class ConnectProjectConnection
    {
        /// <summary>
        /// Stable `scl_` connector ID, even when the request used a UID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectorId { get; set; }

        /// <summary>
        /// Vercel project connected to the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectProjectConnectionProject Project { get; set; }

        /// <summary>
        /// Environments where the connector is enabled for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledEnvironments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<string, global::Vercel.ConnectProjectConnectionEnabledEnvironment?>> EnabledEnvironments { get; set; }

        /// <summary>
        /// Time when the project connection was created, in epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Time when the project connection was last updated, in epoch milliseconds.
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
        /// Initializes a new instance of the <see cref="ConnectProjectConnection" /> class.
        /// </summary>
        /// <param name="connectorId">
        /// Stable `scl_` connector ID, even when the request used a UID.
        /// </param>
        /// <param name="project">
        /// Vercel project connected to the connector.
        /// </param>
        /// <param name="enabledEnvironments">
        /// Environments where the connector is enabled for the project.
        /// </param>
        /// <param name="createdAt">
        /// Time when the project connection was created, in epoch milliseconds.
        /// </param>
        /// <param name="updatedAt">
        /// Time when the project connection was last updated, in epoch milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectProjectConnection(
            string connectorId,
            global::Vercel.ConnectProjectConnectionProject project,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<string, global::Vercel.ConnectProjectConnectionEnabledEnvironment?>> enabledEnvironments,
            double createdAt,
            double updatedAt)
        {
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.EnabledEnvironments = enabledEnvironments ?? throw new global::System.ArgumentNullException(nameof(enabledEnvironments));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectProjectConnection" /> class.
        /// </summary>
        public ConnectProjectConnection()
        {
        }

    }
}