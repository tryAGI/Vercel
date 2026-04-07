
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant26BeforePermission
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
    public static class UserEventPayloadVariant26BeforePermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant26BeforePermission value)
        {
            return value switch
            {
                UserEventPayloadVariant26BeforePermission.ReadWrite_aiGatewayApiKey => "read-write:ai-gateway-api-key",
                UserEventPayloadVariant26BeforePermission.ReadWrite_billing => "read-write:billing",
                UserEventPayloadVariant26BeforePermission.ReadWrite_blob => "read-write:blob",
                UserEventPayloadVariant26BeforePermission.ReadWrite_deployment => "read-write:deployment",
                UserEventPayloadVariant26BeforePermission.ReadWrite_domain => "read-write:domain",
                UserEventPayloadVariant26BeforePermission.ReadWrite_domainRegistrar => "read-write:domain-registrar",
                UserEventPayloadVariant26BeforePermission.ReadWrite_drains => "read-write:drains",
                UserEventPayloadVariant26BeforePermission.ReadWrite_edgeCache => "read-write:edge-cache",
                UserEventPayloadVariant26BeforePermission.ReadWrite_edgeConfig => "read-write:edge-config",
                UserEventPayloadVariant26BeforePermission.ReadWrite_integrationConfiguration => "read-write:integration-configuration",
                UserEventPayloadVariant26BeforePermission.ReadWrite_integrationResource => "read-write:integration-resource",
                UserEventPayloadVariant26BeforePermission.ReadWrite_project => "read-write:project",
                UserEventPayloadVariant26BeforePermission.ReadWrite_projectEnvVars => "read-write:project-env-vars",
                UserEventPayloadVariant26BeforePermission.ReadWrite_projectEnvVarsNonProduction => "read-write:project-env-vars-non-production",
                UserEventPayloadVariant26BeforePermission.ReadWrite_projectEnvVarsProduction => "read-write:project-env-vars-production",
                UserEventPayloadVariant26BeforePermission.ReadWrite_projectFlagsNonProduction => "read-write:project-flags-non-production",
                UserEventPayloadVariant26BeforePermission.ReadWrite_projectFlagsProduction => "read-write:project-flags-production",
                UserEventPayloadVariant26BeforePermission.ReadWrite_projectProtectionBypass => "read-write:project-protection-bypass",
                UserEventPayloadVariant26BeforePermission.ReadWrite_remoteCache => "read-write:remote-cache",
                UserEventPayloadVariant26BeforePermission.ReadWrite_sandbox => "read-write:sandbox",
                UserEventPayloadVariant26BeforePermission.Read_accessGroup => "read:access-group",
                UserEventPayloadVariant26BeforePermission.Read_billing => "read:billing",
                UserEventPayloadVariant26BeforePermission.Read_deployment => "read:deployment",
                UserEventPayloadVariant26BeforePermission.Read_domain => "read:domain",
                UserEventPayloadVariant26BeforePermission.Read_event => "read:event",
                UserEventPayloadVariant26BeforePermission.Read_integrationConfiguration => "read:integration-configuration",
                UserEventPayloadVariant26BeforePermission.Read_monitoring => "read:monitoring",
                UserEventPayloadVariant26BeforePermission.Read_project => "read:project",
                UserEventPayloadVariant26BeforePermission.Read_projectEnvVarsNonProduction => "read:project-env-vars-non-production",
                UserEventPayloadVariant26BeforePermission.Read_projectEnvVarsProduction => "read:project-env-vars-production",
                UserEventPayloadVariant26BeforePermission.Read_sandbox => "read:sandbox",
                UserEventPayloadVariant26BeforePermission.Read_team => "read:team",
                UserEventPayloadVariant26BeforePermission.Use_aiGateway => "use:ai-gateway",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant26BeforePermission? ToEnum(string value)
        {
            return value switch
            {
                "read-write:ai-gateway-api-key" => UserEventPayloadVariant26BeforePermission.ReadWrite_aiGatewayApiKey,
                "read-write:billing" => UserEventPayloadVariant26BeforePermission.ReadWrite_billing,
                "read-write:blob" => UserEventPayloadVariant26BeforePermission.ReadWrite_blob,
                "read-write:deployment" => UserEventPayloadVariant26BeforePermission.ReadWrite_deployment,
                "read-write:domain" => UserEventPayloadVariant26BeforePermission.ReadWrite_domain,
                "read-write:domain-registrar" => UserEventPayloadVariant26BeforePermission.ReadWrite_domainRegistrar,
                "read-write:drains" => UserEventPayloadVariant26BeforePermission.ReadWrite_drains,
                "read-write:edge-cache" => UserEventPayloadVariant26BeforePermission.ReadWrite_edgeCache,
                "read-write:edge-config" => UserEventPayloadVariant26BeforePermission.ReadWrite_edgeConfig,
                "read-write:integration-configuration" => UserEventPayloadVariant26BeforePermission.ReadWrite_integrationConfiguration,
                "read-write:integration-resource" => UserEventPayloadVariant26BeforePermission.ReadWrite_integrationResource,
                "read-write:project" => UserEventPayloadVariant26BeforePermission.ReadWrite_project,
                "read-write:project-env-vars" => UserEventPayloadVariant26BeforePermission.ReadWrite_projectEnvVars,
                "read-write:project-env-vars-non-production" => UserEventPayloadVariant26BeforePermission.ReadWrite_projectEnvVarsNonProduction,
                "read-write:project-env-vars-production" => UserEventPayloadVariant26BeforePermission.ReadWrite_projectEnvVarsProduction,
                "read-write:project-flags-non-production" => UserEventPayloadVariant26BeforePermission.ReadWrite_projectFlagsNonProduction,
                "read-write:project-flags-production" => UserEventPayloadVariant26BeforePermission.ReadWrite_projectFlagsProduction,
                "read-write:project-protection-bypass" => UserEventPayloadVariant26BeforePermission.ReadWrite_projectProtectionBypass,
                "read-write:remote-cache" => UserEventPayloadVariant26BeforePermission.ReadWrite_remoteCache,
                "read-write:sandbox" => UserEventPayloadVariant26BeforePermission.ReadWrite_sandbox,
                "read:access-group" => UserEventPayloadVariant26BeforePermission.Read_accessGroup,
                "read:billing" => UserEventPayloadVariant26BeforePermission.Read_billing,
                "read:deployment" => UserEventPayloadVariant26BeforePermission.Read_deployment,
                "read:domain" => UserEventPayloadVariant26BeforePermission.Read_domain,
                "read:event" => UserEventPayloadVariant26BeforePermission.Read_event,
                "read:integration-configuration" => UserEventPayloadVariant26BeforePermission.Read_integrationConfiguration,
                "read:monitoring" => UserEventPayloadVariant26BeforePermission.Read_monitoring,
                "read:project" => UserEventPayloadVariant26BeforePermission.Read_project,
                "read:project-env-vars-non-production" => UserEventPayloadVariant26BeforePermission.Read_projectEnvVarsNonProduction,
                "read:project-env-vars-production" => UserEventPayloadVariant26BeforePermission.Read_projectEnvVarsProduction,
                "read:sandbox" => UserEventPayloadVariant26BeforePermission.Read_sandbox,
                "read:team" => UserEventPayloadVariant26BeforePermission.Read_team,
                "use:ai-gateway" => UserEventPayloadVariant26BeforePermission.Use_aiGateway,
                _ => null,
            };
        }
    }
}