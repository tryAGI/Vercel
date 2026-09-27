
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType
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
    public static class AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType.All => "all",
                AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType.Preview => "preview",
                AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKSharede0e23f3391031fa6TrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}