
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeSnowflake
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceUsername")]
        public string? ServiceUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceRole")]
        public string? ServiceRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultSessionRole")]
        public string? DefaultSessionRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateKeyPem")]
        public string? PrivateKeyPem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKeyPem")]
        public string? PublicKeyPem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKeyFingerprint")]
        public string? PublicKeyFingerprint { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeSnowflake" /> class.
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="accountIdentifier"></param>
        /// <param name="serviceUsername"></param>
        /// <param name="serviceRole"></param>
        /// <param name="defaultSessionRole"></param>
        /// <param name="privateKeyPem"></param>
        /// <param name="publicKeyPem"></param>
        /// <param name="publicKeyFingerprint"></param>
        /// <param name="extras"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeSnowflake(
            string clientName,
            string accountIdentifier,
            string? serviceUsername,
            string? serviceRole,
            string? defaultSessionRole,
            string? privateKeyPem,
            string? publicKeyPem,
            string? publicKeyFingerprint,
            object? extras)
        {
            this.ClientName = clientName ?? throw new global::System.ArgumentNullException(nameof(clientName));
            this.AccountIdentifier = accountIdentifier ?? throw new global::System.ArgumentNullException(nameof(accountIdentifier));
            this.ServiceUsername = serviceUsername;
            this.ServiceRole = serviceRole;
            this.DefaultSessionRole = defaultSessionRole;
            this.PrivateKeyPem = privateKeyPem;
            this.PublicKeyPem = publicKeyPem;
            this.PublicKeyFingerprint = publicKeyFingerprint;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeSnowflake" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeSnowflake()
        {
        }

    }
}