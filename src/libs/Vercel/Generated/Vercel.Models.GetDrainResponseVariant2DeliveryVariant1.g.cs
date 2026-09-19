
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDrainResponseVariant2DeliveryVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainResponseVariant2DeliveryVariant1CompressionJsonConverter))]
        public global::Vercel.GetDrainResponseVariant2DeliveryVariant1Compression? Compression { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainResponseVariant2DeliveryVariant1EncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDrainResponseVariant2DeliveryVariant1Encoding Encoding { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetDrainResponseVariant2DeliveryVariant1Secret>))]
        public global::Vercel.OneOf<string, global::Vercel.GetDrainResponseVariant2DeliveryVariant1Secret>? Secret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainResponseVariant2DeliveryVariant1TypeJsonConverter))]
        public global::Vercel.GetDrainResponseVariant2DeliveryVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainResponseVariant2DeliveryVariant1" /> class.
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
        public GetDrainResponseVariant2DeliveryVariant1(
            global::Vercel.GetDrainResponseVariant2DeliveryVariant1Encoding encoding,
            string endpoint,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::Vercel.GetDrainResponseVariant2DeliveryVariant1Compression? compression,
            global::Vercel.OneOf<string, global::Vercel.GetDrainResponseVariant2DeliveryVariant1Secret>? secret,
            global::Vercel.GetDrainResponseVariant2DeliveryVariant1Type type)
        {
            this.Compression = compression;
            this.Encoding = encoding;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Secret = secret;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainResponseVariant2DeliveryVariant1" /> class.
        /// </summary>
        public GetDrainResponseVariant2DeliveryVariant1()
        {
        }

    }
}