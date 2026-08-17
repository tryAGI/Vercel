
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetIntegrationResourcesResponseResourceProtocolSettingsAuthentication
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appUrls")]
        public global::System.Collections.Generic.IList<global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrl>? AppUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourcesResponseResourceProtocolSettingsAuthentication" /> class.
        /// </summary>
        /// <param name="appUrls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntegrationResourcesResponseResourceProtocolSettingsAuthentication(
            global::System.Collections.Generic.IList<global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrl>? appUrls)
        {
            this.AppUrls = appUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourcesResponseResourceProtocolSettingsAuthentication" /> class.
        /// </summary>
        public GetIntegrationResourcesResponseResourceProtocolSettingsAuthentication()
        {
        }

    }
}