
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDrainResponseVariant2DeliveryVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainResponseVariant2DeliveryVariant5TypeJsonConverter))]
        public global::Vercel.UpdateDrainResponseVariant2DeliveryVariant5Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainResponseVariant2DeliveryVariant5TargetJsonConverter))]
        public global::Vercel.UpdateDrainResponseVariant2DeliveryVariant5Target Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainResponseVariant2DeliveryVariant5" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="target"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDrainResponseVariant2DeliveryVariant5(
            global::Vercel.UpdateDrainResponseVariant2DeliveryVariant5Type type,
            global::Vercel.UpdateDrainResponseVariant2DeliveryVariant5Target target)
        {
            this.Type = type;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainResponseVariant2DeliveryVariant5" /> class.
        /// </summary>
        public UpdateDrainResponseVariant2DeliveryVariant5()
        {
        }

    }
}