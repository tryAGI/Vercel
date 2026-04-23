
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant220OldSsoProtectionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant220OldSsoProtectionEnumDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant220OldSsoProtectionEnumDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve55182MigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant220OldSsoProtectionEnumCve55182MigrationAppliedFromJsonConverter))]
        public global::Vercel.UserEventPayloadVariant220OldSsoProtectionEnumCve55182MigrationAppliedFrom? Cve55182MigrationAppliedFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("april2026SecurityIncidentMigrationAppliedFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant220OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFromJsonConverter))]
        public global::Vercel.UserEventPayloadVariant220OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom? April2026SecurityIncidentMigrationAppliedFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant220OldSsoProtectionEnum" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
        /// <param name="cve55182MigrationAppliedFrom"></param>
        /// <param name="april2026SecurityIncidentMigrationAppliedFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant220OldSsoProtectionEnum(
            global::Vercel.UserEventPayloadVariant220OldSsoProtectionEnumDeploymentType deploymentType,
            global::Vercel.UserEventPayloadVariant220OldSsoProtectionEnumCve55182MigrationAppliedFrom? cve55182MigrationAppliedFrom,
            global::Vercel.UserEventPayloadVariant220OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom? april2026SecurityIncidentMigrationAppliedFrom)
        {
            this.DeploymentType = deploymentType;
            this.Cve55182MigrationAppliedFrom = cve55182MigrationAppliedFrom;
            this.April2026SecurityIncidentMigrationAppliedFrom = april2026SecurityIncidentMigrationAppliedFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant220OldSsoProtectionEnum" /> class.
        /// </summary>
        public UserEventPayloadVariant220OldSsoProtectionEnum()
        {
        }
    }
}