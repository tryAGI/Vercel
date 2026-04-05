
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDeploymentCheckRunRequest
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDeploymentCheckRunRequestStatusJsonConverter))]
        public global::Vercel.UpdateDeploymentCheckRunRequestStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDeploymentCheckRunRequestConclusionJsonConverter))]
        public global::Vercel.UpdateDeploymentCheckRunRequestConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusionText")]
        public string? ConclusionText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentCheckRunRequest" /> class.
        /// </summary>
        /// <param name="externalId"></param>
        /// <param name="externalUrl"></param>
        /// <param name="status"></param>
        /// <param name="output"></param>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="conclusionText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDeploymentCheckRunRequest(
            string? externalId,
            string? externalUrl,
            global::Vercel.UpdateDeploymentCheckRunRequestStatus? status,
            object? output,
            double? completedAt,
            global::Vercel.UpdateDeploymentCheckRunRequestConclusion? conclusion,
            string? conclusionText)
        {
            this.ExternalId = externalId;
            this.ExternalUrl = externalUrl;
            this.Status = status;
            this.Output = output;
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
            this.ConclusionText = conclusionText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentCheckRunRequest" /> class.
        /// </summary>
        public UpdateDeploymentCheckRunRequest()
        {
        }
    }
}