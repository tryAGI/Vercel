
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When "Single Sign-On (SAML)" is configured, this object contains information regarding the configuration of the Identity Provider (IdP).
    /// </summary>
    public sealed partial class TeamSaml
    {
        /// <summary>
        /// Information for the SAML Single Sign-On configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection")]
        public global::Vercel.TeamSamlConnection? Connection { get; set; }

        /// <summary>
        /// Information for the Directory Sync configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory")]
        public global::Vercel.TeamSamlDirectory? Directory { get; set; }

        /// <summary>
        /// When `true`, interactions with the Team **must** be done with an authentication token that has been authenticated with the Team's SAML Single Sign-On provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforced")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enforced { get; set; }

        /// <summary>
        /// The default redirect URI to use after successful SAML authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRedirectUri")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamSamlDefaultRedirectUriJsonConverter))]
        public global::Vercel.TeamSamlDefaultRedirectUri? DefaultRedirectUri { get; set; }

        /// <summary>
        /// When "Directory Sync" is configured, this object contains a mapping of which Directory Group (by ID) should be assigned to which Vercel Team "role".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public object? Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSaml" /> class.
        /// </summary>
        /// <param name="enforced">
        /// When `true`, interactions with the Team **must** be done with an authentication token that has been authenticated with the Team's SAML Single Sign-On provider.
        /// </param>
        /// <param name="connection">
        /// Information for the SAML Single Sign-On configuration.
        /// </param>
        /// <param name="directory">
        /// Information for the Directory Sync configuration.
        /// </param>
        /// <param name="defaultRedirectUri">
        /// The default redirect URI to use after successful SAML authentication.
        /// </param>
        /// <param name="roles">
        /// When "Directory Sync" is configured, this object contains a mapping of which Directory Group (by ID) should be assigned to which Vercel Team "role".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamSaml(
            bool enforced,
            global::Vercel.TeamSamlConnection? connection,
            global::Vercel.TeamSamlDirectory? directory,
            global::Vercel.TeamSamlDefaultRedirectUri? defaultRedirectUri,
            object? roles)
        {
            this.Connection = connection;
            this.Directory = directory;
            this.Enforced = enforced;
            this.DefaultRedirectUri = defaultRedirectUri;
            this.Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSaml" /> class.
        /// </summary>
        public TeamSaml()
        {
        }
    }
}