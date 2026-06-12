
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeSnowflakeWif
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountIdentifier")]
        public string? AccountIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeSnowflakeWif" /> class.
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="accountIdentifier"></param>
        /// <param name="extras"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeSnowflakeWif(
            string clientName,
            string? accountIdentifier,
            object? extras)
        {
            this.ClientName = clientName ?? throw new global::System.ArgumentNullException(nameof(clientName));
            this.AccountIdentifier = accountIdentifier;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeSnowflakeWif" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeSnowflakeWif()
        {
        }

    }
}