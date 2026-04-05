
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2Secret
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2SecretKindJsonConverter))]
        public global::Vercel.GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2SecretKind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2Secret" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2Secret(
            global::Vercel.GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2SecretKind kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2Secret" /> class.
        /// </summary>
        public GetAllLogDrainsResponseDrainsVariant1ItemDeliveryVariant2Secret()
        {
        }
    }
}