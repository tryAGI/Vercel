
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDrainResponseVariant1DeliveryVariant1Secret
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDrainResponseVariant1DeliveryVariant1SecretKindJsonConverter))]
        public global::Vercel.UpdateDrainResponseVariant1DeliveryVariant1SecretKind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainResponseVariant1DeliveryVariant1Secret" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDrainResponseVariant1DeliveryVariant1Secret(
            global::Vercel.UpdateDrainResponseVariant1DeliveryVariant1SecretKind kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainResponseVariant1DeliveryVariant1Secret" /> class.
        /// </summary>
        public UpdateDrainResponseVariant1DeliveryVariant1Secret()
        {
        }
    }
}