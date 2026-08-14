
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeSendblue
    {
        /// <summary>
        /// Sendblue API key id (`sb-api-key-id`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyId { get; set; }

        /// <summary>
        /// Sendblue API secret key (`sb-api-secret-key`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiSecretKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiSecretKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumbers")]
        public global::System.Collections.Generic.IList<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeSendblue" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// Sendblue API key id (`sb-api-key-id`).
        /// </param>
        /// <param name="apiSecretKey">
        /// Sendblue API secret key (`sb-api-secret-key`).
        /// </param>
        /// <param name="phoneNumbers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeSendblue(
            string apiKeyId,
            string apiSecretKey,
            global::System.Collections.Generic.IList<string>? phoneNumbers)
        {
            this.ApiKeyId = apiKeyId ?? throw new global::System.ArgumentNullException(nameof(apiKeyId));
            this.ApiSecretKey = apiSecretKey ?? throw new global::System.ArgumentNullException(nameof(apiSecretKey));
            this.PhoneNumbers = phoneNumbers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeSendblue" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeSendblue()
        {
        }

    }
}