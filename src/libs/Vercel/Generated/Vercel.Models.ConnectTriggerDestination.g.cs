
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Destinations that incoming triggers should be forwarded to. Limited to 3 entries. Set the initial destination with `triggerDestination` during creation. Replace the complete set with `PATCH /v1/connect/connectors/{connector}/trigger-destinations`.
    /// </summary>
    public sealed partial class ConnectTriggerDestination
    {
        /// <summary>
        /// Vercel project that receives matching trigger requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Stable custom-environment ID to route this destination to. Mutually exclusive with `branch`; omitted destinations keep the legacy production behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentId")]
        public string? CustomEnvironmentId { get; set; }

        /// <summary>
        /// Git branch used to select a preview deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// Route path that receives the forwarded trigger request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectTriggerDestination" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Vercel project that receives matching trigger requests.
        /// </param>
        /// <param name="customEnvironmentId">
        /// Stable custom-environment ID to route this destination to. Mutually exclusive with `branch`; omitted destinations keep the legacy production behavior.
        /// </param>
        /// <param name="branch">
        /// Git branch used to select a preview deployment.
        /// </param>
        /// <param name="path">
        /// Route path that receives the forwarded trigger request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectTriggerDestination(
            string projectId,
            string? customEnvironmentId,
            string? branch,
            string? path)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.CustomEnvironmentId = customEnvironmentId;
            this.Branch = branch;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectTriggerDestination" /> class.
        /// </summary>
        public ConnectTriggerDestination()
        {
        }

    }
}