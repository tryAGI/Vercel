
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Rules that return custom responses for requests matching specific domains.
    /// </summary>
    public sealed partial class SandboxResponseRule
    {
        /// <summary>
        /// The domain (or wildcard pattern) that this response rule applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Request dimensions used to match this rule. Matcher values are omitted.<br/>
        /// Example: [path, method]
        /// </summary>
        /// <example>[path, method]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchDimensions")]
        public global::System.Collections.Generic.IList<string>? MatchDimensions { get; set; }

        /// <summary>
        /// The HTTP status code returned for matching requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxResponseRule" /> class.
        /// </summary>
        /// <param name="domain">
        /// The domain (or wildcard pattern) that this response rule applies to.
        /// </param>
        /// <param name="statusCode">
        /// The HTTP status code returned for matching requests.
        /// </param>
        /// <param name="matchDimensions">
        /// Request dimensions used to match this rule. Matcher values are omitted.<br/>
        /// Example: [path, method]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxResponseRule(
            string domain,
            double statusCode,
            global::System.Collections.Generic.IList<string>? matchDimensions)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.MatchDimensions = matchDimensions;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxResponseRule" /> class.
        /// </summary>
        public SandboxResponseRule()
        {
        }

    }
}