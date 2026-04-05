
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A list of the deployment routing information for each project.
    /// </summary>
    public sealed partial class ListAliasesResponseAliaseMicrofrontendsApplicationsVariant3Item
    {
        /// <summary>
        /// This is the deployment for the same commit, it could be a cancelled deployment. The proxy will fallback to the branchDeploymentId and then the fallbackDeploymentId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// This is the latest non-cancelled deployment of the branch alias at the time the commit alias was created. It is possible there is no deployment for the branch, or this was set before the deployment was canceled, in which case this will point to a cancelled deployment, in either case the proxy will fallback to the fallbackDeploymentId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchDeploymentId")]
        public string? BranchDeploymentId { get; set; }

        /// <summary>
        /// This is the deployment of the fallback host at the time the commit alias was created. It is possible for this to be a deleted deployment, in which case the proxy will show that the deployment is deleted. It will not use the fallbackHost, as a future deployment on the fallback host could be invalid for this deployment, and it could lead to confusion / incorrect behavior for the commit alias.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackDeploymentId")]
        public string? FallbackDeploymentId { get; set; }

        /// <summary>
        /// Temporary for backwards compatibility. Can remove when metadata change is released
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackHost")]
        public string? FallbackHost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchAlias")]
        public string? BranchAlias { get; set; }

        /// <summary>
        /// The project ID of the microfrontends application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAliasesResponseAliaseMicrofrontendsApplicationsVariant3Item" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The project ID of the microfrontends application.
        /// </param>
        /// <param name="deploymentId">
        /// This is the deployment for the same commit, it could be a cancelled deployment. The proxy will fallback to the branchDeploymentId and then the fallbackDeploymentId.
        /// </param>
        /// <param name="branchDeploymentId">
        /// This is the latest non-cancelled deployment of the branch alias at the time the commit alias was created. It is possible there is no deployment for the branch, or this was set before the deployment was canceled, in which case this will point to a cancelled deployment, in either case the proxy will fallback to the fallbackDeploymentId.
        /// </param>
        /// <param name="fallbackDeploymentId">
        /// This is the deployment of the fallback host at the time the commit alias was created. It is possible for this to be a deleted deployment, in which case the proxy will show that the deployment is deleted. It will not use the fallbackHost, as a future deployment on the fallback host could be invalid for this deployment, and it could lead to confusion / incorrect behavior for the commit alias.
        /// </param>
        /// <param name="fallbackHost">
        /// Temporary for backwards compatibility. Can remove when metadata change is released
        /// </param>
        /// <param name="branchAlias"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAliasesResponseAliaseMicrofrontendsApplicationsVariant3Item(
            string projectId,
            string? deploymentId,
            string? branchDeploymentId,
            string? fallbackDeploymentId,
            string? fallbackHost,
            string? branchAlias)
        {
            this.DeploymentId = deploymentId;
            this.BranchDeploymentId = branchDeploymentId;
            this.FallbackDeploymentId = fallbackDeploymentId;
            this.FallbackHost = fallbackHost;
            this.BranchAlias = branchAlias;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAliasesResponseAliaseMicrofrontendsApplicationsVariant3Item" /> class.
        /// </summary>
        public ListAliasesResponseAliaseMicrofrontendsApplicationsVariant3Item()
        {
        }
    }
}