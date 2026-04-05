
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When "Directory Sync" is configured, this object contains a mapping of which Directory Group (by ID) should be assigned to which Vercel Team "role".
    /// </summary>
    public sealed partial class TeamSamlRolesEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessGroupId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSamlRolesEnum" /> class.
        /// </summary>
        /// <param name="accessGroupId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamSamlRolesEnum(
            string accessGroupId)
        {
            this.AccessGroupId = accessGroupId ?? throw new global::System.ArgumentNullException(nameof(accessGroupId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSamlRolesEnum" /> class.
        /// </summary>
        public TeamSamlRolesEnum()
        {
        }
    }
}