
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectTriggerDestinationInputCustomEnvironment
    {
        /// <summary>
        /// Project that receives matching trigger requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Stable custom environment ID that belongs to the destination project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomEnvironmentId { get; set; }

        /// <summary>
        /// Route path on the linked project that receives forwarded trigger requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectTriggerDestinationInputCustomEnvironment" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Project that receives matching trigger requests.
        /// </param>
        /// <param name="customEnvironmentId">
        /// Stable custom environment ID that belongs to the destination project.
        /// </param>
        /// <param name="path">
        /// Route path on the linked project that receives forwarded trigger requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectTriggerDestinationInputCustomEnvironment(
            string projectId,
            string customEnvironmentId,
            string? path)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.CustomEnvironmentId = customEnvironmentId ?? throw new global::System.ArgumentNullException(nameof(customEnvironmentId));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectTriggerDestinationInputCustomEnvironment" /> class.
        /// </summary>
        public ConnectTriggerDestinationInputCustomEnvironment()
        {
        }

    }
}