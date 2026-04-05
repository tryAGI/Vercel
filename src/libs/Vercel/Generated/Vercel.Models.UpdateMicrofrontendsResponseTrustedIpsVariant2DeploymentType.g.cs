
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType
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
    public static class UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType.All => "all",
                UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType.Preview => "preview",
                UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => UpdateMicrofrontendsResponseTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}