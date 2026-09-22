
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Vercel CI check run without a parent `check` (no `checkId` field).
    /// </summary>
    public sealed partial class AutoSDKShared3e4933d1b69c5ad0Variant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared3e4933d1b69c5ad0Variant2BlocksJsonConverter))]
        public global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2Blocks? Blocks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared3e4933d1b69c5ad0Variant2ConclusionJsonConverter))]
        public global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion? Conclusion { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared3e4933d1b69c5ad0Variant2RequiresJsonConverter))]
        public global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2Requires? Requires { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared3e4933d1b69c5ad0Variant2StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2Status Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<string>? Targets { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2SourceVariant1, global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2SourceVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2SourceVariant1, global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2SourceVariant2> Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared3e4933d1b69c5ad0Variant2" /> class.
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
        /// <param name="externalId"></param>
        /// <param name="externalUrl"></param>
        /// <param name="output"></param>
        /// <param name="projectId"></param>
        /// <param name="requires"></param>
        /// <param name="targets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared3e4933d1b69c5ad0Variant2(
            double createdAt,
            string deploymentId,
            string id,
            string name,
            string ownerId,
            global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2Status status,
            double timeout,
            double updatedAt,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2SourceVariant1, global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2SourceVariant2> source,
            global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2Blocks? blocks,
            double? completedAt,
            global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion? conclusion,
            string? conclusionText,
            string? externalId,
            string? externalUrl,
            object? output,
            string? projectId,
            global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2Requires? requires,
            global::System.Collections.Generic.IList<string>? targets)
        {
            this.Blocks = blocks;
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
            this.ConclusionText = conclusionText;
            this.CreatedAt = createdAt;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.ExternalId = externalId;
            this.ExternalUrl = externalUrl;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Output = output;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ProjectId = projectId;
            this.Requires = requires;
            this.Status = status;
            this.Targets = targets;
            this.Timeout = timeout;
            this.UpdatedAt = updatedAt;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared3e4933d1b69c5ad0Variant2" /> class.
        /// </summary>
        public AutoSDKShared3e4933d1b69c5ad0Variant2()
        {
        }

    }
}