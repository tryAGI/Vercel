
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType
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
    public static class AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType.All => "all",
                AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType.Preview => "preview",
                AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}