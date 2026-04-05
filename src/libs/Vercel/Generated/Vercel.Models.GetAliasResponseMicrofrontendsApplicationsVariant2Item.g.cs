
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A list of the deployment routing information for each project.
    /// </summary>
    public sealed partial class GetAliasResponseMicrofrontendsApplicationsVariant2Item
    {
        /// <summary>
        /// This is always set. For branch aliases, it's used as the fallback if there is no deployment for the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackHost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FallbackHost { get; set; }

        /// <summary>
        /// Could point to a branch without a deployment if the project was never deployed. The proxy will fallback to the fallbackHost if there is no deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchAlias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchAlias { get; set; }

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
        /// Initializes a new instance of the <see cref="GetAliasResponseMicrofrontendsApplicationsVariant2Item" /> class.
        /// </summary>
        /// <param name="fallbackHost">
        /// This is always set. For branch aliases, it's used as the fallback if there is no deployment for the branch.
        /// </param>
        /// <param name="branchAlias">
        /// Could point to a branch without a deployment if the project was never deployed. The proxy will fallback to the fallbackHost if there is no deployment.
        /// </param>
        /// <param name="projectId">
        /// The project ID of the microfrontends application.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAliasResponseMicrofrontendsApplicationsVariant2Item(
            string fallbackHost,
            string branchAlias,
            string projectId)
        {
            this.FallbackHost = fallbackHost ?? throw new global::System.ArgumentNullException(nameof(fallbackHost));
            this.BranchAlias = branchAlias ?? throw new global::System.ArgumentNullException(nameof(branchAlias));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAliasResponseMicrofrontendsApplicationsVariant2Item" /> class.
        /// </summary>
        public GetAliasResponseMicrofrontendsApplicationsVariant2Item()
        {
        }
    }
}