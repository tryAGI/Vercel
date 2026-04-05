
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEventRequestEventVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateEventRequestEventVariant2TypeJsonConverter))]
        public global::Vercel.CreateEventRequestEventVariant2Type Type { get; set; }

        /// <summary>
        /// Partner-provided product slug or id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        public string? ProductId { get; set; }

        /// <summary>
        /// Partner provided resource ID
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
        /// Initializes a new instance of the <see cref="CreateEventRequestEventVariant2" /> class.
        /// </summary>
        /// <param name="resourceId">
        /// Partner provided resource ID
        /// </param>
        /// <param name="type"></param>
        /// <param name="productId">
        /// Partner-provided product slug or id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEventRequestEventVariant2(
            string resourceId,
            global::Vercel.CreateEventRequestEventVariant2Type type,
            string? productId)
        {
            this.Type = type;
            this.ProductId = productId;
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventRequestEventVariant2" /> class.
        /// </summary>
        public CreateEventRequestEventVariant2()
        {
        }
    }
}