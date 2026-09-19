
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetTeamMembersResponsePagination
    {
        /// <summary>
        /// Amount of items in the current page.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasNext")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNext { get; set; }

        /// <summary>
        /// Timestamp that must be used to request the next page.<br/>
        /// Example: 1540095775951L
        /// </summary>
        /// <example>1540095775951L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public double? Next { get; set; }

        /// <summary>
        /// Timestamp that must be used to request the previous page.<br/>
        /// Example: 1540095775951L
        /// </summary>
        /// <example>1540095775951L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev")]
        public double? Prev { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamMembersResponsePagination" /> class.
        /// </summary>
        /// <param name="count">
        /// Amount of items in the current page.<br/>
        /// Example: 20
        /// </param>
        /// <param name="hasNext"></param>
        /// <param name="next">
        /// Timestamp that must be used to request the next page.<br/>
        /// Example: 1540095775951L
        /// </param>
        /// <param name="prev">
        /// Timestamp that must be used to request the previous page.<br/>
        /// Example: 1540095775951L
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTeamMembersResponsePagination(
            double count,
            bool hasNext,
            double? next,
            double? prev)
        {
            this.Count = count;
            this.HasNext = hasNext;
            this.Next = next;
            this.Prev = prev;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamMembersResponsePagination" /> class.
        /// </summary>
        public GetTeamMembersResponsePagination()
        {
        }

    }
}