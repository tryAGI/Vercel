
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant23Permission
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
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
        Read_user,
        /// <summary>
        /// 
        /// </summary>
        Use_aiGateway,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant23PermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant23Permission value)
        {
            return value switch
            {
                UserEventPayloadVariant23Permission.Multiply => "*",
                UserEventPayloadVariant23Permission.ReadWrite_aiGatewayApiKey => "read-write:ai-gateway-api-key",
                UserEventPayloadVariant23Permission.ReadWrite_billing => "read-write:billing",
                UserEventPayloadVariant23Permission.ReadWrite_blob => "read-write:blob",
                UserEventPayloadVariant23Permission.ReadWrite_deployment => "read-write:deployment",
                UserEventPayloadVariant23Permission.ReadWrite_domain => "read-write:domain",
                UserEventPayloadVariant23Permission.ReadWrite_domainRegistrar => "read-write:domain-registrar",
                UserEventPayloadVariant23Permission.ReadWrite_drains => "read-write:drains",
                UserEventPayloadVariant23Permission.ReadWrite_edgeCache => "read-write:edge-cache",
                UserEventPayloadVariant23Permission.ReadWrite_edgeConfig => "read-write:edge-config",
                UserEventPayloadVariant23Permission.ReadWrite_integrationConfiguration => "read-write:integration-configuration",
                UserEventPayloadVariant23Permission.ReadWrite_integrationResource => "read-write:integration-resource",
                UserEventPayloadVariant23Permission.ReadWrite_project => "read-write:project",
                UserEventPayloadVariant23Permission.ReadWrite_projectEnvVars => "read-write:project-env-vars",
                UserEventPayloadVariant23Permission.ReadWrite_projectEnvVarsNonProduction => "read-write:project-env-vars-non-production",
                UserEventPayloadVariant23Permission.ReadWrite_projectEnvVarsProduction => "read-write:project-env-vars-production",
                UserEventPayloadVariant23Permission.ReadWrite_projectFlagsNonProduction => "read-write:project-flags-non-production",
                UserEventPayloadVariant23Permission.ReadWrite_projectFlagsProduction => "read-write:project-flags-production",
                UserEventPayloadVariant23Permission.ReadWrite_projectProtectionBypass => "read-write:project-protection-bypass",
                UserEventPayloadVariant23Permission.ReadWrite_remoteCache => "read-write:remote-cache",
                UserEventPayloadVariant23Permission.ReadWrite_sandbox => "read-write:sandbox",
                UserEventPayloadVariant23Permission.Read_accessGroup => "read:access-group",
                UserEventPayloadVariant23Permission.Read_billing => "read:billing",
                UserEventPayloadVariant23Permission.Read_deployment => "read:deployment",
                UserEventPayloadVariant23Permission.Read_domain => "read:domain",
                UserEventPayloadVariant23Permission.Read_event => "read:event",
                UserEventPayloadVariant23Permission.Read_integrationConfiguration => "read:integration-configuration",
                UserEventPayloadVariant23Permission.Read_monitoring => "read:monitoring",
                UserEventPayloadVariant23Permission.Read_project => "read:project",
                UserEventPayloadVariant23Permission.Read_projectEnvVarsNonProduction => "read:project-env-vars-non-production",
                UserEventPayloadVariant23Permission.Read_projectEnvVarsProduction => "read:project-env-vars-production",
                UserEventPayloadVariant23Permission.Read_sandbox => "read:sandbox",
                UserEventPayloadVariant23Permission.Read_team => "read:team",
                UserEventPayloadVariant23Permission.Read_user => "read:user",
                UserEventPayloadVariant23Permission.Use_aiGateway => "use:ai-gateway",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant23Permission? ToEnum(string value)
        {
            return value switch
            {
                "*" => UserEventPayloadVariant23Permission.Multiply,
                "read-write:ai-gateway-api-key" => UserEventPayloadVariant23Permission.ReadWrite_aiGatewayApiKey,
                "read-write:billing" => UserEventPayloadVariant23Permission.ReadWrite_billing,
                "read-write:blob" => UserEventPayloadVariant23Permission.ReadWrite_blob,
                "read-write:deployment" => UserEventPayloadVariant23Permission.ReadWrite_deployment,
                "read-write:domain" => UserEventPayloadVariant23Permission.ReadWrite_domain,
                "read-write:domain-registrar" => UserEventPayloadVariant23Permission.ReadWrite_domainRegistrar,
                "read-write:drains" => UserEventPayloadVariant23Permission.ReadWrite_drains,
                "read-write:edge-cache" => UserEventPayloadVariant23Permission.ReadWrite_edgeCache,
                "read-write:edge-config" => UserEventPayloadVariant23Permission.ReadWrite_edgeConfig,
                "read-write:integration-configuration" => UserEventPayloadVariant23Permission.ReadWrite_integrationConfiguration,
                "read-write:integration-resource" => UserEventPayloadVariant23Permission.ReadWrite_integrationResource,
                "read-write:project" => UserEventPayloadVariant23Permission.ReadWrite_project,
                "read-write:project-env-vars" => UserEventPayloadVariant23Permission.ReadWrite_projectEnvVars,
                "read-write:project-env-vars-non-production" => UserEventPayloadVariant23Permission.ReadWrite_projectEnvVarsNonProduction,
                "read-write:project-env-vars-production" => UserEventPayloadVariant23Permission.ReadWrite_projectEnvVarsProduction,
                "read-write:project-flags-non-production" => UserEventPayloadVariant23Permission.ReadWrite_projectFlagsNonProduction,
                "read-write:project-flags-production" => UserEventPayloadVariant23Permission.ReadWrite_projectFlagsProduction,
                "read-write:project-protection-bypass" => UserEventPayloadVariant23Permission.ReadWrite_projectProtectionBypass,
                "read-write:remote-cache" => UserEventPayloadVariant23Permission.ReadWrite_remoteCache,
                "read-write:sandbox" => UserEventPayloadVariant23Permission.ReadWrite_sandbox,
                "read:access-group" => UserEventPayloadVariant23Permission.Read_accessGroup,
                "read:billing" => UserEventPayloadVariant23Permission.Read_billing,
                "read:deployment" => UserEventPayloadVariant23Permission.Read_deployment,
                "read:domain" => UserEventPayloadVariant23Permission.Read_domain,
                "read:event" => UserEventPayloadVariant23Permission.Read_event,
                "read:integration-configuration" => UserEventPayloadVariant23Permission.Read_integrationConfiguration,
                "read:monitoring" => UserEventPayloadVariant23Permission.Read_monitoring,
                "read:project" => UserEventPayloadVariant23Permission.Read_project,
                "read:project-env-vars-non-production" => UserEventPayloadVariant23Permission.Read_projectEnvVarsNonProduction,
                "read:project-env-vars-production" => UserEventPayloadVariant23Permission.Read_projectEnvVarsProduction,
                "read:sandbox" => UserEventPayloadVariant23Permission.Read_sandbox,
                "read:team" => UserEventPayloadVariant23Permission.Read_team,
                "read:user" => UserEventPayloadVariant23Permission.Read_user,
                "use:ai-gateway" => UserEventPayloadVariant23Permission.Use_aiGateway,
                _ => null,
            };
        }
    }
}