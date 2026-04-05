
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Successful response.
    /// </summary>
    public sealed partial class GetAuthTokenResponse
    {
        /// <summary>
        /// Authentication token metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AuthToken Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthTokenResponse" /> class.
        /// </summary>
        /// <param name="token">
        /// Authentication token metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAuthTokenResponse(
            global::Vercel.AuthToken token)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthTokenResponse" /> class.
        /// </summary>
        public GetAuthTokenResponse()
        {
        }
    }
}