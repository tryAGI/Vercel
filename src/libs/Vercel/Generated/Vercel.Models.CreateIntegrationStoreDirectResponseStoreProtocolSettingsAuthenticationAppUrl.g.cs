
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrl
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTarget Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrl" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="target"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrl(
            string url,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTarget target)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrl" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrl()
        {
        }

    }
}