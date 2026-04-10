
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant28Permission
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
    public static class UserEventPayloadVariant28PermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant28Permission value)
        {
            return value switch
            {
                UserEventPayloadVariant28Permission.ReadWrite_aiGatewayApiKey => "read-write:ai-gateway-api-key",
                UserEventPayloadVariant28Permission.ReadWrite_billing => "read-write:billing",
                UserEventPayloadVariant28Permission.ReadWrite_blob => "read-write:blob",
                UserEventPayloadVariant28Permission.ReadWrite_deployment => "read-write:deployment",
                UserEventPayloadVariant28Permission.ReadWrite_domain => "read-write:domain",
                UserEventPayloadVariant28Permission.ReadWrite_domainRegistrar => "read-write:domain-registrar",
                UserEventPayloadVariant28Permission.ReadWrite_drains => "read-write:drains",
                UserEventPayloadVariant28Permission.ReadWrite_edgeCache => "read-write:edge-cache",
                UserEventPayloadVariant28Permission.ReadWrite_edgeConfig => "read-write:edge-config",
                UserEventPayloadVariant28Permission.ReadWrite_integrationConfiguration => "read-write:integration-configuration",
                UserEventPayloadVariant28Permission.ReadWrite_integrationResource => "read-write:integration-resource",
                UserEventPayloadVariant28Permission.ReadWrite_project => "read-write:project",
                UserEventPayloadVariant28Permission.ReadWrite_projectEnvVars => "read-write:project-env-vars",
                UserEventPayloadVariant28Permission.ReadWrite_projectEnvVarsNonProduction => "read-write:project-env-vars-non-production",
                UserEventPayloadVariant28Permission.ReadWrite_projectEnvVarsProduction => "read-write:project-env-vars-production",
                UserEventPayloadVariant28Permission.ReadWrite_projectFlagsNonProduction => "read-write:project-flags-non-production",
                UserEventPayloadVariant28Permission.ReadWrite_projectFlagsProduction => "read-write:project-flags-production",
                UserEventPayloadVariant28Permission.ReadWrite_projectProtectionBypass => "read-write:project-protection-bypass",
                UserEventPayloadVariant28Permission.ReadWrite_remoteCache => "read-write:remote-cache",
                UserEventPayloadVariant28Permission.ReadWrite_sandbox => "read-write:sandbox",
                UserEventPayloadVariant28Permission.Read_accessGroup => "read:access-group",
                UserEventPayloadVariant28Permission.Read_billing => "read:billing",
                UserEventPayloadVariant28Permission.Read_deployment => "read:deployment",
                UserEventPayloadVariant28Permission.Read_domain => "read:domain",
                UserEventPayloadVariant28Permission.Read_event => "read:event",
                UserEventPayloadVariant28Permission.Read_integrationConfiguration => "read:integration-configuration",
                UserEventPayloadVariant28Permission.Read_monitoring => "read:monitoring",
                UserEventPayloadVariant28Permission.Read_project => "read:project",
                UserEventPayloadVariant28Permission.Read_projectEnvVarsNonProduction => "read:project-env-vars-non-production",
                UserEventPayloadVariant28Permission.Read_projectEnvVarsProduction => "read:project-env-vars-production",
                UserEventPayloadVariant28Permission.Read_sandbox => "read:sandbox",
                UserEventPayloadVariant28Permission.Read_team => "read:team",
                UserEventPayloadVariant28Permission.Use_aiGateway => "use:ai-gateway",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant28Permission? ToEnum(string value)
        {
            return value switch
            {
                "read-write:ai-gateway-api-key" => UserEventPayloadVariant28Permission.ReadWrite_aiGatewayApiKey,
                "read-write:billing" => UserEventPayloadVariant28Permission.ReadWrite_billing,
                "read-write:blob" => UserEventPayloadVariant28Permission.ReadWrite_blob,
                "read-write:deployment" => UserEventPayloadVariant28Permission.ReadWrite_deployment,
                "read-write:domain" => UserEventPayloadVariant28Permission.ReadWrite_domain,
                "read-write:domain-registrar" => UserEventPayloadVariant28Permission.ReadWrite_domainRegistrar,
                "read-write:drains" => UserEventPayloadVariant28Permission.ReadWrite_drains,
                "read-write:edge-cache" => UserEventPayloadVariant28Permission.ReadWrite_edgeCache,
                "read-write:edge-config" => UserEventPayloadVariant28Permission.ReadWrite_edgeConfig,
                "read-write:integration-configuration" => UserEventPayloadVariant28Permission.ReadWrite_integrationConfiguration,
                "read-write:integration-resource" => UserEventPayloadVariant28Permission.ReadWrite_integrationResource,
                "read-write:project" => UserEventPayloadVariant28Permission.ReadWrite_project,
                "read-write:project-env-vars" => UserEventPayloadVariant28Permission.ReadWrite_projectEnvVars,
                "read-write:project-env-vars-non-production" => UserEventPayloadVariant28Permission.ReadWrite_projectEnvVarsNonProduction,
                "read-write:project-env-vars-production" => UserEventPayloadVariant28Permission.ReadWrite_projectEnvVarsProduction,
                "read-write:project-flags-non-production" => UserEventPayloadVariant28Permission.ReadWrite_projectFlagsNonProduction,
                "read-write:project-flags-production" => UserEventPayloadVariant28Permission.ReadWrite_projectFlagsProduction,
                "read-write:project-protection-bypass" => UserEventPayloadVariant28Permission.ReadWrite_projectProtectionBypass,
                "read-write:remote-cache" => UserEventPayloadVariant28Permission.ReadWrite_remoteCache,
                "read-write:sandbox" => UserEventPayloadVariant28Permission.ReadWrite_sandbox,
                "read:access-group" => UserEventPayloadVariant28Permission.Read_accessGroup,
                "read:billing" => UserEventPayloadVariant28Permission.Read_billing,
                "read:deployment" => UserEventPayloadVariant28Permission.Read_deployment,
                "read:domain" => UserEventPayloadVariant28Permission.Read_domain,
                "read:event" => UserEventPayloadVariant28Permission.Read_event,
                "read:integration-configuration" => UserEventPayloadVariant28Permission.Read_integrationConfiguration,
                "read:monitoring" => UserEventPayloadVariant28Permission.Read_monitoring,
                "read:project" => UserEventPayloadVariant28Permission.Read_project,
                "read:project-env-vars-non-production" => UserEventPayloadVariant28Permission.Read_projectEnvVarsNonProduction,
                "read:project-env-vars-production" => UserEventPayloadVariant28Permission.Read_projectEnvVarsProduction,
                "read:sandbox" => UserEventPayloadVariant28Permission.Read_sandbox,
                "read:team" => UserEventPayloadVariant28Permission.Read_team,
                "use:ai-gateway" => UserEventPayloadVariant28Permission.Use_aiGateway,
                _ => null,
            };
        }
    }
}