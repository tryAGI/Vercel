
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1Secret
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1SecretKindJsonConverter))]
        public global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1SecretKind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1Secret" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1Secret(
            global::Vercel.AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1SecretKind kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1Secret" /> class.
        /// </summary>
        public AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant1Secret()
        {
        }

    }
}