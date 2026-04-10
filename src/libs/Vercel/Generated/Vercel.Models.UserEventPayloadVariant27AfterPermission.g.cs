
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant27AfterPermission
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
    public static class UserEventPayloadVariant27AfterPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant27AfterPermission value)
        {
            return value switch
            {
                UserEventPayloadVariant27AfterPermission.ReadWrite_aiGatewayApiKey => "read-write:ai-gateway-api-key",
                UserEventPayloadVariant27AfterPermission.ReadWrite_billing => "read-write:billing",
                UserEventPayloadVariant27AfterPermission.ReadWrite_blob => "read-write:blob",
                UserEventPayloadVariant27AfterPermission.ReadWrite_deployment => "read-write:deployment",
                UserEventPayloadVariant27AfterPermission.ReadWrite_domain => "read-write:domain",
                UserEventPayloadVariant27AfterPermission.ReadWrite_domainRegistrar => "read-write:domain-registrar",
                UserEventPayloadVariant27AfterPermission.ReadWrite_drains => "read-write:drains",
                UserEventPayloadVariant27AfterPermission.ReadWrite_edgeCache => "read-write:edge-cache",
                UserEventPayloadVariant27AfterPermission.ReadWrite_edgeConfig => "read-write:edge-config",
                UserEventPayloadVariant27AfterPermission.ReadWrite_integrationConfiguration => "read-write:integration-configuration",
                UserEventPayloadVariant27AfterPermission.ReadWrite_integrationResource => "read-write:integration-resource",
                UserEventPayloadVariant27AfterPermission.ReadWrite_project => "read-write:project",
                UserEventPayloadVariant27AfterPermission.ReadWrite_projectEnvVars => "read-write:project-env-vars",
                UserEventPayloadVariant27AfterPermission.ReadWrite_projectEnvVarsNonProduction => "read-write:project-env-vars-non-production",
                UserEventPayloadVariant27AfterPermission.ReadWrite_projectEnvVarsProduction => "read-write:project-env-vars-production",
                UserEventPayloadVariant27AfterPermission.ReadWrite_projectFlagsNonProduction => "read-write:project-flags-non-production",
                UserEventPayloadVariant27AfterPermission.ReadWrite_projectFlagsProduction => "read-write:project-flags-production",
                UserEventPayloadVariant27AfterPermission.ReadWrite_projectProtectionBypass => "read-write:project-protection-bypass",
                UserEventPayloadVariant27AfterPermission.ReadWrite_remoteCache => "read-write:remote-cache",
                UserEventPayloadVariant27AfterPermission.ReadWrite_sandbox => "read-write:sandbox",
                UserEventPayloadVariant27AfterPermission.Read_accessGroup => "read:access-group",
                UserEventPayloadVariant27AfterPermission.Read_billing => "read:billing",
                UserEventPayloadVariant27AfterPermission.Read_deployment => "read:deployment",
                UserEventPayloadVariant27AfterPermission.Read_domain => "read:domain",
                UserEventPayloadVariant27AfterPermission.Read_event => "read:event",
                UserEventPayloadVariant27AfterPermission.Read_integrationConfiguration => "read:integration-configuration",
                UserEventPayloadVariant27AfterPermission.Read_monitoring => "read:monitoring",
                UserEventPayloadVariant27AfterPermission.Read_project => "read:project",
                UserEventPayloadVariant27AfterPermission.Read_projectEnvVarsNonProduction => "read:project-env-vars-non-production",
                UserEventPayloadVariant27AfterPermission.Read_projectEnvVarsProduction => "read:project-env-vars-production",
                UserEventPayloadVariant27AfterPermission.Read_sandbox => "read:sandbox",
                UserEventPayloadVariant27AfterPermission.Read_team => "read:team",
                UserEventPayloadVariant27AfterPermission.Use_aiGateway => "use:ai-gateway",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant27AfterPermission? ToEnum(string value)
        {
            return value switch
            {
                "read-write:ai-gateway-api-key" => UserEventPayloadVariant27AfterPermission.ReadWrite_aiGatewayApiKey,
                "read-write:billing" => UserEventPayloadVariant27AfterPermission.ReadWrite_billing,
                "read-write:blob" => UserEventPayloadVariant27AfterPermission.ReadWrite_blob,
                "read-write:deployment" => UserEventPayloadVariant27AfterPermission.ReadWrite_deployment,
                "read-write:domain" => UserEventPayloadVariant27AfterPermission.ReadWrite_domain,
                "read-write:domain-registrar" => UserEventPayloadVariant27AfterPermission.ReadWrite_domainRegistrar,
                "read-write:drains" => UserEventPayloadVariant27AfterPermission.ReadWrite_drains,
                "read-write:edge-cache" => UserEventPayloadVariant27AfterPermission.ReadWrite_edgeCache,
                "read-write:edge-config" => UserEventPayloadVariant27AfterPermission.ReadWrite_edgeConfig,
                "read-write:integration-configuration" => UserEventPayloadVariant27AfterPermission.ReadWrite_integrationConfiguration,
                "read-write:integration-resource" => UserEventPayloadVariant27AfterPermission.ReadWrite_integrationResource,
                "read-write:project" => UserEventPayloadVariant27AfterPermission.ReadWrite_project,
                "read-write:project-env-vars" => UserEventPayloadVariant27AfterPermission.ReadWrite_projectEnvVars,
                "read-write:project-env-vars-non-production" => UserEventPayloadVariant27AfterPermission.ReadWrite_projectEnvVarsNonProduction,
                "read-write:project-env-vars-production" => UserEventPayloadVariant27AfterPermission.ReadWrite_projectEnvVarsProduction,
                "read-write:project-flags-non-production" => UserEventPayloadVariant27AfterPermission.ReadWrite_projectFlagsNonProduction,
                "read-write:project-flags-production" => UserEventPayloadVariant27AfterPermission.ReadWrite_projectFlagsProduction,
                "read-write:project-protection-bypass" => UserEventPayloadVariant27AfterPermission.ReadWrite_projectProtectionBypass,
                "read-write:remote-cache" => UserEventPayloadVariant27AfterPermission.ReadWrite_remoteCache,
                "read-write:sandbox" => UserEventPayloadVariant27AfterPermission.ReadWrite_sandbox,
                "read:access-group" => UserEventPayloadVariant27AfterPermission.Read_accessGroup,
                "read:billing" => UserEventPayloadVariant27AfterPermission.Read_billing,
                "read:deployment" => UserEventPayloadVariant27AfterPermission.Read_deployment,
                "read:domain" => UserEventPayloadVariant27AfterPermission.Read_domain,
                "read:event" => UserEventPayloadVariant27AfterPermission.Read_event,
                "read:integration-configuration" => UserEventPayloadVariant27AfterPermission.Read_integrationConfiguration,
                "read:monitoring" => UserEventPayloadVariant27AfterPermission.Read_monitoring,
                "read:project" => UserEventPayloadVariant27AfterPermission.Read_project,
                "read:project-env-vars-non-production" => UserEventPayloadVariant27AfterPermission.Read_projectEnvVarsNonProduction,
                "read:project-env-vars-production" => UserEventPayloadVariant27AfterPermission.Read_projectEnvVarsProduction,
                "read:sandbox" => UserEventPayloadVariant27AfterPermission.Read_sandbox,
                "read:team" => UserEventPayloadVariant27AfterPermission.Read_team,
                "use:ai-gateway" => UserEventPayloadVariant27AfterPermission.Use_aiGateway,
                _ => null,
            };
        }
    }
}