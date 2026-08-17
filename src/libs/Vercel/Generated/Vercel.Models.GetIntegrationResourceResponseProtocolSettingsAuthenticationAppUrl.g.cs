
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrl
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrl" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="target"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrl(
            string url,
            global::Vercel.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget target)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrl" /> class.
        /// </summary>
        public GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrl()
        {
        }

    }
}