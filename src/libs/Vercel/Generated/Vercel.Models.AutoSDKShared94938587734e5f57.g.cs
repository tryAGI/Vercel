
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared94938587734e5f57
    {
        /// <summary>
        /// Allow same-team Vercel CI access to preview and production deployments built from the CI run's repository, using the deployment source rather than the current project repository link. Defaults to enabled when not stored; omitted or null Trusted Sources updates preserve the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableVercelCiSameRepository")]
        public bool? EnableVercelCiSameRepository { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcProviders")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared94938587734e5f57OidcProvider>>? OidcProviders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedf435ee41818aa67d>? Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared94938587734e5f57" /> class.
        /// </summary>
        /// <param name="enableVercelCiSameRepository">
        /// Allow same-team Vercel CI access to preview and production deployments built from the CI run's repository, using the deployment source rather than the current project repository link. Defaults to enabled when not stored; omitted or null Trusted Sources updates preserve the stored value.
        /// </param>
        /// <param name="oidcProviders"></param>
        /// <param name="projects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared94938587734e5f57(
            bool? enableVercelCiSameRepository,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared94938587734e5f57OidcProvider>>? oidcProviders,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedf435ee41818aa67d>? projects)
        {
            this.EnableVercelCiSameRepository = enableVercelCiSameRepository;
            this.OidcProviders = oidcProviders;
            this.Projects = projects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared94938587734e5f57" /> class.
        /// </summary>
        public AutoSDKShared94938587734e5f57()
        {
        }

    }
}