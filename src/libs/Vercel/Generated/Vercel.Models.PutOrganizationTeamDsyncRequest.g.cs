
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutOrganizationTeamDsyncRequest
    {
        /// <summary>
        /// Whether the Organization's Directory Sync or the team's own directory governs the team's memberships.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dsyncMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutOrganizationTeamDsyncRequestDsyncModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutOrganizationTeamDsyncRequestDsyncMode DsyncMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationTeamDsyncRequest" /> class.
        /// </summary>
        /// <param name="dsyncMode">
        /// Whether the Organization's Directory Sync or the team's own directory governs the team's memberships.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutOrganizationTeamDsyncRequest(
            global::Vercel.PutOrganizationTeamDsyncRequestDsyncMode dsyncMode)
        {
            this.DsyncMode = dsyncMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationTeamDsyncRequest" /> class.
        /// </summary>
        public PutOrganizationTeamDsyncRequest()
        {
        }

    }
}