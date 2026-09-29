
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared26233794f6c8981bSsoProtection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("april2026SecurityIncidentMigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared26233794f6c8981bSsoProtectionApril2026SecurityIncidentMigrationAppliedFromJsonConverter))]
        public global::Vercel.AutoSDKShared26233794f6c8981bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? April2026SecurityIncidentMigrationAppliedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve55182MigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared26233794f6c8981bSsoProtectionCve55182MigrationAppliedFromJsonConverter))]
        public global::Vercel.AutoSDKShared26233794f6c8981bSsoProtectionCve55182MigrationAppliedFrom? Cve55182MigrationAppliedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared26233794f6c8981bSsoProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared26233794f6c8981bSsoProtectionDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared26233794f6c8981bSsoProtection" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
        /// <param name="april2026SecurityIncidentMigrationAppliedFrom"></param>
        /// <param name="cve55182MigrationAppliedFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared26233794f6c8981bSsoProtection(
            global::Vercel.AutoSDKShared26233794f6c8981bSsoProtectionDeploymentType deploymentType,
            global::Vercel.AutoSDKShared26233794f6c8981bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? april2026SecurityIncidentMigrationAppliedFrom,
            global::Vercel.AutoSDKShared26233794f6c8981bSsoProtectionCve55182MigrationAppliedFrom? cve55182MigrationAppliedFrom)
        {
            this.April2026SecurityIncidentMigrationAppliedFrom = april2026SecurityIncidentMigrationAppliedFrom;
            this.Cve55182MigrationAppliedFrom = cve55182MigrationAppliedFrom;
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared26233794f6c8981bSsoProtection" /> class.
        /// </summary>
        public AutoSDKShared26233794f6c8981bSsoProtection()
        {
        }

    }
}