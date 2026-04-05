
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDomainAuthCodeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainAuthCodeResponse" /> class.
        /// </summary>
        /// <param name="authCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDomainAuthCodeResponse(
            string authCode)
        {
            this.AuthCode = authCode ?? throw new global::System.ArgumentNullException(nameof(authCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainAuthCodeResponse" /> class.
        /// </summary>
        public GetDomainAuthCodeResponse()
        {
        }
    }
}