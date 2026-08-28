
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Context for the Update Account screen. Present only when `isAccountUpdateRequired` is true. `managedTeams` is empty for orphan mode (user matches an EMU domain but is not on the team).
    /// </summary>
    public sealed partial class AuthUserAccountUpdateContext
    {
        /// <summary>
        /// Whether this user can cancel their optional Account Update flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canOptOut")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanOptOut { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::Vercel.AuthUserAccountUpdateContextOrganization? Organization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedTeams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AuthUserAccountUpdateContextManagedTeam> ManagedTeams { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verifiedEmuDomains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VerifiedEmuDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserAccountUpdateContext" /> class.
        /// </summary>
        /// <param name="canOptOut">
        /// Whether this user can cancel their optional Account Update flow.
        /// </param>
        /// <param name="managedTeams"></param>
        /// <param name="verifiedEmuDomains"></param>
        /// <param name="organization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserAccountUpdateContext(
            bool canOptOut,
            global::System.Collections.Generic.IList<global::Vercel.AuthUserAccountUpdateContextManagedTeam> managedTeams,
            global::System.Collections.Generic.IList<string> verifiedEmuDomains,
            global::Vercel.AuthUserAccountUpdateContextOrganization? organization)
        {
            this.CanOptOut = canOptOut;
            this.Organization = organization;
            this.ManagedTeams = managedTeams ?? throw new global::System.ArgumentNullException(nameof(managedTeams));
            this.VerifiedEmuDomains = verifiedEmuDomains ?? throw new global::System.ArgumentNullException(nameof(verifiedEmuDomains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserAccountUpdateContext" /> class.
        /// </summary>
        public AuthUserAccountUpdateContext()
        {
        }

    }
}