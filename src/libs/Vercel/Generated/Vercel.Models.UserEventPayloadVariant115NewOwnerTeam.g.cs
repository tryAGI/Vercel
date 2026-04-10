
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant115NewOwnerTeam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Confirmed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConfirmedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessRequestedAt")]
        public double? AccessRequestedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerTeamRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant115NewOwnerTeamRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRoles")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerTeamTeamRole>? TeamRoles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamPermissions")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerTeamTeamPermission>? TeamPermissions { get; set; }

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
        public global::Vercel.UserEventPayloadVariant115NewOwnerTeamJoinedFrom? JoinedFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerTeam" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="teamId"></param>
        /// <param name="confirmed"></param>
        /// <param name="confirmedAt"></param>
        /// <param name="role"></param>
        /// <param name="created"></param>
        /// <param name="accessRequestedAt"></param>
        /// <param name="teamRoles"></param>
        /// <param name="teamPermissions"></param>
        /// <param name="joinedFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant115NewOwnerTeam(
            double createdAt,
            string teamId,
            bool confirmed,
            double confirmedAt,
            global::Vercel.UserEventPayloadVariant115NewOwnerTeamRole role,
            double created,
            double? accessRequestedAt,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerTeamTeamRole>? teamRoles,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerTeamTeamPermission>? teamPermissions,
            global::Vercel.UserEventPayloadVariant115NewOwnerTeamJoinedFrom? joinedFrom)
        {
            this.CreatedAt = createdAt;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Confirmed = confirmed;
            this.ConfirmedAt = confirmedAt;
            this.AccessRequestedAt = accessRequestedAt;
            this.Role = role;
            this.TeamRoles = teamRoles;
            this.TeamPermissions = teamPermissions;
            this.Created = created;
            this.JoinedFrom = joinedFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerTeam" /> class.
        /// </summary>
        public UserEventPayloadVariant115NewOwnerTeam()
        {
        }
    }
}