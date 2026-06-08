
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Destinations that incoming triggers should be forwarded to. Limited to `MAX_CONNEX_TRIGGER_DESTINATIONS` entries.
    /// </summary>
    public sealed partial class CreateConnectorResponseTriggerDestination
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
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseTriggerDestination" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branch"></param>
        /// <param name="path"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorResponseTriggerDestination(
            string projectId,
            string? branch,
            string? path)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Branch = branch;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseTriggerDestination" /> class.
        /// </summary>
        public CreateConnectorResponseTriggerDestination()
        {
        }

    }
}