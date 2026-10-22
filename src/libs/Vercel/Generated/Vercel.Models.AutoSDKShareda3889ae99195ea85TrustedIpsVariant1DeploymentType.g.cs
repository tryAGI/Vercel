
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType
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
    public static class AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType.All => "all",
                AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType.Preview => "preview",
                AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShareda3889ae99195ea85TrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}