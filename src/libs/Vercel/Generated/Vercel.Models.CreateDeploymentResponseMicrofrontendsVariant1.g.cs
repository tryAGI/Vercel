
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseMicrofrontendsVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefaultApp")]
        public bool? IsDefaultApp { get; set; }

        /// <summary>
        /// The project name of the default app of this deployment's microfrontends group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultAppProjectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultAppProjectName { get; set; }

        /// <summary>
        /// A path that is used to take screenshots and as the default path in preview links when a domain for this microfrontend is shown in the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRoute")]
        public string? DefaultRoute { get; set; }

        /// <summary>
        /// The group of microfrontends that this project belongs to. Each microfrontend project must belong to a microfrontends group that is the set of microfrontends that are used together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> GroupIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseMicrofrontendsVariant1" /> class.
        /// </summary>
        /// <param name="defaultAppProjectName">
        /// The project name of the default app of this deployment's microfrontends group.
        /// </param>
        /// <param name="groupIds">
        /// The group of microfrontends that this project belongs to. Each microfrontend project must belong to a microfrontends group that is the set of microfrontends that are used together.
        /// </param>
        /// <param name="isDefaultApp"></param>
        /// <param name="defaultRoute">
        /// A path that is used to take screenshots and as the default path in preview links when a domain for this microfrontend is shown in the UI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseMicrofrontendsVariant1(
            string defaultAppProjectName,
            global::System.Collections.Generic.IList<string> groupIds,
            bool? isDefaultApp,
            string? defaultRoute)
        {
            this.IsDefaultApp = isDefaultApp;
            this.DefaultAppProjectName = defaultAppProjectName ?? throw new global::System.ArgumentNullException(nameof(defaultAppProjectName));
            this.DefaultRoute = defaultRoute;
            this.GroupIds = groupIds ?? throw new global::System.ArgumentNullException(nameof(groupIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseMicrofrontendsVariant1" /> class.
        /// </summary>
        public CreateDeploymentResponseMicrofrontendsVariant1()
        {
        }
    }
}