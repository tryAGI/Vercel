
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDrainResponseVariant2DeliveryVariant5
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainResponseVariant2DeliveryVariant5TargetJsonConverter))]
        public global::Vercel.CreateDrainResponseVariant2DeliveryVariant5Target Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainResponseVariant2DeliveryVariant5TypeJsonConverter))]
        public global::Vercel.CreateDrainResponseVariant2DeliveryVariant5Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant2DeliveryVariant5" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainResponseVariant2DeliveryVariant5(
            global::Vercel.CreateDrainResponseVariant2DeliveryVariant5Target target,
            global::Vercel.CreateDrainResponseVariant2DeliveryVariant5Type type)
        {
            this.Target = target;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant2DeliveryVariant5" /> class.
        /// </summary>
        public CreateDrainResponseVariant2DeliveryVariant5()
        {
        }

    }
}