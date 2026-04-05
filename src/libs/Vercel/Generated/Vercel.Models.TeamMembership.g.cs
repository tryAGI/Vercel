
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The membership of the authenticated User in relation to the Team.
    /// </summary>
    public sealed partial class TeamMembership
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlements")]
        public global::System.Collections.Generic.IList<global::Vercel.TeamMembershipEntitlement>? Entitlements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Confirmed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessRequestedAt")]
        public double? AccessRequestedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamMembershipRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.TeamMembershipRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        public global::System.Collections.Generic.IList<global::Vercel.TeamMembershipTeamRole>? TeamRoles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamPermissions")]
        public global::System.Collections.Generic.IList<global::Vercel.TeamMembershipTeamPermission>? TeamPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinedFrom")]
        public global::Vercel.TeamMembershipJoinedFrom? JoinedFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembership" /> class.
        /// </summary>
        /// <param name="confirmed"></param>
        /// <param name="role"></param>
        /// <param name="createdAt"></param>
        /// <param name="created"></param>
        /// <param name="uid"></param>
        /// <param name="entitlements"></param>
        /// <param name="teamId"></param>
        /// <param name="accessRequestedAt"></param>
        /// <param name="teamRoles"></param>
        /// <param name="teamPermissions"></param>
        /// <param name="joinedFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMembership(
            bool confirmed,
            global::Vercel.TeamMembershipRole role,
            double createdAt,
            double created,
            string? uid,
            global::System.Collections.Generic.IList<global::Vercel.TeamMembershipEntitlement>? entitlements,
            string? teamId,
            double? accessRequestedAt,
            global::System.Collections.Generic.IList<global::Vercel.TeamMembershipTeamRole>? teamRoles,
            global::System.Collections.Generic.IList<global::Vercel.TeamMembershipTeamPermission>? teamPermissions,
            global::Vercel.TeamMembershipJoinedFrom? joinedFrom)
        {
            this.Uid = uid;
            this.Entitlements = entitlements;
            this.TeamId = teamId;
            this.Confirmed = confirmed;
            this.AccessRequestedAt = accessRequestedAt;
            this.Role = role;
            this.TeamRoles = teamRoles;
            this.TeamPermissions = teamPermissions;
            this.CreatedAt = createdAt;
            this.Created = created;
            this.JoinedFrom = joinedFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembership" /> class.
        /// </summary>
        public TeamMembership()
        {
        }
    }
}