
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType
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
    public static class AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType.All => "all",
                AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType.Preview => "preview",
                AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}