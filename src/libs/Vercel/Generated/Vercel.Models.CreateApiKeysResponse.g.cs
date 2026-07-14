
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeysResponse
    {
        /// <summary>
        /// The API key's actual value. This value is only provided in this response, and can never be retrieved again in the future. Be sure to save it somewhere safe!<br/>
        /// Example: uRKJSTt0L4RaSkiMj41QTkxM
        /// </summary>
        /// <example>uRKJSTt0L4RaSkiMj41QTkxM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyString")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyString { get; set; }

        /// <summary>
        /// Information about the newly created API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.APIKey ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeysResponse" /> class.
        /// </summary>
        /// <param name="apiKeyString">
        /// The API key's actual value. This value is only provided in this response, and can never be retrieved again in the future. Be sure to save it somewhere safe!<br/>
        /// Example: uRKJSTt0L4RaSkiMj41QTkxM
        /// </param>
        /// <param name="apiKey">
        /// Information about the newly created API key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeysResponse(
            string apiKeyString,
            global::Vercel.APIKey apiKey)
        {
            this.ApiKeyString = apiKeyString ?? throw new global::System.ArgumentNullException(nameof(apiKeyString));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeysResponse" /> class.
        /// </summary>
        public CreateApiKeysResponse()
        {
        }

    }
}