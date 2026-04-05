
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProductProtocolsTraceDrain
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductProtocolsTraceDrainStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetConfigurationProductsResponseProductProtocolsTraceDrainStatus Status { get; set; }

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
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductProtocolsTraceDrainFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetConfigurationProductsResponseProductProtocolsTraceDrainFormat Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductProtocolsTraceDrain" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="endpoint"></param>
        /// <param name="format"></param>
        /// <param name="headers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProductProtocolsTraceDrain(
            global::Vercel.GetConfigurationProductsResponseProductProtocolsTraceDrainStatus status,
            string endpoint,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsTraceDrainFormat format,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.Status = status;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Headers = headers;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductProtocolsTraceDrain" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProductProtocolsTraceDrain()
        {
        }
    }
}