
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseIntegrations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseIntegrationsStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDeploymentResponseIntegrationsStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimedAt")]
        public double? ClaimedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skippedAt")]
        public double? SkippedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skippedBy")]
        public string? SkippedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseIntegrations" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="startedAt"></param>
        /// <param name="claimedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="skippedAt"></param>
        /// <param name="skippedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseIntegrations(
            global::Vercel.CreateDeploymentResponseIntegrationsStatus status,
            double startedAt,
            double? claimedAt,
            double? completedAt,
            double? skippedAt,
            string? skippedBy)
        {
            this.Status = status;
            this.StartedAt = startedAt;
            this.ClaimedAt = claimedAt;
            this.CompletedAt = completedAt;
            this.SkippedAt = skippedAt;
            this.SkippedBy = skippedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseIntegrations" /> class.
        /// </summary>
        public CreateDeploymentResponseIntegrations()
        {
        }
    }
}