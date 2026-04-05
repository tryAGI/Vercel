
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCheckRunsResponseRun
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("checkId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ListCheckRunsResponseRunSourceVariant1, global::Vercel.ListCheckRunsResponseRunSourceVariant2, global::Vercel.ListCheckRunsResponseRunSourceVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.ListCheckRunsResponseRunSourceVariant1, global::Vercel.ListCheckRunsResponseRunSourceVariant2, global::Vercel.ListCheckRunsResponseRunSourceVariant3> Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListCheckRunsResponseRunRequiresJsonConverter))]
        public global::Vercel.ListCheckRunsResponseRunRequires? Requires { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListCheckRunsResponseRunBlocksJsonConverter))]
        public global::Vercel.ListCheckRunsResponseRunBlocks? Blocks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<string>? Targets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListCheckRunsResponseRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListCheckRunsResponseRunStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListCheckRunsResponseRunConclusionJsonConverter))]
        public global::Vercel.ListCheckRunsResponseRunConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusionText")]
        public string? ConclusionText { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCheckRunsResponseRun" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="checkId"></param>
        /// <param name="ownerId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="source"></param>
        /// <param name="status"></param>
        /// <param name="timeout"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="projectId"></param>
        /// <param name="requires"></param>
        /// <param name="blocks"></param>
        /// <param name="targets"></param>
        /// <param name="conclusion"></param>
        /// <param name="conclusionText"></param>
        /// <param name="externalId"></param>
        /// <param name="externalUrl"></param>
        /// <param name="output"></param>
        /// <param name="completedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCheckRunsResponseRun(
            string id,
            string name,
            string checkId,
            string ownerId,
            string deploymentId,
            global::Vercel.OneOf<global::Vercel.ListCheckRunsResponseRunSourceVariant1, global::Vercel.ListCheckRunsResponseRunSourceVariant2, global::Vercel.ListCheckRunsResponseRunSourceVariant3> source,
            global::Vercel.ListCheckRunsResponseRunStatus status,
            double timeout,
            double createdAt,
            double updatedAt,
            string? projectId,
            global::Vercel.ListCheckRunsResponseRunRequires? requires,
            global::Vercel.ListCheckRunsResponseRunBlocks? blocks,
            global::System.Collections.Generic.IList<string>? targets,
            global::Vercel.ListCheckRunsResponseRunConclusion? conclusion,
            string? conclusionText,
            string? externalId,
            string? externalUrl,
            object? output,
            double? completedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CheckId = checkId ?? throw new global::System.ArgumentNullException(nameof(checkId));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.ProjectId = projectId;
            this.Source = source;
            this.Requires = requires;
            this.Blocks = blocks;
            this.Targets = targets;
            this.Status = status;
            this.Conclusion = conclusion;
            this.ConclusionText = conclusionText;
            this.ExternalId = externalId;
            this.ExternalUrl = externalUrl;
            this.Output = output;
            this.Timeout = timeout;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCheckRunsResponseRun" /> class.
        /// </summary>
        public ListCheckRunsResponseRun()
        {
        }
    }
}