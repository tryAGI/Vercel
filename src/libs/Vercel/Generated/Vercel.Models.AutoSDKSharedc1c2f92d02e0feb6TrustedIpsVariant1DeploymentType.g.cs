
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType
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
    public static class AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType.All => "all",
                AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType.Preview => "preview",
                AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}