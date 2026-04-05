
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMicrofrontendsConfigResponseConfigApplicationsVariant2
    {
        /// <summary>
        /// Development configuration for the child application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("development")]
        public global::Vercel.GetMicrofrontendsConfigResponseConfigApplicationsVariant2Development? Development { get; set; }

        /// <summary>
        /// Groups of path expressions that are routed to this application. See https://vercel.com/docs/microfrontends/path-routing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsConfigResponseConfigApplicationsVariant2RoutingItem> Routing { get; set; }

        /// <summary>
        /// The name of the asset prefix to use instead of the auto-generated name. The asset prefix is used to prefix all paths to static assets, such as JS, CSS, or images that are served by a specific application. It is necessary to ensure there are no conflicts with other applications on the same domain. An auto-generated asset prefix of the form `vc-ap-&lt;hash&gt;` is used when this field is not provided. When this field is provided, `/${assetPrefix}/:path*` must also be added to the list of paths in the `routing` field. Changing the asset prefix after a microfrontend application has already been deployed is not a forwards and backwards compatible change, and the asset prefix should be added to the `routing` field and deployed before setting the `assetPrefix` field. The default value is the auto-generated asset prefix of the form `vc-ap-&lt;hash&gt;`. See https://vercel.com/docs/microfrontends/path-routing#asset-prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetPrefix")]
        public string? AssetPrefix { get; set; }

        /// <summary>
        /// The name used to run the application, e.g. the `name` field in the `package.json`. This is used by the local proxy to map the application config to the locally running app. This is only necessary when the application name does not match the `name` used in `package.json`. See https://vercel.com/docs/microfrontends/configuration#application-naming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageName")]
        public string? PackageName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsConfigResponseConfigApplicationsVariant2" /> class.
        /// </summary>
        /// <param name="routing">
        /// Groups of path expressions that are routed to this application. See https://vercel.com/docs/microfrontends/path-routing.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="development">
        /// Development configuration for the child application.
        /// </param>
        /// <param name="assetPrefix">
        /// The name of the asset prefix to use instead of the auto-generated name. The asset prefix is used to prefix all paths to static assets, such as JS, CSS, or images that are served by a specific application. It is necessary to ensure there are no conflicts with other applications on the same domain. An auto-generated asset prefix of the form `vc-ap-&lt;hash&gt;` is used when this field is not provided. When this field is provided, `/${assetPrefix}/:path*` must also be added to the list of paths in the `routing` field. Changing the asset prefix after a microfrontend application has already been deployed is not a forwards and backwards compatible change, and the asset prefix should be added to the `routing` field and deployed before setting the `assetPrefix` field. The default value is the auto-generated asset prefix of the form `vc-ap-&lt;hash&gt;`. See https://vercel.com/docs/microfrontends/path-routing#asset-prefix.
        /// </param>
        /// <param name="packageName">
        /// The name used to run the application, e.g. the `name` field in the `package.json`. This is used by the local proxy to map the application config to the locally running app. This is only necessary when the application name does not match the `name` used in `package.json`. See https://vercel.com/docs/microfrontends/configuration#application-naming.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsConfigResponseConfigApplicationsVariant2(
            global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsConfigResponseConfigApplicationsVariant2RoutingItem> routing,
            string projectId,
            global::Vercel.GetMicrofrontendsConfigResponseConfigApplicationsVariant2Development? development,
            string? assetPrefix,
            string? packageName)
        {
            this.Development = development;
            this.Routing = routing ?? throw new global::System.ArgumentNullException(nameof(routing));
            this.AssetPrefix = assetPrefix;
            this.PackageName = packageName;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsConfigResponseConfigApplicationsVariant2" /> class.
        /// </summary>
        public GetMicrofrontendsConfigResponseConfigApplicationsVariant2()
        {
        }
    }
}