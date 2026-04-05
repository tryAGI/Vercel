
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDrainResponseVariant1DeliveryVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainResponseVariant1DeliveryVariant2TypeJsonConverter))]
        public global::Vercel.GetDrainResponseVariant1DeliveryVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDrainResponseVariant1DeliveryVariant2Endpoint Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainResponseVariant1DeliveryVariant2EncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDrainResponseVariant1DeliveryVariant2Encoding Encoding { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetDrainResponseVariant1DeliveryVariant2Secret>))]
        public global::Vercel.OneOf<string, global::Vercel.GetDrainResponseVariant1DeliveryVariant2Secret>? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainResponseVariant1DeliveryVariant2" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="encoding"></param>
        /// <param name="headers"></param>
        /// <param name="type"></param>
        /// <param name="secret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainResponseVariant1DeliveryVariant2(
            global::Vercel.GetDrainResponseVariant1DeliveryVariant2Endpoint endpoint,
            global::Vercel.GetDrainResponseVariant1DeliveryVariant2Encoding encoding,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::Vercel.GetDrainResponseVariant1DeliveryVariant2Type type,
            global::Vercel.OneOf<string, global::Vercel.GetDrainResponseVariant1DeliveryVariant2Secret>? secret)
        {
            this.Type = type;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Encoding = encoding;
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainResponseVariant1DeliveryVariant2" /> class.
        /// </summary>
        public GetDrainResponseVariant1DeliveryVariant2()
        {
        }
    }
}