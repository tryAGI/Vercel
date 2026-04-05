
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDrainResponseVariant1DeliveryVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainResponseVariant1DeliveryVariant4TypeJsonConverter))]
        public global::Vercel.CreateDrainResponseVariant1DeliveryVariant4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainResponseVariant1DeliveryVariant4TargetJsonConverter))]
        public global::Vercel.CreateDrainResponseVariant1DeliveryVariant4Target Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant1DeliveryVariant4" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="target"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainResponseVariant1DeliveryVariant4(
            global::Vercel.CreateDrainResponseVariant1DeliveryVariant4Type type,
            global::Vercel.CreateDrainResponseVariant1DeliveryVariant4Target target)
        {
            this.Type = type;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant1DeliveryVariant4" /> class.
        /// </summary>
        public CreateDrainResponseVariant1DeliveryVariant4()
        {
        }
    }
}