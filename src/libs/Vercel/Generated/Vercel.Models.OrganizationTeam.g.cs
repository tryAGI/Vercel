
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationTeam
    {
        /// <summary>
        /// The child team's billing profile within the organization. Optional: links created before this attribute existed have no stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OrganizationTeamBillingPlanJsonConverter))]
        public global::Vercel.OrganizationTeamBillingPlan? BillingPlan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Whether the organization's Directory Sync manages the team's memberships.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dsyncMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OrganizationTeamDsyncModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OrganizationTeamDsyncMode DsyncMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OrganizationTeamSsoModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OrganizationTeamSsoMode SsoMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="OrganizationTeam" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="dsyncMode">
        /// Whether the organization's Directory Sync manages the team's memberships.
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="ssoMode"></param>
        /// <param name="teamId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="billingPlan">
        /// The child team's billing profile within the organization. Optional: links created before this attribute existed have no stored value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationTeam(
            string createdAt,
            global::Vercel.OrganizationTeamDsyncMode dsyncMode,
            string organizationId,
            global::Vercel.OrganizationTeamSsoMode ssoMode,
            string teamId,
            string updatedAt,
            global::Vercel.OrganizationTeamBillingPlan? billingPlan)
        {
            this.BillingPlan = billingPlan;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DsyncMode = dsyncMode;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.SsoMode = ssoMode;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationTeam" /> class.
        /// </summary>
        public OrganizationTeam()
        {
        }

    }
}