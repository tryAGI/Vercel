
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Controls whether deployments may have their source and logs available publicly (i.e. the deployment's `public` boolean set to `true`). This rule does NOT control whether the deployment URL itself requires authentication — see deployment protection settings for that. - `allowPublicDeployments: false`: deployments must be created with `public: false`. Public deployments are blocked. - `allowPublicDeployments: true`: equivalent to `enabled: false`; here only so the field is always present on an enabled rule.
    /// </summary>
    public sealed partial class CreateProjectResponseDeploymentPolicyPublicDeployments
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowPublicDeployments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowPublicDeployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseDeploymentPolicyPublicDeployments" /> class.
        /// </summary>
        /// <param name="allowPublicDeployments"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectResponseDeploymentPolicyPublicDeployments(
            bool allowPublicDeployments,
            bool enabled)
        {
            this.AllowPublicDeployments = allowPublicDeployments;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseDeploymentPolicyPublicDeployments" /> class.
        /// </summary>
        public CreateProjectResponseDeploymentPolicyPublicDeployments()
        {
        }

    }
}