
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseMicrofrontendsVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefaultApp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefaultApp { get; set; }

        /// <summary>
        /// The result of the microfrontends config upload during deployment creation / build. Only set for default app deployments. The config upload is attempted during deployment create, and then again during the build. If the config is not in the root directory, or the deployment is prebuilt, the config cannot be uploaded during deployment create. The upload during deployment build finds the config even if it's not in the root directory, as it has access to all files. Uploading the config during create is ideal, as then all child deployments are guaranteed to have access to the default app deployment config even if the default app has not yet started building. If the config is not uploaded, the child app will show as building until the config has been uploaded during the default app build. - `success` - The config was uploaded successfully, either when the deployment was created or during the build. - `waiting_on_build` - The config could not be uploaded during deployment create, will be attempted again during the build. - `no_config` - No config was found. Only set once the build has not found the config in any of the deployment's files. - `undefined` - Legacy deployments, or there was an error uploading the config during deployment create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfeConfigUploadState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseMicrofrontendsVariant2MfeConfigUploadStateJsonConverter))]
        public global::Vercel.CreateDeploymentResponseMicrofrontendsVariant2MfeConfigUploadState? MfeConfigUploadState { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseMicrofrontendsVariant2" /> class.
        /// </summary>
        /// <param name="isDefaultApp"></param>
        /// <param name="defaultAppProjectName">
        /// The project name of the default app of this deployment's microfrontends group.
        /// </param>
        /// <param name="groupIds">
        /// The group of microfrontends that this project belongs to. Each microfrontend project must belong to a microfrontends group that is the set of microfrontends that are used together.
        /// </param>
        /// <param name="mfeConfigUploadState">
        /// The result of the microfrontends config upload during deployment creation / build. Only set for default app deployments. The config upload is attempted during deployment create, and then again during the build. If the config is not in the root directory, or the deployment is prebuilt, the config cannot be uploaded during deployment create. The upload during deployment build finds the config even if it's not in the root directory, as it has access to all files. Uploading the config during create is ideal, as then all child deployments are guaranteed to have access to the default app deployment config even if the default app has not yet started building. If the config is not uploaded, the child app will show as building until the config has been uploaded during the default app build. - `success` - The config was uploaded successfully, either when the deployment was created or during the build. - `waiting_on_build` - The config could not be uploaded during deployment create, will be attempted again during the build. - `no_config` - No config was found. Only set once the build has not found the config in any of the deployment's files. - `undefined` - Legacy deployments, or there was an error uploading the config during deployment create.
        /// </param>
        /// <param name="defaultRoute">
        /// A path that is used to take screenshots and as the default path in preview links when a domain for this microfrontend is shown in the UI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseMicrofrontendsVariant2(
            bool isDefaultApp,
            string defaultAppProjectName,
            global::System.Collections.Generic.IList<string> groupIds,
            global::Vercel.CreateDeploymentResponseMicrofrontendsVariant2MfeConfigUploadState? mfeConfigUploadState,
            string? defaultRoute)
        {
            this.IsDefaultApp = isDefaultApp;
            this.MfeConfigUploadState = mfeConfigUploadState;
            this.DefaultAppProjectName = defaultAppProjectName ?? throw new global::System.ArgumentNullException(nameof(defaultAppProjectName));
            this.DefaultRoute = defaultRoute;
            this.GroupIds = groupIds ?? throw new global::System.ArgumentNullException(nameof(groupIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseMicrofrontendsVariant2" /> class.
        /// </summary>
        public CreateDeploymentResponseMicrofrontendsVariant2()
        {
        }
    }
}