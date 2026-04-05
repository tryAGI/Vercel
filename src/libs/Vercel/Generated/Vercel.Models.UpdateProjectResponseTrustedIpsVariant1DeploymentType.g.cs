
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseTrustedIpsVariant1DeploymentType
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
    public static class UpdateProjectResponseTrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseTrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                UpdateProjectResponseTrustedIpsVariant1DeploymentType.All => "all",
                UpdateProjectResponseTrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateProjectResponseTrustedIpsVariant1DeploymentType.Preview => "preview",
                UpdateProjectResponseTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UpdateProjectResponseTrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseTrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateProjectResponseTrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => UpdateProjectResponseTrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => UpdateProjectResponseTrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateProjectResponseTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => UpdateProjectResponseTrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}