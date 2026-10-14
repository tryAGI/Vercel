
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class DeploymentCheckUpdatedPayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public global::Vercel.DeploymentCheckUpdatedPayloadNext? Next { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public global::Vercel.DeploymentCheckUpdatedPayloadPrevious? Previous { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentCheckUpdatedPayload" /> class.
        /// </summary>
        /// <param name="checkId"></param>
        /// <param name="checkName"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="next"></param>
        /// <param name="previous"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentCheckUpdatedPayload(
            string checkId,
            string checkName,
            string projectId,
            string projectName,
            global::Vercel.DeploymentCheckUpdatedPayloadNext? next,
            global::Vercel.DeploymentCheckUpdatedPayloadPrevious? previous)
        {
            this.CheckId = checkId ?? throw new global::System.ArgumentNullException(nameof(checkId));
            this.CheckName = checkName ?? throw new global::System.ArgumentNullException(nameof(checkName));
            this.Next = next;
            this.Previous = previous;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentCheckUpdatedPayload" /> class.
        /// </summary>
        public DeploymentCheckUpdatedPayload()
        {
        }

    }
}