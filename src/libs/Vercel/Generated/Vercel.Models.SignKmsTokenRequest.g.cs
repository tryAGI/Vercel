
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SignKmsTokenRequest
    {
        /// <summary>
        /// The claims to include in the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        public object? Claims { get; set; }

        /// <summary>
        /// Additional headers to include in the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// The time-to-live for the token, in seconds.<br/>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public double? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsTokenRequest" /> class.
        /// </summary>
        /// <param name="claims">
        /// The claims to include in the token.
        /// </param>
        /// <param name="headers">
        /// Additional headers to include in the token.
        /// </param>
        /// <param name="ttl">
        /// The time-to-live for the token, in seconds.<br/>
        /// Default Value: 300
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignKmsTokenRequest(
            object? claims,
            object? headers,
            double? ttl)
        {
            this.Claims = claims;
            this.Headers = headers;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsTokenRequest" /> class.
        /// </summary>
        public SignKmsTokenRequest()
        {
        }

    }
}