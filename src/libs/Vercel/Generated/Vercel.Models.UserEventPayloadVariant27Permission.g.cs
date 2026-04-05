
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant27Permission
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
        Read_projectOidcToken,
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
    public static class UserEventPayloadVariant27PermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant27Permission value)
        {
            return value switch
            {
                UserEventPayloadVariant27Permission.ReadWrite_aiGatewayApiKey => "read-write:ai-gateway-api-key",
                UserEventPayloadVariant27Permission.ReadWrite_billing => "read-write:billing",
                UserEventPayloadVariant27Permission.ReadWrite_blob => "read-write:blob",
                UserEventPayloadVariant27Permission.ReadWrite_deployment => "read-write:deployment",
                UserEventPayloadVariant27Permission.ReadWrite_domain => "read-write:domain",
                UserEventPayloadVariant27Permission.ReadWrite_domainRegistrar => "read-write:domain-registrar",
                UserEventPayloadVariant27Permission.ReadWrite_drains => "read-write:drains",
                UserEventPayloadVariant27Permission.ReadWrite_edgeCache => "read-write:edge-cache",
                UserEventPayloadVariant27Permission.ReadWrite_edgeConfig => "read-write:edge-config",
                UserEventPayloadVariant27Permission.ReadWrite_integrationConfiguration => "read-write:integration-configuration",
                UserEventPayloadVariant27Permission.ReadWrite_integrationResource => "read-write:integration-resource",
                UserEventPayloadVariant27Permission.ReadWrite_project => "read-write:project",
                UserEventPayloadVariant27Permission.ReadWrite_projectEnvVars => "read-write:project-env-vars",
                UserEventPayloadVariant27Permission.ReadWrite_projectEnvVarsNonProduction => "read-write:project-env-vars-non-production",
                UserEventPayloadVariant27Permission.ReadWrite_projectEnvVarsProduction => "read-write:project-env-vars-production",
                UserEventPayloadVariant27Permission.ReadWrite_projectFlagsNonProduction => "read-write:project-flags-non-production",
                UserEventPayloadVariant27Permission.ReadWrite_projectFlagsProduction => "read-write:project-flags-production",
                UserEventPayloadVariant27Permission.ReadWrite_projectProtectionBypass => "read-write:project-protection-bypass",
                UserEventPayloadVariant27Permission.ReadWrite_remoteCache => "read-write:remote-cache",
                UserEventPayloadVariant27Permission.Read_accessGroup => "read:access-group",
                UserEventPayloadVariant27Permission.Read_billing => "read:billing",
                UserEventPayloadVariant27Permission.Read_deployment => "read:deployment",
                UserEventPayloadVariant27Permission.Read_domain => "read:domain",
                UserEventPayloadVariant27Permission.Read_event => "read:event",
                UserEventPayloadVariant27Permission.Read_integrationConfiguration => "read:integration-configuration",
                UserEventPayloadVariant27Permission.Read_monitoring => "read:monitoring",
                UserEventPayloadVariant27Permission.Read_project => "read:project",
                UserEventPayloadVariant27Permission.Read_projectEnvVarsNonProduction => "read:project-env-vars-non-production",
                UserEventPayloadVariant27Permission.Read_projectEnvVarsProduction => "read:project-env-vars-production",
                UserEventPayloadVariant27Permission.Read_projectOidcToken => "read:project-oidc-token",
                UserEventPayloadVariant27Permission.Read_team => "read:team",
                UserEventPayloadVariant27Permission.Use_aiGateway => "use:ai-gateway",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant27Permission? ToEnum(string value)
        {
            return value switch
            {
                "read-write:ai-gateway-api-key" => UserEventPayloadVariant27Permission.ReadWrite_aiGatewayApiKey,
                "read-write:billing" => UserEventPayloadVariant27Permission.ReadWrite_billing,
                "read-write:blob" => UserEventPayloadVariant27Permission.ReadWrite_blob,
                "read-write:deployment" => UserEventPayloadVariant27Permission.ReadWrite_deployment,
                "read-write:domain" => UserEventPayloadVariant27Permission.ReadWrite_domain,
                "read-write:domain-registrar" => UserEventPayloadVariant27Permission.ReadWrite_domainRegistrar,
                "read-write:drains" => UserEventPayloadVariant27Permission.ReadWrite_drains,
                "read-write:edge-cache" => UserEventPayloadVariant27Permission.ReadWrite_edgeCache,
                "read-write:edge-config" => UserEventPayloadVariant27Permission.ReadWrite_edgeConfig,
                "read-write:integration-configuration" => UserEventPayloadVariant27Permission.ReadWrite_integrationConfiguration,
                "read-write:integration-resource" => UserEventPayloadVariant27Permission.ReadWrite_integrationResource,
                "read-write:project" => UserEventPayloadVariant27Permission.ReadWrite_project,
                "read-write:project-env-vars" => UserEventPayloadVariant27Permission.ReadWrite_projectEnvVars,
                "read-write:project-env-vars-non-production" => UserEventPayloadVariant27Permission.ReadWrite_projectEnvVarsNonProduction,
                "read-write:project-env-vars-production" => UserEventPayloadVariant27Permission.ReadWrite_projectEnvVarsProduction,
                "read-write:project-flags-non-production" => UserEventPayloadVariant27Permission.ReadWrite_projectFlagsNonProduction,
                "read-write:project-flags-production" => UserEventPayloadVariant27Permission.ReadWrite_projectFlagsProduction,
                "read-write:project-protection-bypass" => UserEventPayloadVariant27Permission.ReadWrite_projectProtectionBypass,
                "read-write:remote-cache" => UserEventPayloadVariant27Permission.ReadWrite_remoteCache,
                "read:access-group" => UserEventPayloadVariant27Permission.Read_accessGroup,
                "read:billing" => UserEventPayloadVariant27Permission.Read_billing,
                "read:deployment" => UserEventPayloadVariant27Permission.Read_deployment,
                "read:domain" => UserEventPayloadVariant27Permission.Read_domain,
                "read:event" => UserEventPayloadVariant27Permission.Read_event,
                "read:integration-configuration" => UserEventPayloadVariant27Permission.Read_integrationConfiguration,
                "read:monitoring" => UserEventPayloadVariant27Permission.Read_monitoring,
                "read:project" => UserEventPayloadVariant27Permission.Read_project,
                "read:project-env-vars-non-production" => UserEventPayloadVariant27Permission.Read_projectEnvVarsNonProduction,
                "read:project-env-vars-production" => UserEventPayloadVariant27Permission.Read_projectEnvVarsProduction,
                "read:project-oidc-token" => UserEventPayloadVariant27Permission.Read_projectOidcToken,
                "read:team" => UserEventPayloadVariant27Permission.Read_team,
                "use:ai-gateway" => UserEventPayloadVariant27Permission.Use_aiGateway,
                _ => null,
            };
        }
    }
}