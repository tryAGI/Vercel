
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        AllExceptCustomDomains,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        ProdDeploymentUrlsAndAllPreviews,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType.All => "all",
                GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType.Preview => "preview",
                GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => GetProjectsResponseVariant3ProjectTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}