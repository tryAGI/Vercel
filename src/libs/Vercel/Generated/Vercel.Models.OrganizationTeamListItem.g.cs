
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An org-team link enriched with the linked team's display fields, as returned by the list-teams endpoint. We project to an explicit flat interface instead of spreading the ElectroDB `OrganizationTeamItem` because its recursive generics break the OpenAPI generator (which would silently drop the route).
    /// </summary>
    public sealed partial class OrganizationTeamListItem
    {
        /// <summary>
        /// The ID of the file used as the Team's avatar, or `null` if none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Billing profile of the organization link: how this team settles within the organization. This is not the team's billing.plan or planIteration. Links with `enterprise` billing participate in organization-level billing and usage rollups. This field is optional for legacy links that have no stored profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OrganizationTeamListItemBillingPlanJsonConverter))]
        public global::Vercel.OrganizationTeamListItemBillingPlan? BillingPlan { get; set; }

        /// <summary>
        /// ISO timestamp of when the team was linked to the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Present only when the request sets `includeMemberCount=true`. Number of members on the Team, including pending memberships. Excludes email invitations that do not have a membership record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memberCount")]
        public double? MemberCount { get; set; }

        /// <summary>
        /// The Team's display name, or `null` if none has been set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The ID of the organization the team belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// The Team's slug, unique across Vercel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OrganizationTeamListItemSsoModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OrganizationTeamListItemSsoMode SsoMode { get; set; }

        /// <summary>
        /// The Team's unique identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// ISO timestamp of when the link was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationTeamListItem" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO timestamp of when the team was linked to the organization.
        /// </param>
        /// <param name="organizationId">
        /// The ID of the organization the team belongs to.
        /// </param>
        /// <param name="slug">
        /// The Team's slug, unique across Vercel.
        /// </param>
        /// <param name="ssoMode"></param>
        /// <param name="teamId">
        /// The Team's unique identifier.
        /// </param>
        /// <param name="updatedAt">
        /// ISO timestamp of when the link was last updated.
        /// </param>
        /// <param name="avatar">
        /// The ID of the file used as the Team's avatar, or `null` if none.
        /// </param>
        /// <param name="billingPlan">
        /// Billing profile of the organization link: how this team settles within the organization. This is not the team's billing.plan or planIteration. Links with `enterprise` billing participate in organization-level billing and usage rollups. This field is optional for legacy links that have no stored profile.
        /// </param>
        /// <param name="memberCount">
        /// Present only when the request sets `includeMemberCount=true`. Number of members on the Team, including pending memberships. Excludes email invitations that do not have a membership record.
        /// </param>
        /// <param name="name">
        /// The Team's display name, or `null` if none has been set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationTeamListItem(
            string createdAt,
            string organizationId,
            string slug,
            global::Vercel.OrganizationTeamListItemSsoMode ssoMode,
            string teamId,
            string updatedAt,
            string? avatar,
            global::Vercel.OrganizationTeamListItemBillingPlan? billingPlan,
            double? memberCount,
            string? name)
        {
            this.Avatar = avatar;
            this.BillingPlan = billingPlan;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.MemberCount = memberCount;
            this.Name = name;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.SsoMode = ssoMode;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationTeamListItem" /> class.
        /// </summary>
        public OrganizationTeamListItem()
        {
        }

    }
}