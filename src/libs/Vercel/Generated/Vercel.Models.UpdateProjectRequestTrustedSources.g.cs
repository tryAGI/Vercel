
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Deployment Protection Trusted Sources
    /// </summary>
    public sealed partial class UpdateProjectRequestTrustedSources
    {
        /// <summary>
        /// Allow same-team Vercel CI access to preview deployments built from the same repository as the CI run. The deployment source repository, not the current project repository link, is authoritative. Defaults to enabled when not stored. Omitting this field preserves its stored value, including when trustedSources is cleared. Set true explicitly to re-enable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableVercelCiSameRepository")]
        public bool? EnableVercelCiSameRepository { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateProjectRequestTrustedSourcesProjects2>? Projects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcProviders")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestTrustedSourcesOidcProvider>>? OidcProviders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSources" /> class.
        /// </summary>
        /// <param name="enableVercelCiSameRepository">
        /// Allow same-team Vercel CI access to preview deployments built from the same repository as the CI run. The deployment source repository, not the current project repository link, is authoritative. Defaults to enabled when not stored. Omitting this field preserves its stored value, including when trustedSources is cleared. Set true explicitly to re-enable.
        /// </param>
        /// <param name="projects"></param>
        /// <param name="oidcProviders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestTrustedSources(
            bool? enableVercelCiSameRepository,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateProjectRequestTrustedSourcesProjects2>? projects,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestTrustedSourcesOidcProvider>>? oidcProviders)
        {
            this.EnableVercelCiSameRepository = enableVercelCiSameRepository;
            this.Projects = projects;
            this.OidcProviders = oidcProviders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSources" /> class.
        /// </summary>
        public UpdateProjectRequestTrustedSources()
        {
        }

    }
}