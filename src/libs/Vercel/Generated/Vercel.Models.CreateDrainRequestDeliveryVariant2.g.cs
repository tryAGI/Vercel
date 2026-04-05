
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDrainRequestDeliveryVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDrainRequestDeliveryVariant2Endpoint Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainRequestDeliveryVariant2EncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDrainRequestDeliveryVariant2Encoding Encoding { get; set; }

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
        public string? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainRequestDeliveryVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="endpoint"></param>
        /// <param name="encoding"></param>
        /// <param name="headers"></param>
        /// <param name="secret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainRequestDeliveryVariant2(
            string type,
            global::Vercel.CreateDrainRequestDeliveryVariant2Endpoint endpoint,
            global::Vercel.CreateDrainRequestDeliveryVariant2Encoding encoding,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            string? secret)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Encoding = encoding;
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainRequestDeliveryVariant2" /> class.
        /// </summary>
        public CreateDrainRequestDeliveryVariant2()
        {
        }
    }
}