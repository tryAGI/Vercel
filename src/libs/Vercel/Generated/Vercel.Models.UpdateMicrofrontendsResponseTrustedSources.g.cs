
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseTrustedSources
    {
        /// <summary>
        /// Allow same-team Vercel CI access to preview deployments built from the CI run's repository, using the deployment source rather than the current project repository link. Defaults to enabled when not stored; omitted or null Trusted Sources updates preserve the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableVercelCiSameRepository")]
        public bool? EnableVercelCiSameRepository { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjects2>? Projects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcProviders")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesOidcProvider>>? OidcProviders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseTrustedSources" /> class.
        /// </summary>
        /// <param name="enableVercelCiSameRepository">
        /// Allow same-team Vercel CI access to preview deployments built from the CI run's repository, using the deployment source rather than the current project repository link. Defaults to enabled when not stored; omitted or null Trusted Sources updates preserve the stored value.
        /// </param>
        /// <param name="projects"></param>
        /// <param name="oidcProviders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseTrustedSources(
            bool? enableVercelCiSameRepository,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjects2>? projects,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesOidcProvider>>? oidcProviders)
        {
            this.EnableVercelCiSameRepository = enableVercelCiSameRepository;
            this.Projects = projects;
            this.OidcProviders = oidcProviders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseTrustedSources" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseTrustedSources()
        {
        }

    }
}