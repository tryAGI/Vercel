
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata about the source platform that triggered the deployment.
    /// </summary>
    public sealed partial class GetDeploymentsResponseDeploymentPlatform
    {
        /// <summary>
        /// The user on the external platform who triggered the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentsResponseDeploymentPlatformCreator Creator { get; set; }

        /// <summary>
        /// Arbitrary key-value metadata provided by the platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::System.Collections.Generic.Dictionary<string, string>? Meta { get; set; }

        /// <summary>
        /// Reference back to the entity on the platform that initiated the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentsResponseDeploymentPlatformOrigin Origin { get; set; }

        /// <summary>
        /// The external platform that created the deployment (e.g. its display name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentsResponseDeploymentPlatformSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentPlatform" /> class.
        /// </summary>
        /// <param name="creator">
        /// The user on the external platform who triggered the deployment.
        /// </param>
        /// <param name="origin">
        /// Reference back to the entity on the platform that initiated the deployment.
        /// </param>
        /// <param name="source">
        /// The external platform that created the deployment (e.g. its display name).
        /// </param>
        /// <param name="meta">
        /// Arbitrary key-value metadata provided by the platform.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentsResponseDeploymentPlatform(
            global::Vercel.GetDeploymentsResponseDeploymentPlatformCreator creator,
            global::Vercel.GetDeploymentsResponseDeploymentPlatformOrigin origin,
            global::Vercel.GetDeploymentsResponseDeploymentPlatformSource source,
            global::System.Collections.Generic.Dictionary<string, string>? meta)
        {
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Meta = meta;
            this.Origin = origin ?? throw new global::System.ArgumentNullException(nameof(origin));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentPlatform" /> class.
        /// </summary>
        public GetDeploymentsResponseDeploymentPlatform()
        {
        }

    }
}