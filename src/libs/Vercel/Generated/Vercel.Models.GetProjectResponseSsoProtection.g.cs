
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponseSsoProtection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseSsoProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectResponseSsoProtectionDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve55182MigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseSsoProtectionCve55182MigrationAppliedFromJsonConverter))]
        public global::Vercel.GetProjectResponseSsoProtectionCve55182MigrationAppliedFrom? Cve55182MigrationAppliedFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseSsoProtection" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
        /// <param name="cve55182MigrationAppliedFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseSsoProtection(
            global::Vercel.GetProjectResponseSsoProtectionDeploymentType deploymentType,
            global::Vercel.GetProjectResponseSsoProtectionCve55182MigrationAppliedFrom? cve55182MigrationAppliedFrom)
        {
            this.DeploymentType = deploymentType;
            this.Cve55182MigrationAppliedFrom = cve55182MigrationAppliedFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseSsoProtection" /> class.
        /// </summary>
        public GetProjectResponseSsoProtection()
        {
        }
    }
}