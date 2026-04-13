
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant27NextPermission
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
    public static class UserEventPayloadVariant27NextPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant27NextPermission value)
        {
            return value switch
            {
                UserEventPayloadVariant27NextPermission.Multiply => "*",
                UserEventPayloadVariant27NextPermission.ReadWrite_aiGatewayApiKey => "read-write:ai-gateway-api-key",
                UserEventPayloadVariant27NextPermission.ReadWrite_billing => "read-write:billing",
                UserEventPayloadVariant27NextPermission.ReadWrite_blob => "read-write:blob",
                UserEventPayloadVariant27NextPermission.ReadWrite_deployment => "read-write:deployment",
                UserEventPayloadVariant27NextPermission.ReadWrite_domain => "read-write:domain",
                UserEventPayloadVariant27NextPermission.ReadWrite_domainRegistrar => "read-write:domain-registrar",
                UserEventPayloadVariant27NextPermission.ReadWrite_drains => "read-write:drains",
                UserEventPayloadVariant27NextPermission.ReadWrite_edgeCache => "read-write:edge-cache",
                UserEventPayloadVariant27NextPermission.ReadWrite_edgeConfig => "read-write:edge-config",
                UserEventPayloadVariant27NextPermission.ReadWrite_integrationConfiguration => "read-write:integration-configuration",
                UserEventPayloadVariant27NextPermission.ReadWrite_integrationResource => "read-write:integration-resource",
                UserEventPayloadVariant27NextPermission.ReadWrite_project => "read-write:project",
                UserEventPayloadVariant27NextPermission.ReadWrite_projectEnvVars => "read-write:project-env-vars",
                UserEventPayloadVariant27NextPermission.ReadWrite_projectEnvVarsNonProduction => "read-write:project-env-vars-non-production",
                UserEventPayloadVariant27NextPermission.ReadWrite_projectEnvVarsProduction => "read-write:project-env-vars-production",
                UserEventPayloadVariant27NextPermission.ReadWrite_projectFlagsNonProduction => "read-write:project-flags-non-production",
                UserEventPayloadVariant27NextPermission.ReadWrite_projectFlagsProduction => "read-write:project-flags-production",
                UserEventPayloadVariant27NextPermission.ReadWrite_projectProtectionBypass => "read-write:project-protection-bypass",
                UserEventPayloadVariant27NextPermission.ReadWrite_remoteCache => "read-write:remote-cache",
                UserEventPayloadVariant27NextPermission.ReadWrite_sandbox => "read-write:sandbox",
                UserEventPayloadVariant27NextPermission.Read_accessGroup => "read:access-group",
                UserEventPayloadVariant27NextPermission.Read_billing => "read:billing",
                UserEventPayloadVariant27NextPermission.Read_deployment => "read:deployment",
                UserEventPayloadVariant27NextPermission.Read_domain => "read:domain",
                UserEventPayloadVariant27NextPermission.Read_event => "read:event",
                UserEventPayloadVariant27NextPermission.Read_integrationConfiguration => "read:integration-configuration",
                UserEventPayloadVariant27NextPermission.Read_monitoring => "read:monitoring",
                UserEventPayloadVariant27NextPermission.Read_project => "read:project",
                UserEventPayloadVariant27NextPermission.Read_projectEnvVarsNonProduction => "read:project-env-vars-non-production",
                UserEventPayloadVariant27NextPermission.Read_projectEnvVarsProduction => "read:project-env-vars-production",
                UserEventPayloadVariant27NextPermission.Read_sandbox => "read:sandbox",
                UserEventPayloadVariant27NextPermission.Read_team => "read:team",
                UserEventPayloadVariant27NextPermission.Read_user => "read:user",
                UserEventPayloadVariant27NextPermission.Use_aiGateway => "use:ai-gateway",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant27NextPermission? ToEnum(string value)
        {
            return value switch
            {
                "*" => UserEventPayloadVariant27NextPermission.Multiply,
                "read-write:ai-gateway-api-key" => UserEventPayloadVariant27NextPermission.ReadWrite_aiGatewayApiKey,
                "read-write:billing" => UserEventPayloadVariant27NextPermission.ReadWrite_billing,
                "read-write:blob" => UserEventPayloadVariant27NextPermission.ReadWrite_blob,
                "read-write:deployment" => UserEventPayloadVariant27NextPermission.ReadWrite_deployment,
                "read-write:domain" => UserEventPayloadVariant27NextPermission.ReadWrite_domain,
                "read-write:domain-registrar" => UserEventPayloadVariant27NextPermission.ReadWrite_domainRegistrar,
                "read-write:drains" => UserEventPayloadVariant27NextPermission.ReadWrite_drains,
                "read-write:edge-cache" => UserEventPayloadVariant27NextPermission.ReadWrite_edgeCache,
                "read-write:edge-config" => UserEventPayloadVariant27NextPermission.ReadWrite_edgeConfig,
                "read-write:integration-configuration" => UserEventPayloadVariant27NextPermission.ReadWrite_integrationConfiguration,
                "read-write:integration-resource" => UserEventPayloadVariant27NextPermission.ReadWrite_integrationResource,
                "read-write:project" => UserEventPayloadVariant27NextPermission.ReadWrite_project,
                "read-write:project-env-vars" => UserEventPayloadVariant27NextPermission.ReadWrite_projectEnvVars,
                "read-write:project-env-vars-non-production" => UserEventPayloadVariant27NextPermission.ReadWrite_projectEnvVarsNonProduction,
                "read-write:project-env-vars-production" => UserEventPayloadVariant27NextPermission.ReadWrite_projectEnvVarsProduction,
                "read-write:project-flags-non-production" => UserEventPayloadVariant27NextPermission.ReadWrite_projectFlagsNonProduction,
                "read-write:project-flags-production" => UserEventPayloadVariant27NextPermission.ReadWrite_projectFlagsProduction,
                "read-write:project-protection-bypass" => UserEventPayloadVariant27NextPermission.ReadWrite_projectProtectionBypass,
                "read-write:remote-cache" => UserEventPayloadVariant27NextPermission.ReadWrite_remoteCache,
                "read-write:sandbox" => UserEventPayloadVariant27NextPermission.ReadWrite_sandbox,
                "read:access-group" => UserEventPayloadVariant27NextPermission.Read_accessGroup,
                "read:billing" => UserEventPayloadVariant27NextPermission.Read_billing,
                "read:deployment" => UserEventPayloadVariant27NextPermission.Read_deployment,
                "read:domain" => UserEventPayloadVariant27NextPermission.Read_domain,
                "read:event" => UserEventPayloadVariant27NextPermission.Read_event,
                "read:integration-configuration" => UserEventPayloadVariant27NextPermission.Read_integrationConfiguration,
                "read:monitoring" => UserEventPayloadVariant27NextPermission.Read_monitoring,
                "read:project" => UserEventPayloadVariant27NextPermission.Read_project,
                "read:project-env-vars-non-production" => UserEventPayloadVariant27NextPermission.Read_projectEnvVarsNonProduction,
                "read:project-env-vars-production" => UserEventPayloadVariant27NextPermission.Read_projectEnvVarsProduction,
                "read:sandbox" => UserEventPayloadVariant27NextPermission.Read_sandbox,
                "read:team" => UserEventPayloadVariant27NextPermission.Read_team,
                "read:user" => UserEventPayloadVariant27NextPermission.Read_user,
                "use:ai-gateway" => UserEventPayloadVariant27NextPermission.Use_aiGateway,
                _ => null,
            };
        }
    }
}