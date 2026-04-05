
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMicrofrontendsRequest
    {
        /// <summary>
        /// The unique group identifier to add this microfrontend to<br/>
        /// Example: mfe_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </summary>
        /// <example>mfe_12HKQaOmR5t5Uy6vdcQsNIiZgHGB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontendsGroupId")]
        public string? MicrofrontendsGroupId { get; set; }

        /// <summary>
        /// Enable or disable microfrontends for the project<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether the application is the default application for the microfrontends group<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefaultApp")]
        public bool? IsDefaultApp { get; set; }

        /// <summary>
        /// The default route used for screenshots and preview links for the project<br/>
        /// Example: /home
        /// </summary>
        /// <example>/home</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRoute")]
        public string? DefaultRoute { get; set; }

        /// <summary>
        /// Whether observability data should be routed to this project or a root project. Can only be set for child applications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routeObservabilityToThisProject")]
        public bool? RouteObservabilityToThisProject { get; set; }

        /// <summary>
        /// Whether domains in this project should route as a microfrontend. Can only be set for child applications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doNotRouteWithMicrofrontendsRouting")]
        public bool? DoNotRouteWithMicrofrontendsRouting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsRequest" /> class.
        /// </summary>
        /// <param name="microfrontendsGroupId">
        /// The unique group identifier to add this microfrontend to<br/>
        /// Example: mfe_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="enabled">
        /// Enable or disable microfrontends for the project<br/>
        /// Example: true
        /// </param>
        /// <param name="isDefaultApp">
        /// Whether the application is the default application for the microfrontends group<br/>
        /// Example: true
        /// </param>
        /// <param name="defaultRoute">
        /// The default route used for screenshots and preview links for the project<br/>
        /// Example: /home
        /// </param>
        /// <param name="routeObservabilityToThisProject">
        /// Whether observability data should be routed to this project or a root project. Can only be set for child applications.
        /// </param>
        /// <param name="doNotRouteWithMicrofrontendsRouting">
        /// Whether domains in this project should route as a microfrontend. Can only be set for child applications.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsRequest(
            string? microfrontendsGroupId,
            bool? enabled,
            bool? isDefaultApp,
            string? defaultRoute,
            bool? routeObservabilityToThisProject,
            bool? doNotRouteWithMicrofrontendsRouting)
        {
            this.MicrofrontendsGroupId = microfrontendsGroupId;
            this.Enabled = enabled;
            this.IsDefaultApp = isDefaultApp;
            this.DefaultRoute = defaultRoute;
            this.RouteObservabilityToThisProject = routeObservabilityToThisProject;
            this.DoNotRouteWithMicrofrontendsRouting = doNotRouteWithMicrofrontendsRouting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsRequest" /> class.
        /// </summary>
        public UpdateMicrofrontendsRequest()
        {
        }
    }
}