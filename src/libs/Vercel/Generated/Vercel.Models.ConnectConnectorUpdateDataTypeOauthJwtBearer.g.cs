
#nullable enable

namespace Vercel
{
    /// <summary>
    /// JWT bearer grant settings.
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeOauthJwtBearer
    {
        /// <summary>
        /// Whether JWT bearer grants are enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Default scopes to request when token params specify scopes: [\"*\"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Default JWT subject claim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub")]
        public string? Sub { get; set; }

        /// <summary>
        /// Default JWT issuer claim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iss")]
        public string? Iss { get; set; }

        /// <summary>
        /// Default JWT audience claim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aud")]
        public string? Aud { get; set; }

        /// <summary>
        /// Additional claims included in generated JWT assertions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalClaims")]
        public object? AdditionalClaims { get; set; }

        /// <summary>
        /// JWT lifetime in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public double? Ttl { get; set; }

        /// <summary>
        /// Whether JWT bearer requests also use client credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useClientCredentials")]
        public bool? UseClientCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeOauthJwtBearer" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether JWT bearer grants are enabled.
        /// </param>
        /// <param name="scopes">
        /// Default scopes to request when token params specify scopes: [\"*\"].
        /// </param>
        /// <param name="sub">
        /// Default JWT subject claim.
        /// </param>
        /// <param name="iss">
        /// Default JWT issuer claim.
        /// </param>
        /// <param name="aud">
        /// Default JWT audience claim.
        /// </param>
        /// <param name="additionalClaims">
        /// Additional claims included in generated JWT assertions.
        /// </param>
        /// <param name="ttl">
        /// JWT lifetime in seconds.
        /// </param>
        /// <param name="useClientCredentials">
        /// Whether JWT bearer requests also use client credentials.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeOauthJwtBearer(
            bool? enabled,
            global::System.Collections.Generic.IList<string>? scopes,
            string? sub,
            string? iss,
            string? aud,
            object? additionalClaims,
            double? ttl,
            bool? useClientCredentials)
        {
            this.Enabled = enabled;
            this.Scopes = scopes;
            this.Sub = sub;
            this.Iss = iss;
            this.Aud = aud;
            this.AdditionalClaims = additionalClaims;
            this.Ttl = ttl;
            this.UseClientCredentials = useClientCredentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeOauthJwtBearer" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeOauthJwtBearer()
        {
        }

    }
}