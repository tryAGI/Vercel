
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A list of the aliases assigned to the deployment
    /// </summary>
    public sealed partial class ListDeploymentAliasesResponseAliase
    {
        /// <summary>
        /// The unique identifier of the alias<br/>
        /// Example: 2WjyKQmM8ZnGcJsPWMrHRHrE
        /// </summary>
        /// <example>2WjyKQmM8ZnGcJsPWMrHRHrE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// The alias name, it could be a `.vercel.app` subdomain or a custom domain<br/>
        /// Example: my-alias.vercel.app
        /// </summary>
        /// <example>my-alias.vercel.app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// The date when the alias was created<br/>
        /// Example: 2017-04-26T23:00:34.232Z
        /// </summary>
        /// <example>2017-04-26T23:00:34.232Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// Target destination domain for redirect when the alias is a redirect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public string? Redirect { get; set; }

        /// <summary>
        /// The protection bypass for the alias
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectionBypass")]
        public object? ProtectionBypass { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeploymentAliasesResponseAliase" /> class.
        /// </summary>
        /// <param name="uid">
        /// The unique identifier of the alias<br/>
        /// Example: 2WjyKQmM8ZnGcJsPWMrHRHrE
        /// </param>
        /// <param name="alias">
        /// The alias name, it could be a `.vercel.app` subdomain or a custom domain<br/>
        /// Example: my-alias.vercel.app
        /// </param>
        /// <param name="created">
        /// The date when the alias was created<br/>
        /// Example: 2017-04-26T23:00:34.232Z
        /// </param>
        /// <param name="redirect">
        /// Target destination domain for redirect when the alias is a redirect
        /// </param>
        /// <param name="protectionBypass">
        /// The protection bypass for the alias
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListDeploymentAliasesResponseAliase(
            string uid,
            string alias,
            global::System.DateTime created,
            string? redirect,
            object? protectionBypass)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Created = created;
            this.Redirect = redirect;
            this.ProtectionBypass = protectionBypass;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeploymentAliasesResponseAliase" /> class.
        /// </summary>
        public ListDeploymentAliasesResponseAliase()
        {
        }
    }
}