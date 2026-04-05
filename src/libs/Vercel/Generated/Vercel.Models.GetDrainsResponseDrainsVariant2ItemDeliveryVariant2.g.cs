
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDrainsResponseDrainsVariant2ItemDeliveryVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2TypeJsonConverter))]
        public global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Endpoint Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2EncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Encoding Encoding { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Secret>))]
        public global::Vercel.OneOf<string, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Secret>? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant2ItemDeliveryVariant2" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="encoding"></param>
        /// <param name="headers"></param>
        /// <param name="type"></param>
        /// <param name="secret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainsResponseDrainsVariant2ItemDeliveryVariant2(
            global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Endpoint endpoint,
            global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Encoding encoding,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Type type,
            global::Vercel.OneOf<string, global::Vercel.GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Secret>? secret)
        {
            this.Type = type;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Encoding = encoding;
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant2ItemDeliveryVariant2" /> class.
        /// </summary>
        public GetDrainsResponseDrainsVariant2ItemDeliveryVariant2()
        {
        }
    }
}