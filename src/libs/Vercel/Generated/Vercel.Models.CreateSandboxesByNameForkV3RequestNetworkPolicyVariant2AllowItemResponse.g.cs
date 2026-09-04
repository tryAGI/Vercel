
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Answer matching requests from the proxy with this response instead of forwarding them to the origin. Combine with a `match` on an earlier rule to allow one sub-path and reject the rest of a domain.
    /// </summary>
    public sealed partial class CreateSandboxesByNameForkV3RequestNetworkPolicyVariant2AllowItemResponse
    {
        /// <summary>
        /// HTTP status code returned to the sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// HTTP response headers. Framing and hop-by-hop headers are managed by the proxy and cannot be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// UTF-8 response body. Requires `contentType`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Value of the `Content-Type` response header. Required when `body` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesByNameForkV3RequestNetworkPolicyVariant2AllowItemResponse" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// HTTP status code returned to the sandbox.
        /// </param>
        /// <param name="headers">
        /// HTTP response headers. Framing and hop-by-hop headers are managed by the proxy and cannot be set.
        /// </param>
        /// <param name="body">
        /// UTF-8 response body. Requires `contentType`.
        /// </param>
        /// <param name="contentType">
        /// Value of the `Content-Type` response header. Required when `body` is set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesByNameForkV3RequestNetworkPolicyVariant2AllowItemResponse(
            int statusCode,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? body,
            string? contentType)
        {
            this.StatusCode = statusCode;
            this.Headers = headers;
            this.Body = body;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesByNameForkV3RequestNetworkPolicyVariant2AllowItemResponse" /> class.
        /// </summary>
        public CreateSandboxesByNameForkV3RequestNetworkPolicyVariant2AllowItemResponse()
        {
        }

    }
}