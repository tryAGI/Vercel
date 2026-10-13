
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiTaskAnalysisTasksResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ListVercelCiTaskAnalysisTasksResponseTask> Tasks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListVercelCiTaskAnalysisTasksResponsePagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskAnalysisTasksResponse" /> class.
        /// </summary>
        /// <param name="tasks"></param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiTaskAnalysisTasksResponse(
            global::System.Collections.Generic.IList<global::Vercel.ListVercelCiTaskAnalysisTasksResponseTask> tasks,
            global::Vercel.ListVercelCiTaskAnalysisTasksResponsePagination pagination)
        {
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskAnalysisTasksResponse" /> class.
        /// </summary>
        public ListVercelCiTaskAnalysisTasksResponse()
        {
        }

    }
}