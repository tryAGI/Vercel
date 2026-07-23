
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Reference back to the entity on the platform that initiated the deployment.
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2PlatformOrigin
    {
        /// <summary>
        /// Whether the value is an opaque identifier or a URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2PlatformOriginTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDeploymentResponseVariant2PlatformOriginType Type { get; set; }

        /// <summary>
        /// The identifier or URL pointing to the originating entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2PlatformOrigin" /> class.
        /// </summary>
        /// <param name="type">
        /// Whether the value is an opaque identifier or a URL.
        /// </param>
        /// <param name="value">
        /// The identifier or URL pointing to the originating entity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2PlatformOrigin(
            global::Vercel.CreateDeploymentResponseVariant2PlatformOriginType type,
            string value)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2PlatformOrigin" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2PlatformOrigin()
        {
        }

    }
}