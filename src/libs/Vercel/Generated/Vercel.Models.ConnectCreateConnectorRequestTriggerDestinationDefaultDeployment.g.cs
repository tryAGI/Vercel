
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment
    {
        /// <summary>
        /// Project that receives triggers. During connector creation, omit it to use the top-level projectId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

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
        /// Initializes a new instance of the <see cref="ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Project that receives triggers. During connector creation, omit it to use the top-level projectId.
        /// </param>
        /// <param name="path">
        /// Route path on the linked project that receives forwarded trigger requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment(
            string? projectId,
            string? path)
        {
            this.ProjectId = projectId;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment" /> class.
        /// </summary>
        public ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment()
        {
        }

    }
}