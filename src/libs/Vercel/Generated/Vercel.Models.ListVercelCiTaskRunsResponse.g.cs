
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiTaskRunsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskRuns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ListVercelCiTaskRunsResponseTaskRun> TaskRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskRunsResponse" /> class.
        /// </summary>
        /// <param name="taskRuns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiTaskRunsResponse(
            global::System.Collections.Generic.IList<global::Vercel.ListVercelCiTaskRunsResponseTaskRun> taskRuns)
        {
            this.TaskRuns = taskRuns ?? throw new global::System.ArgumentNullException(nameof(taskRuns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskRunsResponse" /> class.
        /// </summary>
        public ListVercelCiTaskRunsResponse()
        {
        }

    }
}