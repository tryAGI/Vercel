
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared8df5bff0bb4332b8DeliveryVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared8df5bff0bb4332b8DeliveryVariant2EncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Encoding Encoding { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Endpoint Endpoint { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Secret>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Secret>? Secret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared8df5bff0bb4332b8DeliveryVariant2TypeJsonConverter))]
        public global::Vercel.AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared8df5bff0bb4332b8DeliveryVariant2" /> class.
        /// </summary>
        /// <param name="encoding"></param>
        /// <param name="endpoint"></param>
        /// <param name="headers"></param>
        /// <param name="secret"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared8df5bff0bb4332b8DeliveryVariant2(
            global::Vercel.AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Encoding encoding,
            global::Vercel.AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Endpoint endpoint,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Secret>? secret,
            global::Vercel.AutoSDKShared8df5bff0bb4332b8DeliveryVariant2Type type)
        {
            this.Encoding = encoding;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Secret = secret;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared8df5bff0bb4332b8DeliveryVariant2" /> class.
        /// </summary>
        public AutoSDKShared8df5bff0bb4332b8DeliveryVariant2()
        {
        }

    }
}