
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCheckResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Blocking { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("detailsUrl")]
        public string? DetailsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Example: chk_1a2b3c4d5e6f7g8h9i0j
        /// </summary>
        /// <example>chk_1a2b3c4d5e6f7g8h9i0j</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Vercel.CreateCheckResponseOutput? Output { get; set; }

        /// <summary>
        /// Example: /api/users
        /// </summary>
        /// <example>/api/users</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerequestable")]
        public bool? Rerequestable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public double? StartedAt { get; set; }

        /// <summary>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateCheckResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateCheckResponseStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckResponse" /> class.
        /// </summary>
        /// <param name="blocking"></param>
        /// <param name="createdAt"></param>
        /// <param name="deploymentId"></param>
        /// <param name="id">
        /// Example: chk_1a2b3c4d5e6f7g8h9i0j
        /// </param>
        /// <param name="integrationId"></param>
        /// <param name="name">
        /// Example: Performance Check
        /// </param>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="conclusion">
        /// Example: succeeded
        /// </param>
        /// <param name="detailsUrl"></param>
        /// <param name="externalId"></param>
        /// <param name="output"></param>
        /// <param name="path">
        /// Example: /api/users
        /// </param>
        /// <param name="rerequestable"></param>
        /// <param name="startedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCheckResponse(
            bool blocking,
            double createdAt,
            string deploymentId,
            string id,
            string integrationId,
            string name,
            global::Vercel.CreateCheckResponseStatus status,
            double updatedAt,
            double? completedAt,
            global::Vercel.CreateCheckResponseConclusion? conclusion,
            string? detailsUrl,
            string? externalId,
            global::Vercel.CreateCheckResponseOutput? output,
            string? path,
            bool? rerequestable,
            double? startedAt)
        {
            this.Blocking = blocking;
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
            this.CreatedAt = createdAt;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.DetailsUrl = detailsUrl;
            this.ExternalId = externalId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Output = output;
            this.Path = path;
            this.Rerequestable = rerequestable;
            this.StartedAt = startedAt;
            this.Status = status;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckResponse" /> class.
        /// </summary>
        public CreateCheckResponse()
        {
        }

    }
}