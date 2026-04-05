
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When "Single Sign-On (SAML)" is configured, this object contains information that allows the client-side to identify whether or not this Team has SAML enforced.
    /// </summary>
    public sealed partial class TeamLimitedSaml
    {
        /// <summary>
        /// Information for the SAML Single Sign-On configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection")]
        public global::Vercel.TeamLimitedSamlConnection? Connection { get; set; }

        /// <summary>
        /// Information for the Directory Sync configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory")]
        public global::Vercel.TeamLimitedSamlDirectory? Directory { get; set; }

        /// <summary>
        /// When `true`, interactions with the Team **must** be done with an authentication token that has been authenticated with the Team's SAML Single Sign-On provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforced")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enforced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLimitedSaml" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamLimitedSaml(
            bool enforced,
            global::Vercel.TeamLimitedSamlConnection? connection,
            global::Vercel.TeamLimitedSamlDirectory? directory)
        {
            this.Connection = connection;
            this.Directory = directory;
            this.Enforced = enforced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLimitedSaml" /> class.
        /// </summary>
        public TeamLimitedSaml()
        {
        }
    }
}