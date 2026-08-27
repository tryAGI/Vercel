
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeSnowflakeWif
    {
        /// <summary>
        /// Snowflake client name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientName")]
        public string? ClientName { get; set; }

        /// <summary>
        /// Snowflake account identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountIdentifier")]
        public string? AccountIdentifier { get; set; }

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
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSnowflakeWif" /> class.
        /// </summary>
        /// <param name="clientName">
        /// Snowflake client name.
        /// </param>
        /// <param name="accountIdentifier">
        /// Snowflake account identifier.
        /// </param>
        /// <param name="extras">
        /// Additional provider metadata stored with the connector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeSnowflakeWif(
            string? clientName,
            string? accountIdentifier,
            object? extras)
        {
            this.ClientName = clientName;
            this.AccountIdentifier = accountIdentifier;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSnowflakeWif" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeSnowflakeWif()
        {
        }

    }
}