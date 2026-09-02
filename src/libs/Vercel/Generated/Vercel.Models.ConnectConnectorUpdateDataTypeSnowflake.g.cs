
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeSnowflake
    {
        /// <summary>
        /// Snowflake account identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountIdentifier")]
        public string? AccountIdentifier { get; set; }

        /// <summary>
        /// Default Snowflake role for created sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultSessionRole")]
        public string? DefaultSessionRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSnowflake" /> class.
        /// </summary>
        /// <param name="accountIdentifier">
        /// Snowflake account identifier.
        /// </param>
        /// <param name="defaultSessionRole">
        /// Default Snowflake role for created sessions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeSnowflake(
            string? accountIdentifier,
            string? defaultSessionRole)
        {
            this.AccountIdentifier = accountIdentifier;
            this.DefaultSessionRole = defaultSessionRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSnowflake" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeSnowflake()
        {
        }

    }
}