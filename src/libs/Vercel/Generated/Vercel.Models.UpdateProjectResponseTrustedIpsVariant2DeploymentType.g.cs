
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseTrustedIpsVariant2DeploymentType
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
    public static class UpdateProjectResponseTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                UpdateProjectResponseTrustedIpsVariant2DeploymentType.All => "all",
                UpdateProjectResponseTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateProjectResponseTrustedIpsVariant2DeploymentType.Preview => "preview",
                UpdateProjectResponseTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UpdateProjectResponseTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateProjectResponseTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => UpdateProjectResponseTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => UpdateProjectResponseTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateProjectResponseTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => UpdateProjectResponseTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}