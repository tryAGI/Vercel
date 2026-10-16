
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListOrganizationTeamsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OrganizationTeamListItem> Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationTeamsResponse" /> class.
        /// </summary>
        /// <param name="teams"></param>
        /// <param name="cursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOrganizationTeamsResponse(
            global::System.Collections.Generic.IList<global::Vercel.OrganizationTeamListItem> teams,
            string? cursor)
        {
            this.Cursor = cursor;
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationTeamsResponse" /> class.
        /// </summary>
        public ListOrganizationTeamsResponse()
        {
        }

    }
}