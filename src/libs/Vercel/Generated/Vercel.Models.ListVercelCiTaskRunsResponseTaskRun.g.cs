
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiTaskRunsResponseTaskRun
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvocationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationAttempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InvocationAttempt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobDefinitionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobDefinitionId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Attempt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started")]
        public global::Vercel.ListVercelCiTaskRunsResponseTaskRunStarted? Started { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public global::Vercel.ListVercelCiTaskRunsResponseTaskRunCompleted? Completed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskRunsResponseTaskRun" /> class.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="invocationAttempt"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="jobRunAttempt"></param>
        /// <param name="taskDefinitionId"></param>
        /// <param name="attempt"></param>
        /// <param name="createdAt"></param>
        /// <param name="started"></param>
        /// <param name="completed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiTaskRunsResponseTaskRun(
            string invocationId,
            double invocationAttempt,
            string jobDefinitionId,
            double jobRunAttempt,
            string taskDefinitionId,
            double attempt,
            double createdAt,
            global::Vercel.ListVercelCiTaskRunsResponseTaskRunStarted? started,
            global::Vercel.ListVercelCiTaskRunsResponseTaskRunCompleted? completed)
        {
            this.InvocationId = invocationId ?? throw new global::System.ArgumentNullException(nameof(invocationId));
            this.InvocationAttempt = invocationAttempt;
            this.JobDefinitionId = jobDefinitionId ?? throw new global::System.ArgumentNullException(nameof(jobDefinitionId));
            this.JobRunAttempt = jobRunAttempt;
            this.TaskDefinitionId = taskDefinitionId ?? throw new global::System.ArgumentNullException(nameof(taskDefinitionId));
            this.Attempt = attempt;
            this.CreatedAt = createdAt;
            this.Started = started;
            this.Completed = completed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskRunsResponseTaskRun" /> class.
        /// </summary>
        public ListVercelCiTaskRunsResponseTaskRun()
        {
        }

    }
}