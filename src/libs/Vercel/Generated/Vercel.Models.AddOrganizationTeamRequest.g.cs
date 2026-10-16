
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddOrganizationTeamRequest
    {
        /// <summary>
        /// Whether to create a new team under the organization (\"create\") or link an existing one (\"link\").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AddOrganizationTeamRequestModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AddOrganizationTeamRequestMode Mode { get; set; }

        /// <summary>
        /// The ID of an existing team to add to the organization (link mode).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// The slug of an existing team to link, or the slug for a new team to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// The display name for a new team. Required in create mode; rejected in link mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AddOrganizationTeamRequestBillingPlanJsonConverter))]
        public global::Vercel.AddOrganizationTeamRequestBillingPlan? BillingPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrganizationTeamRequest" /> class.
        /// </summary>
        /// <param name="mode">
        /// Whether to create a new team under the organization (\"create\") or link an existing one (\"link\").
        /// </param>
        /// <param name="teamId">
        /// The ID of an existing team to add to the organization (link mode).
        /// </param>
        /// <param name="slug">
        /// The slug of an existing team to link, or the slug for a new team to create.
        /// </param>
        /// <param name="name">
        /// The display name for a new team. Required in create mode; rejected in link mode.
        /// </param>
        /// <param name="billingPlan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddOrganizationTeamRequest(
            global::Vercel.AddOrganizationTeamRequestMode mode,
            string? teamId,
            string? slug,
            string? name,
            global::Vercel.AddOrganizationTeamRequestBillingPlan? billingPlan)
        {
            this.Mode = mode;
            this.TeamId = teamId;
            this.Slug = slug;
            this.Name = name;
            this.BillingPlan = billingPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrganizationTeamRequest" /> class.
        /// </summary>
        public AddOrganizationTeamRequest()
        {
        }

    }
}