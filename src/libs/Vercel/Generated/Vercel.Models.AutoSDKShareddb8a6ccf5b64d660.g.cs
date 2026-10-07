
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Vercel CI check run without a parent `check` (no `checkId` field).
    /// </summary>
    public sealed partial class AutoSDKShareddb8a6ccf5b64d660
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareddb8a6ccf5b64d660BlocksJsonConverter))]
        public global::Vercel.AutoSDKShareddb8a6ccf5b64d660Blocks? Blocks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareddb8a6ccf5b64d660ConclusionJsonConverter))]
        public global::Vercel.AutoSDKShareddb8a6ccf5b64d660Conclusion? Conclusion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusionText")]
        public string? ConclusionText { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectationRef")]
        public global::Vercel.AutoSDKShareddb8a6ccf5b64d660ExpectationRef? ExpectationRef { get; set; }

        /// <summary>
        /// Latest aggregate revision applied to this check run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectationRevision")]
        public double? ExpectationRevision { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalUrl")]
        public string? ExternalUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareddb8a6ccf5b64d660RequiresJsonConverter))]
        public global::Vercel.AutoSDKShareddb8a6ccf5b64d660Requires? Requires { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public double? StartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareddb8a6ccf5b64d660StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShareddb8a6ccf5b64d660Status Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<string>? Targets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskSummary")]
        public global::Vercel.AutoSDKShareddb8a6ccf5b64d660TaskSummary? TaskSummary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShareddb8a6ccf5b64d660SourceVariant1, global::Vercel.AutoSDKShareddb8a6ccf5b64d660SourceVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShareddb8a6ccf5b64d660SourceVariant1, global::Vercel.AutoSDKShareddb8a6ccf5b64d660SourceVariant2> Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareddb8a6ccf5b64d660" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="deploymentId"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="ownerId"></param>
        /// <param name="status"></param>
        /// <param name="timeout"></param>
        /// <param name="updatedAt"></param>
        /// <param name="source"></param>
        /// <param name="blocks"></param>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="conclusionText"></param>
        /// <param name="expectationRef"></param>
        /// <param name="expectationRevision">
        /// Latest aggregate revision applied to this check run.
        /// </param>
        /// <param name="externalId"></param>
        /// <param name="externalUrl"></param>
        /// <param name="output"></param>
        /// <param name="projectId"></param>
        /// <param name="requires"></param>
        /// <param name="startedAt"></param>
        /// <param name="targets"></param>
        /// <param name="taskSummary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareddb8a6ccf5b64d660(
            double createdAt,
            string deploymentId,
            string id,
            string name,
            string ownerId,
            global::Vercel.AutoSDKShareddb8a6ccf5b64d660Status status,
            double timeout,
            double updatedAt,
            global::Vercel.OneOf<global::Vercel.AutoSDKShareddb8a6ccf5b64d660SourceVariant1, global::Vercel.AutoSDKShareddb8a6ccf5b64d660SourceVariant2> source,
            global::Vercel.AutoSDKShareddb8a6ccf5b64d660Blocks? blocks,
            double? completedAt,
            global::Vercel.AutoSDKShareddb8a6ccf5b64d660Conclusion? conclusion,
            string? conclusionText,
            global::Vercel.AutoSDKShareddb8a6ccf5b64d660ExpectationRef? expectationRef,
            double? expectationRevision,
            string? externalId,
            string? externalUrl,
            object? output,
            string? projectId,
            global::Vercel.AutoSDKShareddb8a6ccf5b64d660Requires? requires,
            double? startedAt,
            global::System.Collections.Generic.IList<string>? targets,
            global::Vercel.AutoSDKShareddb8a6ccf5b64d660TaskSummary? taskSummary)
        {
            this.Blocks = blocks;
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
            this.ConclusionText = conclusionText;
            this.CreatedAt = createdAt;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.ExpectationRef = expectationRef;
            this.ExpectationRevision = expectationRevision;
            this.ExternalId = externalId;
            this.ExternalUrl = externalUrl;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Output = output;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ProjectId = projectId;
            this.Requires = requires;
            this.StartedAt = startedAt;
            this.Status = status;
            this.Targets = targets;
            this.TaskSummary = taskSummary;
            this.Timeout = timeout;
            this.UpdatedAt = updatedAt;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareddb8a6ccf5b64d660" /> class.
        /// </summary>
        public AutoSDKShareddb8a6ccf5b64d660()
        {
        }

    }
}