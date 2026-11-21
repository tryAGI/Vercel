
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutOrganizationTeamDsyncResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dsyncMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutOrganizationTeamDsyncResponseDsyncModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutOrganizationTeamDsyncResponseDsyncMode DsyncMode { get; set; }

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
        /// Initializes a new instance of the <see cref="PutOrganizationTeamDsyncResponse" /> class.
        /// </summary>
        /// <param name="dsyncMode"></param>
        /// <param name="organizationId"></param>
        /// <param name="teamId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutOrganizationTeamDsyncResponse(
            global::Vercel.PutOrganizationTeamDsyncResponseDsyncMode dsyncMode,
            string organizationId,
            string teamId)
        {
            this.DsyncMode = dsyncMode;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationTeamDsyncResponse" /> class.
        /// </summary>
        public PutOrganizationTeamDsyncResponse()
        {
        }

    }
}