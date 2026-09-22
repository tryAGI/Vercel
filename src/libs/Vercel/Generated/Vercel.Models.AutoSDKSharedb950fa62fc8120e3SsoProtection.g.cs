
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedb950fa62fc8120e3SsoProtection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("april2026SecurityIncidentMigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedb950fa62fc8120e3SsoProtectionApril2026SecurityIncidentMigrationAppliedFromJsonConverter))]
        public global::Vercel.AutoSDKSharedb950fa62fc8120e3SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? April2026SecurityIncidentMigrationAppliedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve55182MigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedb950fa62fc8120e3SsoProtectionCve55182MigrationAppliedFromJsonConverter))]
        public global::Vercel.AutoSDKSharedb950fa62fc8120e3SsoProtectionCve55182MigrationAppliedFrom? Cve55182MigrationAppliedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb950fa62fc8120e3SsoProtection" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
        /// <param name="april2026SecurityIncidentMigrationAppliedFrom"></param>
        /// <param name="cve55182MigrationAppliedFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb950fa62fc8120e3SsoProtection(
            global::Vercel.AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType deploymentType,
            global::Vercel.AutoSDKSharedb950fa62fc8120e3SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? april2026SecurityIncidentMigrationAppliedFrom,
            global::Vercel.AutoSDKSharedb950fa62fc8120e3SsoProtectionCve55182MigrationAppliedFrom? cve55182MigrationAppliedFrom)
        {
            this.April2026SecurityIncidentMigrationAppliedFrom = april2026SecurityIncidentMigrationAppliedFrom;
            this.Cve55182MigrationAppliedFrom = cve55182MigrationAppliedFrom;
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb950fa62fc8120e3SsoProtection" /> class.
        /// </summary>
        public AutoSDKSharedb950fa62fc8120e3SsoProtection()
        {
        }

    }
}