
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1TypeJsonConverter))]
        public global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1EncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Encoding Encoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1CompressionJsonConverter))]
        public global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression? Compression { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Secret>))]
        public global::Vercel.OneOf<string, global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Secret>? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="encoding"></param>
        /// <param name="headers"></param>
        /// <param name="type"></param>
        /// <param name="compression"></param>
        /// <param name="secret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1(
            string endpoint,
            global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Encoding encoding,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Type type,
            global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Compression? compression,
            global::Vercel.OneOf<string, global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1Secret>? secret)
        {
            this.Type = type;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Encoding = encoding;
            this.Compression = compression;
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1" /> class.
        /// </summary>
        public GetAllLogDrainsResponseDrainsVariant2ItemDeliveryVariant1()
        {
        }
    }
}