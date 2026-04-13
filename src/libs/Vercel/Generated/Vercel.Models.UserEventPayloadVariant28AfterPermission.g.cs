
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant28AfterPermission
    {
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_aiGatewayApiKey,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_billing,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_blob,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_deployment,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_domain,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_domainRegistrar,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_drains,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_edgeCache,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_edgeConfig,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_integrationConfiguration,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_integrationResource,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_project,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_projectEnvVars,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_projectEnvVarsNonProduction,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_projectEnvVarsProduction,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_projectFlagsNonProduction,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_projectFlagsProduction,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_projectProtectionBypass,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_remoteCache,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_sandbox,
        /// <summary>
        /// 
        /// </summary>
        Read_accessGroup,
        /// <summary>
        /// 
        /// </summary>
        Read_billing,
        /// <summary>
        /// 
        /// </summary>
        Read_deployment,
        /// <summary>
        /// 
        /// </summary>
        Read_domain,
        /// <summary>
        /// 
        /// </summary>
        Read_event,
        /// <summary>
        /// 
        /// </summary>
        Read_integrationConfiguration,
        /// <summary>
        /// 
        /// </summary>
        Read_monitoring,
        /// <summary>
        /// 
        /// </summary>
        Read_project,
        /// <summary>
        /// 
        /// </summary>
        Read_projectEnvVarsNonProduction,
        /// <summary>
        /// 
        /// </summary>
        Read_projectEnvVarsProduction,
        /// <summary>
        /// 
        /// </summary>
        Read_sandbox,
        /// <summary>
        /// 
        /// </summary>
        Read_team,
        /// <summary>
        /// 
        /// </summary>
        Use_aiGateway,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant28AfterPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant28AfterPermission value)
        {
            return value switch
            {
                UserEventPayloadVariant28AfterPermission.ReadWrite_aiGatewayApiKey => "read-write:ai-gateway-api-key",
                UserEventPayloadVariant28AfterPermission.ReadWrite_billing => "read-write:billing",
                UserEventPayloadVariant28AfterPermission.ReadWrite_blob => "read-write:blob",
                UserEventPayloadVariant28AfterPermission.ReadWrite_deployment => "read-write:deployment",
                UserEventPayloadVariant28AfterPermission.ReadWrite_domain => "read-write:domain",
                UserEventPayloadVariant28AfterPermission.ReadWrite_domainRegistrar => "read-write:domain-registrar",
                UserEventPayloadVariant28AfterPermission.ReadWrite_drains => "read-write:drains",
                UserEventPayloadVariant28AfterPermission.ReadWrite_edgeCache => "read-write:edge-cache",
                UserEventPayloadVariant28AfterPermission.ReadWrite_edgeConfig => "read-write:edge-config",
                UserEventPayloadVariant28AfterPermission.ReadWrite_integrationConfiguration => "read-write:integration-configuration",
                UserEventPayloadVariant28AfterPermission.ReadWrite_integrationResource => "read-write:integration-resource",
                UserEventPayloadVariant28AfterPermission.ReadWrite_project => "read-write:project",
                UserEventPayloadVariant28AfterPermission.ReadWrite_projectEnvVars => "read-write:project-env-vars",
                UserEventPayloadVariant28AfterPermission.ReadWrite_projectEnvVarsNonProduction => "read-write:project-env-vars-non-production",
                UserEventPayloadVariant28AfterPermission.ReadWrite_projectEnvVarsProduction => "read-write:project-env-vars-production",
                UserEventPayloadVariant28AfterPermission.ReadWrite_projectFlagsNonProduction => "read-write:project-flags-non-production",
                UserEventPayloadVariant28AfterPermission.ReadWrite_projectFlagsProduction => "read-write:project-flags-production",
                UserEventPayloadVariant28AfterPermission.ReadWrite_projectProtectionBypass => "read-write:project-protection-bypass",
                UserEventPayloadVariant28AfterPermission.ReadWrite_remoteCache => "read-write:remote-cache",
                UserEventPayloadVariant28AfterPermission.ReadWrite_sandbox => "read-write:sandbox",
                UserEventPayloadVariant28AfterPermission.Read_accessGroup => "read:access-group",
                UserEventPayloadVariant28AfterPermission.Read_billing => "read:billing",
                UserEventPayloadVariant28AfterPermission.Read_deployment => "read:deployment",
                UserEventPayloadVariant28AfterPermission.Read_domain => "read:domain",
                UserEventPayloadVariant28AfterPermission.Read_event => "read:event",
                UserEventPayloadVariant28AfterPermission.Read_integrationConfiguration => "read:integration-configuration",
                UserEventPayloadVariant28AfterPermission.Read_monitoring => "read:monitoring",
                UserEventPayloadVariant28AfterPermission.Read_project => "read:project",
                UserEventPayloadVariant28AfterPermission.Read_projectEnvVarsNonProduction => "read:project-env-vars-non-production",
                UserEventPayloadVariant28AfterPermission.Read_projectEnvVarsProduction => "read:project-env-vars-production",
                UserEventPayloadVariant28AfterPermission.Read_sandbox => "read:sandbox",
                UserEventPayloadVariant28AfterPermission.Read_team => "read:team",
                UserEventPayloadVariant28AfterPermission.Use_aiGateway => "use:ai-gateway",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant28AfterPermission? ToEnum(string value)
        {
            return value switch
            {
                "read-write:ai-gateway-api-key" => UserEventPayloadVariant28AfterPermission.ReadWrite_aiGatewayApiKey,
                "read-write:billing" => UserEventPayloadVariant28AfterPermission.ReadWrite_billing,
                "read-write:blob" => UserEventPayloadVariant28AfterPermission.ReadWrite_blob,
                "read-write:deployment" => UserEventPayloadVariant28AfterPermission.ReadWrite_deployment,
                "read-write:domain" => UserEventPayloadVariant28AfterPermission.ReadWrite_domain,
                "read-write:domain-registrar" => UserEventPayloadVariant28AfterPermission.ReadWrite_domainRegistrar,
                "read-write:drains" => UserEventPayloadVariant28AfterPermission.ReadWrite_drains,
                "read-write:edge-cache" => UserEventPayloadVariant28AfterPermission.ReadWrite_edgeCache,
                "read-write:edge-config" => UserEventPayloadVariant28AfterPermission.ReadWrite_edgeConfig,
                "read-write:integration-configuration" => UserEventPayloadVariant28AfterPermission.ReadWrite_integrationConfiguration,
                "read-write:integration-resource" => UserEventPayloadVariant28AfterPermission.ReadWrite_integrationResource,
                "read-write:project" => UserEventPayloadVariant28AfterPermission.ReadWrite_project,
                "read-write:project-env-vars" => UserEventPayloadVariant28AfterPermission.ReadWrite_projectEnvVars,
                "read-write:project-env-vars-non-production" => UserEventPayloadVariant28AfterPermission.ReadWrite_projectEnvVarsNonProduction,
                "read-write:project-env-vars-production" => UserEventPayloadVariant28AfterPermission.ReadWrite_projectEnvVarsProduction,
                "read-write:project-flags-non-production" => UserEventPayloadVariant28AfterPermission.ReadWrite_projectFlagsNonProduction,
                "read-write:project-flags-production" => UserEventPayloadVariant28AfterPermission.ReadWrite_projectFlagsProduction,
                "read-write:project-protection-bypass" => UserEventPayloadVariant28AfterPermission.ReadWrite_projectProtectionBypass,
                "read-write:remote-cache" => UserEventPayloadVariant28AfterPermission.ReadWrite_remoteCache,
                "read-write:sandbox" => UserEventPayloadVariant28AfterPermission.ReadWrite_sandbox,
                "read:access-group" => UserEventPayloadVariant28AfterPermission.Read_accessGroup,
                "read:billing" => UserEventPayloadVariant28AfterPermission.Read_billing,
                "read:deployment" => UserEventPayloadVariant28AfterPermission.Read_deployment,
                "read:domain" => UserEventPayloadVariant28AfterPermission.Read_domain,
                "read:event" => UserEventPayloadVariant28AfterPermission.Read_event,
                "read:integration-configuration" => UserEventPayloadVariant28AfterPermission.Read_integrationConfiguration,
                "read:monitoring" => UserEventPayloadVariant28AfterPermission.Read_monitoring,
                "read:project" => UserEventPayloadVariant28AfterPermission.Read_project,
                "read:project-env-vars-non-production" => UserEventPayloadVariant28AfterPermission.Read_projectEnvVarsNonProduction,
                "read:project-env-vars-production" => UserEventPayloadVariant28AfterPermission.Read_projectEnvVarsProduction,
                "read:sandbox" => UserEventPayloadVariant28AfterPermission.Read_sandbox,
                "read:team" => UserEventPayloadVariant28AfterPermission.Read_team,
                "use:ai-gateway" => UserEventPayloadVariant28AfterPermission.Use_aiGateway,
                _ => null,
            };
        }
    }
}