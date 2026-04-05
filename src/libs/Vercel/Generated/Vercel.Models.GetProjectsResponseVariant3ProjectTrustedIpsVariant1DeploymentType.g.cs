
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType
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
    public static class GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType.All => "all",
                GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType.Preview => "preview",
                GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => GetProjectsResponseVariant3ProjectTrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}