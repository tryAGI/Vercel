
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant2
    {
        /// <summary>
        /// A path that is used to take screenshots and as the default path in preview links when a domain for this microfrontend is shown in the UI. Includes the leading slash, e.g. `/docs`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRoute")]
        public string? DefaultRoute { get; set; }

        /// <summary>
        /// Whether to add microfrontends routing to aliases. This means domains in this project will route as a microfrontend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doNotRouteWithMicrofrontendsRouting")]
        public bool? DoNotRouteWithMicrofrontendsRouting { get; set; }

        /// <summary>
        /// Whether microfrontends are enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Whether the project was part of the legacy limits for hobby and pro-trial before billing was added. This field is only set when the team is upgraded to a paid plan and we are backfilling the subscription status. We cap the subscription to 2 projects and set this field for the 3rd project. When this field is set, the project is not charged for and we do not call any billing APIs for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freeProjectForLegacyLimits")]
        public bool? FreeProjectForLegacyLimits { get; set; }

        /// <summary>
        /// The group IDs of microfrontends that this project belongs to. Each microfrontend project must belong to a microfrontends group that is the set of microfrontends that are used together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> GroupIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefaultApp")]
        public bool? IsDefaultApp { get; set; }

        /// <summary>
        /// Whether observability data should be routed to this microfrontend project or a root project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routeObservabilityToThisProject")]
        public bool? RouteObservabilityToThisProject { get; set; }

        /// <summary>
        /// Timestamp when the microfrontends settings were last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant2" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether microfrontends are enabled for this project.
        /// </param>
        /// <param name="groupIds">
        /// The group IDs of microfrontends that this project belongs to. Each microfrontend project must belong to a microfrontends group that is the set of microfrontends that are used together.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the microfrontends settings were last updated.
        /// </param>
        /// <param name="defaultRoute">
        /// A path that is used to take screenshots and as the default path in preview links when a domain for this microfrontend is shown in the UI. Includes the leading slash, e.g. `/docs`
        /// </param>
        /// <param name="doNotRouteWithMicrofrontendsRouting">
        /// Whether to add microfrontends routing to aliases. This means domains in this project will route as a microfrontend.
        /// </param>
        /// <param name="freeProjectForLegacyLimits">
        /// Whether the project was part of the legacy limits for hobby and pro-trial before billing was added. This field is only set when the team is upgraded to a paid plan and we are backfilling the subscription status. We cap the subscription to 2 projects and set this field for the 3rd project. When this field is set, the project is not charged for and we do not call any billing APIs for this project.
        /// </param>
        /// <param name="isDefaultApp"></param>
        /// <param name="routeObservabilityToThisProject">
        /// Whether observability data should be routed to this microfrontend project or a root project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant2(
            bool enabled,
            global::System.Collections.Generic.IList<string> groupIds,
            double updatedAt,
            string? defaultRoute,
            bool? doNotRouteWithMicrofrontendsRouting,
            bool? freeProjectForLegacyLimits,
            bool? isDefaultApp,
            bool? routeObservabilityToThisProject)
        {
            this.DefaultRoute = defaultRoute;
            this.DoNotRouteWithMicrofrontendsRouting = doNotRouteWithMicrofrontendsRouting;
            this.Enabled = enabled;
            this.FreeProjectForLegacyLimits = freeProjectForLegacyLimits;
            this.GroupIds = groupIds ?? throw new global::System.ArgumentNullException(nameof(groupIds));
            this.IsDefaultApp = isDefaultApp;
            this.RouteObservabilityToThisProject = routeObservabilityToThisProject;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant2" /> class.
        /// </summary>
        public GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant2()
        {
        }

    }
}