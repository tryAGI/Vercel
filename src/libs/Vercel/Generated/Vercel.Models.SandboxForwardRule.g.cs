
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Rules that forward outgoing requests matching specific domains.
    /// </summary>
    public sealed partial class SandboxForwardRule
    {
        /// <summary>
        /// The domain (or wildcard pattern) that this forwarding rule applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// The URL to forward matching requests to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forwardURL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ForwardURL { get; set; }

        /// <summary>
        /// Request dimensions used to match this rule. Matcher values are omitted.<br/>
        /// Example: [path, method]
        /// </summary>
        /// <example>[path, method]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchDimensions")]
        public global::System.Collections.Generic.IList<string>? MatchDimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxForwardRule" /> class.
        /// </summary>
        /// <param name="domain">
        /// The domain (or wildcard pattern) that this forwarding rule applies to.
        /// </param>
        /// <param name="forwardURL">
        /// The URL to forward matching requests to.
        /// </param>
        /// <param name="matchDimensions">
        /// Request dimensions used to match this rule. Matcher values are omitted.<br/>
        /// Example: [path, method]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxForwardRule(
            string domain,
            string forwardURL,
            global::System.Collections.Generic.IList<string>? matchDimensions)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.ForwardURL = forwardURL ?? throw new global::System.ArgumentNullException(nameof(forwardURL));
            this.MatchDimensions = matchDimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxForwardRule" /> class.
        /// </summary>
        public SandboxForwardRule()
        {
        }

    }
}