
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The membership of the authenticated User in relation to the Team.
    /// </summary>
    public sealed partial class AutoSDKShared5dd9960a4fc82feb
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessRequestedAt")]
        public double? AccessRequestedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Confirmed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Created { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlements")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared5dd9960a4fc82febEntitlement>? Entitlements { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isOrgBackingTeamMembership")]
        public bool? IsOrgBackingTeamMembership { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinedFrom")]
        public global::Vercel.AutoSDKShared5dd9960a4fc82febJoinedFrom? JoinedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        public string? OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared5dd9960a4fc82febRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared5dd9960a4fc82febRole Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamPermissions")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared5dd9960a4fc82febTeamPermission>? TeamPermissions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared5dd9960a4fc82febTeamRole>? TeamRoles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared5dd9960a4fc82feb" /> class.
        /// </summary>
        /// <param name="confirmed"></param>
        /// <param name="created"></param>
        /// <param name="createdAt"></param>
        /// <param name="role"></param>
        /// <param name="accessRequestedAt"></param>
        /// <param name="entitlements"></param>
        /// <param name="isOrgBackingTeamMembership"></param>
        /// <param name="joinedFrom"></param>
        /// <param name="organizationId"></param>
        /// <param name="teamId"></param>
        /// <param name="teamPermissions"></param>
        /// <param name="teamRoles"></param>
        /// <param name="uid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared5dd9960a4fc82feb(
            bool confirmed,
            double created,
            double createdAt,
            global::Vercel.AutoSDKShared5dd9960a4fc82febRole role,
            double? accessRequestedAt,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared5dd9960a4fc82febEntitlement>? entitlements,
            bool? isOrgBackingTeamMembership,
            global::Vercel.AutoSDKShared5dd9960a4fc82febJoinedFrom? joinedFrom,
            string? organizationId,
            string? teamId,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared5dd9960a4fc82febTeamPermission>? teamPermissions,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared5dd9960a4fc82febTeamRole>? teamRoles,
            string? uid)
        {
            this.AccessRequestedAt = accessRequestedAt;
            this.Confirmed = confirmed;
            this.Created = created;
            this.CreatedAt = createdAt;
            this.Entitlements = entitlements;
            this.IsOrgBackingTeamMembership = isOrgBackingTeamMembership;
            this.JoinedFrom = joinedFrom;
            this.OrganizationId = organizationId;
            this.Role = role;
            this.TeamId = teamId;
            this.TeamPermissions = teamPermissions;
            this.TeamRoles = teamRoles;
            this.Uid = uid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared5dd9960a4fc82feb" /> class.
        /// </summary>
        public AutoSDKShared5dd9960a4fc82feb()
        {
        }

    }
}