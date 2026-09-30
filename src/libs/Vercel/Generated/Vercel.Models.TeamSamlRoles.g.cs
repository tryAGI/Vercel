
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When "Directory Sync" is configured, this object contains a mapping of which Directory Group (by ID) should be assigned to which Vercel Team roles and permissions, or an access group. Bare team roles are deprecated in favor of DirectorySyncRolesMapping.
    /// </summary>
    public sealed partial class TeamSamlRoles
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}