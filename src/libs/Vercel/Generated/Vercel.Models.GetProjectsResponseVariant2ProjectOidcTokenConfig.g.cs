
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectOidcTokenConfig
    {
        /// <summary>
        /// Whether or not to generate OpenID Connect JSON Web Tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuerMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectOidcTokenConfigIssuerModeJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant2ProjectOidcTokenConfigIssuerMode? IssuerMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectOidcTokenConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether or not to generate OpenID Connect JSON Web Tokens.
        /// </param>
        /// <param name="issuerMode">
        /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectOidcTokenConfig(
            bool? enabled,
            global::Vercel.GetProjectsResponseVariant2ProjectOidcTokenConfigIssuerMode? issuerMode)
        {
            this.Enabled = enabled;
            this.IssuerMode = issuerMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectOidcTokenConfig" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectOidcTokenConfig()
        {
        }
    }
}