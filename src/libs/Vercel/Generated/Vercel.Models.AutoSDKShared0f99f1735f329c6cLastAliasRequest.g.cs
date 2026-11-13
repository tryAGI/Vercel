
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The last promote or rollback request for the project and its job status. Only populated by `GET /v9/projects/{idOrName}` when called with `rollbackInfo=true`; `null` in every other response, even if a request exists.
    /// </summary>
    public sealed partial class AutoSDKShared0f99f1735f329c6cLastAliasRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromDeploymentId")]
        public string? FromDeploymentId { get; set; }

        /// <summary>
        /// If rolling back from a rolling release, fromDeploymentId captures the "base" of that rolling release, and fromRollingReleaseId captures the "target" of that rolling release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromRollingReleaseId")]
        public string? FromRollingReleaseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus JobStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toDeploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToDeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0f99f1735f329c6cLastAliasRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0f99f1735f329c6cLastAliasRequestType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f99f1735f329c6cLastAliasRequest" /> class.
        /// </summary>
        /// <param name="jobStatus"></param>
        /// <param name="requestedAt"></param>
        /// <param name="toDeploymentId"></param>
        /// <param name="type"></param>
        /// <param name="fromDeploymentId"></param>
        /// <param name="fromRollingReleaseId">
        /// If rolling back from a rolling release, fromDeploymentId captures the "base" of that rolling release, and fromRollingReleaseId captures the "target" of that rolling release.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0f99f1735f329c6cLastAliasRequest(
            global::Vercel.AutoSDKShared0f99f1735f329c6cLastAliasRequestJobStatus jobStatus,
            double requestedAt,
            string toDeploymentId,
            global::Vercel.AutoSDKShared0f99f1735f329c6cLastAliasRequestType type,
            string? fromDeploymentId,
            string? fromRollingReleaseId)
        {
            this.FromDeploymentId = fromDeploymentId;
            this.FromRollingReleaseId = fromRollingReleaseId;
            this.JobStatus = jobStatus;
            this.RequestedAt = requestedAt;
            this.ToDeploymentId = toDeploymentId ?? throw new global::System.ArgumentNullException(nameof(toDeploymentId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f99f1735f329c6cLastAliasRequest" /> class.
        /// </summary>
        public AutoSDKShared0f99f1735f329c6cLastAliasRequest()
        {
        }

    }
}