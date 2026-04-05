
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Successful response.
    /// </summary>
    public sealed partial class CreateAuthTokenResponse
    {
        /// <summary>
        /// Authentication token metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AuthToken Token { get; set; }

        /// <summary>
        /// The authentication token's actual value. This token is only provided in this response, and can never be retrieved again in the future. Be sure to save it somewhere safe!<br/>
        /// Example: uRKJSTt0L4RaSkiMj41QTkxM
        /// </summary>
        /// <example>uRKJSTt0L4RaSkiMj41QTkxM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearerToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BearerToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAuthTokenResponse" /> class.
        /// </summary>
        /// <param name="token">
        /// Authentication token metadata.
        /// </param>
        /// <param name="bearerToken">
        /// The authentication token's actual value. This token is only provided in this response, and can never be retrieved again in the future. Be sure to save it somewhere safe!<br/>
        /// Example: uRKJSTt0L4RaSkiMj41QTkxM
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAuthTokenResponse(
            global::Vercel.AuthToken token,
            string bearerToken)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.BearerToken = bearerToken ?? throw new global::System.ArgumentNullException(nameof(bearerToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAuthTokenResponse" /> class.
        /// </summary>
        public CreateAuthTokenResponse()
        {
        }
    }
}