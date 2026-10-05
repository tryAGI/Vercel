
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede052f139ff613de3OidcTokenConfig
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede052f139ff613de3OidcTokenConfigIssuerModeJsonConverter))]
        public global::Vercel.AutoSDKSharede052f139ff613de3OidcTokenConfigIssuerMode? IssuerMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede052f139ff613de3OidcTokenConfig" /> class.
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
        public AutoSDKSharede052f139ff613de3OidcTokenConfig(
            bool? enabled,
            global::Vercel.AutoSDKSharede052f139ff613de3OidcTokenConfigIssuerMode? issuerMode)
        {
            this.Enabled = enabled;
            this.IssuerMode = issuerMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede052f139ff613de3OidcTokenConfig" /> class.
        /// </summary>
        public AutoSDKSharede052f139ff613de3OidcTokenConfig()
        {
        }

    }
}