
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCheckResponse
    {
        /// <summary>
        /// Example: chk_1a2b3c4d5e6f7g8h9i0j
        /// </summary>
        /// <example>chk_1a2b3c4d5e6f7g8h9i0j</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Example: Performance Check
        /// </summary>
        /// <example>Performance Check</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateCheckResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateCheckResponseStatus Status { get; set; }

        /// <summary>
        /// Example: succeeded
        /// </summary>
        /// <example>succeeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateCheckResponseConclusionJsonConverter))]
        public global::Vercel.CreateCheckResponseConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Vercel.CreateCheckResponseOutput? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        /// Example: /api/users
        /// </summary>
        /// <example>/api/users</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Blocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailsUrl")]
        public string? DetailsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public double? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerequestable")]
        public bool? Rerequestable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: chk_1a2b3c4d5e6f7g8h9i0j
        /// </param>
        /// <param name="name">
        /// Example: Performance Check
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="deploymentId"></param>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="blocking"></param>
        /// <param name="integrationId"></param>
        /// <param name="conclusion">
        /// Example: succeeded
        /// </param>
        /// <param name="externalId"></param>
        /// <param name="output"></param>
        /// <param name="completedAt"></param>
        /// <param name="path">
        /// Example: /api/users
        /// </param>
        /// <param name="detailsUrl"></param>
        /// <param name="startedAt"></param>
        /// <param name="rerequestable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCheckResponse(
            string id,
            string name,
            double createdAt,
            double updatedAt,
            string deploymentId,
            global::Vercel.CreateCheckResponseStatus status,
            bool blocking,
            string integrationId,
            global::Vercel.CreateCheckResponseConclusion? conclusion,
            string? externalId,
            global::Vercel.CreateCheckResponseOutput? output,
            double? completedAt,
            string? path,
            string? detailsUrl,
            double? startedAt,
            bool? rerequestable)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Status = status;
            this.Conclusion = conclusion;
            this.ExternalId = externalId;
            this.Output = output;
            this.CompletedAt = completedAt;
            this.Path = path;
            this.Blocking = blocking;
            this.DetailsUrl = detailsUrl;
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.StartedAt = startedAt;
            this.Rerequestable = rerequestable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckResponse" /> class.
        /// </summary>
        public CreateCheckResponse()
        {
        }
    }
}