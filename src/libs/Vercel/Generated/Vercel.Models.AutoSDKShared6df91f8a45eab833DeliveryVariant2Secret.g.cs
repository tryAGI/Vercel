
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared6df91f8a45eab833DeliveryVariant2Secret
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6df91f8a45eab833DeliveryVariant2SecretKindJsonConverter))]
        public global::Vercel.AutoSDKShared6df91f8a45eab833DeliveryVariant2SecretKind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6df91f8a45eab833DeliveryVariant2Secret" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared6df91f8a45eab833DeliveryVariant2Secret(
            global::Vercel.AutoSDKShared6df91f8a45eab833DeliveryVariant2SecretKind kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6df91f8a45eab833DeliveryVariant2Secret" /> class.
        /// </summary>
        public AutoSDKShared6df91f8a45eab833DeliveryVariant2Secret()
        {
        }

    }
}