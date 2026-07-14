
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTraceSessionRequest
    {
        /// <summary>
        /// The project ID the deployment belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The deployment hostname to scope the trace session to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hostname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTraceSessionRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The project ID the deployment belongs to.
        /// </param>
        /// <param name="hostname">
        /// The deployment hostname to scope the trace session to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTraceSessionRequest(
            string projectId,
            string hostname)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTraceSessionRequest" /> class.
        /// </summary>
        public CreateTraceSessionRequest()
        {
        }

    }
}