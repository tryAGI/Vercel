
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchVercelCiLogsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SearchVercelCiLogsResponseInvocation> Invocations { get; set; }

        /// <summary>
        /// Whether more than 1000 lines matched. The newest lines are returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchVercelCiLogsResponse" /> class.
        /// </summary>
        /// <param name="invocations"></param>
        /// <param name="hasMore">
        /// Whether more than 1000 lines matched. The newest lines are returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchVercelCiLogsResponse(
            global::System.Collections.Generic.IList<global::Vercel.SearchVercelCiLogsResponseInvocation> invocations,
            bool hasMore)
        {
            this.Invocations = invocations ?? throw new global::System.ArgumentNullException(nameof(invocations));
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchVercelCiLogsResponse" /> class.
        /// </summary>
        public SearchVercelCiLogsResponse()
        {
        }

    }
}