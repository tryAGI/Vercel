
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared56f06376e757011bDeliveryVariant2Secret
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared56f06376e757011bDeliveryVariant2SecretKindJsonConverter))]
        public global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant2SecretKind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared56f06376e757011bDeliveryVariant2Secret" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared56f06376e757011bDeliveryVariant2Secret(
            global::Vercel.AutoSDKShared56f06376e757011bDeliveryVariant2SecretKind kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared56f06376e757011bDeliveryVariant2Secret" /> class.
        /// </summary>
        public AutoSDKShared56f06376e757011bDeliveryVariant2Secret()
        {
        }

    }
}