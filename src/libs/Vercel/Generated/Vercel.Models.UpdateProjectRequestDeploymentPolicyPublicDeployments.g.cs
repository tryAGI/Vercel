
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestDeploymentPolicyPublicDeployments
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowPublicDeployments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowPublicDeployments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDeploymentPolicyPublicDeployments" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="allowPublicDeployments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestDeploymentPolicyPublicDeployments(
            bool enabled,
            bool allowPublicDeployments)
        {
            this.Enabled = enabled;
            this.AllowPublicDeployments = allowPublicDeployments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDeploymentPolicyPublicDeployments" /> class.
        /// </summary>
        public UpdateProjectRequestDeploymentPolicyPublicDeployments()
        {
        }
    }
}