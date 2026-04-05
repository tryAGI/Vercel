
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata about the source platform that triggered the deployment. Allows us to map a deployment back to a platform (e.g. the chat that created it)
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1Platform
    {
        /// <summary>
        /// The external platform that created the deployment (e.g. its display name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant1PlatformSource Source { get; set; }

        /// <summary>
        /// Reference back to the entity on the platform that initiated the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant1PlatformOrigin Origin { get; set; }

        /// <summary>
        /// The user on the external platform who triggered the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant1PlatformCreator Creator { get; set; }

        /// <summary>
        /// Arbitrary key-value metadata provided by the platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::System.Collections.Generic.Dictionary<string, string>? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1Platform" /> class.
        /// </summary>
        /// <param name="source">
        /// The external platform that created the deployment (e.g. its display name).
        /// </param>
        /// <param name="origin">
        /// Reference back to the entity on the platform that initiated the deployment.
        /// </param>
        /// <param name="creator">
        /// The user on the external platform who triggered the deployment.
        /// </param>
        /// <param name="meta">
        /// Arbitrary key-value metadata provided by the platform.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1Platform(
            global::Vercel.GetDeploymentResponseVariant1PlatformSource source,
            global::Vercel.GetDeploymentResponseVariant1PlatformOrigin origin,
            global::Vercel.GetDeploymentResponseVariant1PlatformCreator creator,
            global::System.Collections.Generic.Dictionary<string, string>? meta)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Origin = origin ?? throw new global::System.ArgumentNullException(nameof(origin));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1Platform" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1Platform()
        {
        }
    }
}