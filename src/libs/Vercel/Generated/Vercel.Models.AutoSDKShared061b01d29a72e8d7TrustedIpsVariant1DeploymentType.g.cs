
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType
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
    public static class AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType.All => "all",
                AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType.Preview => "preview",
                AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}