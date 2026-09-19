
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A paginated list of teams.
    /// </summary>
    public sealed partial class GetTeamsResponse
    {
        /// <summary>
        /// This object contains information related to the pagination of the current request, including the necessary parameters to get the next or previous page of data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Pagination Pagination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.Team, global::Vercel.TeamLimited>> Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamsResponse" /> class.
        /// </summary>
        /// <param name="pagination">
        /// This object contains information related to the pagination of the current request, including the necessary parameters to get the next or previous page of data.
        /// </param>
        /// <param name="teams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTeamsResponse(
            global::Vercel.Pagination pagination,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.Team, global::Vercel.TeamLimited>> teams)
        {
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamsResponse" /> class.
        /// </summary>
        public GetTeamsResponse()
        {
        }

    }
}