
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf5934c240f4382f7SsoProtection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("april2026SecurityIncidentMigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf5934c240f4382f7SsoProtectionApril2026SecurityIncidentMigrationAppliedFromJsonConverter))]
        public global::Vercel.AutoSDKSharedf5934c240f4382f7SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? April2026SecurityIncidentMigrationAppliedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve55182MigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFromJsonConverter))]
        public global::Vercel.AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom? Cve55182MigrationAppliedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf5934c240f4382f7SsoProtection" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
        /// <param name="april2026SecurityIncidentMigrationAppliedFrom"></param>
        /// <param name="cve55182MigrationAppliedFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf5934c240f4382f7SsoProtection(
            global::Vercel.AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType deploymentType,
            global::Vercel.AutoSDKSharedf5934c240f4382f7SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? april2026SecurityIncidentMigrationAppliedFrom,
            global::Vercel.AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom? cve55182MigrationAppliedFrom)
        {
            this.April2026SecurityIncidentMigrationAppliedFrom = april2026SecurityIncidentMigrationAppliedFrom;
            this.Cve55182MigrationAppliedFrom = cve55182MigrationAppliedFrom;
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf5934c240f4382f7SsoProtection" /> class.
        /// </summary>
        public AutoSDKSharedf5934c240f4382f7SsoProtection()
        {
        }

    }
}