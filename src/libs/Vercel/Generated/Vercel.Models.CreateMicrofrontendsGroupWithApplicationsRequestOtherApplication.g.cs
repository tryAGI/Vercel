
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMicrofrontendsGroupWithApplicationsRequestOtherApplication
    {
        /// <summary>
        /// The id of the project that will be used in the new microfrontend group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The default route for the application in the new microfrontend group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRoute")]
        public string? DefaultRoute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMicrofrontendsGroupWithApplicationsRequestOtherApplication" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The id of the project that will be used in the new microfrontend group
        /// </param>
        /// <param name="defaultRoute">
        /// The default route for the application in the new microfrontend group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMicrofrontendsGroupWithApplicationsRequestOtherApplication(
            string projectId,
            string? defaultRoute)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DefaultRoute = defaultRoute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMicrofrontendsGroupWithApplicationsRequestOtherApplication" /> class.
        /// </summary>
        public CreateMicrofrontendsGroupWithApplicationsRequestOtherApplication()
        {
        }
    }
}