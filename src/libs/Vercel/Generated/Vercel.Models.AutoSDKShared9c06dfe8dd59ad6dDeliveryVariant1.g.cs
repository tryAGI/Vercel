
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1CompressionJsonConverter))]
        public global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Compression? Compression { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1EncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Encoding Encoding { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Secret>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Secret>? Secret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1TypeJsonConverter))]
        public global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1" /> class.
        /// </summary>
        /// <param name="encoding"></param>
        /// <param name="endpoint"></param>
        /// <param name="headers"></param>
        /// <param name="compression"></param>
        /// <param name="secret"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1(
            global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Encoding encoding,
            string endpoint,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Compression? compression,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Secret>? secret,
            global::Vercel.AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1Type type)
        {
            this.Compression = compression;
            this.Encoding = encoding;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Secret = secret;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1" /> class.
        /// </summary>
        public AutoSDKShared9c06dfe8dd59ad6dDeliveryVariant1()
        {
        }

    }
}