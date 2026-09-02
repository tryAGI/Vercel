
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeSnowflakeWif
    {
        /// <summary>
        /// Snowflake account identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountIdentifier")]
        public string? AccountIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSnowflakeWif" /> class.
        /// </summary>
        /// <param name="accountIdentifier">
        /// Snowflake account identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeSnowflakeWif(
            string? accountIdentifier)
        {
            this.AccountIdentifier = accountIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSnowflakeWif" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeSnowflakeWif()
        {
        }

    }
}