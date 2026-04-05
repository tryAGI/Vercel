
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant176
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public string? Redirect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectStatusCode")]
        public double? RedirectStatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuredBy")]
        public string? ConfiguredBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant176" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="domain"></param>
        /// <param name="target"></param>
        /// <param name="redirect"></param>
        /// <param name="redirectStatusCode"></param>
        /// <param name="gitBranch"></param>
        /// <param name="configuredBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant176(
            string projectId,
            string projectName,
            string domain,
            string target,
            string? redirect,
            double? redirectStatusCode,
            string? gitBranch,
            string? configuredBy)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Redirect = redirect;
            this.RedirectStatusCode = redirectStatusCode;
            this.GitBranch = gitBranch;
            this.ConfiguredBy = configuredBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant176" /> class.
        /// </summary>
        public UserEventPayloadVariant176()
        {
        }
    }
}