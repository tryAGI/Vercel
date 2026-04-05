
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDrainsResponseDrainsVariant2ItemDeliveryVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainsResponseDrainsVariant2ItemDeliveryVariant4TypeJsonConverter))]
        public global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainsResponseDrainsVariant2ItemDeliveryVariant4TargetJsonConverter))]
        public global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Target Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant2ItemDeliveryVariant4" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="target"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainsResponseDrainsVariant2ItemDeliveryVariant4(
            global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Type type,
            global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant4Target target)
        {
            this.Type = type;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant2ItemDeliveryVariant4" /> class.
        /// </summary>
        public GetDrainsResponseDrainsVariant2ItemDeliveryVariant4()
        {
        }
    }
}