
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedba7c6b12ca723bfbSsoProtection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("april2026SecurityIncidentMigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedba7c6b12ca723bfbSsoProtectionApril2026SecurityIncidentMigrationAppliedFromJsonConverter))]
        public global::Vercel.AutoSDKSharedba7c6b12ca723bfbSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? April2026SecurityIncidentMigrationAppliedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve55182MigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedba7c6b12ca723bfbSsoProtectionCve55182MigrationAppliedFromJsonConverter))]
        public global::Vercel.AutoSDKSharedba7c6b12ca723bfbSsoProtectionCve55182MigrationAppliedFrom? Cve55182MigrationAppliedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedba7c6b12ca723bfbSsoProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedba7c6b12ca723bfbSsoProtectionDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedba7c6b12ca723bfbSsoProtection" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
        /// <param name="april2026SecurityIncidentMigrationAppliedFrom"></param>
        /// <param name="cve55182MigrationAppliedFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedba7c6b12ca723bfbSsoProtection(
            global::Vercel.AutoSDKSharedba7c6b12ca723bfbSsoProtectionDeploymentType deploymentType,
            global::Vercel.AutoSDKSharedba7c6b12ca723bfbSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? april2026SecurityIncidentMigrationAppliedFrom,
            global::Vercel.AutoSDKSharedba7c6b12ca723bfbSsoProtectionCve55182MigrationAppliedFrom? cve55182MigrationAppliedFrom)
        {
            this.April2026SecurityIncidentMigrationAppliedFrom = april2026SecurityIncidentMigrationAppliedFrom;
            this.Cve55182MigrationAppliedFrom = cve55182MigrationAppliedFrom;
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedba7c6b12ca723bfbSsoProtection" /> class.
        /// </summary>
        public AutoSDKSharedba7c6b12ca723bfbSsoProtection()
        {
        }

    }
}