
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant24Permission
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
    public static class UserEventPayloadVariant24PermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant24Permission value)
        {
            return value switch
            {
                UserEventPayloadVariant24Permission.Multiply => "*",
                UserEventPayloadVariant24Permission.ReadWrite_aiGatewayApiKey => "read-write:ai-gateway-api-key",
                UserEventPayloadVariant24Permission.ReadWrite_billing => "read-write:billing",
                UserEventPayloadVariant24Permission.ReadWrite_blob => "read-write:blob",
                UserEventPayloadVariant24Permission.ReadWrite_deployment => "read-write:deployment",
                UserEventPayloadVariant24Permission.ReadWrite_domain => "read-write:domain",
                UserEventPayloadVariant24Permission.ReadWrite_domainRegistrar => "read-write:domain-registrar",
                UserEventPayloadVariant24Permission.ReadWrite_drains => "read-write:drains",
                UserEventPayloadVariant24Permission.ReadWrite_edgeCache => "read-write:edge-cache",
                UserEventPayloadVariant24Permission.ReadWrite_edgeConfig => "read-write:edge-config",
                UserEventPayloadVariant24Permission.ReadWrite_integrationConfiguration => "read-write:integration-configuration",
                UserEventPayloadVariant24Permission.ReadWrite_integrationResource => "read-write:integration-resource",
                UserEventPayloadVariant24Permission.ReadWrite_project => "read-write:project",
                UserEventPayloadVariant24Permission.ReadWrite_projectEnvVars => "read-write:project-env-vars",
                UserEventPayloadVariant24Permission.ReadWrite_projectEnvVarsNonProduction => "read-write:project-env-vars-non-production",
                UserEventPayloadVariant24Permission.ReadWrite_projectEnvVarsProduction => "read-write:project-env-vars-production",
                UserEventPayloadVariant24Permission.ReadWrite_projectFlagsNonProduction => "read-write:project-flags-non-production",
                UserEventPayloadVariant24Permission.ReadWrite_projectFlagsProduction => "read-write:project-flags-production",
                UserEventPayloadVariant24Permission.ReadWrite_projectProtectionBypass => "read-write:project-protection-bypass",
                UserEventPayloadVariant24Permission.ReadWrite_remoteCache => "read-write:remote-cache",
                UserEventPayloadVariant24Permission.ReadWrite_sandbox => "read-write:sandbox",
                UserEventPayloadVariant24Permission.Read_accessGroup => "read:access-group",
                UserEventPayloadVariant24Permission.Read_billing => "read:billing",
                UserEventPayloadVariant24Permission.Read_deployment => "read:deployment",
                UserEventPayloadVariant24Permission.Read_domain => "read:domain",
                UserEventPayloadVariant24Permission.Read_event => "read:event",
                UserEventPayloadVariant24Permission.Read_integrationConfiguration => "read:integration-configuration",
                UserEventPayloadVariant24Permission.Read_monitoring => "read:monitoring",
                UserEventPayloadVariant24Permission.Read_project => "read:project",
                UserEventPayloadVariant24Permission.Read_projectEnvVarsNonProduction => "read:project-env-vars-non-production",
                UserEventPayloadVariant24Permission.Read_projectEnvVarsProduction => "read:project-env-vars-production",
                UserEventPayloadVariant24Permission.Read_sandbox => "read:sandbox",
                UserEventPayloadVariant24Permission.Read_team => "read:team",
                UserEventPayloadVariant24Permission.Read_user => "read:user",
                UserEventPayloadVariant24Permission.Use_aiGateway => "use:ai-gateway",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant24Permission? ToEnum(string value)
        {
            return value switch
            {
                "*" => UserEventPayloadVariant24Permission.Multiply,
                "read-write:ai-gateway-api-key" => UserEventPayloadVariant24Permission.ReadWrite_aiGatewayApiKey,
                "read-write:billing" => UserEventPayloadVariant24Permission.ReadWrite_billing,
                "read-write:blob" => UserEventPayloadVariant24Permission.ReadWrite_blob,
                "read-write:deployment" => UserEventPayloadVariant24Permission.ReadWrite_deployment,
                "read-write:domain" => UserEventPayloadVariant24Permission.ReadWrite_domain,
                "read-write:domain-registrar" => UserEventPayloadVariant24Permission.ReadWrite_domainRegistrar,
                "read-write:drains" => UserEventPayloadVariant24Permission.ReadWrite_drains,
                "read-write:edge-cache" => UserEventPayloadVariant24Permission.ReadWrite_edgeCache,
                "read-write:edge-config" => UserEventPayloadVariant24Permission.ReadWrite_edgeConfig,
                "read-write:integration-configuration" => UserEventPayloadVariant24Permission.ReadWrite_integrationConfiguration,
                "read-write:integration-resource" => UserEventPayloadVariant24Permission.ReadWrite_integrationResource,
                "read-write:project" => UserEventPayloadVariant24Permission.ReadWrite_project,
                "read-write:project-env-vars" => UserEventPayloadVariant24Permission.ReadWrite_projectEnvVars,
                "read-write:project-env-vars-non-production" => UserEventPayloadVariant24Permission.ReadWrite_projectEnvVarsNonProduction,
                "read-write:project-env-vars-production" => UserEventPayloadVariant24Permission.ReadWrite_projectEnvVarsProduction,
                "read-write:project-flags-non-production" => UserEventPayloadVariant24Permission.ReadWrite_projectFlagsNonProduction,
                "read-write:project-flags-production" => UserEventPayloadVariant24Permission.ReadWrite_projectFlagsProduction,
                "read-write:project-protection-bypass" => UserEventPayloadVariant24Permission.ReadWrite_projectProtectionBypass,
                "read-write:remote-cache" => UserEventPayloadVariant24Permission.ReadWrite_remoteCache,
                "read-write:sandbox" => UserEventPayloadVariant24Permission.ReadWrite_sandbox,
                "read:access-group" => UserEventPayloadVariant24Permission.Read_accessGroup,
                "read:billing" => UserEventPayloadVariant24Permission.Read_billing,
                "read:deployment" => UserEventPayloadVariant24Permission.Read_deployment,
                "read:domain" => UserEventPayloadVariant24Permission.Read_domain,
                "read:event" => UserEventPayloadVariant24Permission.Read_event,
                "read:integration-configuration" => UserEventPayloadVariant24Permission.Read_integrationConfiguration,
                "read:monitoring" => UserEventPayloadVariant24Permission.Read_monitoring,
                "read:project" => UserEventPayloadVariant24Permission.Read_project,
                "read:project-env-vars-non-production" => UserEventPayloadVariant24Permission.Read_projectEnvVarsNonProduction,
                "read:project-env-vars-production" => UserEventPayloadVariant24Permission.Read_projectEnvVarsProduction,
                "read:sandbox" => UserEventPayloadVariant24Permission.Read_sandbox,
                "read:team" => UserEventPayloadVariant24Permission.Read_team,
                "read:user" => UserEventPayloadVariant24Permission.Read_user,
                "use:ai-gateway" => UserEventPayloadVariant24Permission.Use_aiGateway,
                _ => null,
            };
        }
    }
}