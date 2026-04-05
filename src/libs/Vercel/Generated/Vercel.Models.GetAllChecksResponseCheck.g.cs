
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAllChecksResponseCheck
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAllChecksResponseCheckConclusionJsonConverter))]
        public global::Vercel.GetAllChecksResponseCheckConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailsUrl")]
        public string? DetailsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Vercel.GetAllChecksResponseCheckOutput? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerequestable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Rerequestable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Blocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public double? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAllChecksResponseCheckStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetAllChecksResponseCheckStatus Status { get; set; }

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
        /// Initializes a new instance of the <see cref="GetAllChecksResponseCheck" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="integrationId"></param>
        /// <param name="name"></param>
        /// <param name="rerequestable"></param>
        /// <param name="blocking"></param>
        /// <param name="status"></param>
        /// <param name="updatedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="detailsUrl"></param>
        /// <param name="output"></param>
        /// <param name="path"></param>
        /// <param name="startedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllChecksResponseCheck(
            double createdAt,
            string id,
            string integrationId,
            string name,
            bool rerequestable,
            bool blocking,
            global::Vercel.GetAllChecksResponseCheckStatus status,
            double updatedAt,
            double? completedAt,
            global::Vercel.GetAllChecksResponseCheckConclusion? conclusion,
            string? detailsUrl,
            global::Vercel.GetAllChecksResponseCheckOutput? output,
            string? path,
            double? startedAt)
        {
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
            this.CreatedAt = createdAt;
            this.DetailsUrl = detailsUrl;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Output = output;
            this.Path = path;
            this.Rerequestable = rerequestable;
            this.Blocking = blocking;
            this.StartedAt = startedAt;
            this.Status = status;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllChecksResponseCheck" /> class.
        /// </summary>
        public GetAllChecksResponseCheck()
        {
        }
    }
}