
#nullable enable

namespace Vercel
{
    /// <summary>
    /// `private_key_jwt` client assertion settings.
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeOauthClientAssertion
    {
        /// <summary>
        /// OAuth client assertion type. Defaults to urn:ietf:params:oauth:client-assertion-type:jwt-bearer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Client assertion lifetime in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public double? Ttl { get; set; }

        /// <summary>
        /// Additional claims included in the client assertion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        public object? Claims { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeOauthClientAssertion" /> class.
        /// </summary>
        /// <param name="type">
        /// OAuth client assertion type. Defaults to urn:ietf:params:oauth:client-assertion-type:jwt-bearer.
        /// </param>
        /// <param name="ttl">
        /// Client assertion lifetime in seconds.
        /// </param>
        /// <param name="claims">
        /// Additional claims included in the client assertion.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeOauthClientAssertion(
            string? type,
            double? ttl,
            object? claims)
        {
            this.Type = type;
            this.Ttl = ttl;
            this.Claims = claims;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeOauthClientAssertion" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeOauthClientAssertion()
        {
        }

    }
}