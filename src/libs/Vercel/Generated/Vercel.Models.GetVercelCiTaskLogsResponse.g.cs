
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVercelCiTaskLogsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetVercelCiTaskLogsResponseTask> Tasks { get; set; }

        /// <summary>
        /// Whether more tasks matched the filters than were returned. With `search`, whether more than 1000 lines matched.
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
        /// Initializes a new instance of the <see cref="GetVercelCiTaskLogsResponse" /> class.
        /// </summary>
        /// <param name="tasks"></param>
        /// <param name="hasMore">
        /// Whether more tasks matched the filters than were returned. With `search`, whether more than 1000 lines matched.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVercelCiTaskLogsResponse(
            global::System.Collections.Generic.IList<global::Vercel.GetVercelCiTaskLogsResponseTask> tasks,
            bool hasMore)
        {
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiTaskLogsResponse" /> class.
        /// </summary>
        public GetVercelCiTaskLogsResponse()
        {
        }

    }
}