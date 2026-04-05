
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// OpenID Connect JSON Web Token generation configuration.
    /// </summary>
    public sealed partial class UpdateProjectRequestOidcTokenConfig
    {
        /// <summary>
        /// Whether or not to generate OpenID Connect JSON Web Tokens.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// team: `https://oidc.vercel.com/[team_slug]` global: `https://oidc.vercel.com`<br/>
        /// Default Value: team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuerMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestOidcTokenConfigIssuerModeJsonConverter))]
        public global::Vercel.UpdateProjectRequestOidcTokenConfigIssuerMode? IssuerMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestOidcTokenConfig" /> class.
        /// </summary>
        /// <param name="issuerMode">
        /// team: `https://oidc.vercel.com/[team_slug]` global: `https://oidc.vercel.com`<br/>
        /// Default Value: team
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestOidcTokenConfig(
            global::Vercel.UpdateProjectRequestOidcTokenConfigIssuerMode? issuerMode)
        {
            this.IssuerMode = issuerMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestOidcTokenConfig" /> class.
        /// </summary>
        public UpdateProjectRequestOidcTokenConfig()
        {
        }
    }
}