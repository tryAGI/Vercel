
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSessionNetworkPolicyRequestVariant1InjectionRule
    {
        /// <summary>
        /// The domain (or pattern) of requests to add headers for. Supports wildcards like *.example.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// HTTP headers to inject into requests for this domain. Existing headers with the same name will be overridden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Optional L7 match. When provided, the injection rule only applies to requests that satisfy every specified dimension. When multiple injection rules target the same domain they are evaluated in order and the first match wins; a rule without `match` matches any request and shadows later rules for the same domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        public global::Vercel.UpdateSessionNetworkPolicyRequestVariant1InjectionRuleMatch? Match { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSessionNetworkPolicyRequestVariant1InjectionRule" /> class.
        /// </summary>
        /// <param name="domain">
        /// The domain (or pattern) of requests to add headers for. Supports wildcards like *.example.com.
        /// </param>
        /// <param name="headers">
        /// HTTP headers to inject into requests for this domain. Existing headers with the same name will be overridden.
        /// </param>
        /// <param name="match">
        /// Optional L7 match. When provided, the injection rule only applies to requests that satisfy every specified dimension. When multiple injection rules target the same domain they are evaluated in order and the first match wins; a rule without `match` matches any request and shadows later rules for the same domain.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSessionNetworkPolicyRequestVariant1InjectionRule(
            string domain,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::Vercel.UpdateSessionNetworkPolicyRequestVariant1InjectionRuleMatch? match)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Match = match;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSessionNetworkPolicyRequestVariant1InjectionRule" /> class.
        /// </summary>
        public UpdateSessionNetworkPolicyRequestVariant1InjectionRule()
        {
        }

    }
}