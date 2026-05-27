
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional L7 match. When provided, the injection rule only applies to requests that satisfy every specified dimension. When multiple injection rules target the same domain they are evaluated in order and the first match wins; a rule without `match` matches any request and shadows later rules for the same domain.
    /// </summary>
    public sealed partial class UpdateSandboxRequestNetworkPolicyVariant1InjectionRuleMatch
    {
        /// <summary>
        /// Match on the request path. Comparison is case-sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public global::Vercel.UpdateSandboxRequestNetworkPolicyVariant1InjectionRuleMatchPath? Path { get; set; }

        /// <summary>
        /// HTTP methods to match. Any single match succeeds (OR semantics).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public global::System.Collections.Generic.IList<string>? Method { get; set; }

        /// <summary>
        /// Query-string entry matchers. Multiple entries are ANDed. Query parameter names and values are both compared case-sensitively (RFC 3986). When a request has multiple values for the same key, any matching value satisfies the matcher.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryString")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateSandboxRequestNetworkPolicyVariant1InjectionRuleMatchQueryStringItem>? QueryString { get; set; }

        /// <summary>
        /// Header matchers. Multiple entries are ANDed. Header names are compared case-insensitively (RFC 9110); header values are compared case-sensitively. When a request has multiple values for the same header, any matching value satisfies the matcher.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateSandboxRequestNetworkPolicyVariant1InjectionRuleMatchHeader>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxRequestNetworkPolicyVariant1InjectionRuleMatch" /> class.
        /// </summary>
        /// <param name="path">
        /// Match on the request path. Comparison is case-sensitive.
        /// </param>
        /// <param name="method">
        /// HTTP methods to match. Any single match succeeds (OR semantics).
        /// </param>
        /// <param name="queryString">
        /// Query-string entry matchers. Multiple entries are ANDed. Query parameter names and values are both compared case-sensitively (RFC 3986). When a request has multiple values for the same key, any matching value satisfies the matcher.
        /// </param>
        /// <param name="headers">
        /// Header matchers. Multiple entries are ANDed. Header names are compared case-insensitively (RFC 9110); header values are compared case-sensitively. When a request has multiple values for the same header, any matching value satisfies the matcher.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSandboxRequestNetworkPolicyVariant1InjectionRuleMatch(
            global::Vercel.UpdateSandboxRequestNetworkPolicyVariant1InjectionRuleMatchPath? path,
            global::System.Collections.Generic.IList<string>? method,
            global::System.Collections.Generic.IList<global::Vercel.UpdateSandboxRequestNetworkPolicyVariant1InjectionRuleMatchQueryStringItem>? queryString,
            global::System.Collections.Generic.IList<global::Vercel.UpdateSandboxRequestNetworkPolicyVariant1InjectionRuleMatchHeader>? headers)
        {
            this.Path = path;
            this.Method = method;
            this.QueryString = queryString;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxRequestNetworkPolicyVariant1InjectionRuleMatch" /> class.
        /// </summary>
        public UpdateSandboxRequestNetworkPolicyVariant1InjectionRuleMatch()
        {
        }

    }
}