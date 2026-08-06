
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Initial trigger destination routing for the linked project.
    /// </summary>
    public sealed partial class CreateConnectorRequestTriggerDestination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Route path on the linked project that receives forwarded trigger requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// The stable env_* ID of a custom environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentId")]
        public string? CustomEnvironmentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestTriggerDestination" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="path">
        /// Route path on the linked project that receives forwarded trigger requests.
        /// </param>
        /// <param name="branch"></param>
        /// <param name="customEnvironmentId">
        /// The stable env_* ID of a custom environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestTriggerDestination(
            string? projectId,
            string? path,
            string? branch,
            string? customEnvironmentId)
        {
            this.ProjectId = projectId;
            this.Path = path;
            this.Branch = branch;
            this.CustomEnvironmentId = customEnvironmentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestTriggerDestination" /> class.
        /// </summary>
        public CreateConnectorRequestTriggerDestination()
        {
        }

    }
}