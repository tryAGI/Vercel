
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemoveOrganizationTeamResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveOrganizationTeamResponse" /> class.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="teamId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveOrganizationTeamResponse(
            string organizationId,
            string teamId)
        {
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveOrganizationTeamResponse" /> class.
        /// </summary>
        public RemoveOrganizationTeamResponse()
        {
        }

    }
}