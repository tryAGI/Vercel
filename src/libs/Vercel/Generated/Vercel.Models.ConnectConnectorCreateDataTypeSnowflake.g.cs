
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeSnowflake
    {
        /// <summary>
        /// Snowflake OAuth client name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientName")]
        public string? ClientName { get; set; }

        /// <summary>
        /// Snowflake account identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountIdentifier { get; set; }

        /// <summary>
        /// Default Snowflake role for created sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultSessionRole")]
        public string? DefaultSessionRole { get; set; }

        /// <summary>
        /// Additional provider metadata stored with the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSnowflake" /> class.
        /// </summary>
        /// <param name="accountIdentifier">
        /// Snowflake account identifier.
        /// </param>
        /// <param name="clientName">
        /// Snowflake OAuth client name.
        /// </param>
        /// <param name="defaultSessionRole">
        /// Default Snowflake role for created sessions.
        /// </param>
        /// <param name="extras">
        /// Additional provider metadata stored with the connector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeSnowflake(
            string accountIdentifier,
            string? clientName,
            string? defaultSessionRole,
            object? extras)
        {
            this.ClientName = clientName;
            this.AccountIdentifier = accountIdentifier ?? throw new global::System.ArgumentNullException(nameof(accountIdentifier));
            this.DefaultSessionRole = defaultSessionRole;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSnowflake" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeSnowflake()
        {
        }

    }
}