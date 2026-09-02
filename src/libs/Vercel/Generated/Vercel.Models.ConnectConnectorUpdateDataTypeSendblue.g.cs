
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeSendblue
    {
        /// <summary>
        /// Sendblue API key id (`sb-api-key-id`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyId")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// Sendblue API secret key (`sb-api-secret-key`).<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiSecretKey")]
        public string? ApiSecretKey { get; set; }

        /// <summary>
        /// E.164 Sendblue lines this connector sends and receives on. Used as the connector's display name, and the only lines its webhooks are registered for; an empty array clears them, which also removes the webhook subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumbers")]
        public global::System.Collections.Generic.IList<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSendblue" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// Sendblue API key id (`sb-api-key-id`).
        /// </param>
        /// <param name="apiSecretKey">
        /// Sendblue API secret key (`sb-api-secret-key`).<br/>
        /// Included only in requests
        /// </param>
        /// <param name="phoneNumbers">
        /// E.164 Sendblue lines this connector sends and receives on. Used as the connector's display name, and the only lines its webhooks are registered for; an empty array clears them, which also removes the webhook subscription.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeSendblue(
            string? apiKeyId,
            string? apiSecretKey,
            global::System.Collections.Generic.IList<string>? phoneNumbers)
        {
            this.ApiKeyId = apiKeyId;
            this.ApiSecretKey = apiSecretKey;
            this.PhoneNumbers = phoneNumbers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSendblue" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeSendblue()
        {
        }

    }
}