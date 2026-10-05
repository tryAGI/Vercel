
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Check run backed by a project-level `check` definition.
    /// </summary>
    public sealed partial class AutoSDKShared87d88207314b07b3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared87d88207314b07b3BlocksJsonConverter))]
        public global::Vercel.AutoSDKShared87d88207314b07b3Blocks? Blocks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared87d88207314b07b3ConclusionJsonConverter))]
        public global::Vercel.AutoSDKShared87d88207314b07b3Conclusion? Conclusion { get; set; }

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
        public global::Vercel.AutoSDKShared87d88207314b07b3ExpectationRef? ExpectationRef { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared87d88207314b07b3RequiresJsonConverter))]
        public global::Vercel.AutoSDKShared87d88207314b07b3Requires? Requires { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared87d88207314b07b3StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared87d88207314b07b3Status Status { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("checkId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant1, global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant2, global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant3, global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4, global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant5>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant1, global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant2, global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant3, global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4, global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant5> Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared87d88207314b07b3" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="deploymentId"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="ownerId"></param>
        /// <param name="status"></param>
        /// <param name="timeout"></param>
        /// <param name="updatedAt"></param>
        /// <param name="checkId"></param>
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
        /// <param name="targets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared87d88207314b07b3(
            double createdAt,
            string deploymentId,
            string id,
            string name,
            string ownerId,
            global::Vercel.AutoSDKShared87d88207314b07b3Status status,
            double timeout,
            double updatedAt,
            string checkId,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant1, global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant2, global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant3, global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4, global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant5> source,
            global::Vercel.AutoSDKShared87d88207314b07b3Blocks? blocks,
            double? completedAt,
            global::Vercel.AutoSDKShared87d88207314b07b3Conclusion? conclusion,
            string? conclusionText,
            global::Vercel.AutoSDKShared87d88207314b07b3ExpectationRef? expectationRef,
            double? expectationRevision,
            string? externalId,
            string? externalUrl,
            object? output,
            string? projectId,
            global::Vercel.AutoSDKShared87d88207314b07b3Requires? requires,
            global::System.Collections.Generic.IList<string>? targets)
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
            this.Status = status;
            this.Targets = targets;
            this.Timeout = timeout;
            this.UpdatedAt = updatedAt;
            this.CheckId = checkId ?? throw new global::System.ArgumentNullException(nameof(checkId));
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared87d88207314b07b3" /> class.
        /// </summary>
        public AutoSDKShared87d88207314b07b3()
        {
        }

    }
}