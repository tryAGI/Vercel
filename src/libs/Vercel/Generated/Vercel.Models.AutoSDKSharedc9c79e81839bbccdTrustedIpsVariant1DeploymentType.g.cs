
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType
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
    public static class AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType.All => "all",
                AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType.Preview => "preview",
                AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}