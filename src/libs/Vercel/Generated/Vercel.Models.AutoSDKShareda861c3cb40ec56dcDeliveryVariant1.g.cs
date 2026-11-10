
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda861c3cb40ec56dcDeliveryVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1CompressionJsonConverter))]
        public global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Compression? Compression { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1EncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Encoding Encoding { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Secret>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Secret>? Secret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1TypeJsonConverter))]
        public global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dcDeliveryVariant1" /> class.
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
        public AutoSDKShareda861c3cb40ec56dcDeliveryVariant1(
            global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Encoding encoding,
            string endpoint,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Compression? compression,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Secret>? secret,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Type type)
        {
            this.Compression = compression;
            this.Encoding = encoding;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Secret = secret;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dcDeliveryVariant1" /> class.
        /// </summary>
        public AutoSDKShareda861c3cb40ec56dcDeliveryVariant1()
        {
        }

    }
}