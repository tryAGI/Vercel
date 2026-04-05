
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectsByProjectIdRollbackByDeploymentIdUpdateDescriptionRequest
    {
        /// <summary>
        /// The reason for the rollback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectsByProjectIdRollbackByDeploymentIdUpdateDescriptionRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// The reason for the rollback
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectsByProjectIdRollbackByDeploymentIdUpdateDescriptionRequest(
            string? description)
        {
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectsByProjectIdRollbackByDeploymentIdUpdateDescriptionRequest" /> class.
        /// </summary>
        public UpdateProjectsByProjectIdRollbackByDeploymentIdUpdateDescriptionRequest()
        {
        }
    }
}