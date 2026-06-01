
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Context for the Update Account screen. Present only when `isAccountUpdateRequired` is true. `managedTeamNames` is empty for orphan mode (user matches an EMU domain but is not on the team).
    /// </summary>
    public sealed partial class AuthUserAccountUpdateContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedTeamNames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ManagedTeamNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserAccountUpdateContext" /> class.
        /// </summary>
        /// <param name="managedTeamNames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserAccountUpdateContext(
            global::System.Collections.Generic.IList<string> managedTeamNames)
        {
            this.ManagedTeamNames = managedTeamNames ?? throw new global::System.ArgumentNullException(nameof(managedTeamNames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserAccountUpdateContext" /> class.
        /// </summary>
        public AuthUserAccountUpdateContext()
        {
        }

    }
}