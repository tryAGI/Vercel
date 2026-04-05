
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectSsoProtection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectSsoProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve55182MigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFromJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom? Cve55182MigrationAppliedFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectSsoProtection" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
        /// <param name="cve55182MigrationAppliedFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectSsoProtection(
            global::Vercel.GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType deploymentType,
            global::Vercel.GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom? cve55182MigrationAppliedFrom)
        {
            this.DeploymentType = deploymentType;
            this.Cve55182MigrationAppliedFrom = cve55182MigrationAppliedFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectSsoProtection" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectSsoProtection()
        {
        }
    }
}