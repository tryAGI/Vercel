
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Integration installation enabled on the project.
    /// </summary>
    public sealed partial class GetProjectResponseIntegration
    {
        /// <summary>
        /// The integration installation ID.<br/>
        /// Example: icfg_3bwCLgxL8qt5kjRLcv2Dit7F
        /// </summary>
        /// <example>icfg_3bwCLgxL8qt5kjRLcv2Dit7F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("installationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstallationId { get; set; }

        /// <summary>
        /// The list of the installation resources connected to the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectResponseIntegrationResource>? Resources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseIntegration" /> class.
        /// </summary>
        /// <param name="installationId">
        /// The integration installation ID.<br/>
        /// Example: icfg_3bwCLgxL8qt5kjRLcv2Dit7F
        /// </param>
        /// <param name="resources">
        /// The list of the installation resources connected to the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseIntegration(
            string installationId,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectResponseIntegrationResource>? resources)
        {
            this.InstallationId = installationId ?? throw new global::System.ArgumentNullException(nameof(installationId));
            this.Resources = resources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseIntegration" /> class.
        /// </summary>
        public GetProjectResponseIntegration()
        {
        }
    }
}