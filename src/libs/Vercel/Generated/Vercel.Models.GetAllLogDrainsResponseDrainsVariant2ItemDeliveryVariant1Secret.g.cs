
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Secret
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1SecretKindJsonConverter))]
        public global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1SecretKind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Secret" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Secret(
            global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1SecretKind kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Secret" /> class.
        /// </summary>
        public GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Secret()
        {
        }
    }
}