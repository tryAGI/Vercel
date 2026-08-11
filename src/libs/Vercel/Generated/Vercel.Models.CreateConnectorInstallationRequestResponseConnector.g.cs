
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorInstallationRequestResponseConnector
    {
        /// <summary>
        /// Client id (e.g. `scl_…`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Client uid (e.g. `salesforce/my-org`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// Client type (e.g. `oauth`, `salesforce`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Resolved service id when known (e.g. `salesforce`), following the `stored.service ?? typeDef.service ?? stored.type` convention.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        public string? Service { get; set; }

        /// <summary>
        /// Curated display name of the resolved service (e.g. "Salesforce"), present when the service is a known service. Suited for end-user surfaces like "Sign in with {serviceName}".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        public string? ServiceName { get; set; }

        /// <summary>
        /// Provider-facing display name when the connector type exposes one, falling back to the stored connector name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The connector's own name: the operator-given client name, falling back to the client type's name for legacy rows without one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorInstallationRequestResponseConnector" /> class.
        /// </summary>
        /// <param name="id">
        /// Client id (e.g. `scl_…`).
        /// </param>
        /// <param name="uid">
        /// Client uid (e.g. `salesforce/my-org`).
        /// </param>
        /// <param name="type">
        /// Client type (e.g. `oauth`, `salesforce`).
        /// </param>
        /// <param name="displayName">
        /// Provider-facing display name when the connector type exposes one, falling back to the stored connector name.
        /// </param>
        /// <param name="name">
        /// The connector's own name: the operator-given client name, falling back to the client type's name for legacy rows without one.
        /// </param>
        /// <param name="service">
        /// Resolved service id when known (e.g. `salesforce`), following the `stored.service ?? typeDef.service ?? stored.type` convention.
        /// </param>
        /// <param name="serviceName">
        /// Curated display name of the resolved service (e.g. "Salesforce"), present when the service is a known service. Suited for end-user surfaces like "Sign in with {serviceName}".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorInstallationRequestResponseConnector(
            string id,
            string uid,
            string type,
            string displayName,
            string name,
            string? service,
            string? serviceName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Service = service;
            this.ServiceName = serviceName;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorInstallationRequestResponseConnector" /> class.
        /// </summary>
        public CreateConnectorInstallationRequestResponseConnector()
        {
        }

    }
}