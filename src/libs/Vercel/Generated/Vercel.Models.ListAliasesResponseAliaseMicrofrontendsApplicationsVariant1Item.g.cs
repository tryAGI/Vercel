
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A list of the deployment routing information for each project.
    /// </summary>
    public sealed partial class ListAliasesResponseAliaseMicrofrontendsApplicationsVariant1Item
    {
        /// <summary>
        /// This is always set. In production it is used as a pointer to each apps production deployment. For pre-production, it's used as the fallback if there is no deployment for the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackHost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FallbackHost { get; set; }

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
        /// Initializes a new instance of the <see cref="ListAliasesResponseAliaseMicrofrontendsApplicationsVariant1Item" /> class.
        /// </summary>
        /// <param name="fallbackHost">
        /// This is always set. In production it is used as a pointer to each apps production deployment. For pre-production, it's used as the fallback if there is no deployment for the branch.
        /// </param>
        /// <param name="projectId">
        /// The project ID of the microfrontends application.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAliasesResponseAliaseMicrofrontendsApplicationsVariant1Item(
            string fallbackHost,
            string projectId)
        {
            this.FallbackHost = fallbackHost ?? throw new global::System.ArgumentNullException(nameof(fallbackHost));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAliasesResponseAliaseMicrofrontendsApplicationsVariant1Item" /> class.
        /// </summary>
        public ListAliasesResponseAliaseMicrofrontendsApplicationsVariant1Item()
        {
        }
    }
}