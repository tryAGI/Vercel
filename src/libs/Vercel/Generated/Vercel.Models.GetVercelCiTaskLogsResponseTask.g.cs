
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVercelCiTaskLogsResponseTask
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobDefinitionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobDefinitionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobRunAttempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double JobRunAttempt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskDefinitionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskDefinitionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskRunAttempt")]
        public double? TaskRunAttempt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.GetVercelCiTaskLogsResponseTaskConclusionVariant1, global::Vercel.GetVercelCiTaskLogsResponseTaskConclusionVariant2, global::Vercel.GetVercelCiTaskLogsResponseTaskConclusionVariant3, global::Vercel.GetVercelCiTaskLogsResponseTaskConclusionVariant4>))]
        public global::Vercel.AnyOf<global::Vercel.GetVercelCiTaskLogsResponseTaskConclusionVariant1, global::Vercel.GetVercelCiTaskLogsResponseTaskConclusionVariant2, global::Vercel.GetVercelCiTaskLogsResponseTaskConclusionVariant3, global::Vercel.GetVercelCiTaskLogsResponseTaskConclusionVariant4>? Conclusion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetVercelCiTaskLogsResponseTaskLine> Lines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiTaskLogsResponseTask" /> class.
        /// </summary>
        /// <param name="jobDefinitionId"></param>
        /// <param name="jobName"></param>
        /// <param name="jobRunAttempt"></param>
        /// <param name="taskDefinitionId"></param>
        /// <param name="taskName"></param>
        /// <param name="lines"></param>
        /// <param name="taskRunAttempt"></param>
        /// <param name="conclusion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVercelCiTaskLogsResponseTask(
            string jobDefinitionId,
            string jobName,
            double jobRunAttempt,
            string taskDefinitionId,
            string taskName,
            global::System.Collections.Generic.IList<global::Vercel.GetVercelCiTaskLogsResponseTaskLine> lines,
            double? taskRunAttempt,
            global::Vercel.AnyOf<global::Vercel.GetVercelCiTaskLogsResponseTaskConclusionVariant1, global::Vercel.GetVercelCiTaskLogsResponseTaskConclusionVariant2, global::Vercel.GetVercelCiTaskLogsResponseTaskConclusionVariant3, global::Vercel.GetVercelCiTaskLogsResponseTaskConclusionVariant4>? conclusion)
        {
            this.JobDefinitionId = jobDefinitionId ?? throw new global::System.ArgumentNullException(nameof(jobDefinitionId));
            this.JobName = jobName ?? throw new global::System.ArgumentNullException(nameof(jobName));
            this.JobRunAttempt = jobRunAttempt;
            this.TaskDefinitionId = taskDefinitionId ?? throw new global::System.ArgumentNullException(nameof(taskDefinitionId));
            this.TaskName = taskName ?? throw new global::System.ArgumentNullException(nameof(taskName));
            this.TaskRunAttempt = taskRunAttempt;
            this.Conclusion = conclusion;
            this.Lines = lines ?? throw new global::System.ArgumentNullException(nameof(lines));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiTaskLogsResponseTask" /> class.
        /// </summary>
        public GetVercelCiTaskLogsResponseTask()
        {
        }

    }
}