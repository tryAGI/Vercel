
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxRequestNetworkPolicyForwardRule
    {
        /// <summary>
        /// The domain (or pattern) of requests to forward. Supports wildcards like *.example.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// HTTP/1.1 proxy URL to forward traffic to. Must not include query string or fragment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forwardURL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ForwardURL { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxRequestNetworkPolicyForwardRule" /> class.
        /// </summary>
        /// <param name="domain">
        /// The domain (or pattern) of requests to forward. Supports wildcards like *.example.com.
        /// </param>
        /// <param name="forwardURL">
        /// HTTP/1.1 proxy URL to forward traffic to. Must not include query string or fragment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxRequestNetworkPolicyForwardRule(
            string domain,
            string forwardURL)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.ForwardURL = forwardURL ?? throw new global::System.ArgumentNullException(nameof(forwardURL));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxRequestNetworkPolicyForwardRule" /> class.
        /// </summary>
        public CreateSandboxRequestNetworkPolicyForwardRule()
        {
        }

    }
}