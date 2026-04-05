
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEdgeConfigResponsePurposeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateEdgeConfigResponsePurposeVariant2TypeJsonConverter))]
        public global::Vercel.CreateEdgeConfigResponsePurposeVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEdgeConfigResponsePurposeVariant2" /> class.
        /// </summary>
        /// <param name="resourceId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEdgeConfigResponsePurposeVariant2(
            string resourceId,
            global::Vercel.CreateEdgeConfigResponsePurposeVariant2Type type)
        {
            this.Type = type;
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEdgeConfigResponsePurposeVariant2" /> class.
        /// </summary>
        public CreateEdgeConfigResponsePurposeVariant2()
        {
        }
    }
}