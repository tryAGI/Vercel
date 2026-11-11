
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc1c2f92d02e0feb6SsoProtection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("april2026SecurityIncidentMigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc1c2f92d02e0feb6SsoProtectionApril2026SecurityIncidentMigrationAppliedFromJsonConverter))]
        public global::Vercel.AutoSDKSharedc1c2f92d02e0feb6SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? April2026SecurityIncidentMigrationAppliedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve55182MigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc1c2f92d02e0feb6SsoProtectionCve55182MigrationAppliedFromJsonConverter))]
        public global::Vercel.AutoSDKSharedc1c2f92d02e0feb6SsoProtectionCve55182MigrationAppliedFrom? Cve55182MigrationAppliedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc1c2f92d02e0feb6SsoProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedc1c2f92d02e0feb6SsoProtectionDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc1c2f92d02e0feb6SsoProtection" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
        /// <param name="april2026SecurityIncidentMigrationAppliedFrom"></param>
        /// <param name="cve55182MigrationAppliedFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc1c2f92d02e0feb6SsoProtection(
            global::Vercel.AutoSDKSharedc1c2f92d02e0feb6SsoProtectionDeploymentType deploymentType,
            global::Vercel.AutoSDKSharedc1c2f92d02e0feb6SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? april2026SecurityIncidentMigrationAppliedFrom,
            global::Vercel.AutoSDKSharedc1c2f92d02e0feb6SsoProtectionCve55182MigrationAppliedFrom? cve55182MigrationAppliedFrom)
        {
            this.April2026SecurityIncidentMigrationAppliedFrom = april2026SecurityIncidentMigrationAppliedFrom;
            this.Cve55182MigrationAppliedFrom = cve55182MigrationAppliedFrom;
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc1c2f92d02e0feb6SsoProtection" /> class.
        /// </summary>
        public AutoSDKSharedc1c2f92d02e0feb6SsoProtection()
        {
        }

    }
}