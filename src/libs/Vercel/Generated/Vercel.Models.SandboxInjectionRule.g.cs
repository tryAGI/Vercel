
#nullable enable

namespace Vercel
{
    /// <summary>
    /// HTTP header injection rules for outgoing requests matching specific domains.
    /// </summary>
    public sealed partial class SandboxInjectionRule
    {
        /// <summary>
        /// The domain (or pattern) that this injection rule applies to. Supports wildcards like *.vercel.com.<br/>
        /// Example: api.vercel.com
        /// </summary>
        /// <example>api.vercel.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// The names of HTTP headers that have value that will be injected for requests to this domain.<br/>
        /// Example: [Authorization, X-API-Key]
        /// </summary>
        /// <example>[Authorization, X-API-Key]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headerNames")]
        public global::System.Collections.Generic.IList<string>? HeaderNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxInjectionRule" /> class.
        /// </summary>
        /// <param name="domain">
        /// The domain (or pattern) that this injection rule applies to. Supports wildcards like *.vercel.com.<br/>
        /// Example: api.vercel.com
        /// </param>
        /// <param name="headerNames">
        /// The names of HTTP headers that have value that will be injected for requests to this domain.<br/>
        /// Example: [Authorization, X-API-Key]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxInjectionRule(
            string domain,
            global::System.Collections.Generic.IList<string>? headerNames)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.HeaderNames = headerNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxInjectionRule" /> class.
        /// </summary>
        public SandboxInjectionRule()
        {
        }
    }
}