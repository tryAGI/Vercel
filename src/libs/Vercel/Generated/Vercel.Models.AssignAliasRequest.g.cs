
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignAliasRequest
    {
        /// <summary>
        /// The alias we want to assign to the deployment defined in the URL<br/>
        /// Example: my-alias.vercel.app
        /// </summary>
        /// <example>my-alias.vercel.app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// The redirect property will take precedence over the deployment id from the URL and consists of a hostname (like test.com) to which the alias should redirect using status code 307<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public string? Redirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignAliasRequest" /> class.
        /// </summary>
        /// <param name="alias">
        /// The alias we want to assign to the deployment defined in the URL<br/>
        /// Example: my-alias.vercel.app
        /// </param>
        /// <param name="redirect">
        /// The redirect property will take precedence over the deployment id from the URL and consists of a hostname (like test.com) to which the alias should redirect using status code 307<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignAliasRequest(
            string? alias,
            string? redirect)
        {
            this.Alias = alias;
            this.Redirect = redirect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignAliasRequest" /> class.
        /// </summary>
        public AssignAliasRequest()
        {
        }
    }
}