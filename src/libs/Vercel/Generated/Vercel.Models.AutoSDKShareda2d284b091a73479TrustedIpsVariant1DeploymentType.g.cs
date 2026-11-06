
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType
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
    public static class AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType.All => "all",
                AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType.Preview => "preview",
                AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShareda2d284b091a73479TrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}