
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDrainResponseVariant1DeliveryVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainResponseVariant1DeliveryVariant4TypeJsonConverter))]
        public global::Vercel.GetDrainResponseVariant1DeliveryVariant4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainResponseVariant1DeliveryVariant4TargetJsonConverter))]
        public global::Vercel.GetDrainResponseVariant1DeliveryVariant4Target Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainResponseVariant1DeliveryVariant4" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="target"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainResponseVariant1DeliveryVariant4(
            global::Vercel.GetDrainResponseVariant1DeliveryVariant4Type type,
            global::Vercel.GetDrainResponseVariant1DeliveryVariant4Target target)
        {
            this.Type = type;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainResponseVariant1DeliveryVariant4" /> class.
        /// </summary>
        public GetDrainResponseVariant1DeliveryVariant4()
        {
        }
    }
}