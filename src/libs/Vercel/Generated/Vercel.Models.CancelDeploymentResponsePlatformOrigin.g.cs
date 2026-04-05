
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Reference back to the entity on the platform that initiated the deployment.
    /// </summary>
    public sealed partial class CancelDeploymentResponsePlatformOrigin
    {
        /// <summary>
        /// Whether the value is an opaque identifier or a URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponsePlatformOriginTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponsePlatformOriginType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="CancelDeploymentResponsePlatformOrigin" /> class.
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
        public CancelDeploymentResponsePlatformOrigin(
            global::Vercel.CancelDeploymentResponsePlatformOriginType type,
            string value)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponsePlatformOrigin" /> class.
        /// </summary>
        public CancelDeploymentResponsePlatformOrigin()
        {
        }
    }
}