
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope
    {
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_deployment,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_deploymentCheck,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_domain,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_drains,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_globalProjectEnvVars,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_integrationDeploymentAction,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_logDrain,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_projectEnvVars,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite_projectProtectionBypass,
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
        Read_project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_deployment => "read-write:deployment",
                CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_deploymentCheck => "read-write:deployment-check",
                CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_domain => "read-write:domain",
                CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_drains => "read-write:drains",
                CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_globalProjectEnvVars => "read-write:global-project-env-vars",
                CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_integrationDeploymentAction => "read-write:integration-deployment-action",
                CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_logDrain => "read-write:log-drain",
                CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_projectEnvVars => "read-write:project-env-vars",
                CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_projectProtectionBypass => "read-write:project-protection-bypass",
                CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.Read_deployment => "read:deployment",
                CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.Read_domain => "read:domain",
                CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.Read_project => "read:project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope? ToEnum(string value)
        {
            return value switch
            {
                "read-write:deployment" => CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_deployment,
                "read-write:deployment-check" => CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_deploymentCheck,
                "read-write:domain" => CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_domain,
                "read-write:drains" => CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_drains,
                "read-write:global-project-env-vars" => CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_globalProjectEnvVars,
                "read-write:integration-deployment-action" => CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_integrationDeploymentAction,
                "read-write:log-drain" => CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_logDrain,
                "read-write:project-env-vars" => CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_projectEnvVars,
                "read-write:project-protection-bypass" => CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.ReadWrite_projectProtectionBypass,
                "read:deployment" => CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.Read_deployment,
                "read:domain" => CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.Read_domain,
                "read:project" => CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope.Read_project,
                _ => null,
            };
        }
    }
}