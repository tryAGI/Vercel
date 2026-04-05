
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseTrustedIpsVariant1DeploymentType
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
    public static class GetProjectResponseTrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                GetProjectResponseTrustedIpsVariant1DeploymentType.All => "all",
                GetProjectResponseTrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectResponseTrustedIpsVariant1DeploymentType.Preview => "preview",
                GetProjectResponseTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                GetProjectResponseTrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectResponseTrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => GetProjectResponseTrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectResponseTrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectResponseTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => GetProjectResponseTrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}