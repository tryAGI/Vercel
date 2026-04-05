
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseTrustedIpsVariant2DeploymentType
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
    public static class GetProjectResponseTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                GetProjectResponseTrustedIpsVariant2DeploymentType.All => "all",
                GetProjectResponseTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectResponseTrustedIpsVariant2DeploymentType.Preview => "preview",
                GetProjectResponseTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                GetProjectResponseTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectResponseTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => GetProjectResponseTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectResponseTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectResponseTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => GetProjectResponseTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}