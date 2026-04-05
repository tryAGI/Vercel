
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Attribution metadata for the deployment, linking commit author to git and Vercel users. Only populated when the `enable-deployment-attribution` flag is enabled.
    /// </summary>
    public sealed partial class CancelDeploymentResponseAttribution
    {
        /// <summary>
        /// Commit metadata from the git commit author
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitMeta")]
        public global::Vercel.CancelDeploymentResponseAttributionCommitMeta? CommitMeta { get; set; }

        /// <summary>
        /// Git provider user associated with the commit author email (only set if resolved)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitUser")]
        public global::Vercel.CancelDeploymentResponseAttributionGitUser? GitUser { get; set; }

        /// <summary>
        /// Vercel user linked to the git provider account (only set if resolved)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelUser")]
        public global::Vercel.CancelDeploymentResponseAttributionVercelUser? VercelUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseAttribution" /> class.
        /// </summary>
        /// <param name="commitMeta">
        /// Commit metadata from the git commit author
        /// </param>
        /// <param name="gitUser">
        /// Git provider user associated with the commit author email (only set if resolved)
        /// </param>
        /// <param name="vercelUser">
        /// Vercel user linked to the git provider account (only set if resolved)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseAttribution(
            global::Vercel.CancelDeploymentResponseAttributionCommitMeta? commitMeta,
            global::Vercel.CancelDeploymentResponseAttributionGitUser? gitUser,
            global::Vercel.CancelDeploymentResponseAttributionVercelUser? vercelUser)
        {
            this.CommitMeta = commitMeta;
            this.GitUser = gitUser;
            this.VercelUser = vercelUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseAttribution" /> class.
        /// </summary>
        public CancelDeploymentResponseAttribution()
        {
        }
    }
}