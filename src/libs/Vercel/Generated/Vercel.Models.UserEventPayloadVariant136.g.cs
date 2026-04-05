
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant136
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewDeploymentSuffix")]
        public string? PreviewDeploymentSuffix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousPreviewDeploymentSuffix")]
        public string? PreviousPreviewDeploymentSuffix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant136" /> class.
        /// </summary>
        /// <param name="previewDeploymentSuffix"></param>
        /// <param name="previousPreviewDeploymentSuffix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant136(
            string? previewDeploymentSuffix,
            string? previousPreviewDeploymentSuffix)
        {
            this.PreviewDeploymentSuffix = previewDeploymentSuffix;
            this.PreviousPreviewDeploymentSuffix = previousPreviewDeploymentSuffix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant136" /> class.
        /// </summary>
        public UserEventPayloadVariant136()
        {
        }
    }
}