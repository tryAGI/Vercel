
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType
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
    public static class UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType.All => "all",
                UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType.Preview => "preview",
                UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => UpdateMicrofrontendsResponseTrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}