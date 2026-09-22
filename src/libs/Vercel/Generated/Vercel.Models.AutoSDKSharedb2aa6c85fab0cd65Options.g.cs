
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional configuration options for the microfrontend.
    /// </summary>
    public sealed partial class AutoSDKSharedb2aa6c85fab0cd65Options
    {
        /// <summary>
        /// If you want to disable the overrides for the site. For example, if you are managing rewrites between applications externally, you may wish to disable the overrides on the toolbar as they will have no effect. See https://vercel.com/docs/microfrontends/managing-microfrontends/vercel-toolbar#routing-overrides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableOverrides")]
        public bool? DisableOverrides { get; set; }

        /// <summary>
        /// The port number used by the local proxy server. The default value is 3024. See https://vercel.com/docs/microfrontends/local-development.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localProxyPort")]
        public double? LocalProxyPort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb2aa6c85fab0cd65Options" /> class.
        /// </summary>
        /// <param name="disableOverrides">
        /// If you want to disable the overrides for the site. For example, if you are managing rewrites between applications externally, you may wish to disable the overrides on the toolbar as they will have no effect. See https://vercel.com/docs/microfrontends/managing-microfrontends/vercel-toolbar#routing-overrides.
        /// </param>
        /// <param name="localProxyPort">
        /// The port number used by the local proxy server. The default value is 3024. See https://vercel.com/docs/microfrontends/local-development.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb2aa6c85fab0cd65Options(
            bool? disableOverrides,
            double? localProxyPort)
        {
            this.DisableOverrides = disableOverrides;
            this.LocalProxyPort = localProxyPort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb2aa6c85fab0cd65Options" /> class.
        /// </summary>
        public AutoSDKSharedb2aa6c85fab0cd65Options()
        {
        }

    }
}