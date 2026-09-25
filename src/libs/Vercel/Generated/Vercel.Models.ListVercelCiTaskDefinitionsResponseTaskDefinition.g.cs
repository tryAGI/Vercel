
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiTaskDefinitionsResponseTaskDefinition
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.ListVercelCiTaskDefinitionsResponseTaskDefinitionOperationVariant1, global::Vercel.ListVercelCiTaskDefinitionsResponseTaskDefinitionOperationVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.ListVercelCiTaskDefinitionsResponseTaskDefinitionOperationVariant1, global::Vercel.ListVercelCiTaskDefinitionsResponseTaskDefinitionOperationVariant2> Operation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencyTaskDefinitionIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DependencyTaskDefinitionIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskDefinitionsResponseTaskDefinition" /> class.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="invocationAttempt"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="jobRunAttempt"></param>
        /// <param name="taskDefinitionId"></param>
        /// <param name="name"></param>
        /// <param name="operation"></param>
        /// <param name="dependencyTaskDefinitionIds"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiTaskDefinitionsResponseTaskDefinition(
            string invocationId,
            double invocationAttempt,
            string jobDefinitionId,
            double jobRunAttempt,
            string taskDefinitionId,
            string name,
            global::Vercel.AnyOf<global::Vercel.ListVercelCiTaskDefinitionsResponseTaskDefinitionOperationVariant1, global::Vercel.ListVercelCiTaskDefinitionsResponseTaskDefinitionOperationVariant2> operation,
            global::System.Collections.Generic.IList<string> dependencyTaskDefinitionIds,
            double createdAt)
        {
            this.InvocationId = invocationId ?? throw new global::System.ArgumentNullException(nameof(invocationId));
            this.InvocationAttempt = invocationAttempt;
            this.JobDefinitionId = jobDefinitionId ?? throw new global::System.ArgumentNullException(nameof(jobDefinitionId));
            this.JobRunAttempt = jobRunAttempt;
            this.TaskDefinitionId = taskDefinitionId ?? throw new global::System.ArgumentNullException(nameof(taskDefinitionId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Operation = operation;
            this.DependencyTaskDefinitionIds = dependencyTaskDefinitionIds ?? throw new global::System.ArgumentNullException(nameof(dependencyTaskDefinitionIds));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskDefinitionsResponseTaskDefinition" /> class.
        /// </summary>
        public ListVercelCiTaskDefinitionsResponseTaskDefinition()
        {
        }

    }
}