
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDrainsResponseDrainsVariant2ItemDeliveryVariant5
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainsResponseDrainsVariant2ItemDeliveryVariant5TargetJsonConverter))]
        public global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant5Target Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainsResponseDrainsVariant2ItemDeliveryVariant5TypeJsonConverter))]
        public global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant5Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant2ItemDeliveryVariant5" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainsResponseDrainsVariant2ItemDeliveryVariant5(
            global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant5Target target,
            global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant5Type type)
        {
            this.Target = target;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant2ItemDeliveryVariant5" /> class.
        /// </summary>
        public GetDrainsResponseDrainsVariant2ItemDeliveryVariant5()
        {
        }

    }
}