
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant1
    {
        /// <summary>
        /// Development configuration for the default application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("development")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant1Development Development { get; set; }

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
        /// Initializes a new instance of the <see cref="GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant1" /> class.
        /// </summary>
        /// <param name="development">
        /// Development configuration for the default application.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="packageName">
        /// The name used to run the application, e.g. the `name` field in the `package.json`. This is used by the local proxy to map the application config to the locally running app. This is only necessary when the application name does not match the `name` used in `package.json`. See https://vercel.com/docs/microfrontends/configuration#application-naming.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant1(
            global::Vercel.GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant1Development development,
            string projectId,
            string? packageName)
        {
            this.Development = development ?? throw new global::System.ArgumentNullException(nameof(development));
            this.PackageName = packageName;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant1" /> class.
        /// </summary>
        public GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant1()
        {
        }
    }
}