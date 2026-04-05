
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseTrustedIpsVariant2DeploymentType
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
    public static class CreateProjectResponseTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                CreateProjectResponseTrustedIpsVariant2DeploymentType.All => "all",
                CreateProjectResponseTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                CreateProjectResponseTrustedIpsVariant2DeploymentType.Preview => "preview",
                CreateProjectResponseTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                CreateProjectResponseTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateProjectResponseTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => CreateProjectResponseTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => CreateProjectResponseTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => CreateProjectResponseTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => CreateProjectResponseTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}