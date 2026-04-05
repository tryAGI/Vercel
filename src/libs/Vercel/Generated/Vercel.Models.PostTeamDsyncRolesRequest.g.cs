
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostTeamDsyncRolesRequest
    {
        /// <summary>
        /// Directory groups to role or access group mappings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTeamDsyncRolesRequest" /> class.
        /// </summary>
        /// <param name="roles">
        /// Directory groups to role or access group mappings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostTeamDsyncRolesRequest(
            object roles)
        {
            this.Roles = roles ?? throw new global::System.ArgumentNullException(nameof(roles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTeamDsyncRolesRequest" /> class.
        /// </summary>
        public PostTeamDsyncRolesRequest()
        {
        }
    }
}