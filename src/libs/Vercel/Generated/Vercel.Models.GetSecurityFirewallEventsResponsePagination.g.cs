
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSecurityFirewallEventsResponsePagination
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Pass as `cursor` to fetch the next page; null when there are no more.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallEventsResponsePagination" /> class.
        /// </summary>
        /// <param name="hasMore"></param>
        /// <param name="next">
        /// Pass as `cursor` to fetch the next page; null when there are no more.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSecurityFirewallEventsResponsePagination(
            bool hasMore,
            string? next)
        {
            this.HasMore = hasMore;
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallEventsResponsePagination" /> class.
        /// </summary>
        public GetSecurityFirewallEventsResponsePagination()
        {
        }

    }
}