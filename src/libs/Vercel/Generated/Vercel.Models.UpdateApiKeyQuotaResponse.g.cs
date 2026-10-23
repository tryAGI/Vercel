
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateApiKeyQuotaResponse
    {
        /// <summary>
        /// Represents an API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.APIKey ApiKey { get; set; }

        /// <summary>
        /// AI Gateway quota associated with an API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.APIKeyQuota Quota { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyQuotaResponse" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Represents an API key.
        /// </param>
        /// <param name="quota">
        /// AI Gateway quota associated with an API key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateApiKeyQuotaResponse(
            global::Vercel.APIKey apiKey,
            global::Vercel.APIKeyQuota quota)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Quota = quota ?? throw new global::System.ArgumentNullException(nameof(quota));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyQuotaResponse" /> class.
        /// </summary>
        public UpdateApiKeyQuotaResponse()
        {
        }

    }
}