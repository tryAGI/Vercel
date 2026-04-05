
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateIntegrationDeploymentActionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateIntegrationDeploymentActionRequestStatusJsonConverter))]
        public global::Vercel.UpdateIntegrationDeploymentActionRequestStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusText")]
        public string? StatusText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusUrl")]
        public string? StatusUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcomes")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateIntegrationDeploymentActionRequestOutcome>? Outcomes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIntegrationDeploymentActionRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="statusText"></param>
        /// <param name="statusUrl"></param>
        /// <param name="outcomes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateIntegrationDeploymentActionRequest(
            global::Vercel.UpdateIntegrationDeploymentActionRequestStatus? status,
            string? statusText,
            string? statusUrl,
            global::System.Collections.Generic.IList<global::Vercel.UpdateIntegrationDeploymentActionRequestOutcome>? outcomes)
        {
            this.Status = status;
            this.StatusText = statusText;
            this.StatusUrl = statusUrl;
            this.Outcomes = outcomes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIntegrationDeploymentActionRequest" /> class.
        /// </summary>
        public UpdateIntegrationDeploymentActionRequest()
        {
        }
    }
}