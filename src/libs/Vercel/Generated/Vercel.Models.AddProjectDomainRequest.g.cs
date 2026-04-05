
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddProjectDomainRequest
    {
        /// <summary>
        /// The project domain name<br/>
        /// Example: www.example.com
        /// </summary>
        /// <example>www.example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Git branch to link the project domain<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        /// The unique custom environment identifier within the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentId")]
        public string? CustomEnvironmentId { get; set; }

        /// <summary>
        /// Target destination domain for redirect<br/>
        /// Example: foobar.com
        /// </summary>
        /// <example>foobar.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public string? Redirect { get; set; }

        /// <summary>
        /// Status code for domain redirect<br/>
        /// Example: 307
        /// </summary>
        /// <example>307</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectStatusCode")]
        public int? RedirectStatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectDomainRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The project domain name<br/>
        /// Example: www.example.com
        /// </param>
        /// <param name="gitBranch">
        /// Git branch to link the project domain<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="customEnvironmentId">
        /// The unique custom environment identifier within the project
        /// </param>
        /// <param name="redirect">
        /// Target destination domain for redirect<br/>
        /// Example: foobar.com
        /// </param>
        /// <param name="redirectStatusCode">
        /// Status code for domain redirect<br/>
        /// Example: 307
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddProjectDomainRequest(
            string name,
            string? gitBranch,
            string? customEnvironmentId,
            string? redirect,
            int? redirectStatusCode)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.GitBranch = gitBranch;
            this.CustomEnvironmentId = customEnvironmentId;
            this.Redirect = redirect;
            this.RedirectStatusCode = redirectStatusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectDomainRequest" /> class.
        /// </summary>
        public AddProjectDomainRequest()
        {
        }
    }
}