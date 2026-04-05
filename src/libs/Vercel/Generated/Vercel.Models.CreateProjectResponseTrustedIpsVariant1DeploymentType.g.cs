
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseTrustedIpsVariant1DeploymentType
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
    public static class CreateProjectResponseTrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                CreateProjectResponseTrustedIpsVariant1DeploymentType.All => "all",
                CreateProjectResponseTrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                CreateProjectResponseTrustedIpsVariant1DeploymentType.Preview => "preview",
                CreateProjectResponseTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                CreateProjectResponseTrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateProjectResponseTrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => CreateProjectResponseTrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => CreateProjectResponseTrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => CreateProjectResponseTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => CreateProjectResponseTrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}