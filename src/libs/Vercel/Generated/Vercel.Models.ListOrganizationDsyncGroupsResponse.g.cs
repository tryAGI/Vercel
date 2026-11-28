
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListOrganizationDsyncGroupsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OrganizationDirectorySyncGroup> Groups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationDsyncGroupsResponse" /> class.
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="cursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOrganizationDsyncGroupsResponse(
            global::System.Collections.Generic.IList<global::Vercel.OrganizationDirectorySyncGroup> groups,
            string? cursor)
        {
            this.Cursor = cursor;
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationDsyncGroupsResponse" /> class.
        /// </summary>
        public ListOrganizationDsyncGroupsResponse()
        {
        }

    }
}