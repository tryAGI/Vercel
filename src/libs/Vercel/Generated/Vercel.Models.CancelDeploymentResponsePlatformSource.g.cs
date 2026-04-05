
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The external platform that created the deployment (e.g. its display name).
    /// </summary>
    public sealed partial class CancelDeploymentResponsePlatformSource
    {
        /// <summary>
        /// Display name of the platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponsePlatformSource" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the platform.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponsePlatformSource(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponsePlatformSource" /> class.
        /// </summary>
        public CancelDeploymentResponsePlatformSource()
        {
        }
    }
}