
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType
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
    public static class AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}