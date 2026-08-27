
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProductProtocolsAuthentication
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductProtocolsAuthenticationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetConfigurationProductsResponseProductProtocolsAuthenticationStatus Status { get; set; }

        /// <summary>
        /// The partner accepts Vercel-managed app URLs via `protocolSettings.authentication.appUrls` on provision-resource and update-resource, and reconciles them into its trusted-origin / redirect-URL allowlist. When absent, consumers surface the URL for a one-time manual registration instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appUrlRegistrationSupport")]
        public bool? AppUrlRegistrationSupport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductProtocolsAuthentication" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="appUrlRegistrationSupport">
        /// The partner accepts Vercel-managed app URLs via `protocolSettings.authentication.appUrls` on provision-resource and update-resource, and reconciles them into its trusted-origin / redirect-URL allowlist. When absent, consumers surface the URL for a one-time manual registration instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProductProtocolsAuthentication(
            global::Vercel.GetConfigurationProductsResponseProductProtocolsAuthenticationStatus status,
            bool? appUrlRegistrationSupport)
        {
            this.Status = status;
            this.AppUrlRegistrationSupport = appUrlRegistrationSupport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductProtocolsAuthentication" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProductProtocolsAuthentication()
        {
        }

    }
}