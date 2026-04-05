
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectCheckResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isRerequestable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRerequestable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectCheckResponseRequiresJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectCheckResponseRequires Requires { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectCheckResponseSourceVariant1, global::Vercel.GetProjectCheckResponseSourceVariant2, global::Vercel.GetProjectCheckResponseSourceVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.GetProjectCheckResponseSourceVariant1, global::Vercel.GetProjectCheckResponseSourceVariant2, global::Vercel.GetProjectCheckResponseSourceVariant3> Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectCheckResponseBlocksJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectCheckResponseBlocks Blocks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Targets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectCheckResponseSourceKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectCheckResponseSourceKind SourceKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceIntegrationConfigurationId")]
        public string? SourceIntegrationConfigurationId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public double? DeletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectCheckResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="ownerId"></param>
        /// <param name="projectId"></param>
        /// <param name="isRerequestable"></param>
        /// <param name="requires"></param>
        /// <param name="source"></param>
        /// <param name="blocks"></param>
        /// <param name="targets"></param>
        /// <param name="sourceKind"></param>
        /// <param name="timeout"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="sourceIntegrationConfigurationId"></param>
        /// <param name="deletedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectCheckResponse(
            string id,
            string name,
            string ownerId,
            string projectId,
            bool isRerequestable,
            global::Vercel.GetProjectCheckResponseRequires requires,
            global::Vercel.OneOf<global::Vercel.GetProjectCheckResponseSourceVariant1, global::Vercel.GetProjectCheckResponseSourceVariant2, global::Vercel.GetProjectCheckResponseSourceVariant3> source,
            global::Vercel.GetProjectCheckResponseBlocks blocks,
            global::System.Collections.Generic.IList<string> targets,
            global::Vercel.GetProjectCheckResponseSourceKind sourceKind,
            double timeout,
            double createdAt,
            double updatedAt,
            string? sourceIntegrationConfigurationId,
            double? deletedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.IsRerequestable = isRerequestable;
            this.Requires = requires;
            this.Source = source;
            this.Blocks = blocks;
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
            this.SourceKind = sourceKind;
            this.SourceIntegrationConfigurationId = sourceIntegrationConfigurationId;
            this.Timeout = timeout;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectCheckResponse" /> class.
        /// </summary>
        public GetProjectCheckResponse()
        {
        }
    }
}