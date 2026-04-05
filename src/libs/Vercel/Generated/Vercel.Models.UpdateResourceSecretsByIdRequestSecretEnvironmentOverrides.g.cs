
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A map of environments to override values for the secret, used for setting different values across deployments in production, preview, and development environments. Note: the same value will be used for all deployments in the given environment.
    /// </summary>
    public sealed partial class UpdateResourceSecretsByIdRequestSecretEnvironmentOverrides
    {
        /// <summary>
        /// Value used for development environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("development")]
        public string? Development { get; set; }

        /// <summary>
        /// Value used for preview environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public string? Preview { get; set; }

        /// <summary>
        /// Value used for production environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("production")]
        public string? Production { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceSecretsByIdRequestSecretEnvironmentOverrides" /> class.
        /// </summary>
        /// <param name="development">
        /// Value used for development environment.
        /// </param>
        /// <param name="preview">
        /// Value used for preview environment.
        /// </param>
        /// <param name="production">
        /// Value used for production environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateResourceSecretsByIdRequestSecretEnvironmentOverrides(
            string? development,
            string? preview,
            string? production)
        {
            this.Development = development;
            this.Preview = preview;
            this.Production = production;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceSecretsByIdRequestSecretEnvironmentOverrides" /> class.
        /// </summary>
        public UpdateResourceSecretsByIdRequestSecretEnvironmentOverrides()
        {
        }
    }
}