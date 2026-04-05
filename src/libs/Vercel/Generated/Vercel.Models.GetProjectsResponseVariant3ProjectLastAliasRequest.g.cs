
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectLastAliasRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromDeploymentId")]
        public string? FromDeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toDeploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToDeploymentId { get; set; }

        /// <summary>
        /// If rolling back from a rolling release, fromDeploymentId captures the "base" of that rolling release, and fromRollingReleaseId captures the "target" of that rolling release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromRollingReleaseId")]
        public string? FromRollingReleaseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectLastAliasRequestJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus JobStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectLastAliasRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant3ProjectLastAliasRequestType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectLastAliasRequest" /> class.
        /// </summary>
        /// <param name="toDeploymentId"></param>
        /// <param name="jobStatus"></param>
        /// <param name="requestedAt"></param>
        /// <param name="type"></param>
        /// <param name="fromDeploymentId"></param>
        /// <param name="fromRollingReleaseId">
        /// If rolling back from a rolling release, fromDeploymentId captures the "base" of that rolling release, and fromRollingReleaseId captures the "target" of that rolling release.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectLastAliasRequest(
            string toDeploymentId,
            global::Vercel.GetProjectsResponseVariant3ProjectLastAliasRequestJobStatus jobStatus,
            double requestedAt,
            global::Vercel.GetProjectsResponseVariant3ProjectLastAliasRequestType type,
            string? fromDeploymentId,
            string? fromRollingReleaseId)
        {
            this.FromDeploymentId = fromDeploymentId;
            this.ToDeploymentId = toDeploymentId ?? throw new global::System.ArgumentNullException(nameof(toDeploymentId));
            this.FromRollingReleaseId = fromRollingReleaseId;
            this.JobStatus = jobStatus;
            this.RequestedAt = requestedAt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectLastAliasRequest" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectLastAliasRequest()
        {
        }
    }
}