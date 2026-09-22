
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared383028c008cc4ae0DeliveryVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared383028c008cc4ae0DeliveryVariant2EncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared383028c008cc4ae0DeliveryVariant2Encoding Encoding { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared383028c008cc4ae0DeliveryVariant2Endpoint Endpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKShared383028c008cc4ae0DeliveryVariant2Secret>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKShared383028c008cc4ae0DeliveryVariant2Secret>? Secret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared383028c008cc4ae0DeliveryVariant2TypeJsonConverter))]
        public global::Vercel.AutoSDKShared383028c008cc4ae0DeliveryVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared383028c008cc4ae0DeliveryVariant2" /> class.
        /// </summary>
        /// <param name="encoding"></param>
        /// <param name="endpoint"></param>
        /// <param name="headers"></param>
        /// <param name="secret"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared383028c008cc4ae0DeliveryVariant2(
            global::Vercel.AutoSDKShared383028c008cc4ae0DeliveryVariant2Encoding encoding,
            global::Vercel.AutoSDKShared383028c008cc4ae0DeliveryVariant2Endpoint endpoint,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKShared383028c008cc4ae0DeliveryVariant2Secret>? secret,
            global::Vercel.AutoSDKShared383028c008cc4ae0DeliveryVariant2Type type)
        {
            this.Encoding = encoding;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Secret = secret;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared383028c008cc4ae0DeliveryVariant2" /> class.
        /// </summary>
        public AutoSDKShared383028c008cc4ae0DeliveryVariant2()
        {
        }

    }
}