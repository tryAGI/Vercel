
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared19aed0f0e253807cOidcTokenConfig
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared19aed0f0e253807cOidcTokenConfigIssuerModeJsonConverter))]
        public global::Vercel.AutoSDKShared19aed0f0e253807cOidcTokenConfigIssuerMode? IssuerMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared19aed0f0e253807cOidcTokenConfig" /> class.
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
        public AutoSDKShared19aed0f0e253807cOidcTokenConfig(
            bool? enabled,
            global::Vercel.AutoSDKShared19aed0f0e253807cOidcTokenConfigIssuerMode? issuerMode)
        {
            this.Enabled = enabled;
            this.IssuerMode = issuerMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared19aed0f0e253807cOidcTokenConfig" /> class.
        /// </summary>
        public AutoSDKShared19aed0f0e253807cOidcTokenConfig()
        {
        }

    }
}