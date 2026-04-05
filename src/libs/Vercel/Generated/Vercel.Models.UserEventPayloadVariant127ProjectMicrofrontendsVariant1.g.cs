
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant127ProjectMicrofrontendsVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefaultApp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefaultApp { get; set; }

        /// <summary>
        /// Timestamp when the microfrontends settings were last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// The group IDs of microfrontends that this project belongs to. Each microfrontend project must belong to a microfrontends group that is the set of microfrontends that are used together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> GroupIds { get; set; }

        /// <summary>
        /// Whether microfrontends are enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// A path that is used to take screenshots and as the default path in preview links when a domain for this microfrontend is shown in the UI. Includes the leading slash, e.g. `/docs`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRoute")]
        public string? DefaultRoute { get; set; }

        /// <summary>
        /// Whether the project was part of the legacy limits for hobby and pro-trial before billing was added. This field is only set when the team is upgraded to a paid plan and we are backfilling the subscription status. We cap the subscription to 2 projects and set this field for the 3rd project. When this field is set, the project is not charged for and we do not call any billing APIs for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freeProjectForLegacyLimits")]
        public bool? FreeProjectForLegacyLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant127ProjectMicrofrontendsVariant1" /> class.
        /// </summary>
        /// <param name="isDefaultApp"></param>
        /// <param name="updatedAt">
        /// Timestamp when the microfrontends settings were last updated.
        /// </param>
        /// <param name="groupIds">
        /// The group IDs of microfrontends that this project belongs to. Each microfrontend project must belong to a microfrontends group that is the set of microfrontends that are used together.
        /// </param>
        /// <param name="enabled">
        /// Whether microfrontends are enabled for this project.
        /// </param>
        /// <param name="defaultRoute">
        /// A path that is used to take screenshots and as the default path in preview links when a domain for this microfrontend is shown in the UI. Includes the leading slash, e.g. `/docs`
        /// </param>
        /// <param name="freeProjectForLegacyLimits">
        /// Whether the project was part of the legacy limits for hobby and pro-trial before billing was added. This field is only set when the team is upgraded to a paid plan and we are backfilling the subscription status. We cap the subscription to 2 projects and set this field for the 3rd project. When this field is set, the project is not charged for and we do not call any billing APIs for this project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant127ProjectMicrofrontendsVariant1(
            bool isDefaultApp,
            double updatedAt,
            global::System.Collections.Generic.IList<string> groupIds,
            bool enabled,
            string? defaultRoute,
            bool? freeProjectForLegacyLimits)
        {
            this.IsDefaultApp = isDefaultApp;
            this.UpdatedAt = updatedAt;
            this.GroupIds = groupIds ?? throw new global::System.ArgumentNullException(nameof(groupIds));
            this.Enabled = enabled;
            this.DefaultRoute = defaultRoute;
            this.FreeProjectForLegacyLimits = freeProjectForLegacyLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant127ProjectMicrofrontendsVariant1" /> class.
        /// </summary>
        public UserEventPayloadVariant127ProjectMicrofrontendsVariant1()
        {
        }
    }
}