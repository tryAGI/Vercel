
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeOauthJwtBearer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub")]
        public string? Sub { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iss")]
        public string? Iss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aud")]
        public string? Aud { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalClaims")]
        public object? AdditionalClaims { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public double? Ttl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useClientCredentials")]
        public bool? UseClientCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeOauthJwtBearer" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="sub"></param>
        /// <param name="iss"></param>
        /// <param name="aud"></param>
        /// <param name="additionalClaims"></param>
        /// <param name="ttl"></param>
        /// <param name="useClientCredentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeOauthJwtBearer(
            bool? enabled,
            string? sub,
            string? iss,
            string? aud,
            object? additionalClaims,
            double? ttl,
            bool? useClientCredentials)
        {
            this.Enabled = enabled;
            this.Sub = sub;
            this.Iss = iss;
            this.Aud = aud;
            this.AdditionalClaims = additionalClaims;
            this.Ttl = ttl;
            this.UseClientCredentials = useClientCredentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeOauthJwtBearer" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeOauthJwtBearer()
        {
        }

    }
}